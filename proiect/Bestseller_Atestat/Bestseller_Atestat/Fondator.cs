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
    public partial class Fondator : Form
    {
        public Fondator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editura pag2 = new Editura();
            pag2.Show();
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ion_Bargan_si_Vitali_Cipileaga pag3 = new Ion_Bargan_si_Vitali_Cipileaga();
            pag3.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Editura pag2 = new Editura();
            pag2.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fondator_Load(object sender, EventArgs e)
        {

        }
    }
}
