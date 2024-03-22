using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1_GUI
{
    public partial class LoginForm : Form
    {
        private string connectionString = "User Id=SYS;Password=Admin123;Data Source=localhost:1521/XE;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\ASUS\\Oracle\\network\\admin;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Thực hiện các hành động sau khi đăng nhập thành công (ví dụ: mở form chính)
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
            this.Hide();
            listEmpForm f = new listEmpForm();
            f.FormClosed += (s, args) => this.Close(); // Đóng form hiện tại khi form mới được đóng
            f.ShowDialog();
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        // Sử dụng parameterized query để tránh tấn công SQL Injection
                        command.CommandText = "SELECT COUNT(*) FROM USERS WHERE USERNAME = :username AND PASSWORD = :password";
                        command.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
