
namespace DOANPTTK
{
    partial class frmDSHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLaphoadon = new System.Windows.Forms.Button();
            this.btnXuathoadon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhthucTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(410, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hóa đơn thanh toán";
            // 
            // btnLaphoadon
            // 
            this.btnLaphoadon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLaphoadon.Location = new System.Drawing.Point(466, 539);
            this.btnLaphoadon.Name = "btnLaphoadon";
            this.btnLaphoadon.Size = new System.Drawing.Size(109, 48);
            this.btnLaphoadon.TabIndex = 21;
            this.btnLaphoadon.Text = "Lập hóa đơn";
            this.btnLaphoadon.UseVisualStyleBackColor = false;
            this.btnLaphoadon.Click += new System.EventHandler(this.btnLaphoadon_Click);
            // 
            // btnXuathoadon
            // 
            this.btnXuathoadon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXuathoadon.Location = new System.Drawing.Point(621, 539);
            this.btnXuathoadon.Name = "btnXuathoadon";
            this.btnXuathoadon.Size = new System.Drawing.Size(109, 48);
            this.btnXuathoadon.TabIndex = 19;
            this.btnXuathoadon.Text = "Xuất hóa đơn";
            this.btnXuathoadon.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dsHoaDon);
            this.panel1.Location = new System.Drawing.Point(29, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 405);
            this.panel1.TabIndex = 22;
            // 
            // dsHoaDon
            // 
            this.dsHoaDon.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colNgayTT,
            this.colMaKH,
            this.colMaTT,
            this.colSotien,
            this.colHinhthucTT,
            this.colNoidung,
            this.colNhanvien});
            this.dsHoaDon.Location = new System.Drawing.Point(15, 15);
            this.dsHoaDon.Name = "dsHoaDon";
            this.dsHoaDon.RowHeadersWidth = 51;
            this.dsHoaDon.RowTemplate.Height = 24;
            this.dsHoaDon.Size = new System.Drawing.Size(1072, 373);
            this.dsHoaDon.TabIndex = 4;
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MAHOADON";
            this.colMaHD.HeaderText = "Mã Hóa Đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.Width = 115;
            // 
            // colNgayTT
            // 
            this.colNgayTT.DataPropertyName = "NGAYTHANHTOAN";
            this.colNgayTT.HeaderText = "Ngày Thanh Toán";
            this.colNgayTT.MinimumWidth = 6;
            this.colNgayTT.Name = "colNgayTT";
            this.colNgayTT.Width = 125;
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MAKHACHHANG";
            this.colMaKH.HeaderText = "Mã Khách Hàng";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Width = 115;
            // 
            // colMaTT
            // 
            this.colMaTT.DataPropertyName = "MATRUNGTAM";
            this.colMaTT.HeaderText = "Mã Trung Tâm";
            this.colMaTT.MinimumWidth = 6;
            this.colMaTT.Name = "colMaTT";
            this.colMaTT.Width = 115;
            // 
            // colSotien
            // 
            this.colSotien.DataPropertyName = "SOTIEN";
            this.colSotien.HeaderText = "Số Tiền";
            this.colSotien.MinimumWidth = 6;
            this.colSotien.Name = "colSotien";
            this.colSotien.Width = 115;
            // 
            // colHinhthucTT
            // 
            this.colHinhthucTT.DataPropertyName = "HINHTHUCTHANHTOAN";
            this.colHinhthucTT.HeaderText = "Hình Thức Thanh Toán";
            this.colHinhthucTT.MinimumWidth = 6;
            this.colHinhthucTT.Name = "colHinhthucTT";
            this.colHinhthucTT.Width = 145;
            // 
            // colNoidung
            // 
            this.colNoidung.DataPropertyName = "NOIDUNG";
            this.colNoidung.HeaderText = "Nội Dung Thanh Toán";
            this.colNoidung.MinimumWidth = 6;
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.Width = 165;
            // 
            // colNhanvien
            // 
            this.colNhanvien.DataPropertyName = "NHANVIENLAPHOADON";
            this.colNhanvien.HeaderText = "Nhân Viên Lập Hóa Đơn";
            this.colNhanvien.MinimumWidth = 6;
            this.colNhanvien.Name = "colNhanvien";
            this.colNhanvien.Width = 125;
            // 
            // frmDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLaphoadon);
            this.Controls.Add(this.btnXuathoadon);
            this.Controls.Add(this.label1);
            this.Name = "frmDSHoaDon";
            this.Text = "Danh sách hóa đơn thanh toán";
            this.Load += new System.EventHandler(this.frmDSHoaDon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaphoadon;
        private System.Windows.Forms.Button btnXuathoadon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dsHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhthucTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanvien;
    }
}