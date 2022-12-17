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
    public partial class UserControlTT : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlTT()
        {
            InitializeComponent();
        }
        public void LayBangChoGridView()
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            string sql = "select Mathanhtoan,Maphong,(CASE WHEN Tinhtrangthanhtoantiendien='1' THEN N'Đã Thanh Toán' ELSE N'Chưa Thanh Toán' END) AS Tinhtrangthanhtoantiendien,(CASE WHEN Tinhtrangthanhtoantienphong='1' THEN N'Đã Thanh Toán' ELSE N'Chưa Thanh Toán' END) AS Tinhtrangthanhtoantienphong from thanhtoan";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Mã Thanh Toán";
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 130;

            dataGridView1.Columns[1].HeaderText = "Mã Phòng";
            dataGridView1.Columns[1].Width = 100;

            dataGridView1.Columns[2].HeaderText = "Thanh Toán Tiền Điện";
            dataGridView1.Columns[2].Width = 200;

            dataGridView1.Columns[3].HeaderText = "Thanh Toán Tiền Phòng";
            dataGridView1.Columns[3].Width = 200;
        }
        public void Loadtext()
        {
            txtMT.Text = "";
            cboMP.Text = "";
            cbd.Checked = false;
            cbp.Checked = false;
        }

        private void UserControlTT_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            conn.Open();
            //Add du lieu vao cboMP
            string addMP = "Select Maphong from phong where Tinhtrang='False' ";
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
            txtMT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cboMP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string TD = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (TD == "Đã Thanh Toán")
            {
                cbd.Checked = true;
            }
            else
            {
                cbd.Checked = false;
            }
            string TP = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (TP == "Đã Thanh Toán")
            {
                cbp.Checked = true;
            }
            else
            {
                cbp.Checked = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            try
            {
                if (txtMT.Text != "" && cboMP.Text != "")
                {
                    conn.Open();
                    //Kiem tra trung ten
                    string ktmt = "Select * From thanhtoan where Mathanhtoan='" + txtMT.Text + "'";
                    SqlCommand cmdkt = new SqlCommand(ktmt, conn);
                    SqlDataReader readerkt;
                    readerkt = cmdkt.ExecuteReader();
                    if (readerkt.Read())
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã thanh toán ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMT.Focus();
                        cmdkt.Dispose();
                        readerkt.Dispose();
                    }
                    else
                    {
                        cmdkt.Dispose();
                        readerkt.Dispose();
                        string TienDien;
                        if (cbd.Checked)
                        {
                            TienDien = "True";
                        }
                        else
                        {
                            TienDien = "False";
                        }
                        string TienPhong;
                        if (cbp.Checked)
                        {
                            TienPhong = "True";
                        }
                        else
                        {
                            TienPhong = "False";
                        }
                        string sql = "INSERT INTO thanhtoan VALUES('" + txtMT.Text + "','" + cboMP.Text + "','" + TienDien + "','" + TienPhong + "')";
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
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            try
            {
                conn.Open();
                string TienDien;
                if (cbd.Checked)
                {
                    TienDien = "True";
                }
                else
                {
                    TienDien = "False";
                }
                string TienPhong;
                if (cbp.Checked)
                {
                    TienPhong = "True";
                }
                else
                {
                    TienPhong = "False";
                }
                string sql = "update Thanhtoan set Maphong=N'" + cboMP.Text + "',Tinhtrangthanhtoantiendien='" + TienDien + "',Tinhtrangthanhtoantienphong='" + TienPhong + "' where Mathanhtoan='" + txtMT.Text + "'";
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
                string sql = "Delete from Thanhtoan where Mathanhtoan = '" + txtMT.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công !");
                LayBangChoGridView();
                Loadtext();
                conn.Close();
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
