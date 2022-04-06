using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPMT
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-NPJA2V7\TUYENCHAU;Initial Catalog=QLPMT;Integrated Security=True";
        SqlConnection sqlcon = null;
        public Form1()
        {
            InitializeComponent();
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select * from BENHNHAN";
            sqlCommand.Connection = sqlcon;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string maBN = reader.GetString(0);
                string tenBN = reader.GetString(1);
                DateTime ngaysinh = reader.GetDateTime(2);
                bool gioitinh = reader.GetBoolean(3);
                string diachi = reader.GetString(4).ToString();
                string sdt = reader.GetString(5).ToString();

                ListViewItem lv = new ListViewItem(maBN);
                lv.SubItems.Add(tenBN);
                lv.SubItems.Add(ngaysinh.ToString());
                if (gioitinh == false)
                {
                    lv.SubItems.Add("Nam");

                }
                else
                {
                    lv.SubItems.Add("Nữ");
                }
                lv.SubItems.Add(diachi);
                lv.SubItems.Add(sdt);

                danhSachDKKB.Items.Add(lv);
            }
            reader.Close();
        }

            private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            string tenBN = hoTenNhap.Text.Trim();
            string gioiTinh=gioiTinhNhap.Text.Trim();  
            string diachi=diaChiNhap.Text.Trim();
            string ngaysinh = ngaySinhNhap.Text.Trim();
            string sdt = sdtNhap.Text.Trim();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "insert into BENHNHAN values(2000,'ádasd','1997-10-15 00:00:00','true','khu B','23994333','false')";
            sqlCommand.Connection = sqlcon;
            int kq = sqlCommand.ExecuteNonQuery();
            if (kq == 0)
            {
                MessageBox.Show("Thêm thành công");
             
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            string tenBN = hoTenNhap.Text.Trim();
            string gioiTinh = gioiTinhNhap.Text.Trim();
            string diachi = diaChiNhap.Text.Trim();
            string ngaysinh = ngaySinhNhap.Text.Trim();
            string sdt = sdtNhap.Text.Trim();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "insert into BENHNHAN values(2000,'ádasd','1997-10-15 00:00:00','true','khu B','23994333','false')";
            sqlCommand.Connection = sqlcon;
            int kq = sqlCommand.ExecuteNonQuery();
            if (kq == 0)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelDkKham_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void soBenhNhan_Click(object sender, EventArgs e)
        {
                
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void danhSáchKhsamBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýPhiếuKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home f = new Home();
           // f.MdiParent = this;
            f.Show();
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            // f.MdiParent = this;
            f.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
           // cbxBenhNhan.Text = 
        }
    }
}
