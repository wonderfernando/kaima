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

namespace INTERFACE.GestaoAdministrativa
{
    public partial class FrmCargoCadastro : Form
    {

        
        Cargo Cargo;
        public FrmCargoCadastro(Cargo Cargo)
        {
            InitializeComponent();
            this.Cargo = Cargo;
            lblDesc.Text = "EDITAR CARGO";
            txtCargo.Text = Cargo.Nome;
        }

        public FrmCargoCadastro()
        {
            InitializeComponent();
        }

        private void FrmCargoCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            if (Cargo==null)
            {
                Cargo cargo_ = new Cargo(txtCargo.Text);
                if (cargo_.Insert())
                    {
                        MessageBox.Show("Inserido com sucesso");
                        DialogResult = DialogResult.OK;
                    }
            }
            else
            {
                Cargo cargo_ = new Cargo(Cargo.Id, txtCargo.Text);
                if (cargo_.Edit())
                {
                    MessageBox.Show("Editado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            
            }
          
            Close();
        }
    }
}
