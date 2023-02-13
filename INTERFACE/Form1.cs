using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        int cont = 1;
        int seconds = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                label1.Text = "Carregando.";
                cont++;
            }
            else if (cont == 2)
            {
                label1.Text = "Carregando..";
                cont++;
            }
            else if (cont == 3)
            {
                label1.Text = "Carregando...";
                cont++;
                if (seconds >= 15)
                {
                    timer1.Stop();
                    this.Hide();
                    new Login().Show();
                }
            }
            else
            {
                cont = 1;
            }

            seconds++;
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
