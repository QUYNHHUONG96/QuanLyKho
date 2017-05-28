namespace QuanLyKho_form
{
    partial class frmthongke
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
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhangnhap = new System.Windows.Forms.Button();
            this.btnhangxuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbthang = new System.Windows.Forms.ComboBox();
            this.btnHangtrongkho = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(1, 160);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(650, 121);
            this.dgvThongKe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnhangnhap);
            this.groupBox1.Controls.Add(this.btnhangxuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbthang);
            this.groupBox1.Controls.Add(this.btnHangtrongkho);
            this.groupBox1.Location = new System.Drawing.Point(1, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // btnhangnhap
            // 
            this.btnhangnhap.BackColor = System.Drawing.Color.Yellow;
            this.btnhangnhap.ForeColor = System.Drawing.Color.Blue;
            this.btnhangnhap.Location = new System.Drawing.Point(116, 18);
            this.btnhangnhap.Name = "btnhangnhap";
            this.btnhangnhap.Size = new System.Drawing.Size(167, 23);
            this.btnhangnhap.TabIndex = 14;
            this.btnhangnhap.Text = "Lưu lượng nhập";
            this.btnhangnhap.UseVisualStyleBackColor = false;
            this.btnhangnhap.Click += new System.EventHandler(this.btnhangnhap_Click);
            // 
            // btnhangxuat
            // 
            this.btnhangxuat.BackColor = System.Drawing.Color.Yellow;
            this.btnhangxuat.ForeColor = System.Drawing.Color.Blue;
            this.btnhangxuat.Location = new System.Drawing.Point(116, 47);
            this.btnhangxuat.Name = "btnhangxuat";
            this.btnhangxuat.Size = new System.Drawing.Size(167, 23);
            this.btnhangxuat.TabIndex = 13;
            this.btnhangxuat.Text = "Lưu lượng xuất";
            this.btnhangxuat.UseVisualStyleBackColor = false;
            this.btnhangxuat.Click += new System.EventHandler(this.btnHangdaxuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tháng";
            // 
            // cmbthang
            // 
            this.cmbthang.FormattingEnabled = true;
            this.cmbthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbthang.Location = new System.Drawing.Point(404, 27);
            this.cmbthang.Name = "cmbthang";
            this.cmbthang.Size = new System.Drawing.Size(121, 21);
            this.cmbthang.TabIndex = 6;
            this.cmbthang.SelectedIndexChanged += new System.EventHandler(this.btnHangtrongkho_Click);
            // 
            // btnHangtrongkho
            // 
            this.btnHangtrongkho.BackColor = System.Drawing.Color.Yellow;
            this.btnHangtrongkho.ForeColor = System.Drawing.Color.Blue;
            this.btnHangtrongkho.Location = new System.Drawing.Point(116, 76);
            this.btnHangtrongkho.Name = "btnHangtrongkho";
            this.btnHangtrongkho.Size = new System.Drawing.Size(167, 23);
            this.btnHangtrongkho.TabIndex = 3;
            this.btnHangtrongkho.Text = "Số lượng hàng còn trong kho";
            this.btnHangtrongkho.UseVisualStyleBackColor = false;
            this.btnHangtrongkho.Click += new System.EventHandler(this.btnHangtrongkho_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyKho_form.Properties.Resources.home;
            this.button1.Location = new System.Drawing.Point(32, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(654, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongKe);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmthongke";
            this.Text = "frmthongke";
            this.Load += new System.EventHandler(this.frmthongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHangtrongkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbthang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnhangxuat;
        private System.Windows.Forms.Button btnhangnhap;
    }
}