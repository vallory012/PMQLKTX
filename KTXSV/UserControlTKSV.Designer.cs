namespace KTXSV
{
    partial class UserControlTKSV
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.rdTSV = new System.Windows.Forms.RadioButton();
            this.rdMSV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Masv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sodienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quequan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maquoctich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Makhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnRS = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhập Từ Khóa";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(307, 179);
            this.txtTK.MaxLength = 30;
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(165, 27);
            this.txtTK.TabIndex = 29;
            // 
            // rdTSV
            // 
            this.rdTSV.AutoSize = true;
            this.rdTSV.Location = new System.Drawing.Point(144, 31);
            this.rdTSV.Name = "rdTSV";
            this.rdTSV.Size = new System.Drawing.Size(115, 21);
            this.rdTSV.TabIndex = 23;
            this.rdTSV.TabStop = true;
            this.rdTSV.Text = "Tên Sinh Viên";
            this.rdTSV.UseVisualStyleBackColor = true;
            // 
            // rdMSV
            // 
            this.rdMSV.AutoSize = true;
            this.rdMSV.Location = new System.Drawing.Point(6, 31);
            this.rdMSV.Name = "rdMSV";
            this.rdMSV.Size = new System.Drawing.Size(109, 21);
            this.rdMSV.TabIndex = 22;
            this.rdMSV.TabStop = true;
            this.rdMSV.Text = "Mã Sinh Viên";
            this.rdMSV.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTSV);
            this.groupBox1.Controls.Add(this.rdMSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(187, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 72);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa Chọn Tìm Kiếm";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Masv,
            this.Hoten,
            this.Sodienthoai,
            this.Quequan,
            this.Maquoctich,
            this.Makhoa,
            this.Maphong});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 398);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(820, 147);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Masv
            // 
            this.Masv.Text = "Mã SV";
            this.Masv.Width = 108;
            // 
            // Hoten
            // 
            this.Hoten.Text = "Họ Tên";
            this.Hoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hoten.Width = 143;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.Text = "Số ĐT";
            this.Sodienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sodienthoai.Width = 113;
            // 
            // Quequan
            // 
            this.Quequan.Text = "Quê Quán";
            this.Quequan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quequan.Width = 175;
            // 
            // Maquoctich
            // 
            this.Maquoctich.Text = "Quốc Tịch";
            this.Maquoctich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Maquoctich.Width = 105;
            // 
            // Makhoa
            // 
            this.Makhoa.Text = "Khoa";
            this.Makhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Makhoa.Width = 88;
            // 
            // Maphong
            // 
            this.Maphong.Text = "Phòng";
            this.Maphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Maphong.Width = 83;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(513, 261);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 37);
            this.btnThoat.TabIndex = 53;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRS
            // 
            this.btnRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRS.Location = new System.Drawing.Point(513, 218);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(103, 37);
            this.btnRS.TabIndex = 52;
            this.btnRS.Text = "Reset";
            this.btnRS.UseVisualStyleBackColor = false;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(513, 175);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(103, 37);
            this.btnTK.TabIndex = 51;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 93);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Sinh Viên";
            // 
            // UserControlTKSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRS);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlTKSV";
            this.Size = new System.Drawing.Size(820, 545);
            this.Load += new System.EventHandler(this.UserControlTKSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.RadioButton rdTSV;
        private System.Windows.Forms.RadioButton rdMSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Masv;
        private System.Windows.Forms.ColumnHeader Hoten;
        private System.Windows.Forms.ColumnHeader Sodienthoai;
        private System.Windows.Forms.ColumnHeader Quequan;
        private System.Windows.Forms.ColumnHeader Maquoctich;
        private System.Windows.Forms.ColumnHeader Makhoa;
        private System.Windows.Forms.ColumnHeader Maphong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
