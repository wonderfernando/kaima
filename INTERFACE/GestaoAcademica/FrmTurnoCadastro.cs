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
    public partial class FrmTurnoCadastro : Form
    {
        public FrmTurnoCadastro()
        {
            InitializeComponent();
        }
        Turno turno;
        public FrmTurnoCadastro(Turno turno)
        {
            InitializeComponent();
            this.turno = turno;
            lblText.Text = "EDITAR TURNO";
            txtTurno.Text = turno.nome;
            txtInicio.Text = turno.inicio;
            txtFinal.Text = turno.final;
        }

        private void FrmTurnoCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (turno== null)
            {

                Turno turno = new Turno(txtTurno.Text, txtInicio.Text, txtFinal.Text);
                if (turno.inserir())
                {
                    MessageBox.Show("Inserido com sucesso");
                    this.DialogResult = DialogResult.OK;

                }
            }
            else
            {
                turno.nome = txtTurno.Text;
                turno.inicio = txtInicio.Text;
                turno.final = txtFinal.Text;
                if (turno.Edit())
                {
                    MessageBox.Show("Editado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }
          
            Close();
        }
    }
}
