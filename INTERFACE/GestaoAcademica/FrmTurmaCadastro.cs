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
        public FrmTurmaCadastro()
        {
            InitializeComponent();
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
            loadDisci();
            txtAno.Text = AnoLectivo.getLast().Ano;
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
            Turma t = new Turma(txtTurma.Text, listCurso[cmbCurso.SelectedIndex].Id, listClasse[cmbClasse.SelectedIndex].Id, listTurno[cmbTurno.SelectedIndex].Id, listRes[cmbRes.SelectedIndex].Id, AnoLectivo.getLast().Id, listSala[cmbSala.SelectedIndex].Id); ;
            if (t.Insert())
            {
                MessageBox.Show("Inserido com sucesso");
                DialogResult = DialogResult.OK;
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
            profDisc = ProfessorDisciplina.listTodosByDiscId(listDisciplina[cmbDisci.SelectedIndex].id);
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
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bool exits = false;
           
            for (int i = 0; i < newProfDisc.Count; i++)
            {
                if (newProfDisc[i].IdDisciplina == listDisciplina[cmbDisci.SelectedIndex].id)
                {
                    newProfDisc.RemoveAt(i);
                    lsboxProf.Items.RemoveAt(i);
                }
            }
            
                newProfDisc.Add(new ProfessorDisciplina(profDisc[cmbProf.SelectedIndex].Id, listDisciplina[cmbDisci.SelectedIndex].id));
                lsboxProf.Items.Add(cmbProf.SelectedItem.ToString() + " (" + cmbDisci.SelectedItem.ToString() + ")");
            
        }
    }
}
