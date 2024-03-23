namespace PH1_GUI
{
    partial class Role
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Rolename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RowReview = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rolename});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 40);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(594, 389);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Rolename
            // 
            this.Rolename.Text = "Role name";
            this.Rolename.Width = 588;
            // 
            // roleInput
            // 
            this.roleInput.AccessibleName = "roleName";
            this.roleInput.Location = new System.Drawing.Point(612, 40);
            this.roleInput.Name = "roleInput";
            this.roleInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roleInput.Size = new System.Drawing.Size(176, 22);
            this.roleInput.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(614, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // search
            // 
            this.search.AccessibleName = "search";
            this.search.Location = new System.Drawing.Point(12, 11);
            this.search.Name = "search";
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.search.Size = new System.Drawing.Size(594, 22);
            this.search.TabIndex = 8;
            this.search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(614, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update Role";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RowReview
            // 
            this.RowReview.AccessibleName = "roleName";
            this.RowReview.Location = new System.Drawing.Point(612, 120);
            this.RowReview.Name = "RowReview";
            this.RowReview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RowReview.Size = new System.Drawing.Size(176, 22);
            this.RowReview.TabIndex = 9;
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RowReview);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.roleInput);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.button1);
            this.Name = "Role";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Rolename;
        private System.Windows.Forms.TextBox roleInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox RowReview;
    }
}