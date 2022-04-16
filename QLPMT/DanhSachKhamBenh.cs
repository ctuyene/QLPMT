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
using System.Configuration;

namespace QLPMT
{
    public partial class DanhSachKhamBenh : Form
    {
        string strCon = @"Data Source=DESKTOP-NPJA2V7\TUYENCHAU;Initial Catalog=QLPMT;Integrated Security=True";
        SqlConnection sqlcon = null;
        private const string _idPrefix = "BN";

        public DanhSachKhamBenh()
        {
            InitializeComponent();
        }
        void getData()
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
            SqlDataReader reader = sqlCommand.ExecuteReader();
            danhSachDKKB.Items.Clear();
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
            soBenhNhanCount.Text = danhSachDKKB.Items.Count.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            string id = AutoGenerateID();
            string tenBN = hoTenNhap.Text.Trim();

            string gioiTinh;
            if (gioiTinhNhap.Text.Trim() == "Nữ")
            {
                gioiTinh = "true";

            }
            else
            {
                gioiTinh = "false";
            }
            string diachi = diaChiNhap.Text.Trim();
            string ngaysinh = ngaySinhNhap.Text.Trim();
            string sdt = sdtNhap.Text.Trim();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "insert into BENHNHAN values('" + id + "',N'" + tenBN + "','1997-10-15 00:00:00',N'" + gioiTinh + "',N'" + diachi + "','" + sdt + "','false')";
            sqlCommand.Connection = sqlcon;
            int kq = sqlCommand.ExecuteNonQuery();

            if (kq != 0)
            {
                MessageBox.Show("Thêm thành công");
                getData();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
            ClearTextBox();
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
            getData();
            //if (sqlcon == null)
            //{
            //    sqlcon = new SqlConnection(strCon);
            //}
            //if (sqlcon.State == ConnectionState.Closed)
            //{
            //    sqlcon.Open();
            //}
            //string sqlQuerry = "Select TenBenhNhan from BENHNHAN";
            //SqlCommand sqlCommand = new SqlCommand();

            //sqlCommand = new SqlCommand(sqlQuerry, sqlcon);
            //SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);




            //sqlcon.Close();
            cbxBenhNhan.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxBenhNhan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getBenhNhan(combData);
            cbxBenhNhan.AutoCompleteCustomSource = combData;
        }
        void getBenhNhan(AutoCompleteStringCollection dataCollection)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT [TenBenhNhan] FROM [BENHNHAN]";
            connection = new SqlConnection(strCon);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        
        private void quảnLýPhiếuKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            // f.MdiParent = this;
            f.Show();
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuKhamBenh f = new PhieuKhamBenh();
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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public string AutoGenerateID()
        {
            String lastID = "BN000000";

            if (danhSachDKKB.Items.Count > 0)
            {
                lastID = danhSachDKKB.Items[danhSachDKKB.Items.Count - 1].Text;
            }

            string[] tokens = lastID.Split(new[] { "BN" }, StringSplitOptions.None);



            return _idPrefix + (Int32.Parse(tokens[1]) + 1).ToString("D5");

            //return _idPrefix + (danhSachDKKB.Items[danhSachDKKB.Items.Count] + 1).ToString("D5");
        }
        public void ClearTextBox()
        {
            hoTenNhap.Clear();
            gioiTinhNhap.Clear();
            diaChiNhap.Clear();
            sdtNhap.Clear();
        }

        private void danhSachDKKB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
