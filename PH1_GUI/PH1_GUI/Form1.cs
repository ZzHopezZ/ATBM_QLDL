using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PH1_GUI
{
    public partial class listEmpForm : Form
    {
        private string connectionString = "User Id=SYS;Password=Admin123;Data Source=localhost:1521/XE;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\ASUS\\Oracle\\network\\admin;";

        public listEmpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "SP_Test_GetAllNhanSu";

                        // Tạo parameter cho stored procedure
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertNVForm f = new InsertNVForm();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
