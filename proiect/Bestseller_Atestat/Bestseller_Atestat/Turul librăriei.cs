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
    public partial class Turul_librăriei : Form
    {
        public Turul_librăriei()
        {
            InitializeComponent();
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instagram pag2 = new Instagram();
            pag2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Directory.GetCurrentDirectory() + "\\video.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
