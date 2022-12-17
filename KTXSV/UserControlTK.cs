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
using Microsoft.Office.Interop.Excel;

namespace KTXSV
{
    public partial class UserControlTK : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlTK()
        {
            InitializeComponent();
        }

        private void UserControlTK_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            conn.Open();
            //Add du lieu vao cboQTich
            string addQT = "Select Maquoctich from quoctich";
            SqlCommand cmdQT = new SqlCommand(addQT, conn);
            SqlDataReader readerQT = cmdQT.ExecuteReader();
            while (readerQT.Read())
            {

                cboQT.Items.Add(readerQT.GetString(0));
            }
            readerQT.Dispose();
            cmdQT.Dispose();
            //Add du lieu vao cboKhoa
            string addMK = "Select Makhoa from khoa";
            SqlCommand cmdMK = new SqlCommand(addMK, conn);
            SqlDataReader readerMK = cmdMK.ExecuteReader();
            while (readerMK.Read())
            {

                cboKhoa.Items.Add(readerMK.GetString(0));
            }
            readerMK.Dispose();
            cmdMK.Dispose();
        }

        public int KiemTra()
        {
            if (rdKhoa.Checked == true)
                return 1;
            else if (rdQT.Checked == true)
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
                cmd.CommandText = "select Masv,Hoten,Ngaysinh,Gioitinh,Sodienthoai,Quequan,Maquoctich,Makhoa,Maphong from sinhvien where Makhoa='" + cboKhoa.Text + "'";
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
                        item.SubItems.Add(string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(td.Rows[i][2])));
                        if (Convert.ToInt16(td.Rows[i][3]) == 1)
                            item.SubItems.Add("Nam");
                        else
                            item.SubItems.Add("Nữ");
                        //item.SubItems.Add(td.Rows[i][3].ToString());
                        item.SubItems.Add(td.Rows[i][4].ToString());
                        item.SubItems.Add(td.Rows[i][5].ToString());
                        item.SubItems.Add(td.Rows[i][6].ToString());
                        item.SubItems.Add(td.Rows[i][7].ToString());
                        item.SubItems.Add(td.Rows[i][8].ToString());
                        listView1.Items.Add(item);
                    }
                }
                else
                    MessageBox.Show("Bạn Chưa Chọn Khoa");
            }
            else if (KiemTra() == 2)
            {
                cmd.CommandText = "select Masv,Hoten,Ngaysinh,Gioitinh,Sodienthoai,Quequan,Maquoctich,Makhoa,Maphong from sinhvien where Maquoctich='" + cboQT.Text + "'";
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
                        item.SubItems.Add(string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(td.Rows[i][2])));
                        if (Convert.ToInt16(td.Rows[i][3]) == 1)
                            item.SubItems.Add("Nam");
                        else
                            item.SubItems.Add("Nữ");
                        //item.SubItems.Add(td.Rows[i][3].ToString());
                        item.SubItems.Add(td.Rows[i][4].ToString());
                        item.SubItems.Add(td.Rows[i][5].ToString());
                        item.SubItems.Add(td.Rows[i][6].ToString());
                        item.SubItems.Add(td.Rows[i][7].ToString());
                        item.SubItems.Add(td.Rows[i][8].ToString());
                        listView1.Items.Add(item);
                    }
                }
                else
                    MessageBox.Show("Bạn Chưa Chọn Quốc Tịch");
            }
            else
                MessageBox.Show("Chọn Chức Năng Thống Kê");
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            rdKhoa.Checked = false;
            rdQT.Checked = false;
            cboKhoa.Enabled = true;
            cboQT.Enabled = true;
            cboKhoa.SelectedIndex = -1;
            cboQT.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void rdKhoa_CheckedChanged(object sender, EventArgs e)
        {
            cboKhoa.Enabled = true;
            cboQT.Enabled = false;
            cboQT.SelectedIndex = -1;
        }

        private void rdQT_CheckedChanged(object sender, EventArgs e)
        {
            cboKhoa.Enabled = false;
            cboQT.Enabled = true;
            cboKhoa.SelectedIndex = -1;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            ws.Cells.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Range["A1:I3"].MergeCells = true;
            ws.Range["A1:I3"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            ws.Range["B1:I3"].VerticalAlignment= XlHAlign.xlHAlignCenter;
            ws.Range["A1:I3"].Value = "Thống Kê Sinh Viên";
            ws.Range["A1:I3"].Font.Bold = true;
            ws.Range["A1:I3"].Font.Size = 20;
            ws.Range["A1:I3"].Font.Name = "Times new roman";
            ws.Range["A1:I3"].Font.ColorIndex = 3;
            ws.Range["A4:A4"].Value = "Mã SV";
            ws.Range["A4:A4"].Font.Bold = true;
            ws.Range["A4:A4"].Font.ColorIndex = 5;
            ws.Range["B4:B4"].Value = "Họ Tên";
            ws.Range["B4:B4"].Font.Bold = true;
            ws.Range["B4:B4"].Font.ColorIndex = 5;
            ws.Range["C4:C4"].Value = "Ngày Sinh";
            ws.Range["C4:C4"].Font.Bold = true;
            ws.Range["C4:C4"].Font.ColorIndex = 5;
            ws.Columns[3].NumberFormat = "@";
            ws.Range["D4:D4"].Value = "Giới Tính";
            ws.Range["D4:D4"].Font.Bold = true;
            ws.Range["D4:D4"].Font.ColorIndex = 5;
            ws.Range["E4:E4"].Value = "Số Điện Thoại";
            ws.Range["E4:E4"].Font.Bold = true;
            ws.Range["E4:E4"].Font.ColorIndex = 5;
            ws.Columns[5].NumberFormat = "@";
            ws.Range["F4:F4"].Value = "Quê Quán";
            ws.Range["F4:F4"].Font.Bold = true;
            ws.Range["F4:F4"].Font.ColorIndex = 5;
            ws.Range["G4:G4"].Value = "Mã Quốc Tịch";
            ws.Range["G4:G4"].Font.Bold = true;
            ws.Range["G4:G4"].Font.ColorIndex = 5;
            ws.Range["H4:H4"].Value = "Mã Khoa";
            ws.Range["H4:H4"].Font.Bold = true;
            ws.Range["H4:H4"].Font.ColorIndex = 5;
            ws.Range["I4:I4"].Value = "Mã Phòng";
            ws.Range["I4:I4"].Font.Bold = true;
            ws.Range["I4:I4"].Font.ColorIndex = 5;
            ws.Range["A4:I4"].Font.Size = 12;
            ws.Range["A4:I4"].Font.Name = "Times new roman";
            ws.Range["A20:I20"].MergeCells = true;
            ws.Range["A20:I20"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            ws.Range["A20:I20"].Value = "Quảng Ninh, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            ws.Range["A20:I20"].Font.Name = "Times new roman";
            ws.Range["A20:I20"].Font.Size = 12;
            ws.Name = "DS Sinh Viên";
            int i =5 ;
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
                ws.Cells[i, 9] = item.SubItems[8].Text;
                i++;
            }
            ws.Columns.AutoFit();
        }
    }
}
