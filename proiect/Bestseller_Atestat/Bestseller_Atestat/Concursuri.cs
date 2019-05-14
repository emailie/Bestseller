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
    public partial class Concursuri : Form
    {
        public Concursuri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libraria pag2 = new Libraria();
            pag2.Show();
            this.Close();
        }
    }
}
