namespace KTXSV
{
    partial class frmLogin
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
            this.txtTentk = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtmk = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboNho = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnDN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // txtTentk
            // 
            this.txtTentk.Depth = 0;
            this.txtTentk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentk.Hint = "Tên Đăng Nhập";
            this.txtTentk.Location = new System.Drawing.Point(29, 127);
            this.txtTentk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTentk.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.PasswordChar = '\0';
            this.txtTentk.SelectedText = "";
            this.txtTentk.SelectionLength = 0;
            this.txtTentk.SelectionStart = 0;
            this.txtTentk.Size = new System.Drawing.Size(388, 28);
            this.txtTentk.TabIndex = 0;
            this.txtTentk.UseSystemPasswordChar = false;
            // 
            // txtmk
            // 
            this.txtmk.Depth = 0;
            this.txtmk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Hint = "Mật Khẩu";
            this.txtmk.Location = new System.Drawing.Point(29, 191);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmk.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '\0';
            this.txtmk.SelectedText = "";
            this.txtmk.SelectionLength = 0;
            this.txtmk.SelectionStart = 0;
            this.txtmk.Size = new System.Drawing.Size(388, 28);
            this.txtmk.TabIndex = 1;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // cboNho
            // 
            this.cboNho.AutoSize = true;
            this.cboNho.Depth = 0;
            this.cboNho.Font = new System.Drawing.Font("Roboto", 10F);
            this.cboNho.Location = new System.Drawing.Point(29, 256);
            this.cboNho.Margin = new System.Windows.Forms.Padding(0);
            this.cboNho.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboNho.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboNho.Name = "cboNho";
            this.cboNho.Ripple = true;
            this.cboNho.Size = new System.Drawing.Size(93, 30);
            this.cboNho.TabIndex = 2;
            this.cboNho.Text = "Ghi Nhớ";
            this.cboNho.UseVisualStyleBackColor = true;
            // 
            // btnDN
            // 
            this.btnDN.Depth = 0;
            this.btnDN.Location = new System.Drawing.Point(131, 329);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDN.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDN.Name = "btnDN";
            this.btnDN.Primary = true;
            this.btnDN.Size = new System.Drawing.Size(196, 43);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(29, 407);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(388, 1);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 427);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.cboNho);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtTentk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                  Hệ Thống Quản Trị";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtTentk;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtmk;
        private MaterialSkin.Controls.MaterialCheckBox cboNho;
        private MaterialSkin.Controls.MaterialRaisedButton btnDN;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}