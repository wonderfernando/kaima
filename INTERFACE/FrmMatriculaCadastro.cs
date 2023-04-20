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
            Matricula.fecharMatricular(listAluno[cmbAluno.SelectedIndex].Id);
      
            DateTime dataInicio = DateTime.Parse(AnoLectivo.getLast().DataInicio);
            DateTime dataFim = DateTime.Parse(AnoLectivo.getLast().DataFinal);

            int meses = ((dataFim.Year - dataInicio.Year) * 12) + (dataFim.Month - dataInicio.Month); // cálculo da quantidade de meses
     

             m.inserir();
            //gerando as mensalidades da matricula
            for (int i = 0; i < meses; i++)
            {
                dataInicio = dataInicio.AddMonths(1);
               
                Propina prop = new Propina(Matricula.getLast().Id, listAluno[cmbAluno.SelectedIndex].Id ,dataInicio.ToShortDateString(), "", listCurso[cmbCurso.SelectedIndex].Mensalidade, 0, 0, 1, Multa.findId(1).multa);
                prop.Insert();
            }     
           MessageBox.Show("Matriculado com sucesso");
            
            Close();
        }

        List<Turma> copyTurma;

        public bool getData()
        {
                listAluno = new Aluno().listTodos();
                listClasse = new Classe().listTodos();
                listCurso = new Curso().listTodo();
                listTurno = new Turno().listTodos();
                listTurma = new Turma().listTodos();
                return true;
        }
        public async void loadCombo()
        {
           var result = await Task.Run( () => getData());

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

            load.Visible = false;
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

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex==0)
            {
                txtTotal.Text = MatriculaPayment.findId(1).Preco.ToString();
            }
            else if (cmbTipo.SelectedIndex==1)
            {
                txtTotal.Text = MatriculaPayment.findId(2).Preco.ToString();
            }
            else
            {
                txtTotal.Text = "0";
            }
        }
    }
}
