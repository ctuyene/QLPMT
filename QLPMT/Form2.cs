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
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=DESKTOP-NPJA2V7\TUYENCHAU;Initial Catalog=QLPMT;Integrated Security=True";
        SqlConnection sqlcon = null;
        public Form2()
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

                listBenhNhan.Items.Add(lv);
            }
            reader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void soBenhNhan_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
    }
}
