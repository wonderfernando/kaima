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
    public partial class FrmMatriculaCadastro : Form
    {
        List<Aluno> listAluno;
        List<Curso> listCurso;
        List<Classe> listClasse;
        List<Turno> listTurno;
        List<Turma> listTurma;

        public FrmMatriculaCadastro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMatriculaCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadCombo();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Matricula m = new Matricula(listAluno[cmbAluno.SelectedIndex].Id, copyTurma[cmbTurma.SelectedIndex].Id, AnoLectivo.getLast().Id, txtFim.Text, txtNmatricula.Text, 1, cmbTipo.SelectedItem.ToString());
            if (Matricula.fecharMatricular(listAluno[cmbAluno.SelectedIndex].Id))
            {
                m.inserir();
                MessageBox.Show("Matriculado com sucesso");
            }
            Close();
        }

        List<Turma> copyTurma;
        public void loadCombo()
        {
            listAluno = new Aluno().listTodos();
            listClasse = new Classe().listTodos();
            listCurso = new Curso().listTodo();
            listTurno = new Turno().listTodos();
            listTurma = new Turma().listTodos();
            foreach (Aluno item in  listAluno)
            {
                cmbAluno.Items.Add(item.Nome);
            }
            foreach (Classe item in listClasse)
            {
                cmbClasse.Items.Add(item.Nome);
            }
            foreach (Curso item in listCurso)
            {
                cmbCurso.Items.Add(item.Nome);
            }
            foreach (Turno item in listTurno)
            {
                cmbTurno.Items.Add(item.nome);
            }
  
            txtAnoLetovo.Text = AnoLectivo.getLast().Ano;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasse.SelectedIndex>=0 && cmbCurso.SelectedIndex>=0)
            {
                cmbTurma.Items.Clear();
                copyTurma = listTurma.Where<Turma>(t => t.IdCurso == listCurso[cmbCurso.SelectedIndex].Id && listClasse[cmbClasse.SelectedIndex].Id == t.IdClasse).ToList();
                copyTurma.ForEach(t => cmbTurma.Items.Add(t.Nome));
            }
        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmbClasse.SelectedIndex >= 0 && cmbCurso.SelectedIndex >= 0)
            {
                cmbTurma.Items.Clear();
                copyTurma = listTurma.Where<Turma>(t => t.IdCurso == listCurso[cmbCurso.SelectedIndex].Id && listClasse[cmbClasse.SelectedIndex].Id == t.IdClasse).ToList();
                copyTurma.ForEach(t => cmbTurma.Items.Add(t.Nome));
            }
       
    }
  
        private void cmbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTurma.SelectedIndex>=0)
            {
                Turma t = copyTurma[cmbTurma.SelectedIndex];
                cmbTurno.Text = t.Turno.nome;
            }
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new FrmAlunoView(this).ShowDialog();
        }
        public void setAluno(int idAluno)
        {
            Aluno aluno = Aluno.findId(idAluno);
            cmbAluno.Text = aluno.Nome; 
        }
    }
}
