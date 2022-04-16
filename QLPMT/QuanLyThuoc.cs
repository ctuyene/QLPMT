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
    public partial class quanLyThuoc : Form
    {
        string strCon = @"Data Source=DESKTOP-NPJA2V7\TUYENCHAU;Initial Catalog=QLPMT;Integrated Security=True";
        SqlConnection sqlcon = null;
        public quanLyThuoc()
        {
            InitializeComponent();
        }

        private void quanLyThuoc_Load(object sender, EventArgs e)
        {
            //getDanhSachThuoc();
        }

         void getDanhSachThuoc()
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
            sqlCommand.CommandText = "select * from THUOC";
            sqlCommand.Connection = sqlcon;
            listThuoc.Items.Clear();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string maThuoc = reader.GetString(0);
                string tenThuoc = reader.GetString(2);
                string congDung = reader.GetString(3);
                int donGia = reader.GetInt32(4);
                int soLuong=reader.GetInt32(5);

                ListViewItem lv = new ListViewItem(maThuoc);
                lv.SubItems.Add(tenThuoc);
                lv.SubItems.Add(congDung);
                lv.SubItems.Add(donGia.ToString());
                lv.SubItems.Add(soLuong.ToString());

                listThuoc.Items.Add(lv);
            }
            reader.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhapThuoc form = new NhapThuoc();
            form.Show(); // or form.ShowDialog(this);
        }
    }
}
