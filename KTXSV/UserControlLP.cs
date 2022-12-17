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
    public partial class UserControlLP : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlLP()
        {
            InitializeComponent();
        }
        public int KiemTra()
        {
            if (rdD.Checked == true)
                return 1;
            else if (rdGH.Checked == true)
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

                cmd.CommandText = "select Maphong,Tenphong,Tang,Khu,Tinhtrang  from phong,banggia where phong.Loaiphong=banggia.LoaiPhong and phong.LoaiPhong = N'Phòng Đơn'";
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
                        if (Convert.ToInt16(td.Rows[i][4]) == 1)
                            item.SubItems.Add("Trống");
                        else
                            item.SubItems.Add("Đã Sử Dụng");
                        //item.SubItems.Add(td.Rows[i][4].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
            else if (KiemTra() == 2)
            {
                cmd.CommandText = "select Maphong,Tenphong,Tang,Khu,Tinhtrang  from phong,banggia where phong.Loaiphong=banggia.LoaiPhong and phong.LoaiPhong = N'Phòng Ghép'";
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
                        if (Convert.ToInt16(td.Rows[i][4]) == 1)
                            item.SubItems.Add("Trống");
                        else
                            item.SubItems.Add("Đã Sử Dụng");
                        //item.SubItems.Add(td.Rows[i][4].ToString());
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
            rdD.Checked = false;
            rdGH.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
