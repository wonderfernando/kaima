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
    public partial class FrmTurmaProfessoreView : Form
    {
        Turma turma;
        public FrmTurmaProfessoreView(Turma turma)
        {
            InitializeComponent();
            this.turma = turma;
        }

        List<TurmaDisciplinaProfessor> listTdP;
        private void FrmTurmaProfessoreView_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadGrid();
            loadDiscCombo();
        }

        public void loadGrid()
        {
            listTdP = TurmaDisciplinaProfessor.listTodoForTurmaId(turma.Id);
            listBoxControl1.Items.Clear();
            foreach (TurmaDisciplinaProfessor item in listTdP)
            {
                listBoxControl1.Items.Add(item.Professor.Funcionario.Nome + " ("+ item.Disciplina.disciplina+")");
            }
        }
        public void loadProfCombo()
        {
            
        }
        List<ClasseDisciplinaCurso> listDisc;
        List<ProfessorDisciplina> listProf;
        public void loadDiscCombo()
        {
            cmbDisci.Items.Clear();
            listDisc = ClasseDisciplinaCurso.listForClasseCurso(turma.IdCurso, turma.IdClasse);
            foreach (ClasseDisciplinaCurso item in  listDisc)
            {
                cmbDisci.Items.Add(item.Disciplina.disciplina);
            }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDisci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDisci.SelectedIndex>=0)
            {
                cmb.Items.Clear();
                listProf = ProfessorDisciplina.listTodosByDiscId(listDisc[cmbDisci.SelectedIndex].IdDisciplina);
                foreach (ProfessorDisciplina item in listProf)
                {
                    cmb.Items.Add(item.Professor.Funcionario.Nome);
                }
            }
        }
        List<TurmaDisciplinaProfessor> newTurmaDisci = new List<TurmaDisciplinaProfessor>();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (TurmaDisciplinaProfessor item in listTdP)
            {
                if (item.IdDisciplina == listDisc[cmbDisci.SelectedIndex].IdDisciplina)
                {
                    TurmaDisciplinaProfessor.DELETE(item.Id);
                    listBoxControl1.Items.RemoveAt(count);
                }
                count++;
            }
            new TurmaDisciplinaProfessor(listProf[cmb.SelectedIndex].IdProfessor, turma.Id, listDisc[cmbDisci.SelectedIndex].IdDisciplina).inserir();
            listBoxControl1.Items.Add(cmb.SelectedItem.ToString() + " (" + cmbDisci.SelectedItem.ToString() + ")");
            listTdP = TurmaDisciplinaProfessor.listTodoForTurmaId(turma.Id);
        }
    }
}
