
namespace DOANPTTK
{
    partial class frmDangKyTiemChung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChongoimuitiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.dtpNgayTiemDuKien = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cbMaTrungTam = new System.Windows.Forms.ComboBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDangKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDSPhieuDangKy = new System.Windows.Forms.DataGridView();
            this.colMaDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTrungTam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTiemDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPhieuDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChongoimuitiem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbLoai);
            this.panel1.Controls.Add(this.dtpNgayTiemDuKien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.cbMaTrungTam);
            this.panel1.Controls.Add(this.dtpNgayLapPhieu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaKhachHang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaDangKy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 397);
            this.panel1.TabIndex = 9;
            // 
            // btnChongoimuitiem
            // 
            this.btnChongoimuitiem.BackColor = System.Drawing.Color.Moccasin;
            this.btnChongoimuitiem.Location = new System.Drawing.Point(388, 331);
            this.btnChongoimuitiem.Name = "btnChongoimuitiem";
            this.btnChongoimuitiem.Size = new System.Drawing.Size(175, 38);
            this.btnChongoimuitiem.TabIndex = 18;
            this.btnChongoimuitiem.Text = "Chọn gói tiêm/mũi tiêm";
            this.btnChongoimuitiem.UseVisualStyleBackColor = false;
            this.btnChongoimuitiem.Click += new System.EventHandler(this.btnChongoimuitiem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(246, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "(* 0: Chọn gói tiêm; 1: Chọn mũi tiêm)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(99, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gói tiêm/mũi tiêm vacxin:";
            // 
            // cbLoai
            // 
            this.cbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbLoai.Location = new System.Drawing.Point(327, 250);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(296, 28);
            this.cbLoai.TabIndex = 15;
            // 
            // dtpNgayTiemDuKien
            // 
            this.dtpNgayTiemDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayTiemDuKien.Location = new System.Drawing.Point(327, 205);
            this.dtpNgayTiemDuKien.Name = "dtpNgayTiemDuKien";
            this.dtpNgayTiemDuKien.Size = new System.Drawing.Size(296, 27);
            this.dtpNgayTiemDuKien.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(99, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày tiêm dự kiến:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDangKy.Location = new System.Drawing.Point(214, 331);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(102, 38);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cbMaTrungTam
            // 
            this.cbMaTrungTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaTrungTam.FormattingEnabled = true;
            this.cbMaTrungTam.Items.AddRange(new object[] {
            "TT001",
            "TT002",
            "TT003"});
            this.cbMaTrungTam.Location = new System.Drawing.Point(327, 159);
            this.cbMaTrungTam.Name = "cbMaTrungTam";
            this.cbMaTrungTam.Size = new System.Drawing.Size(296, 28);
            this.cbMaTrungTam.TabIndex = 12;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(327, 67);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(296, 27);
            this.dtpNgayLapPhieu.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(99, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã trung tâm:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(327, 113);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(296, 27);
            this.txtMaKhachHang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(99, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(99, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày lập phiếu:";
            // 
            // txtMaDangKy
            // 
            this.txtMaDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDangKy.Location = new System.Drawing.Point(327, 24);
            this.txtMaDangKy.Name = "txtMaDangKy";
            this.txtMaDangKy.Size = new System.Drawing.Size(296, 27);
            this.txtMaDangKy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(98, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đăng ký:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(253, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng ký tiêm chủng";
            // 
            // dgDSPhieuDangKy
            // 
            this.dgDSPhieuDangKy.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgDSPhieuDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSPhieuDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDangKy,
            this.colNgayLapPhieu,
            this.colMaKhachHang,
            this.colMaTrungTam,
            this.colNgayTiemDuKien});
            this.dgDSPhieuDangKy.Location = new System.Drawing.Point(24, 527);
            this.dgDSPhieuDangKy.Name = "dgDSPhieuDangKy";
            this.dgDSPhieuDangKy.RowHeadersWidth = 51;
            this.dgDSPhieuDangKy.RowTemplate.Height = 24;
            this.dgDSPhieuDangKy.Size = new System.Drawing.Size(733, 211);
            this.dgDSPhieuDangKy.TabIndex = 12;
            // 
            // colMaDangKy
            // 
            this.colMaDangKy.DataPropertyName = "MADANGKY";
            this.colMaDangKy.HeaderText = "Mã đăng ký";
            this.colMaDangKy.MinimumWidth = 6;
            this.colMaDangKy.Name = "colMaDangKy";
            this.colMaDangKy.Width = 125;
            // 
            // colNgayLapPhieu
            // 
            this.colNgayLapPhieu.DataPropertyName = "NGAYLAPPHIEU";
            this.colNgayLapPhieu.HeaderText = "Ngày lập phiếu";
            this.colNgayLapPhieu.MinimumWidth = 6;
            this.colNgayLapPhieu.Name = "colNgayLapPhieu";
            this.colNgayLapPhieu.Width = 140;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.DataPropertyName = "MAKHACHHANG";
            this.colMaKhachHang.HeaderText = "Mã khách hàng";
            this.colMaKhachHang.MinimumWidth = 6;
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.Width = 125;
            // 
            // colMaTrungTam
            // 
            this.colMaTrungTam.DataPropertyName = "MATRUNGTAM";
            this.colMaTrungTam.HeaderText = "Mã trung tâm";
            this.colMaTrungTam.MinimumWidth = 6;
            this.colMaTrungTam.Name = "colMaTrungTam";
            this.colMaTrungTam.Width = 125;
            // 
            // colNgayTiemDuKien
            // 
            this.colNgayTiemDuKien.DataPropertyName = "NGAYTIEMDUKIEN";
            this.colNgayTiemDuKien.HeaderText = "Ngày tiêm dự kiến";
            this.colNgayTiemDuKien.MinimumWidth = 6;
            this.colNgayTiemDuKien.Name = "colNgayTiemDuKien";
            this.colNgayTiemDuKien.Width = 160;
            // 
            // frmDangKyTiemChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 767);
            this.Controls.Add(this.dgDSPhieuDangKy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKyTiemChung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tiêm chủng";
            this.Load += new System.EventHandler(this.frmDangKyTiemChung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPhieuDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaTrungTam;
        private System.Windows.Forms.DateTimePicker dtpNgayTiemDuKien;
        private System.Windows.Forms.DataGridView dgDSPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTrungTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTiemDuKien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Button btnChongoimuitiem;
    }
}