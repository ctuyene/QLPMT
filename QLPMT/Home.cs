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
            int index = menu.FocusedItem.Index;


            switch (index)
            {
                case 0:
                    panel1.Controls.Clear();
                    Form1 form1 = new Form1() { TopLevel = false, TopMost = true };
                    panel1.Controls.Add(form1);
                    form1.Show();
                    form1.WindowState = FormWindowState.Maximized;
                    break;
                case 1:
                    panel1.Controls.Clear();
                    Form2 form2 = new Form2() { TopLevel = false, TopMost = true };
                    panel1.Controls.Add(form2);
                    form2.Show();
                    form2.WindowState = FormWindowState.Maximized;
                    break;
                case 2:
                    panel1.Controls.Clear();
                    Form3 form3 = new Form3() { TopLevel = false, TopMost = true };
                    panel1.Controls.Add(form3);
                    form3.Show();
                    form3.WindowState = FormWindowState.Maximized;
                    break;
                case 3:
                    panel1.Controls.Clear();
                    Form5  form5 = new Form5() { TopLevel = false, TopMost = true };
                    panel1.Controls.Add(form5);
                    form5.Show();
                    form5.WindowState = FormWindowState.Maximized;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
