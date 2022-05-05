
namespace DOANPTTK
{
    partial class frmPhanCongCongViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.cbb_vitri = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_dsphancong = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_ngayphancong = new System.Windows.Forms.ComboBox();
            this.btn_phancong = new System.Windows.Forms.Button();
            this.cbb_phonglamviec = new System.Windows.Forms.ComboBox();
            this.cbb_manhanvien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_caphancong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphancong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(361, 507);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(244, 41);
            this.btn_xoa.TabIndex = 56;
            this.btn_xoa.Text = "Xóa khỏi danh sách";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // cbb_vitri
            // 
            this.cbb_vitri.FormattingEnabled = true;
            this.cbb_vitri.Items.AddRange(new object[] {
            "Nhân viên hướng dẫn",
            "Nhân viên y tế",
            "Bác sĩ ",
            "Nhân viên kế toán"});
            this.cbb_vitri.Location = new System.Drawing.Point(760, 58);
            this.cbb_vitri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_vitri.Name = "cbb_vitri";
            this.cbb_vitri.Size = new System.Drawing.Size(171, 24);
            this.cbb_vitri.TabIndex = 54;
            this.cbb_vitri.SelectedIndexChanged += new System.EventHandler(this.cbb_vitri_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(523, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 18);
            this.label7.TabIndex = 53;
            this.label7.Text = "Vị trí muốn phân công";
            // 
            // dgv_dsphancong
            // 
            this.dgv_dsphancong.AllowUserToAddRows = false;
            this.dgv_dsphancong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dsphancong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dsphancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsphancong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column1,
            this.Column5,
            this.cb_xoa});
            this.dgv_dsphancong.Location = new System.Drawing.Point(33, 302);
            this.dgv_dsphancong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_dsphancong.Name = "dgv_dsphancong";
            this.dgv_dsphancong.RowHeadersWidth = 62;
            this.dgv_dsphancong.RowTemplate.Height = 28;
            this.dgv_dsphancong.Size = new System.Drawing.Size(899, 199);
            this.dgv_dsphancong.TabIndex = 55;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã nhân viên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày phân công";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ca phân công";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phòng làm việc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // cb_xoa
            // 
            this.cb_xoa.HeaderText = "Xóa";
            this.cb_xoa.MinimumWidth = 6;
            this.cb_xoa.Name = "cb_xoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "DANH SÁCH ĐÃ PHÂN CÔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(367, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Phân công công việc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_ngayphancong);
            this.groupBox1.Controls.Add(this.btn_phancong);
            this.groupBox1.Controls.Add(this.cbb_phonglamviec);
            this.groupBox1.Controls.Add(this.cbb_manhanvien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbb_caphancong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(33, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(899, 164);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // cbb_ngayphancong
            // 
            this.cbb_ngayphancong.FormattingEnabled = true;
            this.cbb_ngayphancong.Location = new System.Drawing.Point(667, 32);
            this.cbb_ngayphancong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_ngayphancong.Name = "cbb_ngayphancong";
            this.cbb_ngayphancong.Size = new System.Drawing.Size(176, 24);
            this.cbb_ngayphancong.TabIndex = 56;
            this.cbb_ngayphancong.SelectedIndexChanged += new System.EventHandler(this.cbb_ngayphancong_SelectedIndexChanged);
            // 
            // btn_phancong
            // 
            this.btn_phancong.AutoSize = true;
            this.btn_phancong.BackColor = System.Drawing.Color.Turquoise;
            this.btn_phancong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_phancong.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phancong.Location = new System.Drawing.Point(380, 117);
            this.btn_phancong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_phancong.Name = "btn_phancong";
            this.btn_phancong.Size = new System.Drawing.Size(157, 41);
            this.btn_phancong.TabIndex = 55;
            this.btn_phancong.Text = "Phân công";
            this.btn_phancong.UseVisualStyleBackColor = false;
            this.btn_phancong.Click += new System.EventHandler(this.btn_phancong_Click);
            // 
            // cbb_phonglamviec
            // 
            this.cbb_phonglamviec.FormattingEnabled = true;
            this.cbb_phonglamviec.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbb_phonglamviec.Location = new System.Drawing.Point(220, 78);
            this.cbb_phonglamviec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_phonglamviec.Name = "cbb_phonglamviec";
            this.cbb_phonglamviec.Size = new System.Drawing.Size(195, 24);
            this.cbb_phonglamviec.TabIndex = 32;
            // 
            // cbb_manhanvien
            // 
            this.cbb_manhanvien.FormattingEnabled = true;
            this.cbb_manhanvien.Location = new System.Drawing.Point(220, 36);
            this.cbb_manhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_manhanvien.Name = "cbb_manhanvien";
            this.cbb_manhanvien.Size = new System.Drawing.Size(195, 24);
            this.cbb_manhanvien.TabIndex = 31;
            this.cbb_manhanvien.SelectedIndexChanged += new System.EventHandler(this.cbb_manhanvien_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phòng làm việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã nhân viên";
            // 
            // cbb_caphancong
            // 
            this.cbb_caphancong.FormattingEnabled = true;
            this.cbb_caphancong.Location = new System.Drawing.Point(667, 78);
            this.cbb_caphancong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_caphancong.Name = "cbb_caphancong";
            this.cbb_caphancong.Size = new System.Drawing.Size(176, 24);
            this.cbb_caphancong.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày phân công";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ca phân công";
            // 
            // frmPhanCongCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 564);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.cbb_vitri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_dsphancong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPhanCongCongViec";
            this.Text = "Phân công công việc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhanCongCongViec_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphancong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ComboBox cbb_vitri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_dsphancong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_phancong;
        private System.Windows.Forms.ComboBox cbb_phonglamviec;
        private System.Windows.Forms.ComboBox cbb_manhanvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_caphancong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_ngayphancong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb_xoa;
    }
}