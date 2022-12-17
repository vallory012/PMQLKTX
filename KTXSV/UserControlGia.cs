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
    public partial class UserControlGia : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlGia()
        {
            InitializeComponent();
        }
        public void LayBangChoGridView()
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            string sql = "select * from banggia";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Loại Phòng";
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 150;

            dataGridView1.Columns[1].HeaderText = "Giá Điện";
            dataGridView1.Columns[1].Width = 100;

            dataGridView1.Columns[2].HeaderText = "Giá Phòng";
            dataGridView1.Columns[2].Width = 100;

            dataGridView1.Columns[3].HeaderText = "Năm Học";
            dataGridView1.Columns[3].Width = 100;
        }
        public void Loadtext()
        {
            txtLP.Text = "";
            txtGD.Text = "";
            txtGP.Text = "";
            txtNH.Text = "";
        }

        private void UserControlGia_Load(object sender, EventArgs e)
        {
            LayBangChoGridView();
            dataGridView1.Columns["Giadien"].DefaultCellStyle.Format = "00,0";
            dataGridView1.Columns["Giaphong"].DefaultCellStyle.Format = "00,0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtGD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGP.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNH.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            try
            {
                if (txtLP.Text != "" && txtGD.Text != "" && txtGP.Text != "" && txtNH.Text != "")
                {
                    conn.Open();
                    //Kiem tra trung ten
                    string ktgia = "Select * From banggia where LoaiPhong='" + txtLP.Text + "'";
                    SqlCommand cmdkt = new SqlCommand(ktgia, conn);
                    SqlDataReader readerkt;
                    readerkt = cmdkt.ExecuteReader();
                    if (readerkt.Read())
                    {
                        MessageBox.Show("Bạn đã nhập trùng loại phòng ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtLP.Focus();
                        cmdkt.Dispose();
                        readerkt.Dispose();
                    }
                    else
                    {
                        cmdkt.Dispose();
                        readerkt.Dispose();
                        string sql = "INSERT INTO banggia VALUES('" + txtLP.Text + "','" + txtGD.Text + "','" + txtGP.Text + "','" + txtNH.Text + "')";
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
                string sql = "update banggia set Giadien='" + txtGD.Text + "',Giaphong='" + txtGP.Text + "',Namhoc='" + txtNH.Text + "' Where LoaiPhong = '" + txtLP.Text + "'";
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
                string sql = "Delete from banggia where LoaiPhong = '" + txtLP.Text + "'";
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
