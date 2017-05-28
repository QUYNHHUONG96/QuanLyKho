namespace QuanLyKho_form
{
    partial class frmmain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnphieunhap = new System.Windows.Forms.Button();
            this.btnkhohang = new System.Windows.Forms.Button();
            this.btnphieuxuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnnhanvien);
            this.groupBox1.Controls.Add(this.btnphieunhap);
            this.groupBox1.Controls.Add(this.btnkhohang);
            this.groupBox1.Controls.Add(this.btnphieuxuat);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.groupBox1.Location = new System.Drawing.Point(2, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Image = global::QuanLyKho_form.Properties.Resources.she_users1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(129, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quản lý người dùng";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKe.ForeColor = System.Drawing.Color.Blue;
            this.btnThongKe.Image = global::QuanLyKho_form.Properties.Resources.note_accept;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(424, 79);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(106, 56);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Image = global::QuanLyKho_form.Properties.Resources.help;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnhanvien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnhanvien.ForeColor = System.Drawing.Color.Blue;
            this.btnnhanvien.Image = global::QuanLyKho_form.Properties.Resources.users;
            this.btnnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.Location = new System.Drawing.Point(129, 19);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(106, 54);
            this.btnnhanvien.TabIndex = 3;
            this.btnnhanvien.Text = "Nhân viên";
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhanvien.UseVisualStyleBackColor = false;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnphieunhap
            // 
            this.btnphieunhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnphieunhap.ForeColor = System.Drawing.Color.Blue;
            this.btnphieunhap.Image = global::QuanLyKho_form.Properties.Resources.shopping_cart_up;
            this.btnphieunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnphieunhap.Location = new System.Drawing.Point(424, 19);
            this.btnphieunhap.Name = "btnphieunhap";
            this.btnphieunhap.Size = new System.Drawing.Size(106, 54);
            this.btnphieunhap.TabIndex = 2;
            this.btnphieunhap.Text = "Quản lý nhập";
            this.btnphieunhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnphieunhap.UseVisualStyleBackColor = false;
            this.btnphieunhap.Click += new System.EventHandler(this.btnphieunhap_Click);
            // 
            // btnkhohang
            // 
            this.btnkhohang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkhohang.ForeColor = System.Drawing.Color.Blue;
            this.btnkhohang.Image = global::QuanLyKho_form.Properties.Resources.database;
            this.btnkhohang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhohang.Location = new System.Drawing.Point(268, 79);
            this.btnkhohang.Name = "btnkhohang";
            this.btnkhohang.Size = new System.Drawing.Size(105, 56);
            this.btnkhohang.TabIndex = 1;
            this.btnkhohang.Text = "Kho hàng";
            this.btnkhohang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhohang.UseVisualStyleBackColor = false;
            this.btnkhohang.Click += new System.EventHandler(this.btnkhohang_Click);
            // 
            // btnphieuxuat
            // 
            this.btnphieuxuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnphieuxuat.ForeColor = System.Drawing.Color.Blue;
            this.btnphieuxuat.Image = global::QuanLyKho_form.Properties.Resources.shopping_cart_down;
            this.btnphieuxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnphieuxuat.Location = new System.Drawing.Point(268, 19);
            this.btnphieuxuat.Name = "btnphieuxuat";
            this.btnphieuxuat.Size = new System.Drawing.Size(105, 54);
            this.btnphieuxuat.TabIndex = 0;
            this.btnphieuxuat.Text = "Quản lý xuất";
            this.btnphieuxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnphieuxuat.UseVisualStyleBackColor = false;
            this.btnphieuxuat.Click += new System.EventHandler(this.btnphieuxuat_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(167, 313);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(281, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý kho hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuanLyKho_form.Properties.Resources._6_cach_de_nang_cao_hieu_qua_quan_ly_kho_hang1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(645, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmmain";
            this.Text = "frmmain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnphieunhap;
        private System.Windows.Forms.Button btnkhohang;
        private System.Windows.Forms.Button btnphieuxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button button2;
    }
}