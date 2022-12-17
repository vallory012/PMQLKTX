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
    public partial class UserControlTTOAN : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlTTOAN()
        {
            InitializeComponent();
        }
        public int KiemTra()
        {
            if (rdDTT.Checked == true)
                return 1;
            else if (rdCTT.Checked == true)
                return 2;
            else
                return 0;
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            try
            {
                if (cboThang.Text != "" && cboNam.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    if (KiemTra() == 1)
                    {
                        cmd.CommandText = "select thanhtoan.Maphong,Thang,Nam,Tinhtrangthanhtoantiendien,Tinhtrangthanhtoantienphong from thanhtoan,sodien where thanhtoan.Maphong=sodien.Maphong and Tinhtrangthanhtoantiendien='True' and Tinhtrangthanhtoantienphong='True' and Thang='" + cboThang.Text + "' and Nam='" + cboNam.Text + "'";
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
                                if (Convert.ToInt16(td.Rows[i][3]) == 1)
                                    item.SubItems.Add("Đã Thanh Toán");
                                else
                                    item.SubItems.Add("Chưa Thanh Toán");
                                //item.SubItems.Add(td.Rows[i][2].ToString());
                                if (Convert.ToInt16(td.Rows[i][4]) == 1)
                                    item.SubItems.Add("Đã Thanh Toán");
                                else
                                    item.SubItems.Add("Chưa Thanh Toán");
                                //item.SubItems.Add(td.Rows[i][3].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                        else
                            MessageBox.Show("Không Có Dữ Liệu Của Tháng " + cboThang.Text + " " + cboNam.Text);
                    }
                    else if (KiemTra() == 2)
                    {
                        cmd.CommandText = "select thanhtoan.Maphong,Thang,Nam,Tinhtrangthanhtoantiendien,Tinhtrangthanhtoantienphong from thanhtoan,sodien where thanhtoan.Maphong=sodien.Maphong and (Tinhtrangthanhtoantiendien='False' or Tinhtrangthanhtoantienphong='False') and Thang='" + cboThang.Text + "' and Nam='" + cboNam.Text + "'";
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
                                if (Convert.ToInt16(td.Rows[i][3]) == 1)
                                    item.SubItems.Add("Đã Thanh Toán");
                                else
                                    item.SubItems.Add("Chưa Thanh Toán");
                                //item.SubItems.Add(td.Rows[i][2].ToString());
                                if (Convert.ToInt16(td.Rows[i][4]) == 1)
                                    item.SubItems.Add("Đã Thanh Toán");
                                else
                                    item.SubItems.Add("Chưa Thanh Toán");
                                //item.SubItems.Add(td.Rows[i][3].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                        else
                            MessageBox.Show("Không Có Dữ Liệu Của Tháng " + cboThang.Text + " " + cboNam.Text);
                    }
                    else
                        MessageBox.Show("Chọn Chức Năng Tìm Kiếm");
                }
                else
                {
                    MessageBox.Show("Vui Lòng Chọn Tháng & Năm Để Thống Kê");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !" + ex.Message);
            }
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            rdDTT.Checked = false;
            rdCTT.Checked = false;
            cboThang.Text = "";
            cboNam.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
