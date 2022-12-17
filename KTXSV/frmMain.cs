using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTXSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            panelSilde.Height = btnND.Height;
            panelSilde.Top = btnND.Top;
            userControlMain1.BringToFront();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            panelSilde.Height = btnThoat.Height;
            panelSilde.Top = btnThoat.Top;
        }

        private void btnND_Click(object sender, EventArgs e)
        {
            panelSilde.Height = btnND.Height;
            panelSilde.Top = btnND.Top;
            userControlND1.BringToFront();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            panelSilde.Height = btnKhoa.Height;
            panelSilde.Top = btnKhoa.Top;
            userControlKhoa1.BringToFront();
        }

        private void btnQT_Click(object sender, EventArgs e)
        {
            panelSilde.Height = btnQT.Height;
            panelSilde.Top = btnQT.Top;
            userControlQT1.BringToFront();
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            panelSilde.Height = btnSV.Height;
            panelSilde.Top = btnSV.Top;
            userControlSV1.BringToFront();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            panelSilde.Height = btnPhong.Height;
            panelSilde.Top = btnPhong.Top;
            userControlPhong1.BringToFront();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            panelSilde.Height = btnDN.Height;
            panelSilde.Top = btnDN.Top;
            userControlDN1.BringToFront();
        }

        private void btnGia_Click(object sender, EventArgs e)
        {
            panelSilde.Height = btnGia.Height;
            panelSilde.Top = btnGia.Top;
            userControlGia1.BringToFront();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            panelSilde.Height = btnTT.Height;
            panelSilde.Top = btnTT.Top;
            userControlTT1.BringToFront();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            /*đăngXuấtToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
            tìmKiếmToolStripMenuItem.Enabled = false;
            bảoMậtToolStripMenuItem.Enabled = false;
            btnND.Enabled = false;
            btnGia.Enabled = false;
            btnDN.Enabled = false;
            btnKhoa.Enabled = false;
            btnPhong.Enabled = false;
            btnQT.Enabled = false;
            btnSV.Enabled = false;
            btnTT.Enabled = false;
            btnThoat.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            */
            Hide();

        }

        /*private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/

        private void thốngKêSinhViênKTXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlTK1.BringToFront();
        }

        private void danhSáchPhòngChưaThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlDSP1.BringToFront();
        }

        private void dữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlDATA1.BringToFront();
        }

        private void thôngTinThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlTTOAN1.BringToFront();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlTKSV1.BringToFront();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlLP1.BringToFront();
        }

        private void tìnhTrạngPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlTTP1.BringToFront();
        }

        private void tênVàMãPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlTP1.BringToFront();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlGT1.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            đăngNhậpToolStripMenuItem.Enabled = false;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
