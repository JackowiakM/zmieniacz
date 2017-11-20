using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class O_Programie : Form
    {
        public O_Programie()
        {
            InitializeComponent();
        }

        private void link_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://student.puls.edu.pl/");
        }

        private void link_instytut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.up.poznan.pl/iir/");
        }

        private void wyjście_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
