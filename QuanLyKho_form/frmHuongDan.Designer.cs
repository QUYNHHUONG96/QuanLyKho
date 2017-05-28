namespace QuanLyKho_form
{
    partial class frmHuongDan
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Hướng dẫn sử dụng phần mềm quản lý kho hàng",
            "",
            "1. Quản lý nhân viên: bao gồm các chức năng thêm, sửa thông tin, xóa thông tin nh" +
                "ân viên.",
            "",
            "2. Quản lý nhập hàng: ",
            "    Quản lý các phiếu nhập và chi tiết phiếu nhập bao gồm các chức năng:",
            "     -  Thêm phiếu nhập mới: mã phiếu nhập, ngày nhập, mã nhân viên nhập hàng",
            "     -   Thêm chi tiết phiếu nhập: 1 phiếu nhập có thể nhập được nhiều loại mặt h" +
                "àng, do đó ",
            "     có nhiều chi tiết phiếu nhập: mã phiếu nhập, mã loại hàng, mã cung cấp, tên " +
                "hàng, số",
            "     lượng, đơn giá... sau khi thêm thành công sẽ cho phép loại hàng đó lưu vào t" +
                "rong kho.",
            "     - Xóa phiếu nhập sẽ xóa cả các chi tiết phiếu nhập đó.",
            "     - Sửa phiếu nhập: sửa lại các thông tin của phiếu nhập.",
            "     - Sửa chi tiết phiếu nhập.",
            "",
            "3. Quản lý xuất hàng:",
            "    Quản lý các phiếu xuất và chi tiết phiếu xuất bao gồm các chức năng:",
            "     -  Thêm phiếu xuất mới: mã phiếu xuất, ngày xuất, mã nhân viên xuất hàng, mã" +
                " khách hàng",
            "     -   Thêm chi tiết phiếu xuất: 1 phiếu xuất có thể xuất được nhiều loại mặt h" +
                "àng, do đó ",
            "     có nhiều chi tiết phiếu xuất: mã phiếu xuất, mã hàng, số lượng, đơn giá... n" +
                "ếu số lượng trong",
            "     kho không đủ sẽ có thông báo. Sau khi thêm thành công sẽ trừ đi số lượng hàn" +
                "g đó trong kho.",
            "     - Xóa phiếu xuất sẽ xóa cả các chi tiết phiếu xuất đó.",
            "     - Sửa phiếu xuất: sửa lại các thông tin của phiếu xuất.",
            "     - Sửa chi tiết phiếu xuất.",
            "",
            "4. Kho hàng",
            "   Quản lý các mặt hàng hiện có trong kho: sửa, xóa mặt hàng",
            "   ",
            "5.Thống kê:",
            "   Thống kê số lượng hàng còn lại trong kho, số lượng hàng đã xuất theo từng mặt " +
                "hàng"});
            this.listBox1.Location = new System.Drawing.Point(2, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(481, 420);
            this.listBox1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThoat.Image = global::QuanLyKho_form.Properties.Resources.home;
            this.btnThoat.Location = new System.Drawing.Point(377, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 468);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.listBox1);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnThoat;
    }
}