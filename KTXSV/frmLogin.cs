using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTXSV
{
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public frmLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            try
            {
                if (txtTentk.Text != "" && txtmk.Text != "")
                {
                    conn.Open();
                    string select = "Select * From nguoidung where Tentk='" + txtTentk.Text + "' and Matkhau='" + txtmk.Text + "'";
                    SqlCommand cmd = new SqlCommand(select, conn);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Wellcome frm = new Wellcome();
                        frm.Show();
                        this.Hide();
                        cmd.Dispose();
                        reader.Close();
                        reader.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu !", "Xin lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập Tên Đăng Nhập Hoặc Mật Khẩu !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !" + ex.Message);
            }
            if (cboNho.Checked)
            {
                Properties.Settings.Default.txtTentk = txtTentk.Text;
                Properties.Settings.Default.txtmk = txtmk.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.txtTentk = "";
                Properties.Settings.Default.txtmk = "";
                Properties.Settings.Default.Save();
            }
            txtTentk.Text = Properties.Settings.Default.txtTentk;
            txtmk.Text = Properties.Settings.Default.txtmk;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtTentk.Text = Properties.Settings.Default.txtTentk;
            txtmk.Text = Properties.Settings.Default.txtmk;
        }
    }
}
