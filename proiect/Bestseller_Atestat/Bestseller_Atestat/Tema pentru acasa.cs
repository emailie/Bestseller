﻿using System;
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
    public partial class Tema_pentru_acasa : Form
    {
        public Tema_pentru_acasa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editura pag2 = new Editura();
            pag2.Show();
            this.Close();
        }
    }
}
