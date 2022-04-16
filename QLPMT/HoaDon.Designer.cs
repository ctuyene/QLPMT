namespace QLPMT
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.lbNgayKham = new System.Windows.Forms.Label();
            this.lbTenBenhNhan = new System.Windows.Forms.Label();
            this.lbMaPhieuKhamBenh = new System.Windows.Forms.Label();
            this.lbTienKham = new System.Windows.Forms.Label();
            this.lbTienThuoc = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbTieuDe.Location = new System.Drawing.Point(28, 31);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(179, 38);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "HÓA ĐƠN";
            // 
            // lbNgayKham
            // 
            this.lbNgayKham.AutoSize = true;
            this.lbNgayKham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNgayKham.Location = new System.Drawing.Point(51, 165);
            this.lbNgayKham.Name = "lbNgayKham";
            this.lbNgayKham.Size = new System.Drawing.Size(76, 16);
            this.lbNgayKham.TabIndex = 1;
            this.lbNgayKham.Text = "Ngày khám";
            // 
            // lbTenBenhNhan
            // 
            this.lbTenBenhNhan.AutoSize = true;
            this.lbTenBenhNhan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbTenBenhNhan.Location = new System.Drawing.Point(51, 124);
            this.lbTenBenhNhan.Name = "lbTenBenhNhan";
            this.lbTenBenhNhan.Size = new System.Drawing.Size(96, 16);
            this.lbTenBenhNhan.TabIndex = 2;
            this.lbTenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // lbMaPhieuKhamBenh
            // 
            this.lbMaPhieuKhamBenh.AutoSize = true;
            this.lbMaPhieuKhamBenh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaPhieuKhamBenh.Location = new System.Drawing.Point(51, 210);
            this.lbMaPhieuKhamBenh.Name = "lbMaPhieuKhamBenh";
            this.lbMaPhieuKhamBenh.Size = new System.Drawing.Size(131, 16);
            this.lbMaPhieuKhamBenh.TabIndex = 3;
            this.lbMaPhieuKhamBenh.Text = "Mã phiếu khám bệnh";
            // 
            // lbTienKham
            // 
            this.lbTienKham.AutoSize = true;
            this.lbTienKham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTienKham.Location = new System.Drawing.Point(51, 317);
            this.lbTienKham.Name = "lbTienKham";
            this.lbTienKham.Size = new System.Drawing.Size(70, 16);
            this.lbTienKham.TabIndex = 4;
            this.lbTienKham.Text = "Tiền khám";
            this.lbTienKham.Click += new System.EventHandler(this.lbTienKham_Click);
            // 
            // lbTienThuoc
            // 
            this.lbTienThuoc.AutoSize = true;
            this.lbTienThuoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTienThuoc.Location = new System.Drawing.Point(51, 360);
            this.lbTienThuoc.Name = "lbTienThuoc";
            this.lbTienThuoc.Size = new System.Drawing.Size(69, 16);
            this.lbTienThuoc.TabIndex = 5;
            this.lbTienThuoc.Text = "Tiền thuốc";
            this.lbTienThuoc.Click += new System.EventHandler(this.lbTienThuoc_Click);
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbThanhTien.Location = new System.Drawing.Point(503, 577);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(69, 16);
            this.lbThanhTien.TabIndex = 7;
            this.lbThanhTien.Text = "Thành tiền";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 666);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbTienThuoc);
            this.Controls.Add(this.lbTienKham);
            this.Controls.Add(this.lbMaPhieuKhamBenh);
            this.Controls.Add(this.lbTenBenhNhan);
            this.Controls.Add(this.lbNgayKham);
            this.Controls.Add(this.lbTieuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbNgayKham;
        private System.Windows.Forms.Label lbTenBenhNhan;
        private System.Windows.Forms.Label lbMaPhieuKhamBenh;
        private System.Windows.Forms.Label lbTienKham;
        private System.Windows.Forms.Label lbTienThuoc;
        private System.Windows.Forms.Label lbThanhTien;
    }
}