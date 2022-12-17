using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace KTXSV
{
    public partial class UserControlDSP : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlDSP()
        {
            InitializeComponent();
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
                    cmd.CommandText = "select phong.Maphong,Tenphong,phong.Loaiphong,Tinhtrangthanhtoantiendien,Tinhtrangthanhtoantienphong,Sodiendung,Giadien,Giaphong from Phong,thanhtoan,banggia,sodien where phong.Maphong=sodien.Maphong and phong.Maphong=thanhtoan.Maphong and phong.Loaiphong=banggia.LoaiPhong and (Tinhtrangthanhtoantiendien='False' or Tinhtrangthanhtoantienphong='False') and Thang='" + cboThang.Text + "' and Nam='" + cboNam.Text + "'";
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    System.Data.DataTable td = new System.Data.DataTable();
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
                                item.SubItems.Add("Chưa Chưa Toán");
                            //item.SubItems.Add(td.Rows[i][3].ToString());
                            if (Convert.ToInt16(td.Rows[i][4]) == 1)
                                item.SubItems.Add("Đã Thanh Toán");
                            else
                                item.SubItems.Add("Chưa Thanh Toán");
                            //item.SubItems.Add(td.Rows[i][4].ToString());
                            item.SubItems.Add(td.Rows[i][5].ToString());
                            item.SubItems.Add(string.Format("{0:#,#0}", Convert.ToDecimal(td.Rows[i][6])));
                            //item.SubItems.Add(td.Rows[i][6].ToString());
                            item.SubItems.Add(string.Format("{0:#,#0}", Convert.ToDecimal(td.Rows[i][7])));
                            //item.SubItems.Add(td.Rows[i][7].ToString());
                            listView1.Items.Add(item);
                        }
                    }
                    else
                        MessageBox.Show("Không Có Dữ Liệu Của Tháng " + cboThang.Text + " " + cboNam.Text);
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
            cboNam.Text = "";
            cboThang.Text = "";
            listView1.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            ws.Cells.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Range["A1:H3"].MergeCells = true;
            ws.Range["A1:H3"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            ws.Range["B1:H3"].VerticalAlignment = XlHAlign.xlHAlignCenter;
            ws.Range["A1:H3"].Value = "Danh Sách Phòng Chưa Thanh Toán";
            ws.Range["A1:H3"].Font.Bold = true;
            ws.Range["A1:H3"].Font.Size = 20;
            ws.Range["A1:H3"].Font.Name = "Times new roman";
            ws.Range["A1:H3"].Font.ColorIndex = 3;
            ws.Cells[4, 1] = "Mã Phòng";
            ws.Cells[4, 1].Font.Bold = true;
            ws.Cells[4, 1].Font.ColorIndex = 5;
            ws.Cells[4, 2] = "Tên Phòng";
            ws.Cells[4, 2].Font.Bold = true;
            ws.Cells[4, 2].Font.ColorIndex = 5;
            ws.Cells[4, 3] = "Loại Phòng";
            ws.Cells[4, 3].Font.Bold = true;
            ws.Cells[4, 3].Font.ColorIndex = 5;
            ws.Cells[4, 4] = "T.Toán Tiền Điện";
            ws.Cells[4, 4].Font.Bold = true;
            ws.Cells[4, 4].Font.ColorIndex = 5;
            ws.Cells[4, 5] = "T.Toán Tiền Phòng";
            ws.Cells[4, 5].Font.Bold = true;
            ws.Cells[4, 5].Font.ColorIndex = 5;
            ws.Cells[4, 6] = "Số Điện Dùng";
            ws.Cells[4, 6].Font.Bold = true;
            ws.Cells[4, 6].Font.ColorIndex = 5;
            ws.Cells[4, 7] = "Giá Điện";
            ws.Cells[4, 7].Font.Bold = true;
            ws.Cells[4, 7].Font.ColorIndex = 5;
            ws.Cells[4, 8] = "Giá Phòng";
            ws.Cells[4, 8].Font.Bold = true;
            ws.Cells[4, 8].Font.ColorIndex = 5;
            ws.Range["A4:H4"].Font.Size = 12;
            ws.Range["A4:H4"].Font.Name = "Times new roman";
            ws.Range["A20:H20"].MergeCells = true;
            ws.Range["A20:H20"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            ws.Range["A20:H20"].Value = "Quảng Ninh, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            ws.Range["A20:H20"].Font.Name = "Times new roman";
            ws.Range["A20:H20"].Font.Size = 12;
            ws.Name = "DS Phòng";
            int i = 5;
            foreach (ListViewItem item in listView1.Items)
            {
                ws.Cells[i, 1] = item.SubItems[0].Text;
                ws.Cells[i, 2] = item.SubItems[1].Text;
                ws.Cells[i, 3] = item.SubItems[2].Text;
                ws.Cells[i, 4] = item.SubItems[3].Text;
                ws.Cells[i, 5] = item.SubItems[4].Text;
                ws.Cells[i, 6] = item.SubItems[5].Text;
                ws.Cells[i, 7] = item.SubItems[6].Text;
                ws.Cells[i, 8] = item.SubItems[7].Text;
                i++;
            }
            ws.Columns.AutoFit();
        }
    }
}
