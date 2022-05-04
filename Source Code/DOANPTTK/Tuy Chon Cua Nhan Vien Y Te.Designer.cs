
namespace DOANPTTK
{
    partial class frmOptionsNVYT
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
            this.btnDatMuaVacXin = new System.Windows.Forms.Button();
            this.btnXuLyPKB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXemThongTin.Location = new System.Drawing.Point(209, 179);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(155, 51);
            this.btnXemThongTin.TabIndex = 20;
            this.btnXemThongTin.Text = "Thông tin tài khoản";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThanhToan.Location = new System.Drawing.Point(441, 179);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(153, 51);
            this.btnThanhToan.TabIndex = 19;
            this.btnThanhToan.Text = "Đăng ký phân công công việc";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnDatMuaVacXin
            // 
            this.btnDatMuaVacXin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDatMuaVacXin.Location = new System.Drawing.Point(441, 267);
            this.btnDatMuaVacXin.Name = "btnDatMuaVacXin";
            this.btnDatMuaVacXin.Size = new System.Drawing.Size(153, 51);
            this.btnDatMuaVacXin.TabIndex = 17;
            this.btnDatMuaVacXin.Text = "Xử lý phiếu tiêm chủng";
            this.btnDatMuaVacXin.UseVisualStyleBackColor = false;
            // 
            // btnXuLyPKB
            // 
            this.btnXuLyPKB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXuLyPKB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXuLyPKB.Location = new System.Drawing.Point(209, 267);
            this.btnXuLyPKB.Name = "btnXuLyPKB";
            this.btnXuLyPKB.Size = new System.Drawing.Size(155, 51);
            this.btnXuLyPKB.TabIndex = 16;
            this.btnXuLyPKB.Text = "Xử lý phiếu khám bệnh";
            this.btnXuLyPKB.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(230, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tùy Chọn Chức Năng";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignOut.Location = new System.Drawing.Point(686, 22);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(92, 36);
            this.btnSignOut.TabIndex = 26;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmOptionsNVYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDatMuaVacXin);
            this.Controls.Add(this.btnXuLyPKB);
            this.Controls.Add(this.label1);
            this.Name = "frmOptionsNVYT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn của nhân viên y tế";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDatMuaVacXin;
        private System.Windows.Forms.Button btnXuLyPKB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignOut;
    }
}