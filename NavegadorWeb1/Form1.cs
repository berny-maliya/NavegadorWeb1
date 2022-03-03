using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            navegador.Navigate(URLNavega.Text);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            navegador.GoBack();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            navegador.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            navegador.Refresh();
        }

        private void parar_Click(object sender, EventArgs e)
        {
            navegador.Stop();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            navegador.GoHome();
        }
    }
}
