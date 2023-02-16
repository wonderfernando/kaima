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

namespace INTERFACE.GestaoAcademica
{
    public partial class FrmAreaFormacaoCadastro : Form
    {
        AreaFormacao areaFormacao;
        public FrmAreaFormacaoCadastro()
        {
            InitializeComponent();
        }
        public FrmAreaFormacaoCadastro(AreaFormacao areaFormacao)
        {
            InitializeComponent();
            this.areaFormacao = areaFormacao;
            lblText.Text = "EDITAR AREA DE FORMAÇÃO";
            txtDuracao.Text = areaFormacao.duracao.ToString();
            txtFormacao.Text = areaFormacao.area;
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
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       private void guna2Button2_Click(object sender, EventArgs e)
        {
           if (areaFormacao != null)
            {
                areaFormacao.area = txtFormacao.Text;
                areaFormacao.duracao = int.Parse(txtDuracao.Text);
                if (areaFormacao.Edit())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
            else
            {
                BUSSINESS.AreaFormacao area = new BUSSINESS.AreaFormacao();
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
          
            }
           Close();
        }
    }
}
