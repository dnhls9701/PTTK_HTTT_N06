
namespace DOANPTTK
{
    partial class frmTraCuu
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ttdatmua = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttdatmua)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(309, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Thông tin đặt giữ vắc xin";
            // 
            // dgv_ttdatmua
            // 
            this.dgv_ttdatmua.AllowUserToAddRows = false;
            this.dgv_ttdatmua.AllowUserToDeleteRows = false;
            this.dgv_ttdatmua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ttdatmua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttdatmua.Location = new System.Drawing.Point(45, 80);
            this.dgv_ttdatmua.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ttdatmua.Name = "dgv_ttdatmua";
            this.dgv_ttdatmua.RowHeadersWidth = 51;
            this.dgv_ttdatmua.RowTemplate.Height = 24;
            this.dgv_ttdatmua.Size = new System.Drawing.Size(775, 247);
            this.dgv_ttdatmua.TabIndex = 32;
            this.dgv_ttdatmua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ttdatmua_CellContentClick);
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_ttdatmua);
            this.Name = "frmTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTraCuu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttdatmua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ttdatmua;
    }
}