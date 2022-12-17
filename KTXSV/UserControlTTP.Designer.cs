namespace KTXSV
{
    partial class UserControlTTP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Maphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tenphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Khu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDSD = new System.Windows.Forms.RadioButton();
            this.rdPT = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnRS = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 93);
            this.panel1.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(222, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Kiếm Tình Trạng Phòng";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Maphong,
            this.Tenphong,
            this.Tang,
            this.Khu,
            this.Loaiphong});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 388);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(820, 157);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 64;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Maphong
            // 
            this.Maphong.Text = "Mã Phòng";
            this.Maphong.Width = 161;
            // 
            // Tenphong
            // 
            this.Tenphong.Text = "Tên Phòng";
            this.Tenphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tenphong.Width = 185;
            // 
            // Tang
            // 
            this.Tang.Text = "Tầng";
            this.Tang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tang.Width = 173;
            // 
            // Khu
            // 
            this.Khu.Text = "Thuộc Khu";
            this.Khu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Khu.Width = 185;
            // 
            // Loaiphong
            // 
            this.Loaiphong.Text = "Loại Phòng";
            this.Loaiphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Loaiphong.Width = 111;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDSD);
            this.groupBox1.Controls.Add(this.rdPT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 74);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng Tìm Kiếm";
            // 
            // rdDSD
            // 
            this.rdDSD.AutoSize = true;
            this.rdDSD.Location = new System.Drawing.Point(152, 31);
            this.rdDSD.Name = "rdDSD";
            this.rdDSD.Size = new System.Drawing.Size(164, 21);
            this.rdDSD.TabIndex = 2;
            this.rdDSD.TabStop = true;
            this.rdDSD.Text = "Phòng Đang Sử Dụng";
            this.rdDSD.UseVisualStyleBackColor = true;
            // 
            // rdPT
            // 
            this.rdPT.AutoSize = true;
            this.rdPT.Location = new System.Drawing.Point(21, 31);
            this.rdPT.Name = "rdPT";
            this.rdPT.Size = new System.Drawing.Size(109, 21);
            this.rdPT.TabIndex = 1;
            this.rdPT.TabStop = true;
            this.rdPT.Text = "Phòng Trống";
            this.rdPT.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(530, 264);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 37);
            this.btnThoat.TabIndex = 69;
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
            this.btnRS.Location = new System.Drawing.Point(530, 221);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(103, 37);
            this.btnRS.TabIndex = 68;
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
            this.btnTK.Location = new System.Drawing.Point(530, 178);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(103, 37);
            this.btnTK.TabIndex = 67;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // UserControlTTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRS);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlTTP";
            this.Size = new System.Drawing.Size(820, 545);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Maphong;
        private System.Windows.Forms.ColumnHeader Tenphong;
        private System.Windows.Forms.ColumnHeader Tang;
        private System.Windows.Forms.ColumnHeader Khu;
        private System.Windows.Forms.ColumnHeader Loaiphong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDSD;
        private System.Windows.Forms.RadioButton rdPT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnTK;
    }
}
