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
    public partial class frmDangKyTiemChung : Form
    {
        BUS_PhieuDangKy BUS_phieuDangKy = new BUS_PhieuDangKy();
        BUS_TaiKhoan BUS_taiKhoan = new BUS_TaiKhoan();
        string tenTaiKhoan;
        public frmDangKyTiemChung(string tenTK)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTK;
            
            DataRow dr = BUS_taiKhoan.LayThongTinTaiKhoan(this.tenTaiKhoan);
            txtMaKhachHang.Text = dr[0].ToString();
            
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaDangKy.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDangKy.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dtpNgayLapPhieu.Value.ToShortDateString()))
            {
                MessageBox.Show("Bạn chưa nhập ngày lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayLapPhieu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbMaTrungTam.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã trung tâm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaTrungTam.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dtpNgayTiemDuKien.Value.ToShortDateString()))
            {
                MessageBox.Show("Bạn chưa nhập ngày tiêm dự kiến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayTiemDuKien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbLoai.Text))
            {
                MessageBox.Show("Bạn chưa chọn gói tiêm/mũi tiên vacxin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbLoai.Focus();
                return false;
            }
            return true;
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1ETUQ04I\SQLEXPRESS;Initial Catalog=QLTC;Persist Security Info=True;User ID=sa;Password=12345");

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DTO_PhieuDangKy phieuDangKy = new DTO_PhieuDangKy();
                phieuDangKy.MaDangKy = txtMaDangKy.Text;
                phieuDangKy.NgayLapPhieu = new DateTime(dtpNgayLapPhieu.Value.Year, dtpNgayLapPhieu.Value.Month, dtpNgayLapPhieu.Value.Day);
                phieuDangKy.MaKhachHang = txtMaKhachHang.Text;
                phieuDangKy.MaTrungTam = cbMaTrungTam.Text;
                phieuDangKy.NgayTiemDuKien = new DateTime(dtpNgayTiemDuKien.Value.Year, dtpNgayTiemDuKien.Value.Month, dtpNgayTiemDuKien.Value.Day);
                phieuDangKy.Loai = int.Parse(cbLoai.Text);
               
                if (BUS_phieuDangKy.TaoPhieuDangKy(phieuDangKy))
                {
                    MessageBox.Show("Tạo phiếu đăng ký thành công!", "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Tạo phiếu đăng ký không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void frmDangKyTiemChung_Load(object sender, EventArgs e)
        {
            DTO_PhieuDangKy pdk1 = new DTO_PhieuDangKy();
            pdk1.MaKhachHang = this.tenTaiKhoan;
            DataTable dt = BUS_phieuDangKy.LayThongTinPhieuDangKyCuaKH(pdk1);
            dgDSPhieuDangKy.DataSource = dt;
           
        }

        private void btnChongoimuitiem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DTO_PhieuDangKy phieuDangKy = new DTO_PhieuDangKy();
                phieuDangKy.MaDangKy = txtMaDangKy.Text;
                phieuDangKy.NgayLapPhieu = new DateTime(dtpNgayLapPhieu.Value.Year, dtpNgayLapPhieu.Value.Month, dtpNgayLapPhieu.Value.Day);
                phieuDangKy.MaKhachHang = txtMaKhachHang.Text;
                phieuDangKy.MaTrungTam = cbMaTrungTam.Text;
                phieuDangKy.NgayTiemDuKien = new DateTime(dtpNgayTiemDuKien.Value.Year, dtpNgayTiemDuKien.Value.Month, dtpNgayTiemDuKien.Value.Day);
                phieuDangKy.Loai = int.Parse(cbLoai.Text);

                if (BUS_phieuDangKy.TaoPhieuDangKy(phieuDangKy))
                {
                    //MessageBox.Show("Tạo Hóa Đơn Thành Công!");
                    DTO_PhieuDangKy pdk = new DTO_PhieuDangKy();
                    pdk.MaDangKy = phieuDangKy.MaDangKy;
                    pdk.Loai = phieuDangKy.Loai;

                    DataTable dt = BUS_phieuDangKy.KiemTraThongTinPhieuDangKy(pdk);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        string loai = row["LOAI"].ToString();
                        int type = int.Parse(loai);
                        switch (type)
                        {
                            case 0:
                                {
                                    frmDSGoiTiem frmDSGoiTiem = new frmDSGoiTiem(pdk.MaDangKy);
                                    this.Hide();
                                    frmDSGoiTiem.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case 1:
                                {
                                    frmDSMuiTiemVacxin frmDSMuiTiem = new frmDSMuiTiemVacxin(pdk.MaDangKy);
                                    this.Hide();
                                    frmDSMuiTiem.ShowDialog();
                                    this.Show();
                                    break;
                                }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tạo phiếu đăng ký không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
