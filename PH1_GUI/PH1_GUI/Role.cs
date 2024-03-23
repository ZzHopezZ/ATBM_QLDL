using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PH1_GUI
{
    public partial class Role : Form
    {
        List<String> roles = new List<string> { "Admin", "Normal user", "Manager" };
        public Role()
        {
            InitializeComponent();
            //Load Role Procedure
            for (int i=0; i<roles.Count; ++i)
            {
                ListViewItem listItem = new ListViewItem(roles[i]);
                listView.Items.Add(listItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(roleInput.Text))
                return;
            ListViewItem listItem = new ListViewItem(roleInput.Text);
            listView.Items.Add(listItem);

            //Save Role Procedure
            roleInput.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;
            try
            {
                //Get Row
                ListViewItem item = listView.SelectedItems[0];
                RowReview.Text = item.SubItems[0].Text;
                RowReview.Enabled = false;
            }
            catch(Exception ex)
            {

            }
            
        }

        //Delete Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {

                //Get Row
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }
        //Search
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Text.ToLower().StartsWith(search.Text.ToLower()))
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
        //Add Role
        private void button4_Click(object sender, EventArgs e)
        {
            AssignRole assignRole = new AssignRole();
            assignRole.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
