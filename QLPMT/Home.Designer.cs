namespace QLPMT
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDSKB = new System.Windows.Forms.Button();
            this.btnQLBN = new System.Windows.Forms.Button();
            this.btnQLPKB = new System.Windows.Forms.Button();
            this.btnQLT = new System.Windows.Forms.Button();
            this.btnBCDT = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(216, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 1097);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QLPMT.Properties.Resources.nhom2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 1097);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnQLT);
            this.groupBox1.Controls.Add(this.btnQLPKB);
            this.groupBox1.Controls.Add(this.btnQLBN);
            this.groupBox1.Controls.Add(this.btnDSKB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 723);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnDSKB
            // 
            this.btnDSKB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDSKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKB.ForeColor = System.Drawing.Color.White;
            this.btnDSKB.Location = new System.Drawing.Point(0, 115);
            this.btnDSKB.Name = "btnDSKB";
            this.btnDSKB.Size = new System.Drawing.Size(188, 120);
            this.btnDSKB.TabIndex = 0;
            this.btnDSKB.Text = "Danh sách khám bệnh";
            this.btnDSKB.UseVisualStyleBackColor = false;
            this.btnDSKB.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQLBN
            // 
            this.btnQLBN.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQLBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBN.ForeColor = System.Drawing.Color.White;
            this.btnQLBN.Location = new System.Drawing.Point(0, 274);
            this.btnQLBN.Name = "btnQLBN";
            this.btnQLBN.Size = new System.Drawing.Size(188, 120);
            this.btnQLBN.TabIndex = 1;
            this.btnQLBN.Text = "Quản lý Bệnh nhân";
            this.btnQLBN.UseVisualStyleBackColor = false;
            this.btnQLBN.Click += new System.EventHandler(this.btnQLBN_Click);
            // 
            // btnQLPKB
            // 
            this.btnQLPKB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQLPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPKB.ForeColor = System.Drawing.Color.White;
            this.btnQLPKB.Location = new System.Drawing.Point(0, 433);
            this.btnQLPKB.Name = "btnQLPKB";
            this.btnQLPKB.Size = new System.Drawing.Size(188, 120);
            this.btnQLPKB.TabIndex = 2;
            this.btnQLPKB.Text = "Quản lý Phiếu khám bệnh";
            this.btnQLPKB.UseVisualStyleBackColor = false;
            this.btnQLPKB.Click += new System.EventHandler(this.btnQLPKB_Click);
            // 
            // btnQLT
            // 
            this.btnQLT.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLT.ForeColor = System.Drawing.Color.White;
            this.btnQLT.Location = new System.Drawing.Point(0, 592);
            this.btnQLT.Name = "btnQLT";
            this.btnQLT.Size = new System.Drawing.Size(188, 120);
            this.btnQLT.TabIndex = 3;
            this.btnQLT.Text = "Quản lý thuốc";
            this.btnQLT.UseVisualStyleBackColor = false;
            this.btnQLT.Click += new System.EventHandler(this.btnQLT_Click);
            // 
            // btnBCDT
            // 
            this.btnBCDT.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBCDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCDT.ForeColor = System.Drawing.Color.White;
            this.btnBCDT.Location = new System.Drawing.Point(12, 751);
            this.btnBCDT.Name = "btnBCDT";
            this.btnBCDT.Size = new System.Drawing.Size(188, 120);
            this.btnBCDT.TabIndex = 4;
            this.btnBCDT.Text = "Báo cáo doanh thu";
            this.btnBCDT.UseVisualStyleBackColor = false;
            this.btnBCDT.Click += new System.EventHandler(this.btnBCDT_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLPMT.Properties.Resources.nhom1;
            this.pictureBox2.Location = new System.Drawing.Point(27, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(379, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÝ PHÒNG MẠCH TƯ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 919);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBCDT);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý phòng mạch tư";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBCDT;
        private System.Windows.Forms.Button btnQLT;
        private System.Windows.Forms.Button btnQLPKB;
        private System.Windows.Forms.Button btnQLBN;
        private System.Windows.Forms.Button btnDSKB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}