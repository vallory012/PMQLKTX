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
    public partial class UserControlTTP : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlTTP()
        {
            InitializeComponent();
        }
        public int KiemTra()
        {
            if (rdPT.Checked == true)
                return 1;
            else if (rdDSD.Checked == true)
                return 2;
            else
                return 0;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (KiemTra() == 1)
            {

                cmd.CommandText = "select Maphong,Tenphong,Tang,Khu,phong.Loaiphong from phong,banggia where phong.Loaiphong=banggia.LoaiPhong and Tinhtrang = 'True'";
                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                DataTable td = new DataTable();
                td.Load(rd);
                if (td.Rows.Count != 0)
                {
                    for (int i = 0; i < td.Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                        item.SubItems.Add(td.Rows[i][1].ToString());
                        item.SubItems.Add(td.Rows[i][2].ToString());
                        item.SubItems.Add(td.Rows[i][3].ToString());
                        item.SubItems.Add(td.Rows[i][4].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
            else if (KiemTra() == 2)
            {
                cmd.CommandText = "select Maphong,Tenphong,Tang,Khu,phong.Loaiphong from phong,banggia where phong.Loaiphong=banggia.LoaiPhong and Tinhtrang = 'False'";
                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                DataTable td = new DataTable();
                td.Load(rd);
                if (td.Rows.Count != 0)
                {
                    for (int i = 0; i < td.Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                        item.SubItems.Add(td.Rows[i][1].ToString());
                        item.SubItems.Add(td.Rows[i][2].ToString());
                        item.SubItems.Add(td.Rows[i][3].ToString());
                        item.SubItems.Add(td.Rows[i][4].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
            else
                MessageBox.Show("Chọn Chức Năng Tìm Kiếm");
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            rdPT.Checked = false;
            rdDSD.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
