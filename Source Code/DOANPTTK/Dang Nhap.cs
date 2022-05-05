using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DOANPTTK
{
    public partial class frmDangNhap : Form
    {
        BUS_TaiKhoan BUS_taiKhoan;
        BUS_NhanVien BUS_nhanVien;
        public frmDangNhap()
        {
            InitializeComponent();
       
            BUS_taiKhoan = new BUS_TaiKhoan();
            BUS_nhanVien = new BUS_NhanVien();
 
        }
  
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            DTO_TaiKhoan tk = new DTO_TaiKhoan();
            tk.TenTaiKhoan = txtTenTaiKhoan.Text;
            tk.MatKhau = txtMatKhau.Text;
            DataTable dt = BUS_taiKhoan.DocThongTinTaiKhoan(tk);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string loaiND = row["LOAIND"].ToString();
                int type = int.Parse(loaiND);
                switch (type)
                {
                    case 0:
                        {
                            frmOptionsCustom frmOptions = new frmOptionsCustom(txtTenTaiKhoan.Text);
                            this.Hide();
                            frmOptions.ShowDialog();
                            this.Show();
                            break;
                        }
                    case 1:
                        {
                            DTO_NhanVien nv = new DTO_NhanVien();
                            nv.MaNhanVien = txtTenTaiKhoan.Text;
                            DataTable dtNV = BUS_nhanVien.DocThongTinNhanVien(nv);
                            if (dtNV.Rows.Count > 0)
                            {
                                DataRow rowNV = dtNV.Rows[0];
                                string viTri = rowNV["VITRI"].ToString();
                                int typeViTri = int.Parse(viTri);
                                switch (typeViTri)
                                {
                                    case 0:
                                        {
                                            frmOptionsNVHD frmOptionsNVHD = new frmOptionsNVHD();
                                            this.Hide();
                                            frmOptionsNVHD.ShowDialog();
                                            this.Show();
                                            break;
                                        }
                                    case 1:
                                        {
                                            //
                                            frmOptionsNVYT frmOptionsNVYT = new frmOptionsNVYT();
                                            this.Hide();
                                            frmOptionsNVYT.ShowDialog();
                                            this.Show();
                                            break;
                                        }
                                    case 2:
                                        {
                                            frmOptionsBS frmOptionsBS = new frmOptionsBS();
                                            this.Hide();
                                            frmOptionsBS.ShowDialog();
                                            this.Show();
                                            break;
                                        }
                                    case 3:
                                        {
                                            frmOptionsNVKT frmOptionsNVKT = new frmOptionsNVKT(txtTenTaiKhoan.Text);
                                            this.Hide();
                                            frmOptionsNVKT.ShowDialog();
                                            this.Show();
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            frmOptionsBPDH frmOptionsBPDH = new frmOptionsBPDH();
                            this.Hide();
                            frmOptionsBPDH.ShowDialog();
                            this.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
