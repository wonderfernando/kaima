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
    public partial class FrmSalaCadastro : Form
    {
        public FrmSalaCadastro()
        {
            InitializeComponent();
        }
        Sala sala;
        public FrmSalaCadastro(Sala sala)
        {
            InitializeComponent();
            this.sala = sala;
            lblText.Text = "EDITAR SALA";
            txtSala.Text = sala.nome;
            txtCap.Text = sala.capacidade.ToString();
            txtTipo.Text = sala.tipo;
        }

        private void FrmSalaCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (sala==null)
            {
                Sala sala = new Sala(txtSala.Text, int.Parse(txtCap.Text), txtTipo.Text);
                if (sala.inserir())
                {
                    this.DialogResult = DialogResult.OK;
                }
              
            }
            else
            {
                sala.nome = txtSala.Text;
                sala.capacidade = int.Parse(txtCap.Text);
                sala.tipo = txtTipo.Text;
                if (sala.Edit())
                {
                    MessageBox.Show("Editado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }
             this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
