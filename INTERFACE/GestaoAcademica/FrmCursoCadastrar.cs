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
    public partial class FrmCursoCadastrar : Form
    {
        Curso curso;
        public FrmCursoCadastrar()
        {
            InitializeComponent();
        }

        public FrmCursoCadastrar(Curso curso)
        {
            InitializeComponent();
            this.curso = curso;
            lblText.Text = "EDITAR CURSO";
            txtCurso.Text = curso.Nome;
            txtMensalidade.Text = curso.Mensalidade.ToString();
         
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (curso!= null)
            {
                curso.Nome = txtCurso.Text;
                curso.Mensalidade = float.Parse(txtMensalidade.Text);
                curso.areaId = listArea[comboFormaca.SelectedIndex].id;
                if (curso.Edit())
                {
                    MessageBox.Show("Editado com sucesso");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                int areaId = listArea[comboFormaca.SelectedIndex].id;
                Curso c = new Curso(txtCurso.Text,areaId, int.Parse(txtMensalidade.Text.ToString()));
                if (c.inserir())
                  {
                    MessageBox.Show("Inserido com sucesso");
                    if (MessageBox.Show("Adcionar agora as diciplinas ? ") == DialogResult.Yes)
                    {
                        int idCurso = Curso.getLast().Id;
                        FrmCursoDisciplinaClasse frmCdC = new FrmCursoDisciplinaClasse(idCurso);
                        frmCdC.ShowDialog();
                    }
                    this.DialogResult = DialogResult.OK;
                  }
            }
        
            this.Close();
        }

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<AreaFormacao> listArea = new List<AreaFormacao>();
        public void loadComboArea()
        {
            comboFormaca.Items.Clear();
           listArea = new AreaFormacao().listTodos();

            foreach (AreaFormacao item in listArea)
            {
                comboFormaca.Items.Add(item.area);
            }
        }
        private void FrmCursoCadastrar_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadComboArea();
            if (curso!=null)
            {
                comboFormaca.Text = curso.area.area;
            }
        }

 
        private void btnFechar_Click(object sender, EventArgs e)
        {
            new FrmCursoDisciplinaClasse(1).ShowDialog();
            //Close();
        }
    }
}
