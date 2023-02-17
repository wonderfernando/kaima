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
    public partial class FrmProfessorDisciplinaView : Form
    {
        Professor prof;
        public FrmProfessorDisciplinaView(Professor prof)
        {
            InitializeComponent();
            this.prof = prof;
            guna2ShadowForm1.SetShadowForm(this);
            loadList();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProfessorDisciplinaView_Load(object sender, EventArgs e)
        {
           
        }
        List<TurmaDisciplinaProfessor> listTdP;
        public void loadList()
        {
           // int count = 0;
            foreach (TurmaDisciplinaProfessor item in new TurmaDisciplinaProfessor().listTodo())
            {
                if (item.IdProfessor==prof.Id)
                {
                    listBoxControl1.Items.Add(item.Turma.Nome+ "("+ item.Disciplina.disciplina+")");
                }
            //    count++;
            }
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
