namespace QuanLyKho_form
{
    partial class frmkhohang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkhohang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbtimLH = new System.Windows.Forms.ComboBox();
            this.rdbtten = new System.Windows.Forms.RadioButton();
            this.rdbtmaloaihang = new System.Windows.Forms.RadioButton();
            this.rdbtmahang = new System.Windows.Forms.RadioButton();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnLoaihang = new System.Windows.Forms.Button();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnnhacc = new System.Windows.Forms.Button();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.cmbmaloaihang = new System.Windows.Forms.ComboBox();
            this.cmbmacc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvchitietpn = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietpn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(5, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 110);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbtimLH);
            this.groupBox2.Controls.Add(this.rdbtten);
            this.groupBox2.Controls.Add(this.rdbtmaloaihang);
            this.groupBox2.Controls.Add(this.rdbtmahang);
            this.groupBox2.Location = new System.Drawing.Point(82, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo";
            // 
            // cmbtimLH
            // 
            this.cmbtimLH.FormattingEnabled = true;
            this.cmbtimLH.Items.AddRange(new object[] {
            "LH01",
            "LH02",
            "LH03",
            "LH04"});
            this.cmbtimLH.Location = new System.Drawing.Point(116, 23);
            this.cmbtimLH.Name = "cmbtimLH";
            this.cmbtimLH.Size = new System.Drawing.Size(116, 21);
            this.cmbtimLH.TabIndex = 26;
            // 
            // rdbtten
            // 
            this.rdbtten.AutoSize = true;
            this.rdbtten.Location = new System.Drawing.Point(16, 70);
            this.rdbtten.Name = "rdbtten";
            this.rdbtten.Size = new System.Drawing.Size(71, 17);
            this.rdbtten.TabIndex = 22;
            this.rdbtten.TabStop = true;
            this.rdbtten.Text = "Tên hàng";
            this.rdbtten.UseVisualStyleBackColor = true;
            // 
            // rdbtmaloaihang
            // 
            this.rdbtmaloaihang.AutoSize = true;
            this.rdbtmaloaihang.Location = new System.Drawing.Point(16, 24);
            this.rdbtmaloaihang.Name = "rdbtmaloaihang";
            this.rdbtmaloaihang.Size = new System.Drawing.Size(86, 17);
            this.rdbtmaloaihang.TabIndex = 20;
            this.rdbtmaloaihang.TabStop = true;
            this.rdbtmaloaihang.Text = "Mã loại hàng";
            this.rdbtmaloaihang.UseVisualStyleBackColor = true;
            // 
            // rdbtmahang
            // 
            this.rdbtmahang.AutoSize = true;
            this.rdbtmahang.Location = new System.Drawing.Point(16, 47);
            this.rdbtmahang.Name = "rdbtmahang";
            this.rdbtmahang.Size = new System.Drawing.Size(67, 17);
            this.rdbtmahang.TabIndex = 21;
            this.rdbtmahang.TabStop = true;
            this.rdbtmahang.Text = "Mã hàng";
            this.rdbtmahang.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntimkiem.Image = global::QuanLyKho_form.Properties.Resources.search;
            this.btntimkiem.Location = new System.Drawing.Point(507, 67);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(63, 37);
            this.btntimkiem.TabIndex = 17;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(373, 43);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(197, 20);
            this.txttimkiem.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nhập khóa cần tìm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtgianhap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnLoaihang);
            this.groupBox1.Controls.Add(this.txtgiaban);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnnhacc);
            this.groupBox1.Controls.Add(this.txttenhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmahang);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.cmbmaloaihang);
            this.groupBox1.Controls.Add(this.cmbmacc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(149, 156);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(172, 20);
            this.txtgianhap.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Giá nhập";
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.Image = global::QuanLyKho_form.Properties.Resources.application_edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(360, 151);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(63, 37);
            this.btnsua.TabIndex = 47;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnluu.Image = global::QuanLyKho_form.Properties.Resources.save;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(561, 147);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(63, 37);
            this.btnluu.TabIndex = 46;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnxoa.Image = global::QuanLyKho_form.Properties.Resources.remove;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(465, 147);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(63, 37);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthoat.Image = global::QuanLyKho_form.Properties.Resources.redo;
            this.btnthoat.Location = new System.Drawing.Point(657, 147);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(63, 37);
            this.btnthoat.TabIndex = 44;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnLoaihang
            // 
            this.btnLoaihang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoaihang.Image = global::QuanLyKho_form.Properties.Resources.window;
            this.btnLoaihang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaihang.Location = new System.Drawing.Point(561, 89);
            this.btnLoaihang.Name = "btnLoaihang";
            this.btnLoaihang.Size = new System.Drawing.Size(138, 45);
            this.btnLoaihang.TabIndex = 43;
            this.btnLoaihang.Text = "Chi tiết loại hàng";
            this.btnLoaihang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoaihang.UseVisualStyleBackColor = false;
            this.btnLoaihang.Click += new System.EventHandler(this.btnLoaihang_Click_1);
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(508, 23);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(172, 20);
            this.txtgiaban.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Giá bán";
            // 
            // btnnhacc
            // 
            this.btnnhacc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnhacc.Image = ((System.Drawing.Image)(resources.GetObject("btnnhacc.Image")));
            this.btnnhacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhacc.Location = new System.Drawing.Point(382, 89);
            this.btnnhacc.Name = "btnnhacc";
            this.btnnhacc.Size = new System.Drawing.Size(146, 45);
            this.btnnhacc.TabIndex = 34;
            this.btnnhacc.Text = "Chi tiết nhà cung cấp";
            this.btnnhacc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhacc.UseVisualStyleBackColor = false;
            this.btnnhacc.Click += new System.EventHandler(this.btnnhacc_Click_1);
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(149, 54);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(172, 20);
            this.txttenhang.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(149, 23);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(172, 20);
            this.txtmahang.TabIndex = 27;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(508, 54);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(172, 20);
            this.txtsoluong.TabIndex = 26;
            // 
            // cmbmaloaihang
            // 
            this.cmbmaloaihang.FormattingEnabled = true;
            this.cmbmaloaihang.Items.AddRange(new object[] {
            "LH01",
            "LH02",
            "LH03",
            "LH04"});
            this.cmbmaloaihang.Location = new System.Drawing.Point(149, 84);
            this.cmbmaloaihang.Name = "cmbmaloaihang";
            this.cmbmaloaihang.Size = new System.Drawing.Size(173, 21);
            this.cmbmaloaihang.TabIndex = 25;
            // 
            // cmbmacc
            // 
            this.cmbmacc.FormattingEnabled = true;
            this.cmbmacc.Items.AddRange(new object[] {
            ""});
            this.cmbmacc.Location = new System.Drawing.Point(149, 120);
            this.cmbmacc.Name = "cmbmacc";
            this.cmbmacc.Size = new System.Drawing.Size(172, 21);
            this.cmbmacc.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mã loại hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số luong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã hàng";
            // 
            // dgvchitietpn
            // 
            this.dgvchitietpn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvchitietpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitietpn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvchitietpn.Location = new System.Drawing.Point(0, 317);
            this.dgvchitietpn.Name = "dgvchitietpn";
            this.dgvchitietpn.Size = new System.Drawing.Size(737, 220);
            this.dgvchitietpn.TabIndex = 4;
            this.dgvchitietpn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchitietpn_CellClick);
            // 
            // frmkhohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(737, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvchitietpn);
            this.Name = "frmkhohang";
            this.Text = "frmhanghoa";
            this.Load += new System.EventHandler(this.frmhanghoa_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietpn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ComboBox cmbmaloaihang;
        private System.Windows.Forms.ComboBox cmbmacc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvchitietpn;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnhacc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnLoaihang;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbtimLH;
        private System.Windows.Forms.RadioButton rdbtten;
        private System.Windows.Forms.RadioButton rdbtmaloaihang;
        private System.Windows.Forms.RadioButton rdbtmahang;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.Label label7;
    }
}