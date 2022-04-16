using System.Windows.Forms;

namespace QLPMT
{
    partial class DanhSachKhamBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachKhamBenh));
            this.label1 = new System.Windows.Forms.Label();
            this.soBenhNhan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cbxBenhNhan = new System.Windows.Forms.ComboBox();
            this.labelBenhNhan = new System.Windows.Forms.Label();
            this.labelDkKham = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ngaySinhNhap = new System.Windows.Forms.DateTimePicker();
            this.sdtNhap = new System.Windows.Forms.TextBox();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.diaChiNhap = new System.Windows.Forms.TextBox();
            this.gioiTinhNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hoTenNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNhapThongTinBenhNhan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.danhSachDKKB = new System.Windows.Forms.ListView();
            this.maBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenBenhNhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.searchDateTime = new System.Windows.Forms.DateTimePicker();
            this.soBenhNhanCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khám bệnh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soBenhNhan
            // 
            this.soBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soBenhNhan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soBenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soBenhNhan.Location = new System.Drawing.Point(18, 49);
            this.soBenhNhan.Margin = new System.Windows.Forms.Padding(8);
            this.soBenhNhan.Name = "soBenhNhan";
            this.soBenhNhan.Size = new System.Drawing.Size(1214, 40);
            this.soBenhNhan.TabIndex = 5;
            this.soBenhNhan.Text = "Số bệnh nhân đã tiếp nhận: ";
            this.soBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.soBenhNhan.Click += new System.EventHandler(this.soBenhNhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.btnDangKy);
            this.groupBox1.Controls.Add(this.cbxBenhNhan);
            this.groupBox1.Controls.Add(this.labelBenhNhan);
            this.groupBox1.Controls.Add(this.labelDkKham);
            this.groupBox1.Location = new System.Drawing.Point(653, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(575, 196);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDangKy.Location = new System.Drawing.Point(252, 139);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(8);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(173, 41);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cbxBenhNhan
            // 
            this.cbxBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBenhNhan.AutoCompleteCustomSource.AddRange(new string[] {
            "combData"});
            this.cbxBenhNhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxBenhNhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxBenhNhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBenhNhan.DropDownHeight = 130;
            this.cbxBenhNhan.FormattingEnabled = true;
            this.cbxBenhNhan.IntegralHeight = false;
            this.cbxBenhNhan.ItemHeight = 25;
            this.cbxBenhNhan.Location = new System.Drawing.Point(171, 91);
            this.cbxBenhNhan.Margin = new System.Windows.Forms.Padding(8);
            this.cbxBenhNhan.Name = "cbxBenhNhan";
            this.cbxBenhNhan.Size = new System.Drawing.Size(371, 31);
            this.cbxBenhNhan.TabIndex = 2;
            this.cbxBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cbxBenhNhan_SelectedIndexChanged);
            // 
            // labelBenhNhan
            // 
            this.labelBenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenhNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBenhNhan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelBenhNhan.Location = new System.Drawing.Point(5, 92);
            this.labelBenhNhan.Margin = new System.Windows.Forms.Padding(8);
            this.labelBenhNhan.Name = "labelBenhNhan";
            this.labelBenhNhan.Size = new System.Drawing.Size(150, 30);
            this.labelBenhNhan.TabIndex = 1;
            this.labelBenhNhan.Text = "Bệnh nhân";
            this.labelBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDkKham
            // 
            this.labelDkKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDkKham.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelDkKham.Location = new System.Drawing.Point(224, 23);
            this.labelDkKham.Name = "labelDkKham";
            this.labelDkKham.Size = new System.Drawing.Size(200, 50);
            this.labelDkKham.TabIndex = 0;
            this.labelDkKham.Text = "Đăng ký khám";
            this.labelDkKham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDkKham.Click += new System.EventHandler(this.labelDkKham_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.ngaySinhNhap);
            this.groupBox2.Controls.Add(this.sdtNhap);
            this.groupBox2.Controls.Add(this.btnThemBN);
            this.groupBox2.Controls.Add(this.diaChiNhap);
            this.groupBox2.Controls.Add(this.gioiTinhNhap);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.hoTenNhap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelNhapThongTinBenhNhan);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(653, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 445);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(215, 329);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(199, 36);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Đăng ký khám bệnh";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(188, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 26);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "+84";
            // 
            // ngaySinhNhap
            // 
            this.ngaySinhNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ngaySinhNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaySinhNhap.Location = new System.Drawing.Point(188, 188);
            this.ngaySinhNhap.Name = "ngaySinhNhap";
            this.ngaySinhNhap.Size = new System.Drawing.Size(200, 27);
            this.ngaySinhNhap.TabIndex = 9;
            this.ngaySinhNhap.Value = new System.DateTime(2022, 3, 31, 15, 14, 27, 0);
            this.ngaySinhNhap.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // sdtNhap
            // 
            this.sdtNhap.CausesValidation = false;
            this.sdtNhap.Location = new System.Drawing.Point(252, 274);
            this.sdtNhap.Margin = new System.Windows.Forms.Padding(8);
            this.sdtNhap.Multiline = true;
            this.sdtNhap.Name = "sdtNhap";
            this.sdtNhap.Size = new System.Drawing.Size(317, 30);
            this.sdtNhap.TabIndex = 13;
            this.sdtNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sdtNhap.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnThemBN
            // 
            this.btnThemBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemBN.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemBN.FlatAppearance.BorderSize = 0;
            this.btnThemBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThemBN.Location = new System.Drawing.Point(252, 376);
            this.btnThemBN.Margin = new System.Windows.Forms.Padding(8);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(173, 41);
            this.btnThemBN.TabIndex = 4;
            this.btnThemBN.Text = "Thêm Bệnh nhân";
            this.btnThemBN.UseVisualStyleBackColor = false;
            this.btnThemBN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // diaChiNhap
            // 
            this.diaChiNhap.CausesValidation = false;
            this.diaChiNhap.Location = new System.Drawing.Point(188, 226);
            this.diaChiNhap.Margin = new System.Windows.Forms.Padding(8);
            this.diaChiNhap.Multiline = true;
            this.diaChiNhap.Name = "diaChiNhap";
            this.diaChiNhap.Size = new System.Drawing.Size(381, 30);
            this.diaChiNhap.TabIndex = 12;
            this.diaChiNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.diaChiNhap.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // gioiTinhNhap
            // 
            this.gioiTinhNhap.CausesValidation = false;
            this.gioiTinhNhap.Location = new System.Drawing.Point(189, 133);
            this.gioiTinhNhap.Margin = new System.Windows.Forms.Padding(8);
            this.gioiTinhNhap.Multiline = true;
            this.gioiTinhNhap.Name = "gioiTinhNhap";
            this.gioiTinhNhap.Size = new System.Drawing.Size(380, 30);
            this.gioiTinhNhap.TabIndex = 10;
            this.gioiTinhNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(11, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số điện thoại";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(11, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(11, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hoTenNhap
            // 
            this.hoTenNhap.CausesValidation = false;
            this.hoTenNhap.Location = new System.Drawing.Point(188, 74);
            this.hoTenNhap.Margin = new System.Windows.Forms.Padding(8);
            this.hoTenNhap.Multiline = true;
            this.hoTenNhap.Name = "hoTenNhap";
            this.hoTenNhap.Size = new System.Drawing.Size(381, 30);
            this.hoTenNhap.TabIndex = 5;
            this.hoTenNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoTenNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ và tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNhapThongTinBenhNhan
            // 
            this.labelNhapThongTinBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapThongTinBenhNhan.ForeColor = System.Drawing.Color.DimGray;
            this.labelNhapThongTinBenhNhan.Location = new System.Drawing.Point(156, 25);
            this.labelNhapThongTinBenhNhan.Name = "labelNhapThongTinBenhNhan";
            this.labelNhapThongTinBenhNhan.Size = new System.Drawing.Size(327, 41);
            this.labelNhapThongTinBenhNhan.TabIndex = 4;
            this.labelNhapThongTinBenhNhan.Text = "Nhập thông tin bệnh nhân";
            this.labelNhapThongTinBenhNhan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.danhSachDKKB);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.searchDateTime);
            this.groupBox3.Location = new System.Drawing.Point(18, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox3.Size = new System.Drawing.Size(619, 662);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // danhSachDKKB
            // 
            this.danhSachDKKB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danhSachDKKB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maBN,
            this.tenBenhNhan,
            this.ngaySinh,
            this.gioiTinh,
            this.diaChi,
            this.sdt});
            this.danhSachDKKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSachDKKB.HideSelection = false;
            this.danhSachDKKB.Location = new System.Drawing.Point(5, 92);
            this.danhSachDKKB.Name = "danhSachDKKB";
            this.danhSachDKKB.Size = new System.Drawing.Size(614, 561);
            this.danhSachDKKB.TabIndex = 9;
            this.danhSachDKKB.UseCompatibleStateImageBehavior = false;
            this.danhSachDKKB.View = System.Windows.Forms.View.Details;
            this.danhSachDKKB.SelectedIndexChanged += new System.EventHandler(this.danhSachDKKB_SelectedIndexChanged);
            // 
            // maBN
            // 
            this.maBN.Text = "Mã Bệnh Nhân";
            this.maBN.Width = 175;
            // 
            // tenBenhNhan
            // 
            this.tenBenhNhan.Text = "Tên Bệnh Nhân";
            this.tenBenhNhan.Width = 182;
            // 
            // ngaySinh
            // 
            this.ngaySinh.Text = "Ngày sinh";
            this.ngaySinh.Width = 90;
            // 
            // gioiTinh
            // 
            this.gioiTinh.Text = "Giới tính";
            this.gioiTinh.Width = 89;
            // 
            // diaChi
            // 
            this.diaChi.Text = "Địa chỉ";
            this.diaChi.Width = 130;
            // 
            // sdt
            // 
            this.sdt.Text = "Số điện thoại";
            this.sdt.Width = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 49);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách đăng ký khám bệnh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchDateTime
            // 
            this.searchDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchDateTime.Location = new System.Drawing.Point(1, 10);
            this.searchDateTime.Name = "searchDateTime";
            this.searchDateTime.Size = new System.Drawing.Size(186, 27);
            this.searchDateTime.TabIndex = 7;
            this.searchDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // soBenhNhanCount
            // 
            this.soBenhNhanCount.AutoSize = true;
            this.soBenhNhanCount.BackColor = System.Drawing.Color.White;
            this.soBenhNhanCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soBenhNhanCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.soBenhNhanCount.Location = new System.Drawing.Point(287, 53);
            this.soBenhNhanCount.Name = "soBenhNhanCount";
            this.soBenhNhanCount.Size = new System.Drawing.Size(0, 29);
            this.soBenhNhanCount.TabIndex = 11;
            // 
            // DanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1240, 774);
            this.Controls.Add(this.soBenhNhanCount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.soBenhNhan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhSachKhamBenh";
            this.Text = "Quản lý phòng mạch tư";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDkKham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelBenhNhan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ComboBox cbxBenhNhan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker searchDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoTenNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNhapThongTinBenhNhan;
        private System.Windows.Forms.TextBox diaChiNhap;
        private System.Windows.Forms.TextBox gioiTinhNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.TextBox sdtNhap;
        private System.Windows.Forms.DateTimePicker ngaySinhNhap;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Label soBenhNhan;
        private System.Windows.Forms.ListView danhSachDKKB;
        private System.Windows.Forms.ColumnHeader maBN;
        private System.Windows.Forms.ColumnHeader tenBenhNhan;
        private System.Windows.Forms.ColumnHeader ngaySinh;
        private System.Windows.Forms.ColumnHeader gioiTinh;
        private System.Windows.Forms.ColumnHeader diaChi;
        private System.Windows.Forms.ColumnHeader sdt;
        private System.Windows.Forms.Label soBenhNhanCount;
    }
}

