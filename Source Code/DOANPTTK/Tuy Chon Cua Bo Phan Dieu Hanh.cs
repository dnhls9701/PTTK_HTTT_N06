﻿using System;
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
    public partial class frmOptionsBPDH : Form
    {
        frmDangNhap frmDangNhap = new frmDangNhap();
        public frmOptionsBPDH()
        {
            //cur_frmDangNhap = frmDangNhap;
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmDangNhap.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                //..
            }
        }
    }
}
