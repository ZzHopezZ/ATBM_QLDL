namespace PH1_GUI
{
    partial class InsertNVForm
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
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.Label();
            this.PhuCap = new System.Windows.Forms.Label();
            this.textBoxPhuCap = new System.Windows.Forms.TextBox();
            this.DT = new System.Windows.Forms.Label();
            this.textBoxDT = new System.Windows.Forms.TextBox();
            this.VaiTro = new System.Windows.Forms.Label();
            this.MaDV = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Phai = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.Label();
            this.comboBoxPhai = new System.Windows.Forms.ComboBox();
            this.comboBoxVaiTro = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMaDV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(89, 29);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(201, 22);
            this.textBoxHoTen.TabIndex = 0;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.NgaySinh.Location = new System.Drawing.Point(10, 147);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(73, 17);
            this.NgaySinh.TabIndex = 5;
            this.NgaySinh.Text = "Ngày Sinh";
            this.NgaySinh.Click += new System.EventHandler(this.NgaySinh_Click);
            // 
            // PhuCap
            // 
            this.PhuCap.AutoSize = true;
            this.PhuCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.PhuCap.Location = new System.Drawing.Point(12, 207);
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.Size = new System.Drawing.Size(60, 17);
            this.PhuCap.TabIndex = 7;
            this.PhuCap.Text = "Phụ cấp";
            // 
            // textBoxPhuCap
            // 
            this.textBoxPhuCap.Location = new System.Drawing.Point(89, 202);
            this.textBoxPhuCap.Name = "textBoxPhuCap";
            this.textBoxPhuCap.Size = new System.Drawing.Size(201, 22);
            this.textBoxPhuCap.TabIndex = 6;
            // 
            // DT
            // 
            this.DT.AutoSize = true;
            this.DT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.DT.Location = new System.Drawing.Point(12, 270);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(36, 17);
            this.DT.TabIndex = 9;
            this.DT.Text = "SĐT";
            // 
            // textBoxDT
            // 
            this.textBoxDT.Location = new System.Drawing.Point(89, 265);
            this.textBoxDT.Name = "textBoxDT";
            this.textBoxDT.Size = new System.Drawing.Size(201, 22);
            this.textBoxDT.TabIndex = 8;
            // 
            // VaiTro
            // 
            this.VaiTro.AutoSize = true;
            this.VaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.VaiTro.Location = new System.Drawing.Point(12, 335);
            this.VaiTro.Name = "VaiTro";
            this.VaiTro.Size = new System.Drawing.Size(49, 17);
            this.VaiTro.TabIndex = 11;
            this.VaiTro.Text = "Vai trò";
            // 
            // MaDV
            // 
            this.MaDV.AutoSize = true;
            this.MaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.MaDV.Location = new System.Drawing.Point(12, 397);
            this.MaDV.Name = "MaDV";
            this.MaDV.Size = new System.Drawing.Size(69, 17);
            this.MaDV.TabIndex = 13;
            this.MaDV.Text = "Mã đơn vị";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(131, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Phai
            // 
            this.Phai.AutoSize = true;
            this.Phai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Phai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.Phai.Location = new System.Drawing.Point(10, 85);
            this.Phai.Name = "Phai";
            this.Phai.Size = new System.Drawing.Size(60, 17);
            this.Phai.TabIndex = 15;
            this.Phai.Text = "Giới tính";
            // 
            // HoTen
            // 
            this.HoTen.AutoSize = true;
            this.HoTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.HoTen.Location = new System.Drawing.Point(10, 34);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(50, 17);
            this.HoTen.TabIndex = 16;
            this.HoTen.Text = "Họ tên";
            // 
            // comboBoxPhai
            // 
            this.comboBoxPhai.FormattingEnabled = true;
            this.comboBoxPhai.Items.AddRange(new object[] {
            "NAM",
            "NU"});
            this.comboBoxPhai.Location = new System.Drawing.Point(89, 83);
            this.comboBoxPhai.Name = "comboBoxPhai";
            this.comboBoxPhai.Size = new System.Drawing.Size(201, 24);
            this.comboBoxPhai.TabIndex = 17;
            // 
            // comboBoxVaiTro
            // 
            this.comboBoxVaiTro.FormattingEnabled = true;
            this.comboBoxVaiTro.Location = new System.Drawing.Point(89, 333);
            this.comboBoxVaiTro.Name = "comboBoxVaiTro";
            this.comboBoxVaiTro.Size = new System.Drawing.Size(201, 24);
            this.comboBoxVaiTro.TabIndex = 18;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(90, 143);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNgaySinh.TabIndex = 19;
            // 
            // comboBoxMaDV
            // 
            this.comboBoxMaDV.FormattingEnabled = true;
            this.comboBoxMaDV.Location = new System.Drawing.Point(90, 390);
            this.comboBoxMaDV.Name = "comboBoxMaDV";
            this.comboBoxMaDV.Size = new System.Drawing.Size(201, 24);
            this.comboBoxMaDV.TabIndex = 20;
            // 
            // InsertNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 492);
            this.Controls.Add(this.comboBoxMaDV);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.comboBoxVaiTro);
            this.Controls.Add(this.comboBoxPhai);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.Phai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaDV);
            this.Controls.Add(this.VaiTro);
            this.Controls.Add(this.DT);
            this.Controls.Add(this.textBoxDT);
            this.Controls.Add(this.PhuCap);
            this.Controls.Add(this.textBoxPhuCap);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.textBoxHoTen);
            this.Name = "InsertNVForm";
            this.Text = "InsertNVForm";
            this.Load += new System.EventHandler(this.InsertNVForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label NgaySinh;
        private System.Windows.Forms.Label PhuCap;
        private System.Windows.Forms.TextBox textBoxPhuCap;
        private System.Windows.Forms.Label DT;
        private System.Windows.Forms.TextBox textBoxDT;
        private System.Windows.Forms.Label VaiTro;
        private System.Windows.Forms.Label MaDV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Phai;
        private System.Windows.Forms.Label HoTen;
        private System.Windows.Forms.ComboBox comboBoxPhai;
        private System.Windows.Forms.ComboBox comboBoxVaiTro;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.ComboBox comboBoxMaDV;
    }
}