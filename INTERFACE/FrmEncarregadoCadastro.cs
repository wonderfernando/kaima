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

namespace INTERFACE
{
    public partial class FrmEncarregadoCadastro : Form
    {
        Encarregado encarragado;
        public FrmEncarregadoCadastro(Encarregado encarregado)
        {
            InitializeComponent();
            this.encarragado = encarregado;
            lblText.Text = "EDITAR ENCARREGADO";
            txtEmail.Text = encarragado.Email;
            txtNome.Text = encarragado.Nome;
            txtTelefone.Text = encarragado.Telefone;
        }
        public FrmEncarregadoCadastro( )
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEncarregadoCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            if (encarragado != null)
                cmbSexo.Text = encarragado.Sexo; 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (encarragado == null)
            {
                Encarregado enc = new Encarregado(txtNome.Text, txtTelefone.Text, txtEmail.Text, cmbSexo.SelectedItem.ToString());
                enc.Insert();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                encarragado.Nome = txtNome.Text;
                encarragado.Telefone = txtTelefone.Text;
                encarragado.Email = txtEmail.Text;
                encarragado.Sexo = cmbSexo.SelectedItem.ToString();
                encarragado.Edit();
                DialogResult = DialogResult.OK;
            }
            Close();
        }
    }
}
