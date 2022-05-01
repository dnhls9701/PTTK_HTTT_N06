
namespace DOANPTTK
{
    partial class frmLapHoaDon
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHinhthucTT = new System.Windows.Forms.ComboBox();
            this.txtNhanvien = new System.Windows.Forms.TextBox();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXemdanhsach = new System.Windows.Forms.Button();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông tin hóa đơn thanh toán";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpNgayThanhToan);
            this.panel1.Controls.Add(this.txtMaTT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbHinhthucTT);
            this.panel1.Controls.Add(this.txtNhanvien);
            this.panel1.Controls.Add(this.txtSotien);
            this.panel1.Controls.Add(this.txtNoidung);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(39, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 337);
            this.panel1.TabIndex = 9;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(205, 123);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(187, 22);
            this.txtMaTT.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mã trung tâm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nội dung thanh toán:";
            // 
            // cbHinhthucTT
            // 
            this.cbHinhthucTT.FormattingEnabled = true;
            this.cbHinhthucTT.Items.AddRange(new object[] {
            "Thanh Toán Bằng Tiền Mặt",
            "Thanh Toán Bằng Thẻ"});
            this.cbHinhthucTT.Location = new System.Drawing.Point(206, 166);
            this.cbHinhthucTT.Name = "cbHinhthucTT";
            this.cbHinhthucTT.Size = new System.Drawing.Size(187, 24);
            this.cbHinhthucTT.TabIndex = 20;
            // 
            // txtNhanvien
            // 
            this.txtNhanvien.Location = new System.Drawing.Point(641, 123);
            this.txtNhanvien.Name = "txtNhanvien";
            this.txtNhanvien.Size = new System.Drawing.Size(178, 22);
            this.txtNhanvien.TabIndex = 17;
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(594, 78);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(225, 22);
            this.txtSotien.TabIndex = 16;
            // 
            // txtNoidung
            // 
            this.txtNoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoidung.Location = new System.Drawing.Point(205, 211);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(614, 98);
            this.txtNoidung.TabIndex = 13;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(205, 78);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(187, 22);
            this.txtMaKH.TabIndex = 11;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(205, 34);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(187, 22);
            this.txtMaHD.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(480, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ngày thanh toán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nhân viên lập hóa đơn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hình thức thanh toán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(297, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lập hóa đơn thanh toán";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTao.Location = new System.Drawing.Point(335, 502);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(109, 48);
            this.btnTao.TabIndex = 10;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnXemdanhsach
            // 
            this.btnXemdanhsach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXemdanhsach.Location = new System.Drawing.Point(499, 502);
            this.btnXemdanhsach.Name = "btnXemdanhsach";
            this.btnXemdanhsach.Size = new System.Drawing.Size(126, 48);
            this.btnXemdanhsach.TabIndex = 11;
            this.btnXemdanhsach.Text = "Xem danh sách hóa đơn";
            this.btnXemdanhsach.UseVisualStyleBackColor = false;
            this.btnXemdanhsach.Click += new System.EventHandler(this.btnXemdanhsach_Click);
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(603, 35);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(216, 22);
            this.dtpNgayThanhToan.TabIndex = 25;
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 578);
            this.Controls.Add(this.btnXemdanhsach);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmLapHoaDon";
            this.Text = "Lập hóa đơn thanh toán";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNhanvien;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHinhthucTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnXemdanhsach;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
    }
}