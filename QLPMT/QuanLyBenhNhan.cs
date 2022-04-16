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
    public partial class QuanLyBenhNhan : Form
    {
        string strCon = @"Data Source=DESKTOP-NPJA2V7\TUYENCHAU;Initial Catalog=QLPMT;Integrated Security=True";
        SqlConnection sqlcon = null;
        public QuanLyBenhNhan()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getDanhSachBenhNhan();
        }

        private void soBenhNhan_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBenhNhan.SelectedItems.Count==0) return;
            
            ListViewItem lvi = listBenhNhan.SelectedItems[0];

            tbMaBN.Text = lvi.SubItems[0].Text;
            tbxHoTenBN.Text = lvi.SubItems[1].Text;
            tbxNgaySinhBN.Text = lvi.SubItems[2].Text;
            tbxGioiTinhBN.Text=lvi.SubItems[3].Text;
            tbxDiaChiBN.Text = lvi.SubItems[4].Text;
            tbxSDTBN.Text=lvi.SubItems[5].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
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
            sqlCommand.CommandText = "update BENHNHAN set MaBenhNhan='"+ tbMaBN.Text.Trim() + "',TenBenhNhan=N'"+ tbxHoTenBN.Text.Trim() + "',NgaySinh='" + tbxNgaySinhBN.Text.Trim() + "',GioiTinh=N'true',DiaChi=N'" + tbxDiaChiBN.Text.Trim() + "',SoDienThoai='" + tbxSDTBN.Text.Trim() + "' WHERE MaBenhNhan='"+tbMaBN.Text.Trim()+"' ";
            sqlCommand.Connection = sqlcon;
            int kq = sqlCommand.ExecuteNonQuery();

            if (kq != 0)
            {
                MessageBox.Show("Cập nhật thành công");
                getDanhSachBenhNhan();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
        void getDanhSachBenhNhan()
        {
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
            listBenhNhan.Items.Clear();
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

                listBenhNhan.Items.Add(lv);
            }
            reader.Close();
        }

        private void btnXoaBN_Click(object sender, EventArgs e)
        {
            DialogResult kqXoa = MessageBox.Show("Bạn có thật sự muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kqXoa == DialogResult.Yes)
            {
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
                sqlCommand.CommandText = "delete from BENHNHAN WHERE MaBenhNhan='" + tbMaBN.Text.Trim() + "' ";
                sqlCommand.Connection = sqlcon;
                 sqlCommand.ExecuteNonQuery();
                getDanhSachBenhNhan();

            }
        }

        private void tbMaBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
