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
    public partial class Ion_Bargan_si_Vitali_Cipileaga : Form
    {
        public Ion_Bargan_si_Vitali_Cipileaga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Fondator pag2 = new Fondator();
            pag2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editura pag2 = new Editura();
            pag2.Show();
        }
    }
}
