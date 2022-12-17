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
    public partial class UserControlDN : UserControl
    {
        string ketnoi = @"Data Source=DESKTOP-9PHN420;Initial Catalog=QLKTX;Integrated Security=True";
        public UserControlDN()
        {
            InitializeComponent();
        }
        public void LayBangChoGridView()
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            string sql = "select * from sodien";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Mã Tiêu Thụ";
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 100;

            dataGridView1.Columns[1].HeaderText = "Mã Phòng";
            dataGridView1.Columns[1].Width = 100;

            dataGridView1.Columns[2].HeaderText = "Số Điện Dùng";
            dataGridView1.Columns[2].Width = 100;

            dataGridView1.Columns[3].HeaderText = "Tháng";
            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns[4].HeaderText = "Năm";
            dataGridView1.Columns[4].Width = 100;
        }
        public void Loadtext()
        {
            txtMTT.Text = "";
            cboMP.Text = "";
            txtSD.Text = "";
            txtThang.Text = "";
            txtNam.Text = "";
        }

        private void UserControlDN_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            conn.Open();
            //Add du lieu vao cboMP
            string addMP = "Select Maphong from phong Where Tinhtrang='False' ";
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
            txtMTT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cboMP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtThang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNam.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            try
            {
                if (txtMTT.Text != "" && cboMP.Text != "" && txtSD.Text != "" && txtThang.Text != "" && txtNam.Text != "")
                {
                    conn.Open();
                    //Kiem tra trung ten
                    string kttt = "Select * From sodien where Matieuthu='" + txtMTT.Text + "'";
                    SqlCommand cmdkt = new SqlCommand(kttt, conn);
                    SqlDataReader readerkt;
                    readerkt = cmdkt.ExecuteReader();
                    if (readerkt.Read())
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã tiêu thụ ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMTT.Focus();
                        cmdkt.Dispose();
                        readerkt.Dispose();
                    }
                    else
                    {
                        cmdkt.Dispose();
                        readerkt.Dispose();
                        string sql = "INSERT INTO sodien VALUES('" + txtMTT.Text + "','" + cboMP.Text + "','" + txtSD.Text + "','" + txtThang.Text + "','" + txtNam.Text + "')";
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
                string sql = "update sodien set Maphong='" + cboMP.Text + "',Sodiendung='" + txtSD.Text + "',Thang='" + txtThang.Text + "',Nam='" + txtNam.Text + "' Where Matieuthu = '" + txtMTT.Text + "'";
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
                string sql = "Delete from sodien where Matieuthu = '" + txtMTT.Text + "'";
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
