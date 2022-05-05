using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANPTTK
{
    public partial class frmPhanCongCongViec : Form
    {
        BUS_LichRanh busLichRanh = new BUS_LichRanh();
        BUS_PhanCong busPhanCong = new BUS_PhanCong();
        public frmPhanCongCongViec()
        {
            InitializeComponent();
            this.load_dsPhanCong();
        }

        private void load_dsPhanCong()
        {
            DataTable dt = busPhanCong.DocPhanCong();
            dgv_dsphancong.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dgv_dsphancong.Rows.Add();
                dgv_dsphancong.Rows[n].Cells[0].Value = row[0].ToString();
                dgv_dsphancong.Rows[n].Cells[1].Value = row[1].ToString().Substring(0,10);
                dgv_dsphancong.Rows[n].Cells[2].Value = row[2].ToString();
                dgv_dsphancong.Rows[n].Cells[3].Value = row[3].ToString();
            }
        }

        private void cbb_vitri_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_manhanvien.Text = null;
            int vitri;
            if (cbb_vitri.Text == "Nhân viên hướng dẫn")
                vitri = 0;
            else if (cbb_vitri.Text == "Nhân viên y tế")
                vitri = 1;
            else if (cbb_vitri.Text == "Bác sĩ")
                vitri = 2;
            else
                vitri = 3;
            cbb_manhanvien.DataSource = busLichRanh.DocMaNhanVien(vitri);
            cbb_manhanvien.DisplayMember = "MANHANVIEN";
            cbb_manhanvien.ValueMember = "MANHANVIEN";
        }

        private void cbb_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_ngayphancong.Text = null;
            cbb_ngayphancong.DataSource = busLichRanh.DocNgayRanh(cbb_manhanvien.Text);
            cbb_ngayphancong.DisplayMember = cbb_ngayphancong.ValueMember = "NGAYRANH";
        }

       

        private void cbb_ngayphancong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_caphancong.Text = null;
            cbb_caphancong.DataSource = busLichRanh.DocCaRanh(cbb_manhanvien.Text, cbb_ngayphancong.Text);
            cbb_caphancong.DisplayMember = cbb_caphancong.ValueMember = "CARANH";
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(cbb_vitri.Text) || string.IsNullOrEmpty(cbb_manhanvien.Text)|| string.IsNullOrEmpty(cbb_phonglamviec.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_vitri.Focus();
                return false;
            }
            return true;
        }

        private void btn_phancong_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DTO_PhanCong phancong = new DTO_PhanCong();
                phancong.MaNhanVien = cbb_manhanvien.Text;
                phancong.NgayPhanCong = cbb_ngayphancong.Text;
                phancong.CaLam = int.Parse(cbb_caphancong.Text);
                phancong.PhongLamViec = int.Parse(cbb_phonglamviec.Text);

                if (busPhanCong.TaoPhanCong(phancong))
                {
                    MessageBox.Show("Đã phân công!");
                    this.load_dsPhanCong();
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_dsphancong.RowCount; i++)
            {
                if (Convert.ToBoolean(dgv_dsphancong.Rows[i].Cells["cb_xoa"].Value) == true)
                {
                    DTO_PhanCong phancong = new DTO_PhanCong();
                    phancong.MaNhanVien = dgv_dsphancong.Rows[i].Cells[0].Value.ToString();
                    phancong.NgayPhanCong = dgv_dsphancong.Rows[i].Cells[1].Value.ToString();
                    phancong.CaLam = int.Parse(dgv_dsphancong.Rows[i].Cells[2].Value.ToString());
                    busPhanCong.XoaPhanCong(phancong);
                }
            }
            this.load_dsPhanCong();
        }

        private void frmPhanCongCongViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
