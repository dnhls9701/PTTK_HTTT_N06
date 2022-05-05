
namespace DOANPTTK
{
    partial class frmOptionsBPDH
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
            this.btnPhanCongCongViec = new System.Windows.Forms.Button();
            this.btnDangKyTiemChung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXemThongTin.Location = new System.Drawing.Point(221, 194);
            this.btnXemThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(358, 50);
            this.btnXemThongTin.TabIndex = 32;
            this.btnXemThongTin.Text = "Thông tin tài khoản";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            // 
            // btnPhanCongCongViec
            // 
            this.btnPhanCongCongViec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPhanCongCongViec.Location = new System.Drawing.Point(427, 274);
            this.btnPhanCongCongViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanCongCongViec.Name = "btnPhanCongCongViec";
            this.btnPhanCongCongViec.Size = new System.Drawing.Size(153, 50);
            this.btnPhanCongCongViec.TabIndex = 31;
            this.btnPhanCongCongViec.Text = "Phân công công việc";
            this.btnPhanCongCongViec.UseVisualStyleBackColor = false;
            this.btnPhanCongCongViec.Click += new System.EventHandler(this.btnPhanCongCongViec_Click);
            // 
            // btnDangKyTiemChung
            // 
            this.btnDangKyTiemChung.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangKyTiemChung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangKyTiemChung.Location = new System.Drawing.Point(221, 274);
            this.btnDangKyTiemChung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKyTiemChung.Name = "btnDangKyTiemChung";
            this.btnDangKyTiemChung.Size = new System.Drawing.Size(153, 50);
            this.btnDangKyTiemChung.TabIndex = 30;
            this.btnDangKyTiemChung.Text = "Duyệt danh sách đặt mua vacxin";
            this.btnDangKyTiemChung.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(229, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tùy Chọn Chức Năng";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_dangxuat.Location = new System.Drawing.Point(316, 344);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(153, 50);
            this.btn_dangxuat.TabIndex = 33;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // frmOptionsBPDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dangxuat);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.btnPhanCongCongViec);
            this.Controls.Add(this.btnDangKyTiemChung);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOptionsBPDH";
            this.Text = "Tùy chọn của bộ phận điều hành";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnPhanCongCongViec;
        private System.Windows.Forms.Button btnDangKyTiemChung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dangxuat;
    }
}