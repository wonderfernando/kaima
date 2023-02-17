using System;

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
        Disciplina disciplina;
        public FrmDisciplinaCadastro(Disciplina disciplina)
        {
            InitializeComponent();
            this.disciplina = disciplina;
            lblText.Text = "EDITAR DISCIPLINA";
            txtNome.Text = disciplina.disciplina;
        }

        private void FrmDisciplinaCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (disciplina==null)
            {
                 Disciplina disciplina1 = new Disciplina(txtNome.Text);
                 if (disciplina1.inserir())
                 {
                      this.DialogResult = DialogResult.OK;
                 }
            }
            else
            {
                disciplina.disciplina = txtNome.Text;
                if (disciplina.Edit())
                {
                    MessageBox.Show("Editado com sucesso");
                    this.DialogResult = DialogResult.OK;
                }
            }
           
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
