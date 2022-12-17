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
    public partial class UserControlSV : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlSV()
        {
            InitializeComponent();
        }

        public void LayBangChoGridView()
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            string sql = "select Masv,Hoten,convert(char(10),Ngaysinh,103) as Ngaysinh,( case when  Gioitinh='1' then N'Nam' else N'Nữ' End)As Gioitinh,Email,Sodienthoai,Quequan,Maquoctich,Makhoa,Maphong from sinhvien";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 120;

            dataGridView1.Columns[1].HeaderText = "Họ Tên";
            dataGridView1.Columns[1].Width = 130;

            dataGridView1.Columns[2].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[2].Width = 110;

            dataGridView1.Columns[3].HeaderText = "Giới Tính";
            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[4].Width = 200;

            dataGridView1.Columns[5].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[5].Width = 120;

            dataGridView1.Columns[6].HeaderText = "Quê Quán";
            dataGridView1.Columns[6].Width = 100;

            dataGridView1.Columns[7].HeaderText = "Mã Quốc Tịch";
            dataGridView1.Columns[7].Width = 100;

            dataGridView1.Columns[8].HeaderText = "Mã Khoa";
            dataGridView1.Columns[8].Width = 100;

            dataGridView1.Columns[9].HeaderText = "Mã Phòng";
            dataGridView1.Columns[9].Width = 100;
        }
        public void Loadtext()
        {
            txtMSV.Text = "";
            txtHT.Text = "";
            mskNS.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtQQ.Text = "";
            cboQT.Text = "";
            cboKhoa.Text = "";
            cboMP.Text = "";
        }
        private void UserControlSV_Load(object sender, EventArgs e)
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
            //Add du lieu vao cboMP
            string addMP = "Select Maphong from phong where Tinhtrang='true' ";
            SqlCommand cmdMP = new SqlCommand(addMP, conn);
            SqlDataReader readerMP = cmdMP.ExecuteReader();
            while (readerMP.Read())
            {

                cboMP.Items.Add(readerMP.GetString(0));
            }
            readerMP.Dispose();
            cmdMP.Dispose();
            LayBangChoGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mskNS.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtQQ.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cboQT.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cboKhoa.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cboMP.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            string GT = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (GT.Trim() == "Nam") //trim() cắt khoản trắng 2 đầu
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            try
            {
                if (txtMSV.Text != "" && txtHT.Text != "" && mskNS.Text != "" && txtEmail.Text != "" && txtSDT.Text != "" && txtQQ.Text != "" && cboQT.Text != "" && cboKhoa.Text != "" && cboMP.Text != "")
                {
                    conn.Open();
                    DateTime.ParseExact(mskNS.Text, "dd/MM/yyyy", null);
                    //Kiem tra trung ten
                    string ktsv = "Select * From sinhvien where Masv='" + txtMSV.Text + "'";
                    SqlCommand cmdsv = new SqlCommand(ktsv, conn);
                    SqlDataReader readersv;
                    readersv = cmdsv.ExecuteReader();
                    if (readersv.Read())
                    {
                        MessageBox.Show("Bạn đã nhập trùng sinh viên ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMSV.Focus();
                        cmdsv.Dispose();
                        readersv.Dispose();
                    }
                    else
                    {
                        cmdsv.Dispose();
                        readersv.Dispose();
                        string Gender;
                        if (rdNam.Checked)
                        {
                            Gender = "True";
                        }
                        else
                        {
                            Gender = "False";
                        }
                        string sql = "INSERT INTO sinhvien VALUES('" + txtMSV.Text + "',N'" + txtHT.Text + "',convert(date,'" + mskNS.Text + "',105),'" + Gender + "',N'" + txtEmail.Text + "','" + txtSDT.Text + "',N'" + txtQQ.Text + "','" + cboQT.Text + "','" + cboKhoa.Text + "','" + cboMP.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm Thành Công !");
                            LayBangChoGridView();
                            Loadtext();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại !");
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ dữ liệu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !" + ex.Message);
                MessageBox.Show("Ngày không hợp lệ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            try
            {
                conn.Open();
                DateTime.ParseExact(mskNS.Text, "dd/MM/yyyy", null);
                string Gender;
                if (rdNam.Checked)
                {
                    Gender = "True";
                }
                else
                {
                    Gender = "False";
                }
                string sql = "UPDATE sinhvien SET  Hoten=N'" + txtHT.Text + "',Ngaysinh=convert(date,'" + mskNS.Text + "', 105),Gioitinh='" + Gender + "',Email=N'" + txtEmail.Text + "',Sodienthoai='" + txtSDT.Text + "',Quequan=N'" + txtQQ.Text + "',Maquoctich='" + cboQT.Text + "',Makhoa='" + cboKhoa.Text + "',Maphong='" + cboMP.Text + "' where Masv='" + txtMSV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa Thành Công !");
                    LayBangChoGridView();
                    Loadtext();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại !");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !" + ex.Message);
                MessageBox.Show("Ngày không hợp lệ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa không !", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            SqlConnection conn = new SqlConnection(ketnoi);
            if (ThongBao == DialogResult.OK)
            {
                conn.Open();
                string sql = "Delete from sinhvien where Masv = '" + txtMSV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công !");
                LayBangChoGridView();
                Loadtext();
                conn.Close();
            }
        }
    }
}
