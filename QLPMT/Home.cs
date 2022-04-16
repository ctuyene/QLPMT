using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLPMT
{
    public partial class Home : Form
    {


        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;  
            /*
            Form1 form1 = new Form1() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(form1);
            form1.Show();
            form1.WindowState = FormWindowState.Maximized;
            */
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DanhSachKhamBenh form1 = new DanhSachKhamBenh() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(form1);
            form1.Show();
            form1.WindowState = FormWindowState.Maximized;
        }

        private void btnQLBN_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLyBenhNhan form2 = new QuanLyBenhNhan() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(form2);
            form2.Show();
            form2.WindowState = FormWindowState.Maximized;
        }

        private void btnQLPKB_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PhieuKhamBenh form3 = new PhieuKhamBenh() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(form3);
            form3.Show();
            form3.WindowState = FormWindowState.Maximized;
        }

        private void btnQLT_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            quanLyThuoc form4 = new quanLyThuoc() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(form4);
            form4.Show();
            form4.WindowState = FormWindowState.Maximized;
        }

        private void btnBCDT_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BaoCaoDoanhThu form5 = new BaoCaoDoanhThu() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(form5);
            form5.Show();
            form5.WindowState = FormWindowState.Maximized;
        }
    }
}
