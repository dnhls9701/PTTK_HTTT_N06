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
    public partial class frmDatMuaVacXin : Form
    {
        string MaKhachHang;
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_Vacxin busVacXin = new BUS_Vacxin();
        public frmDatMuaVacXin(string makh)
        {
            InitializeComponent();
            this.MaKhachHang = makh;
            DataRow dr = busKhachHang.DocThongTinKhachHang(this.MaKhachHang);
            lb_tenkhachhang.Text = dr[1].ToString();
            lb_curdate.Text = DateTime.Now.ToShortDateString();
        }

        private void cbb_loaivacxin_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt;
            if (cbb_loaivacxin.Text == "Gói tiêm")
                dt = busVacXin.DocThongTinGoiTiem();
            else
                dt = busVacXin.DocThongTinTiemLe();

            lb_thanhtien.Text = "0";
            dgv_DSVacXinDaChon.Rows.Clear();
            dgv_DSVacXinHT.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dgv_DSVacXinHT.Rows.Add();
                dgv_DSVacXinHT.Rows[n].Cells[0].Value = row[0].ToString();
                dgv_DSVacXinHT.Rows[n].Cells[1].Value = row[1].ToString();
                dgv_DSVacXinHT.Rows[n].Cells[2].Value = row[2].ToString();
                dgv_DSVacXinHT.Rows[n].Cells[3].Value = row[3].ToString();
            }
        }

        private void dgv_DSVacXinHT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DSVacXinHT.Columns["cb_chon"].Index && e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(dgv_DSVacXinHT.Rows[e.RowIndex].Cells["cb_chon"].Value) == true)
                    dgv_DSVacXinHT.Rows[e.RowIndex].Cells["cb_chon"].Value = null;
                else
                    dgv_DSVacXinHT.Rows[e.RowIndex].Cells["cb_chon"].Value = true;

                int thanhtien = 0;
                dgv_DSVacXinDaChon.Rows.Clear();
                for (int i = 0; i < dgv_DSVacXinHT.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgv_DSVacXinHT.Rows[i].Cells["cb_chon"].Value) == true)
                    {
                        int n = dgv_DSVacXinDaChon.Rows.Add();
                        dgv_DSVacXinDaChon.Rows[n].Cells[0].Value = dgv_DSVacXinHT.Rows[i].Cells[0].Value;
                        dgv_DSVacXinDaChon.Rows[n].Cells[1].Value = dgv_DSVacXinHT.Rows[i].Cells[1].Value;
                        dgv_DSVacXinDaChon.Rows[n].Cells[2].Value = dgv_DSVacXinHT.Rows[i].Cells[2].Value;
                        dgv_DSVacXinDaChon.Rows[n].Cells[3].Value = dgv_DSVacXinHT.Rows[i].Cells[3].Value;

                        thanhtien += int.Parse(dgv_DSVacXinDaChon.Rows[n].Cells[3].Value.ToString());
                    }
                }
                lb_thanhtien.Text = thanhtien.ToString();
            }
        }

        private void btn_datmua_Click(object sender, EventArgs e)
        {
            if (dgv_DSVacXinDaChon.RowCount == 0)
                MessageBox.Show("Danh sách đặt mua không được bỏ trống");
            else if (cbb_trungtam.Text == "")
                MessageBox.Show("Địa điểm không được bỏ trống");
            else
            {
                BUS_DatMuaVacXin busDatMuaVacXin = new BUS_DatMuaVacXin();
                string MaDatMua = busDatMuaVacXin.TaoMaDatMua();
                DTO_DatMuaVacXin datmua = new DTO_DatMuaVacXin();
                datmua.MaDatMua = MaDatMua;
                datmua.NgayDat = DateTime.Now;
                datmua.MaKhachHang = this.MaKhachHang;
                datmua.MaTrungTam = cbb_trungtam.Text;
                if (cbb_loaivacxin.Text == "Gói tiêm")
                    datmua.Loai = 0;
                else
                    datmua.Loai = 1;

                if (busDatMuaVacXin.TaoDatMuaVacXin(datmua))
                {
                    BUS_ChiTietDatMua busChiTietDatMua = new BUS_ChiTietDatMua();
                    DTO_ChiTietDatMua ctdatmua = new DTO_ChiTietDatMua();
                    ctdatmua.MaDatMua = MaDatMua;
                    for (int i = 0; i < dgv_DSVacXinDaChon.RowCount; i++)
                    {
                        ctdatmua.MaGoiTiem_VacXin = dgv_DSVacXinDaChon.Rows[i].Cells[0].Value.ToString();
                        if (datmua.Loai == 0)
                            busChiTietDatMua.TaoChiTietDatMuaGOI(ctdatmua);
                        else
                            busChiTietDatMua.TaoChiTietDatMuaLE(ctdatmua);
                    }
                    MessageBox.Show("Đặt mua Thành Công!");
                }
                else
                {
                    MessageBox.Show("Đặt mua không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void frmDatMuaVacXin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
