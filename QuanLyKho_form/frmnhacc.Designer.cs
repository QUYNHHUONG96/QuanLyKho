namespace QuanLyKho_form
{
    partial class frmnhacc
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
            this.dgvnhacc = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnxemdanhsach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhacc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnhacc
            // 
            this.dgvnhacc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvnhacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhacc.Location = new System.Drawing.Point(1, 84);
            this.dgvnhacc.Name = "dgvnhacc";
            this.dgvnhacc.Size = new System.Drawing.Size(438, 282);
            this.dgvnhacc.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyKho_form.Properties.Resources.redo;
            this.btnThoat.Location = new System.Drawing.Point(254, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 47);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnxemdanhsach
            // 
            this.btnxemdanhsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnxemdanhsach.Location = new System.Drawing.Point(98, 19);
            this.btnxemdanhsach.Name = "btnxemdanhsach";
            this.btnxemdanhsach.Size = new System.Drawing.Size(80, 47);
            this.btnxemdanhsach.TabIndex = 10;
            this.btnxemdanhsach.Text = "Xem danh sách đầy đủ";
            this.btnxemdanhsach.UseVisualStyleBackColor = false;
            this.btnxemdanhsach.Click += new System.EventHandler(this.btnxemdanhsach_Click);
            // 
            // frmnhacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(442, 378);
            this.Controls.Add(this.btnxemdanhsach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvnhacc);
            this.Name = "frmnhacc";
            this.Text = "frmnhacc";
            this.Load += new System.EventHandler(this.frmnhacc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhacc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvnhacc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnxemdanhsach;
    }
}