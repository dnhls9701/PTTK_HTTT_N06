
namespace DOANPTTK
{
    partial class frmOptionsNVHD
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
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnSuaPhieu = new System.Windows.Forms.Button();
            this.btnDatMuaVacXin = new System.Windows.Forms.Button();
            this.btnDangKyTiemChung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXemThongTin.Location = new System.Drawing.Point(221, 164);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(153, 51);
            this.btnXemThongTin.TabIndex = 20;
            this.btnXemThongTin.Text = "Thông tin tài khoản";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThanhToan.Location = new System.Drawing.Point(426, 327);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(153, 51);
            this.btnThanhToan.TabIndex = 19;
            this.btnThanhToan.Text = "Xử lý phiếu đăng ký";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnSuaPhieu
            // 
            this.btnSuaPhieu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSuaPhieu.Location = new System.Drawing.Point(221, 327);
            this.btnSuaPhieu.Name = "btnSuaPhieu";
            this.btnSuaPhieu.Size = new System.Drawing.Size(153, 51);
            this.btnSuaPhieu.TabIndex = 18;
            this.btnSuaPhieu.Text = "Kiểm tra số lượng vacxin";
            this.btnSuaPhieu.UseVisualStyleBackColor = false;
            // 
            // btnDatMuaVacXin
            // 
            this.btnDatMuaVacXin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDatMuaVacXin.Location = new System.Drawing.Point(426, 244);
            this.btnDatMuaVacXin.Name = "btnDatMuaVacXin";
            this.btnDatMuaVacXin.Size = new System.Drawing.Size(153, 51);
            this.btnDatMuaVacXin.TabIndex = 17;
            this.btnDatMuaVacXin.Text = "Tra cứu thông tin tiêm chủng";
            this.btnDatMuaVacXin.UseVisualStyleBackColor = false;
            // 
            // btnDangKyTiemChung
            // 
            this.btnDangKyTiemChung.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangKyTiemChung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangKyTiemChung.Location = new System.Drawing.Point(221, 244);
            this.btnDangKyTiemChung.Name = "btnDangKyTiemChung";
            this.btnDangKyTiemChung.Size = new System.Drawing.Size(153, 51);
            this.btnDangKyTiemChung.TabIndex = 16;
            this.btnDangKyTiemChung.Text = "Tạo danh sách đặt mua vacxin";
            this.btnDangKyTiemChung.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tùy Chọn Chức Năng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(426, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 51);
            this.button1.TabIndex = 21;
            this.button1.Text = "Đăng ký phân công công việc";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignOut.Location = new System.Drawing.Point(685, 23);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(92, 36);
            this.btnSignOut.TabIndex = 26;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmOptionsNVHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnSuaPhieu);
            this.Controls.Add(this.btnDatMuaVacXin);
            this.Controls.Add(this.btnDangKyTiemChung);
            this.Controls.Add(this.label1);
            this.Name = "frmOptionsNVHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy Chọn Của Nhân Viên Hướng Dẫn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnSuaPhieu;
        private System.Windows.Forms.Button btnDatMuaVacXin;
        private System.Windows.Forms.Button btnDangKyTiemChung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSignOut;
    }
}