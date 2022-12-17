using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KTXSV
{
    public partial class UserControlDATA : UserControl
    {
        public UserControlDATA()
        {
            InitializeComponent();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ketnoi);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "BACKUP DATABASE [QLKTX] TO DISK='E:\\QLKTX.bak'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sao Lưu Database Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR BACKUP DATABASE");
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
