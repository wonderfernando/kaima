using BUSSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACE.Financeiro
{
    public partial class FrmMudarpPreco : Form
    {
        MatriculaPayment matriculaPay;
        public FrmMudarpPreco(MatriculaPayment matriculaPay)
        {
            InitializeComponent();
            label1.Text = matriculaPay.Nome;
            this.matriculaPay = matriculaPay;
            guna2TextBox1.Text = matriculaPay.Preco.ToString();
        }

        private void FrmMudarpPreco_Load(object sender, EventArgs e)
        {

        }
    }
}
