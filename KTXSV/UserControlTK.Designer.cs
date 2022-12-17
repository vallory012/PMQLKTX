namespace KTXSV
{
    partial class UserControlTK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboQT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdQT = new System.Windows.Forms.RadioButton();
            this.rdKhoa = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Masv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sodienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quequan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maquoctich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Makhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnRS = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboKhoa
            // 
            this.cboKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(207, 142);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(157, 26);
            this.cboKhoa.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Chọn Khoa";
            // 
            // cboQT
            // 
            this.cboQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQT.FormattingEnabled = true;
            this.cboQT.Location = new System.Drawing.Point(538, 142);
            this.cboQT.Name = "cboQT";
            this.cboQT.Size = new System.Drawing.Size(157, 26);
            this.cboQT.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Chọn Quốc Tịch";
            // 
            // rdQT
            // 
            this.rdQT.AutoSize = true;
            this.rdQT.Location = new System.Drawing.Point(123, 44);
            this.rdQT.Name = "rdQT";
            this.rdQT.Size = new System.Drawing.Size(91, 21);
            this.rdQT.TabIndex = 40;
            this.rdQT.TabStop = true;
            this.rdQT.Text = "Quốc Tịch";
            this.rdQT.UseVisualStyleBackColor = true;
            this.rdQT.CheckedChanged += new System.EventHandler(this.rdQT_CheckedChanged);
            // 
            // rdKhoa
            // 
            this.rdKhoa.AutoSize = true;
            this.rdKhoa.Location = new System.Drawing.Point(42, 44);
            this.rdKhoa.Name = "rdKhoa";
            this.rdKhoa.Size = new System.Drawing.Size(59, 21);
            this.rdKhoa.TabIndex = 39;
            this.rdKhoa.TabStop = true;
            this.rdKhoa.Text = "Khoa";
            this.rdKhoa.UseVisualStyleBackColor = true;
            this.rdKhoa.CheckedChanged += new System.EventHandler(this.rdKhoa_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Masv,
            this.Hoten,
            this.Ngaysinh,
            this.Gioitinh,
            this.Sodienthoai,
            this.Quequan,
            this.Maquoctich,
            this.Makhoa,
            this.Maphong});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 375);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(820, 170);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Masv
            // 
            this.Masv.Text = "Mã Sinh Viên";
            this.Masv.Width = 80;
            // 
            // Hoten
            // 
            this.Hoten.Text = "Họ Tên";
            this.Hoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hoten.Width = 116;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Text = "Ngày Sinh";
            this.Ngaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ngaysinh.Width = 103;
            // 
            // Gioitinh
            // 
            this.Gioitinh.Text = "Giới Tính";
            this.Gioitinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gioitinh.Width = 85;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.Text = "Số Điện Thoại";
            this.Sodienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sodienthoai.Width = 109;
            // 
            // Quequan
            // 
            this.Quequan.Text = "Quê Quán";
            this.Quequan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quequan.Width = 80;
            // 
            // Maquoctich
            // 
            this.Maquoctich.Text = "Mã Quốc Tịch";
            this.Maquoctich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Maquoctich.Width = 85;
            // 
            // Makhoa
            // 
            this.Makhoa.Text = "Mã Khoa";
            this.Makhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Makhoa.Width = 73;
            // 
            // Maphong
            // 
            this.Maphong.Text = "Mã Phòng";
            this.Maphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Maphong.Width = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdQT);
            this.groupBox1.Controls.Add(this.rdKhoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(126, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 81);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Chức Năng Thống Kê";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(473, 207);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(103, 37);
            this.btnTK.TabIndex = 43;
            this.btnTK.Text = "Thống Kê";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnRS
            // 
            this.btnRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRS.Location = new System.Drawing.Point(473, 250);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(103, 37);
            this.btnRS.TabIndex = 44;
            this.btnRS.Text = "Reset";
            this.btnRS.UseVisualStyleBackColor = false;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(592, 207);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(103, 37);
            this.btnXuat.TabIndex = 45;
            this.btnXuat.Text = "Xuất File";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(592, 251);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 37);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 93);
            this.panel1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(252, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Sinh Viên KTX";
            // 
            // UserControlTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnRS);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cboQT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlTK";
            this.Size = new System.Drawing.Size(820, 545);
            this.Load += new System.EventHandler(this.UserControlTK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboQT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdQT;
        private System.Windows.Forms.RadioButton rdKhoa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ColumnHeader Masv;
        private System.Windows.Forms.ColumnHeader Hoten;
        private System.Windows.Forms.ColumnHeader Ngaysinh;
        private System.Windows.Forms.ColumnHeader Gioitinh;
        private System.Windows.Forms.ColumnHeader Sodienthoai;
        private System.Windows.Forms.ColumnHeader Quequan;
        private System.Windows.Forms.ColumnHeader Maquoctich;
        private System.Windows.Forms.ColumnHeader Makhoa;
        private System.Windows.Forms.ColumnHeader Maphong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
