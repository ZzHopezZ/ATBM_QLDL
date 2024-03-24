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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PH1_GUI
{
    public partial class CapQuyen : Form
    {
        private string connectionString = "User Id=SYS;Password=11032003;DATA SOURCE=localhost:1521/xe;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\trana\\Oracle\\network\\admin;PERSIST SECURITY INFO=True;";
        string username;
        private List<string> tableName = new List<string>();
        private List<string> collumnName = new List<string>();
        private string grant, table, user, objectCol;
        public CapQuyen(string username)
        {
            InitializeComponent();
            this.username = username;
            fetchTableName();
            tableName.Insert(0, "");
            comboBox2.DataSource = tableName;
            comboBox2.SelectedIndex = 0;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            user = "John";

        }

        private void CapQuyen_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grant = comboBox1.SelectedItem.ToString();
            if (grant == "INSERT" || grant =="DELETE")
            {
                dataGridView1.Columns.Clear();
            }
            comboBox2.SelectedIndex = 0;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                table = comboBox2.SelectedItem.ToString();
                if (grant != "INSERT" && grant != "DELETE" && grant != null)
                {
                    fetchCollumnTable();
                }
              
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            //Xử lí chuỗi
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText.Contains("COLUMN_NAME"))
                {

                    // Tìm thấy tên cột chứa username
                    // Duyệt qua từng dòng đã chọn trong DataGridView để xóa
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        // Lấy giá trị của cột chứa username
                        string collumn = row.Cells[column.Index].Value.ToString();

                        // Gọi hàm xóa người dùng

                        values.Add(collumn);
                    }
                    objectCol = String.Join(",", values);
                    //MessageBox.Show(objectCol);
                    // Kết thúc việc duyệt các cột
                    break;
                }
            }
            string strsql = "";
            if (values != null)
            {
                //gramt select on table_name to user with grant option;

                strsql = "GRANT " + grant + "(" + objectCol + ") on " + table + " to " + user;
                if (checkBox1.Checked)
                {
                    strsql = strsql + " with grant option";
                }


            }
            else
                strsql = "GRANT " + grant + " on " + table + " to " + user;
            MessageBox.Show(strsql);
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "PH1_EXECUTESQL";

                        // Thêm các parameter cho stored procedure
                        command.Parameters.Add("STRSQL", OracleDbType.Varchar2).Value = strsql;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }




        }

        private void fetchTableName()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "PH1_RETURNOBJECTNAME";

                        // Thêm các parameter cho stored procedure
                        command.Parameters.Add("cur_OUT", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            List<String> resultList = new List<String>();
                            while (reader.Read())
                            {
                                // Đọc từng dòng và thêm vào list.
                                // Giả sử MyDataType là class của bạn có các property tương ứng với các cột trong DB

                                String Column1 = reader["object_name"].ToString();                  
                                
                                resultList.Add(Column1);


                            }
                            tableName.AddRange(resultList);
                            // Hiển thị dữ liệu lên DataGridView
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void fetchCollumnTable()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "PH1_RETURNTABLECOLUMN";

                        // Thêm các parameter cho stored procedure
                        command.Parameters.Add("p_table_name", OracleDbType.NVarchar2).Value = table;
                        command.Parameters.Add("cur_OUT", OracleDbType.RefCursor, ParameterDirection.Output);

                        //using (OracleDataReader reader = command.ExecuteReader())
                        //{
                        //    List<String> resultList = new List<String>();
                        //    while (reader.Read())
                        //    {
                        //        // Đọc từng dòng và thêm vào list.
                        //        // Giả sử MyDataType là class của bạn có các property tương ứng với các cột trong DB

                        //        String Column1 = reader["column_name"].ToString();                                
                        //        resultList.Add(Column1);



                        //    }
                        //    collumnName.AddRange(resultList);
                        //    // Hiển thị dữ liệu lên DataGridView
                        //}
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