
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
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDangKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.cbMaTrungTam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayTiemDuKien = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTrungTam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTiemDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Size = new System.Drawing.Size(733, 326);
            this.panel1.TabIndex = 9;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(326, 262);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(102, 38);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(110, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày lập phiếu:";
            // 
            // txtMaDangKy
            // 
            this.txtMaDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDangKy.Location = new System.Drawing.Point(298, 24);
            this.txtMaDangKy.Name = "txtMaDangKy";
            this.txtMaDangKy.Size = new System.Drawing.Size(296, 27);
            this.txtMaDangKy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(109, 27);
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
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(298, 113);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(296, 27);
            this.txtMaKhachHang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(110, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(110, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã trung tâm:";
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(298, 67);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(296, 27);
            this.dtpNgayLapPhieu.TabIndex = 11;
            // 
            // cbMaTrungTam
            // 
            this.cbMaTrungTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaTrungTam.FormattingEnabled = true;
            this.cbMaTrungTam.Items.AddRange(new object[] {
            "TT01",
            "TT02",
            "TT03"});
            this.cbMaTrungTam.Location = new System.Drawing.Point(298, 159);
            this.cbMaTrungTam.Name = "cbMaTrungTam";
            this.cbMaTrungTam.Size = new System.Drawing.Size(296, 28);
            this.cbMaTrungTam.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(110, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày tiêm dự kiến:";
            // 
            // dtpNgayTiemDuKien
            // 
            this.dtpNgayTiemDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayTiemDuKien.Location = new System.Drawing.Point(298, 205);
            this.dtpNgayTiemDuKien.Name = "dtpNgayTiemDuKien";
            this.dtpNgayTiemDuKien.Size = new System.Drawing.Size(296, 27);
            this.dtpNgayTiemDuKien.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDangKy,
            this.colNgayLapPhieu,
            this.colMaKhachHang,
            this.colMaTrungTam,
            this.colNgayTiemDuKien});
            this.dataGridView1.Location = new System.Drawing.Point(24, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 211);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(655, 37);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 33);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangKyTiemChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKyTiemChung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tiêm chủng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTrungTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTiemDuKien;
        private System.Windows.Forms.Button btnThoat;
    }
}