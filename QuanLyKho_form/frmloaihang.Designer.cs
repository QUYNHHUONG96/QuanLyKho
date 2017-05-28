namespace QuanLyKho_form
{
    partial class frmloaihang
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
            this.btnXemdanhsach = new System.Windows.Forms.Button();
            this.dgvloaihang = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaihang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemdanhsach
            // 
            this.btnXemdanhsach.BackColor = System.Drawing.Color.Yellow;
            this.btnXemdanhsach.ForeColor = System.Drawing.Color.Blue;
            this.btnXemdanhsach.Location = new System.Drawing.Point(45, 12);
            this.btnXemdanhsach.Name = "btnXemdanhsach";
            this.btnXemdanhsach.Size = new System.Drawing.Size(75, 58);
            this.btnXemdanhsach.TabIndex = 10;
            this.btnXemdanhsach.Text = "Xem danh sách loại hàng";
            this.btnXemdanhsach.UseVisualStyleBackColor = false;
            this.btnXemdanhsach.Click += new System.EventHandler(this.btnXemdanhsach_Click);
            // 
            // dgvloaihang
            // 
            this.dgvloaihang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvloaihang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaihang.Location = new System.Drawing.Point(0, 76);
            this.dgvloaihang.Name = "dgvloaihang";
            this.dgvloaihang.Size = new System.Drawing.Size(303, 252);
            this.dgvloaihang.TabIndex = 8;
       //     this.dgvloaihang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaihang_CellClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::QuanLyKho_form.Properties.Resources.redo;
            this.btnthoat.Location = new System.Drawing.Point(186, 21);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 41);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // frmloaihang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(309, 328);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnXemdanhsach);
            this.Controls.Add(this.dgvloaihang);
            this.Name = "frmloaihang";
            this.Text = "frmloaihang";
            this.Load += new System.EventHandler(this.frmloaihang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaihang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvloaihang;
        private System.Windows.Forms.Button btnXemdanhsach;
        private System.Windows.Forms.Button btnthoat;
    }
}