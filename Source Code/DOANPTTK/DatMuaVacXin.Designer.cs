
namespace DOANPTTK
{
    partial class frmDatMuaVacXin
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
            this.label15 = new System.Windows.Forms.Label();
            this.btn_datmua = new System.Windows.Forms.Button();
            this.cbb_trungtam = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_DSVacXinDaChon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_DSVacXinHT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_loaivacxin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_curdate = new System.Windows.Forms.Label();
            this.lb_tenkhachhang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSVacXinDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSVacXinHT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(692, 283);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 15);
            this.label15.TabIndex = 62;
            this.label15.Text = "VND";
            // 
            // btn_datmua
            // 
            this.btn_datmua.BackColor = System.Drawing.Color.Turquoise;
            this.btn_datmua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_datmua.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datmua.Location = new System.Drawing.Point(565, 305);
            this.btn_datmua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_datmua.Name = "btn_datmua";
            this.btn_datmua.Size = new System.Drawing.Size(93, 33);
            this.btn_datmua.TabIndex = 61;
            this.btn_datmua.Text = "Đặt mua";
            this.btn_datmua.UseVisualStyleBackColor = false;
            this.btn_datmua.Click += new System.EventHandler(this.btn_datmua_Click);
            // 
            // cbb_trungtam
            // 
            this.cbb_trungtam.DisplayMember = "Nam";
            this.cbb_trungtam.FormattingEnabled = true;
            this.cbb_trungtam.Items.AddRange(new object[] {
            "TT001",
            "TT002",
            "TT003"});
            this.cbb_trungtam.Location = new System.Drawing.Point(496, 206);
            this.cbb_trungtam.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_trungtam.Name = "cbb_trungtam";
            this.cbb_trungtam.Size = new System.Drawing.Size(231, 21);
            this.cbb_trungtam.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(493, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 19);
            this.label11.TabIndex = 54;
            this.label11.Text = "Chọn địa điểm muốn tiêm";
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.AutoSize = true;
            this.lb_thanhtien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtien.ForeColor = System.Drawing.Color.Red;
            this.lb_thanhtien.Location = new System.Drawing.Point(592, 245);
            this.lb_thanhtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(33, 37);
            this.lb_thanhtien.TabIndex = 60;
            this.lb_thanhtien.Text = "0";
            this.lb_thanhtien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(495, 258);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 59;
            this.label9.Text = "THÀNH TIỀN :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_DSVacXinDaChon);
            this.panel2.Controls.Add(this.dgv_DSVacXinHT);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbb_loaivacxin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 362);
            this.panel2.TabIndex = 57;
            // 
            // dgv_DSVacXinDaChon
            // 
            this.dgv_DSVacXinDaChon.AllowUserToAddRows = false;
            this.dgv_DSVacXinDaChon.AllowUserToDeleteRows = false;
            this.dgv_DSVacXinDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSVacXinDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5});
            this.dgv_DSVacXinDaChon.Location = new System.Drawing.Point(14, 220);
            this.dgv_DSVacXinDaChon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSVacXinDaChon.Name = "dgv_DSVacXinDaChon";
            this.dgv_DSVacXinDaChon.RowHeadersWidth = 51;
            this.dgv_DSVacXinDaChon.RowTemplate.Height = 24;
            this.dgv_DSVacXinDaChon.Size = new System.Drawing.Size(454, 127);
            this.dgv_DSVacXinDaChon.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chọn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // dgv_DSVacXinHT
            // 
            this.dgv_DSVacXinHT.AllowUserToAddRows = false;
            this.dgv_DSVacXinHT.AllowUserToDeleteRows = false;
            this.dgv_DSVacXinHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSVacXinHT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.cb_chon});
            this.dgv_DSVacXinHT.Location = new System.Drawing.Point(14, 59);
            this.dgv_DSVacXinHT.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSVacXinHT.Name = "dgv_DSVacXinHT";
            this.dgv_DSVacXinHT.RowHeadersWidth = 51;
            this.dgv_DSVacXinHT.RowTemplate.Height = 24;
            this.dgv_DSVacXinHT.Size = new System.Drawing.Size(454, 122);
            this.dgv_DSVacXinHT.TabIndex = 47;
            this.dgv_DSVacXinHT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSVacXinHT_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mô tả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 101;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // cb_chon
            // 
            this.cb_chon.HeaderText = "Chọn";
            this.cb_chon.MinimumWidth = 6;
            this.cb_chon.Name = "cb_chon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(120, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "DANH SÁCH VẮC XIN HỆ THỐNG";
            this.label6.UseMnemonic = false;
            // 
            // cbb_loaivacxin
            // 
            this.cbb_loaivacxin.DisplayMember = "Nam";
            this.cbb_loaivacxin.FormattingEnabled = true;
            this.cbb_loaivacxin.Items.AddRange(new object[] {
            "Gói tiêm",
            "Tiêm lẻ"});
            this.cbb_loaivacxin.Location = new System.Drawing.Point(193, 3);
            this.cbb_loaivacxin.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_loaivacxin.Name = "cbb_loaivacxin";
            this.cbb_loaivacxin.Size = new System.Drawing.Size(119, 21);
            this.cbb_loaivacxin.TabIndex = 45;
            this.cbb_loaivacxin.SelectedIndexChanged += new System.EventHandler(this.cbb_loaivacxin_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại vắc xin muốn đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH VẮC XIN ĐÃ CHỌN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lb_curdate);
            this.panel1.Controls.Add(this.lb_tenkhachhang);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(492, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 134);
            this.panel1.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 19);
            this.label14.TabIndex = 10;
            // 
            // lb_curdate
            // 
            this.lb_curdate.AutoSize = true;
            this.lb_curdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_curdate.Location = new System.Drawing.Point(122, 87);
            this.lb_curdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_curdate.Name = "lb_curdate";
            this.lb_curdate.Size = new System.Drawing.Size(0, 17);
            this.lb_curdate.TabIndex = 9;
            // 
            // lb_tenkhachhang
            // 
            this.lb_tenkhachhang.AutoSize = true;
            this.lb_tenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkhachhang.Location = new System.Drawing.Point(115, 54);
            this.lb_tenkhachhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tenkhachhang.Name = "lb_tenkhachhang";
            this.lb_tenkhachhang.Size = new System.Drawing.Size(97, 17);
            this.lb_tenkhachhang.TabIndex = 8;
            this.lb_tenkhachhang.Text = "Nguyễn văn A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày đặt mua:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin đặt mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(305, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Đặt mua vắc xin";
            // 
            // frmDatMuaVacXin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 384);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_datmua);
            this.Controls.Add(this.cbb_trungtam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_thanhtien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDatMuaVacXin";
            this.Text = "Đặt mua vắc xin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDatMuaVacXin_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSVacXinDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSVacXinHT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_datmua;
        private System.Windows.Forms.ComboBox cbb_trungtam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_loaivacxin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_curdate;
        private System.Windows.Forms.Label lb_tenkhachhang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_DSVacXinHT;
        private System.Windows.Forms.DataGridView dgv_DSVacXinDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb_chon;
    }
}