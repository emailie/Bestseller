using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bestseller_Atestat
{
    public partial class Instagram : Form
    {
        public Instagram()
        {
            InitializeComponent();
        }

        private void Instagram_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Libraria pag2 = new Libraria();
            pag2.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Turul_librăriei pag2 = new Turul_librăriei();
            pag2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            citate_repostări pag2 = new citate_repostări();
            pag2.Show();
            this.Close();
        }
    }
}
