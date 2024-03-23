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
    public partial class AssignRole : Form
    {
        List<String> roles = new List<string> { "Admin", "Normal user", "Manager" };
        List<String> users = new List<string> { "user 1", "user 2", "user 2" };
        public AssignRole()
        {
            InitializeComponent();
            //Load User Proc
            for (int i = 0; i < users.Count; ++i)
            {
                ListViewItem listItem = new ListViewItem(users[i]);
                listView.Items.Add(listItem);
            }
            //Load Roles Proc
            for (int i = 0; i < roles.Count; ++i)
            {
                comboBox1.Items.Add(roles[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assign role: "+comboBox1.Text + " to user: " + listView.SelectedItems[0].Text);
            this.Dispose();
            //Assign Role Procedure (User name,Role)
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Text.ToLower().StartsWith(textBox1.Text.ToLower()))
                {
                    item.Selected = true;
                    item.BackColor = Color.CornflowerBlue;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.Selected = false;
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
            }
        }
    }
}
