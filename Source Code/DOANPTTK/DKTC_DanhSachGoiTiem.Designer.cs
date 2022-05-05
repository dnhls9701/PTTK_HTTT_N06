
namespace DOANPTTK
{
    partial class frmDSGoiTiem
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
            this.dgDanhSachGoiTiem = new System.Windows.Forms.DataGridView();
            this.colMaDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGoiTiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachGoiTiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDanhSachGoiTiem
            // 
            this.dgDanhSachGoiTiem.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgDanhSachGoiTiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhSachGoiTiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDangKy,
            this.colTenGoiTiem,
            this.colMota,
            this.colGiaGoi,
            this.colChon});
            this.dgDanhSachGoiTiem.Location = new System.Drawing.Point(31, 91);
            this.dgDanhSachGoiTiem.Name = "dgDanhSachGoiTiem";
            this.dgDanhSachGoiTiem.RowHeadersWidth = 51;
            this.dgDanhSachGoiTiem.RowTemplate.Height = 24;
            this.dgDanhSachGoiTiem.Size = new System.Drawing.Size(932, 261);
            this.dgDanhSachGoiTiem.TabIndex = 14;
            // 
            // colMaDangKy
            // 
            this.colMaDangKy.DataPropertyName = "MAGOITIEM";
            this.colMaDangKy.HeaderText = "Mã gói tiêm";
            this.colMaDangKy.MinimumWidth = 6;
            this.colMaDangKy.Name = "colMaDangKy";
            this.colMaDangKy.Width = 125;
            // 
            // colTenGoiTiem
            // 
            this.colTenGoiTiem.DataPropertyName = "TENGOITIEM";
            this.colTenGoiTiem.HeaderText = "Tên gói tiêm";
            this.colTenGoiTiem.MinimumWidth = 6;
            this.colTenGoiTiem.Name = "colTenGoiTiem";
            this.colTenGoiTiem.Width = 140;
            // 
            // colMota
            // 
            this.colMota.DataPropertyName = "MOTA";
            this.colMota.HeaderText = "Mô tả";
            this.colMota.MinimumWidth = 6;
            this.colMota.Name = "colMota";
            this.colMota.Width = 165;
            // 
            // colGiaGoi
            // 
            this.colGiaGoi.DataPropertyName = "GIAGOI";
            this.colGiaGoi.HeaderText = "Giá gói";
            this.colGiaGoi.MinimumWidth = 6;
            this.colGiaGoi.Name = "colGiaGoi";
            this.colGiaGoi.Width = 125;
            // 
            // colChon
            // 
            this.colChon.HeaderText = "Chọn";
            this.colChon.MinimumWidth = 6;
            this.colChon.Name = "colChon";
            this.colChon.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(260, -266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đăng ký tiêm chủng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(363, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách gói tiêm";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangKy.Location = new System.Drawing.Point(446, 380);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(96, 39);
            this.btnDangKy.TabIndex = 16;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // frmDSGoiTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDanhSachGoiTiem);
            this.Controls.Add(this.label1);
            this.Name = "frmDSGoiTiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách gói tiêm";
            this.Load += new System.EventHandler(this.frmDSGoiTiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachGoiTiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanhSachGoiTiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGoiTiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaGoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
    }
}