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
    public partial class InsertNVForm : Form
    {
        private List<string> vaiTroList = new List<string> { "TRUONG DON VI", "TRUONG KHOA", "GIANG VIEN", "NHAN VIEN CO BAN", "GIAO VU" };
        private List<string> maDVList = new List<string>();
        private string connectionString = "User Id=SYS;Password=Admin123;Data Source=localhost:1521/XE;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\ASUS\\Oracle\\network\\admin;";

        public InsertNVForm()
        {
            InitializeComponent();

            maDVList = LoadMaDVListFromDatabase();
            comboBoxVaiTro.DataSource = vaiTroList;
            comboBoxMaDV.DataSource = maDVList;
        }

        private List<string> LoadMaDVListFromDatabase()
        {
            List<string> maDVList = new List<string>();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT MADV FROM DONVI";
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            maDVList.Add(reader.GetString(0));
                        }
                    }

                    for (int i = 0; i < maDVList.Count; i++)
                    {
                        maDVList[i] = maDVList[i].Length > 5 ? maDVList[i].Substring(0, 5) : maDVList[i];
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return maDVList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string hoTen = textBoxHoTen.Text;
            string phai = comboBoxPhai.Text;
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            float phuCap = float.Parse(textBoxPhuCap.Text);
            string dt = textBoxDT.Text;
            string vaiTro = comboBoxVaiTro.SelectedItem.ToString();
            string maDV = comboBoxMaDV.SelectedItem.ToString();

            InsertEmployee(hoTen, phai, ngaySinh, phuCap, dt, vaiTro, maDV);

            MessageBox.Show("Thêm nhân viên thành công!");
            Close();
        }

        private void NgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void InsertEmployee(string hoTen, string phai, DateTime ngaySinh, float phuCap, string dt, string vaiTro, string maDV)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "SP_Test_InsertNhanVien";

                        // Thêm các parameter cho stored procedure
                        command.Parameters.Add("p_HOTEN", OracleDbType.NVarchar2).Value = hoTen;
                        command.Parameters.Add("p_PHAI", OracleDbType.Char).Value = phai;
                        command.Parameters.Add("p_NGSINH", OracleDbType.Date).Value = ngaySinh;
                        command.Parameters.Add("p_PHUCAP", OracleDbType.Double).Value = phuCap;
                        command.Parameters.Add("p_DT", OracleDbType.Char).Value = dt;
                        command.Parameters.Add("p_VAITRO", OracleDbType.NVarchar2).Value = vaiTro;
                        command.Parameters.Add("p_MADV", OracleDbType.Char).Value = maDV;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void InsertNVForm_Load(object sender, EventArgs e)
        {

        }
    }
}
