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
    public partial class Editura : Form
    {
        public Editura()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pag_principala pag2 = new Pag_principala();
            pag2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fondator pag2 = new Fondator();
            pag2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amintiri_din_viitor pag2 = new Amintiri_din_viitor();
            pag2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tema_pentru_acasa pag2 = new Tema_pentru_acasa();
            pag2.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eu_sunt_femeie pag2 = new Eu_sunt_femeie();
            pag2.Show();
            this.Close();
        }
    }
}
