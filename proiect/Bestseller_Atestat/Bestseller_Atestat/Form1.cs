using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestseller_Atestat
{
    public partial class Pag_principala : Form
    {
        public Pag_principala()
        {
            InitializeComponent();
        }
        int counter = -1;
        int len = 0;
        string txt;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pag_principala_Load(object sender, EventArgs e)
        {
            txt = titlu.Text;
            len = txt.Length;
            titlu.Text = "";
            timer1.Start();

            titlu.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editura pag2 = new Editura();
            pag2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Libraria pag2 = new Libraria();
            pag2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter <= len)
            {
                titlu.Text = txt.Substring(0, counter);

            }
            if (counter > len)
            {
                counter = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                                                                                      