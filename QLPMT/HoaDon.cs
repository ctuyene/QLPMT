using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLPMT
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void lbTienThuoc_Click(object sender, EventArgs e)
        {

        }

        private void lbTienKham_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            //Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            //e.Graphics.DrawLine(pen, 20, 10, 300, 100);
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawLShapeLine(e.Graphics, 10, 10, 20, 40);
        }

        private void DrawLShapeLine(Graphics graphics, int v1, int v2, int v3, int v4)
        {
            throw new NotImplementedException();
        }
    }
}
