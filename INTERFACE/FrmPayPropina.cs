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
    public partial class FrmPayPropina : Form
    {
        Propina propina;
        public FrmPayPropina() 
        {
            InitializeComponent();
       
        }
        public FrmPayPropina(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            txtNme.Text = usuario.username;
            txtSenha.Text = usuario.senha;
        }

        private void FrmPayPropina_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        Usuario usuario;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (usuario==null)
            {
                Usuario user = new Usuario(txtNme.Text, txtSenha.Text);
                if (user.insert())
                {
                    MessageBox.Show("Cadastrado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                usuario.username = txtNme.Text;
                usuario.senha = txtSenha.Text;
                if (usuario.EDIT())
                {
                    MessageBox.Show("Editado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }
            Close();
        }
    }
}
