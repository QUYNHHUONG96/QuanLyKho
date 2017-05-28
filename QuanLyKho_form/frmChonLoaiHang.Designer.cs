namespace QuanLyKho_form
{
    partial class frmChonLoaiHang
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
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Location = new System.Drawing.Point(2, 92);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.Size = new System.Drawing.Size(586, 241);
            this.dgvdanhsach.TabIndex = 0;
            this.dgvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellClick);
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(136, 41);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(100, 20);
            this.txtmahang.TabIndex = 1;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(399, 41);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng";
            // 
            // btnChon
            // 
            this.btnChon.Image = global::QuanLyKho_form.Properties.Resources.accept1;
            this.btnChon.Location = new System.Drawing.Point(163, 339);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 32);
            this.btnChon.TabIndex = 6;
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyKho_form.Properties.Resources.redo;
            this.button1.Location = new System.Drawing.Point(325, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChonLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(595, 394);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmahang);
            this.Controls.Add(this.dgvdanhsach);
            this.Name = "frmChonLoaiHang";
            this.Text = "frmChonLoaiHang";
            this.Load += new System.EventHandler(this.frmChonLoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChon;
    }
}