using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1_GUI
{
    public partial class ThuHoiQuyenUser : Form
    {
        private string connectionString = "User Id=SYS;Password=11032003;DATA SOURCE=localhost:1521/xe;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\trana\\Oracle\\network\\admin;PERSIST SECURITY INFO=True;";
        string username;
        private List<string> tableName = new List<string>();
        private List<string> collumnName = new List<string>();
        private string grant, table, user, priv;
        int countRow = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.HeaderText.ToLower().Contains("table_name"))
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            // Lấy giá trị của cột chứa username
                            table = row.Cells[column.Index].Value.ToString();

                        }

                      

                    }
                    if (column.HeaderText.ToLower().Contains("privilege"))
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            // Lấy giá trị của cột chứa username
                            priv = row.Cells[column.Index].Value.ToString();

                        }
                        
                    }

                    


                }
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                deletePrivs();
                MessageBox.Show(table + priv);
            }
        }

            public ThuHoiQuyenUser(string username)
        {
            InitializeComponent();
            this.username = username;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            user = "JOHN";
            fetchPrivUser();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        private void deletePrivs()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "PH1_THUHOIQUYENUSER";

                        // Thêm các parameter cho stored procedure
                        command.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = "JOHN";
                        command.Parameters.Add("TABLE_NAME", OracleDbType.Varchar2).Value = table;
                        command.Parameters.Add("PRIV", OracleDbType.Varchar2).Value = priv;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void fetchPrivUser()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "PH1_XEMQUYENCUAUSERTRENTABLE";
                        
                        // Thêm các parameter cho stored procedure
                        command.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = "JOHN";
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
