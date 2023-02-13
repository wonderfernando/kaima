using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACE.GestaoAcademica
{
    public partial class FrmAreaFormacaoCadastro : Form
    {
        public FrmAreaFormacaoCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAreaFormacaoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        BUSSINESS.AreaFormacao area = new BUSSINESS.AreaFormacao();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            area.area = txtFormacao.Text;
            area.duracao = int.Parse(txtDuracao.Text);
            if (area.inserir())
            {
                 this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
          

            Close();
        }
    }
}
