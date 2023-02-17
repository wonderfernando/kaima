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
    public partial class FrmTurmaCadastro : Form
    {
        Turma turma;
        public FrmTurmaCadastro()
        {
            InitializeComponent();
        }
        public FrmTurmaCadastro(Turma turma)
        {
            InitializeComponent();
            this.turma = turma;
            txtTurma.Text = turma.Nome;
            txtAno.Text = turma.AnoLectivo.Ano;
            lblText.Text = "EDITAR TURMA";
            pnlProf.Visible = false;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTurmaCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadClasse();
            loadCurso();
            loadSala();
            loadTurno();
            loadRes();
            //loadDisci();
            txtAno.Text = AnoLectivo.getLast().Ano;
            if (turma != null)
            {
                cmbClasse.Text = turma.Classe.Nome;
                cmbRes.Text = turma.Professor.Funcionario.Nome;
                cmbCurso.Text = turma.Curso.Nome;
                cmbTurno.Text = turma.Turno.nome;
                cmbSala.Text = turma.Sala.nome;
            }
        }
        List<Classe> listClasse;
        List<Curso> listCurso;
        List<Turno> listTurno;
        List<Professor> listRes;
        List<Sala> listSala;
        List<Disciplina> listDisciplina;
        public void loadClasse()
        {
            listClasse = new Classe().listTodos();
            cmbClasse.Items.Clear();
            foreach (Classe item in listClasse)
            {
                cmbClasse.Items.Add(item.Nome);
            }
        }
        public void loadSala()
        {
            listSala = new Sala().listTodos();
            cmbSala.Items.Clear();
            foreach (Sala item in listSala)
            {
                cmbSala.Items.Add(item.nome);
            }
        }
        public void loadDisci()
        {
            listDisciplina = new Disciplina().listTodo();
            cmbDisci.Items.Clear();
            foreach (Disciplina item in listDisciplina)
            {
                cmbDisci.Items.Add(item.disciplina);
            }
        }
        public void loadCurso()
        {
            listCurso = new Curso().listTodo();
            cmbCurso.Items.Clear();
            foreach (Curso item in listCurso)
            {
                cmbCurso.Items.Add(item.Nome);
            }
        }
        public void loadTurno()
        {
            cmbTurno.Items.Clear();
            listTurno = new Turno().listTodos();
            foreach (Turno item in listTurno)
            {
                cmbTurno.Items.Add(item.nome);
            }
        }
        public void loadRes()
        {
           
            listRes = new Professor().listTodos();
            cmbRes.Items.Clear();
            foreach (Professor item in listRes)
            {
                cmbRes.Items.Add(item.Funcionario.Nome);
            }
        }




        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (turma==null)
            {
                Turma t = new Turma(txtTurma.Text, listCurso[cmbCurso.SelectedIndex].Id, listClasse[cmbClasse.SelectedIndex].Id, listTurno[cmbTurno.SelectedIndex].Id, listRes[cmbRes.SelectedIndex].Id, AnoLectivo.getLast().Id, listSala[cmbSala.SelectedIndex].Id); ;
                if (t.Insert())
                {
                    int idTurma = Turma.getLast().Id;
                    foreach (TurmaDisciplinaProfessor item in newProfDiscTurma)
                    {
                        item.IdTurma = idTurma;
                        item.inserir();
                    }
                    MessageBox.Show("Inserido com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                turma.Nome = txtTurma.Text;
                turma.IdClasse = listClasse[cmbClasse.SelectedIndex].Id;
                turma.IdCurso = listCurso[cmbCurso.SelectedIndex].Id;
                turma.IdProf = listRes[cmbRes.SelectedIndex].Id;
                turma.IdSala = listSala[cmbSala.SelectedIndex].Id;
                turma.IdTurno = listTurno[cmbTurno.SelectedIndex].Id;
                if (turma.Edit())
                {
                    MessageBox.Show("Editado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }
            
            Close();
        }

        private void cmbRes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<ProfessorDisciplina> profDisc;
        public void loadCombProf()
        {
            cmbProf.Items.Clear();
            profDisc = ProfessorDisciplina.listTodosByDiscId(listCdD[cmbDisci.SelectedIndex].IdDisciplina);
            foreach (ProfessorDisciplina item in profDisc)
            {
                cmbProf.Items.Add(item.Professor.Funcionario.Nome);
            }
        }
        private void cmbDisci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDisci.SelectedIndex >=0)
            {
                loadCombProf();
            }
        }
        List<ProfessorDisciplina> newProfDisc = new List<ProfessorDisciplina>();
        List<TurmaDisciplinaProfessor> newProfDiscTurma = new List<TurmaDisciplinaProfessor>();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
           ////Remover caso aquela disciplina ja estema adicionada
            for (int i = 0; i < newProfDiscTurma.Count; i++)
            {
                if (newProfDiscTurma[i].IdDisciplina == listCdD[cmbDisci.SelectedIndex].IdDisciplina)
                {
                    newProfDiscTurma.RemoveAt(i);
                    lsboxProf.Items.RemoveAt(i);
                }
            }

            //Adiciona o item no listBox e no Array
                newProfDiscTurma.Add(new TurmaDisciplinaProfessor(profDisc[cmbProf.SelectedIndex].IdProfessor, 0 , listCdD[cmbDisci.SelectedIndex].IdDisciplina));
                lsboxProf.Items.Add(cmbProf.SelectedItem.ToString() + " (" + cmbDisci.SelectedItem.ToString() + ")");
            
        }
        List<ClasseDisciplinaCurso> listCdD; 
       
        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasse.SelectedIndex >= 0 && cmbCurso.SelectedIndex>=0)
            {
                cmbDisci.Items.Clear();
                listCdD = ClasseDisciplinaCurso.listForClasseCurso(listCurso[cmbCurso.SelectedIndex].Id, listClasse[cmbClasse.SelectedIndex].Id);
                foreach (ClasseDisciplinaCurso item in listCdD)
                {
                    cmbDisci.Items.Add(item.Disciplina.disciplina);
                }
            }
        }

        private void pnlProf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasse.SelectedIndex >= 0 && cmbCurso.SelectedIndex >= 0)
            {
                cmbDisci.Items.Clear();
                listCdD = ClasseDisciplinaCurso.listForClasseCurso(listCurso[cmbCurso.SelectedIndex].Id, listClasse[cmbClasse.SelectedIndex].Id);
                foreach (ClasseDisciplinaCurso item in listCdD)
                {
                    cmbDisci.Items.Add(item.Disciplina.disciplina);
                }
            }
        }
    }
}
