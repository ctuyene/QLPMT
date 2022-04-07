namespace QLPMT
{
    partial class QuanLyBenhNhan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.soBenhNhan = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBenhNhan = new System.Windows.Forms.ListView();
            this.maBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.tbxHoTenBN = new System.Windows.Forms.TextBox();
            this.tbxNgaySinhBN = new System.Windows.Forms.TextBox();
            this.tbxSDTBN = new System.Windows.Forms.TextBox();
            this.tbxDiaChiBN = new System.Windows.Forms.TextBox();
            this.tbxGioiTinhBN = new System.Windows.Forms.TextBox();
            this.tbxMaBN = new System.Windows.Forms.TextBox();
            this.labelSĐT = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelTenBN = new System.Windows.Forms.Label();
            this.labelMaBN = new System.Windows.Forms.Label();
            this.grbThongTinBN = new System.Windows.Forms.GroupBox();
            this.btnXoaBN = new System.Windows.Forms.Button();
            this.grbThongTinBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý bệnh nhân";
            // 
            // soBenhNhan
            // 
            this.soBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soBenhNhan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.soBenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soBenhNhan.Location = new System.Drawing.Point(1, 58);
            this.soBenhNhan.Margin = new System.Windows.Forms.Padding(8);
            this.soBenhNhan.Name = "soBenhNhan";
            this.soBenhNhan.Size = new System.Drawing.Size(990, 77);
            this.soBenhNhan.TabIndex = 6;
            this.soBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.soBenhNhan.Click += new System.EventHandler(this.soBenhNhan_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Họ và tên tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.Location = new System.Drawing.Point(190, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Nội dung tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(565, 49);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách bệnh nhân";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(577, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 49);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thông tin bệnh nhân";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBenhNhan
            // 
            this.listBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBenhNhan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maBN,
            this.hoTen,
            this.ngaySinh,
            this.gioiTinh,
            this.diaChi,
            this.soDienThoai});
            this.listBenhNhan.FullRowSelect = true;
            this.listBenhNhan.HideSelection = false;
            this.listBenhNhan.Location = new System.Drawing.Point(6, 199);
            this.listBenhNhan.Name = "listBenhNhan";
            this.listBenhNhan.Size = new System.Drawing.Size(565, 423);
            this.listBenhNhan.TabIndex = 14;
            this.listBenhNhan.UseCompatibleStateImageBehavior = false;
            this.listBenhNhan.View = System.Windows.Forms.View.Details;
            this.listBenhNhan.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // maBN
            // 
            this.maBN.Text = "Mã Bệnh Nhân";
            // 
            // hoTen
            // 
            this.hoTen.Text = "Họ và Tên";
            // 
            // ngaySinh
            // 
            this.ngaySinh.Text = "Ngày sinh";
            // 
            // gioiTinh
            // 
            this.gioiTinh.Text = "Giới tính";
            // 
            // diaChi
            // 
            this.diaChi.Text = "Địa chỉ";
            // 
            // soDienThoai
            // 
            this.soDienThoai.Text = "Số điện thoại";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(60, 361);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(134, 38);
            this.btnCapNhat.TabIndex = 28;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // tbxHoTenBN
            // 
            this.tbxHoTenBN.BackColor = System.Drawing.Color.White;
            this.tbxHoTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoTenBN.ForeColor = System.Drawing.Color.Black;
            this.tbxHoTenBN.Location = new System.Drawing.Point(171, 114);
            this.tbxHoTenBN.Name = "tbxHoTenBN";
            this.tbxHoTenBN.Size = new System.Drawing.Size(216, 27);
            this.tbxHoTenBN.TabIndex = 27;
            // 
            // tbxNgaySinhBN
            // 
            this.tbxNgaySinhBN.BackColor = System.Drawing.Color.White;
            this.tbxNgaySinhBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNgaySinhBN.ForeColor = System.Drawing.Color.Black;
            this.tbxNgaySinhBN.Location = new System.Drawing.Point(171, 162);
            this.tbxNgaySinhBN.Name = "tbxNgaySinhBN";
            this.tbxNgaySinhBN.Size = new System.Drawing.Size(216, 27);
            this.tbxNgaySinhBN.TabIndex = 26;
            // 
            // tbxSDTBN
            // 
            this.tbxSDTBN.BackColor = System.Drawing.Color.White;
            this.tbxSDTBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSDTBN.ForeColor = System.Drawing.Color.Black;
            this.tbxSDTBN.Location = new System.Drawing.Point(171, 306);
            this.tbxSDTBN.Name = "tbxSDTBN";
            this.tbxSDTBN.Size = new System.Drawing.Size(216, 27);
            this.tbxSDTBN.TabIndex = 25;
            // 
            // tbxDiaChiBN
            // 
            this.tbxDiaChiBN.BackColor = System.Drawing.Color.White;
            this.tbxDiaChiBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiaChiBN.ForeColor = System.Drawing.Color.Black;
            this.tbxDiaChiBN.Location = new System.Drawing.Point(171, 258);
            this.tbxDiaChiBN.Name = "tbxDiaChiBN";
            this.tbxDiaChiBN.Size = new System.Drawing.Size(216, 27);
            this.tbxDiaChiBN.TabIndex = 24;
            // 
            // tbxGioiTinhBN
            // 
            this.tbxGioiTinhBN.BackColor = System.Drawing.Color.White;
            this.tbxGioiTinhBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGioiTinhBN.ForeColor = System.Drawing.Color.Black;
            this.tbxGioiTinhBN.Location = new System.Drawing.Point(171, 210);
            this.tbxGioiTinhBN.Name = "tbxGioiTinhBN";
            this.tbxGioiTinhBN.Size = new System.Drawing.Size(216, 27);
            this.tbxGioiTinhBN.TabIndex = 23;
            // 
            // tbxMaBN
            // 
            this.tbxMaBN.BackColor = System.Drawing.Color.White;
            this.tbxMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaBN.ForeColor = System.Drawing.Color.Black;
            this.tbxMaBN.Location = new System.Drawing.Point(171, 66);
            this.tbxMaBN.Name = "tbxMaBN";
            this.tbxMaBN.ReadOnly = true;
            this.tbxMaBN.Size = new System.Drawing.Size(216, 27);
            this.tbxMaBN.TabIndex = 22;
            // 
            // labelSĐT
            // 
            this.labelSĐT.AutoSize = true;
            this.labelSĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSĐT.Location = new System.Drawing.Point(6, 306);
            this.labelSĐT.Name = "labelSĐT";
            this.labelSĐT.Size = new System.Drawing.Size(53, 25);
            this.labelSĐT.TabIndex = 21;
            this.labelSĐT.Text = "SĐT";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.Location = new System.Drawing.Point(6, 258);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(71, 25);
            this.labelDiaChi.TabIndex = 20;
            this.labelDiaChi.Text = "Địa chỉ";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioiTinh.Location = new System.Drawing.Point(6, 210);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(82, 25);
            this.labelGioiTinh.TabIndex = 19;
            this.labelGioiTinh.Text = "Giới tính";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.Location = new System.Drawing.Point(6, 162);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(99, 25);
            this.labelNgaySinh.TabIndex = 18;
            this.labelNgaySinh.Text = "Ngày sinh";
            // 
            // labelTenBN
            // 
            this.labelTenBN.AutoSize = true;
            this.labelTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenBN.Location = new System.Drawing.Point(6, 114);
            this.labelTenBN.Name = "labelTenBN";
            this.labelTenBN.Size = new System.Drawing.Size(103, 25);
            this.labelTenBN.TabIndex = 17;
            this.labelTenBN.Text = "Họ và Tên";
            // 
            // labelMaBN
            // 
            this.labelMaBN.AutoSize = true;
            this.labelMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaBN.Location = new System.Drawing.Point(6, 66);
            this.labelMaBN.Name = "labelMaBN";
            this.labelMaBN.Size = new System.Drawing.Size(140, 25);
            this.labelMaBN.TabIndex = 16;
            this.labelMaBN.Text = "Mã Bệnh nhân";
            // 
            // grbThongTinBN
            // 
            this.grbThongTinBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinBN.Controls.Add(this.btnCapNhat);
            this.grbThongTinBN.Controls.Add(this.tbxHoTenBN);
            this.grbThongTinBN.Controls.Add(this.btnXoaBN);
            this.grbThongTinBN.Controls.Add(this.tbxNgaySinhBN);
            this.grbThongTinBN.Controls.Add(this.labelMaBN);
            this.grbThongTinBN.Controls.Add(this.tbxSDTBN);
            this.grbThongTinBN.Controls.Add(this.labelTenBN);
            this.grbThongTinBN.Controls.Add(this.tbxDiaChiBN);
            this.grbThongTinBN.Controls.Add(this.labelNgaySinh);
            this.grbThongTinBN.Controls.Add(this.tbxGioiTinhBN);
            this.grbThongTinBN.Controls.Add(this.labelGioiTinh);
            this.grbThongTinBN.Controls.Add(this.tbxMaBN);
            this.grbThongTinBN.Controls.Add(this.labelDiaChi);
            this.grbThongTinBN.Controls.Add(this.labelSĐT);
            this.grbThongTinBN.Location = new System.Drawing.Point(577, 199);
            this.grbThongTinBN.Name = "grbThongTinBN";
            this.grbThongTinBN.Size = new System.Drawing.Size(403, 423);
            this.grbThongTinBN.TabIndex = 30;
            this.grbThongTinBN.TabStop = false;
            // 
            // btnXoaBN
            // 
            this.btnXoaBN.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaBN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnXoaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBN.ForeColor = System.Drawing.Color.White;
            this.btnXoaBN.Location = new System.Drawing.Point(227, 361);
            this.btnXoaBN.Name = "btnXoaBN";
            this.btnXoaBN.Size = new System.Drawing.Size(134, 38);
            this.btnXoaBN.TabIndex = 29;
            this.btnXoaBN.Text = "Xóa Bệnh nhân";
            this.btnXoaBN.UseVisualStyleBackColor = false;
            this.btnXoaBN.Click += new System.EventHandler(this.btnXoaBN_Click);
            // 
            // QuanLyBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 655);
            this.Controls.Add(this.grbThongTinBN);
            this.Controls.Add(this.listBenhNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.soBenhNhan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyBenhNhan";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbThongTinBN.ResumeLayout(false);
            this.grbThongTinBN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label soBenhNhan;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listBenhNhan;
        private System.Windows.Forms.ColumnHeader maBN;
        private System.Windows.Forms.ColumnHeader hoTen;
        private System.Windows.Forms.ColumnHeader ngaySinh;
        private System.Windows.Forms.ColumnHeader gioiTinh;
        private System.Windows.Forms.ColumnHeader diaChi;
        private System.Windows.Forms.ColumnHeader soDienThoai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox tbxHoTenBN;
        private System.Windows.Forms.TextBox tbxNgaySinhBN;
        private System.Windows.Forms.TextBox tbxSDTBN;
        private System.Windows.Forms.TextBox tbxDiaChiBN;
        private System.Windows.Forms.TextBox tbxGioiTinhBN;
        private System.Windows.Forms.TextBox tbxMaBN;
        private System.Windows.Forms.Label labelSĐT;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelTenBN;
        private System.Windows.Forms.Label labelMaBN;
        private System.Windows.Forms.GroupBox grbThongTinBN;
        private System.Windows.Forms.Button btnXoaBN;
    }
}