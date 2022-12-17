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
    public partial class UserControlPhong : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlPhong()
        {
            InitializeComponent();
        }
        public void LayBangChoGridView()
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            string sql = "select Maphong,Tenphong,Tang,Khu,(case when Tinhtrang='1' then N'Trống' else N'Đã sử dụnng' end )as Tinhtrang,Loaiphong from phong";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Mã Phòng";
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 150;

            dataGridView1.Columns[1].HeaderText = "Tên Phòng";
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.Columns[2].HeaderText = "Tầng";
            dataGridView1.Columns[2].Width = 100;

            dataGridView1.Columns[3].HeaderText = "Khu";
            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns[4].HeaderText = "Tình Trạng";
            dataGridView1.Columns[4].Width = 100;

            dataGridView1.Columns[5].HeaderText = "Loại Phòng";
            dataGridView1.Columns[5].Width = 100;
        }
        public void Loadtext()
        {
            txtMP.Text = "";
            txtTP.Text = "";
            cboTang.Text = "";
            cboKhu.Text = "";
            cboLP.Text = "";
        }

        private void UserControlPhong_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            conn.Open();
            //Add du lieu vao cboLP
            string addLP = "Select Loaiphong from banggia ";
            SqlCommand cmdLP = new SqlCommand(addLP, conn);
            SqlDataReader readerLP = cmdLP.ExecuteReader();
            while (readerLP.Read())
            {

                cboLP.Items.Add(readerLP.GetString(0));
            }
            readerLP.Dispose();
            cmdLP.Dispose();
            LayBangChoGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cboTang.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cboKhu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cboLP.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string TT = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (TT.Trim() == "Trống") //trim() cắt khoản trắng 2 đầu
            {
                rdoTrong.Checked = true;
            }
            else
            {
                rdoSD.Checked = true;
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
                if (txtMP.Text != "" && txtTP.Text != "" && cboTang.Text != "" && cboKhu.Text != "" && cboLP.Text != "")
                {
                    conn.Open();
                    //Kiem tra trung ten
                    string ktph = "Select * From phong where Maphong='" + txtMP.Text + "'";
                    SqlCommand cmdkt = new SqlCommand(ktph, conn);
                    SqlDataReader readerkt;
                    readerkt = cmdkt.ExecuteReader();
                    if (readerkt.Read())
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã phòng ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMP.Focus();
                        cmdkt.Dispose();
                        readerkt.Dispose();
                    }
                    else
                    {
                        cmdkt.Dispose();
                        readerkt.Dispose();
                        // insert du lieu e dang loi phan nay co a
                        string TrangThai;
                        if (rdoTrong.Checked)
                        {
                            TrangThai = "True";
                        }
                        else
                        {
                            TrangThai = "False";
                        }
                        string sql = "INSERT INTO phong VALUES('" + txtMP.Text + "',N'" + txtTP.Text + "','" + cboTang.Text + "','" + cboKhu.Text + "','" + TrangThai + "',N'" + cboLP.Text + "')";
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
                string TrangThai;
                if (rdoTrong.Checked)
                {
                    TrangThai = "True";
                }
                else
                {
                    TrangThai = "False";
                }
                string sql = "update phong set Tenphong=N'" + txtTP.Text + "',Tang='" + cboTang.Text + "',Khu='" + cboKhu.Text + "',Tinhtrang='" + TrangThai + "',Loaiphong=N'" + cboLP.Text + "' where Maphong='" + txtMP.Text + "'";
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
                string sql = "Delete from phong where Maphong = '" + txtMP.Text + "'";
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
