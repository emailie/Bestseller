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
    public partial class Libraria : Form
    {
        public Libraria()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void Libraria_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pag_principala pag2 = new Pag_principala();
            pag2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instagram pag2 = new Instagram();
            pag2.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Concursuri pag2 = new Concursuri();
            pag2.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
