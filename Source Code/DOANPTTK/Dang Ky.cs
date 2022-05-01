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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1ETUQ04I\SQLEXPRESS;Initial Catalog=QLTC;Persist Security Info=True;User ID=sa;Password=12345");
        
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO TAIKHOAN(TENTAIKHOAN, MATKHAU, LOAIND) VALUES('"+txtTenTaiKhoan.Text+"', '" + txtMatKhau.Text+"', 0)";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                MessageBox.Show("Đăng ký thành công!");

                if (dataTable.Rows.Count > 0)
                {
                    frmOptionsCustom frmOptions = new frmOptionsCustom();
                    frmOptions.Show();
                    this.Hide();
                }
            }
            catch { 
                MessageBox.Show("Đăng ký không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTenTaiKhoan.Focus();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
