
namespace DOANPTTK
{
    partial class frmDSMuiTiemVacxin
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
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDanhSachMuiTiem = new System.Windows.Forms.DataGridView();
            this.colMaVacxin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenVacxin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachMuiTiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangKy.Location = new System.Drawing.Point(439, 383);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(96, 39);
            this.btnDangKy.TabIndex = 19;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(290, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Danh sách mũi tiêm vacxin";
            // 
            // dgDanhSachMuiTiem
            // 
            this.dgDanhSachMuiTiem.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgDanhSachMuiTiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhSachMuiTiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaVacxin,
            this.colTenVacxin,
            this.colMota,
            this.colSoLuongTon,
            this.colNhaCungCap,
            this.colDonGia,
            this.colChon});
            this.dgDanhSachMuiTiem.Location = new System.Drawing.Point(33, 91);
            this.dgDanhSachMuiTiem.Name = "dgDanhSachMuiTiem";
            this.dgDanhSachMuiTiem.RowHeadersWidth = 51;
            this.dgDanhSachMuiTiem.RowTemplate.Height = 24;
            this.dgDanhSachMuiTiem.Size = new System.Drawing.Size(928, 261);
            this.dgDanhSachMuiTiem.TabIndex = 17;
            // 
            // colMaVacxin
            // 
            this.colMaVacxin.DataPropertyName = "MAVACXIN";
            this.colMaVacxin.HeaderText = "Mã vacxin";
            this.colMaVacxin.MinimumWidth = 6;
            this.colMaVacxin.Name = "colMaVacxin";
            this.colMaVacxin.Width = 125;
            // 
            // colTenVacxin
            // 
            this.colTenVacxin.DataPropertyName = "TENVACXIN";
            this.colTenVacxin.HeaderText = "Tên vacxin";
            this.colTenVacxin.MinimumWidth = 6;
            this.colTenVacxin.Name = "colTenVacxin";
            this.colTenVacxin.Width = 125;
            // 
            // colMota
            // 
            this.colMota.DataPropertyName = "MOTA";
            this.colMota.HeaderText = "Mô tả";
            this.colMota.MinimumWidth = 6;
            this.colMota.Name = "colMota";
            this.colMota.Width = 125;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SOLUONGTON";
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.MinimumWidth = 6;
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.Width = 125;
            // 
            // colNhaCungCap
            // 
            this.colNhaCungCap.DataPropertyName = "NHACUNGCAP";
            this.colNhaCungCap.HeaderText = "Nhà cung cấp";
            this.colNhaCungCap.MinimumWidth = 6;
            this.colNhaCungCap.Name = "colNhaCungCap";
            this.colNhaCungCap.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DONGIA";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 125;
            // 
            // colChon
            // 
            this.colChon.HeaderText = "Chọn";
            this.colChon.MinimumWidth = 6;
            this.colChon.Name = "colChon";
            this.colChon.Width = 125;
            // 
            // frmDSMuiTiemVacxin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDanhSachMuiTiem);
            this.Name = "frmDSMuiTiemVacxin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách mũi tiêm vacxin";
            this.Load += new System.EventHandler(this.frmDSMuiTiemVacxin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachMuiTiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgDanhSachMuiTiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaVacxin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenVacxin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
    }
}