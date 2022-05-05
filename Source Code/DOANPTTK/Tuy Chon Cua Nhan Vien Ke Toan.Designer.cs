
namespace DOANPTTK
{
    partial class frmOptionsNVKT
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
            this.btnDatMuaVacXin = new System.Windows.Forms.Button();
            this.btnDangKyTiemChung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXemThongTin.Location = new System.Drawing.Point(221, 197);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(358, 51);
            this.btnXemThongTin.TabIndex = 28;
            this.btnXemThongTin.Text = "Thông tin tài khoản";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            // 
            // btnDatMuaVacXin
            // 
            this.btnDatMuaVacXin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDatMuaVacXin.Location = new System.Drawing.Point(426, 277);
            this.btnDatMuaVacXin.Name = "btnDatMuaVacXin";
            this.btnDatMuaVacXin.Size = new System.Drawing.Size(153, 51);
            this.btnDatMuaVacXin.TabIndex = 27;
            this.btnDatMuaVacXin.Text = "Xử lý thanh toán";
            this.btnDatMuaVacXin.UseVisualStyleBackColor = false;
            // 
            // btnDangKyTiemChung
            // 
            this.btnDangKyTiemChung.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangKyTiemChung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangKyTiemChung.Location = new System.Drawing.Point(221, 277);
            this.btnDangKyTiemChung.Name = "btnDangKyTiemChung";
            this.btnDangKyTiemChung.Size = new System.Drawing.Size(153, 51);
            this.btnDangKyTiemChung.TabIndex = 26;
            this.btnDangKyTiemChung.Text = "Đăng ký phân công công việc";
            this.btnDangKyTiemChung.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(229, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tùy Chọn Chức Năng";
            // 
            // frmOptionsNVKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.btnDatMuaVacXin);
            this.Controls.Add(this.btnDangKyTiemChung);
            this.Controls.Add(this.label1);
            this.Name = "frmOptionsNVKT";
            this.Text = "Tùy chọn của nhân viên kế toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnDatMuaVacXin;
        private System.Windows.Forms.Button btnDangKyTiemChung;
        private System.Windows.Forms.Label label1;
    }
}