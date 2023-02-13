using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSSINESS;
namespace INTERFACE.GestaoAcademica
{
    public partial class FrmDisciplinaCadastro : Form
    {
        public FrmDisciplinaCadastro()
        {
            InitializeComponent();
         
        }

        private void FrmDisciplinaCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            Disciplina disciplina = new Disciplina(guna2TextBox2.Text);
            if (disciplina.inserir())
            {
                 this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("dasd");
                this.DialogResult = DialogResult.No;
            }
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
