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
    public partial class UpdateUserRole : Form
    {
        List<String> roles = new List<string> { "UPDATE", "DELETE", "INSERT","CREATE" };
        List<String> objects_ = new List<string> { "OBJECT1", "OBJECT2", "OBJECT3", "OBJECT4" };
        public class Admin
        {
            public string method { get; set; }
            public string obj { get; set; }
        }

        public UpdateUserRole(String value)
        {
            InitializeComponent();
            List<Admin> methods = new List<Admin>();
            methods.Add(new Admin()
            {
                method = "UPDATE",
                obj = "OBJECT1"
            });

            methods.Add(new Admin()
            {
                method = "DELETE",
                obj = "OBJECT2"
            });

            methods.Add(new Admin()
            {
                method = "UPDATE",
                obj = "OBJECT 3"
            });

            methods.Add(new Admin()
            {
                method = "INSERT",
                obj ="OBJECT 1"
            });


            label1.Text = value;

            dataGridView.DataSource = methods;

            //Load User Proc
            for (int i = 0; i < roles.Count; ++i)
            {
                comboBox1.Items.Add(roles[i]);
            }
            //Load object_ Proc
            for (int i = 0; i < objects_.Count; ++i)
            {
                comboBox2.Items.Add(objects_[i]);
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            string value = dataGridView.CurrentRow.Cells[0].Value + "" + dataGridView.CurrentRow.Cells[1].Value;
            textBox1.Text = value;
            textBox1.Enabled = false;
        }
    }
}
