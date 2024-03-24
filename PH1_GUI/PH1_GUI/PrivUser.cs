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
    public partial class PrivUser : Form
    {
        private string connectionString = "User Id=SYS;Password=11032003;DATA SOURCE=localhost:1521/xe;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\trana\\Oracle\\network\\admin;PERSIST SECURITY INFO=True;";
        string username;
        public PrivUser(string username)
        {
            InitializeComponent();
            this.username = username;
            fetchPriv();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fetchPriv()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "PH1_XEMQUYENUSER";

                        // Thêm các parameter cho stored procedure
                        command.Parameters.Add("username", OracleDbType.NVarchar2).Value = username;
                        command.Parameters.Add("cur_OUT", OracleDbType.RefCursor, ParameterDirection.Output);

                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị dữ liệu lên DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
