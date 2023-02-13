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
            Turno turno = new Turno(txtTurno.Text,txtInicio.Text,txtFinal.Text);
            if (turno.inserir())
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
