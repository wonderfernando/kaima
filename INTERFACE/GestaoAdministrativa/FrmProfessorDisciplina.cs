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
    public partial class FrmProfessorDisciplina : Form
    {
        Professor prof;
        public FrmProfessorDisciplina(Professor prof)
        {
            InitializeComponent();
            this.prof = prof;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProfessorDisciplina_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadComboDisc();
            loadGrid();
        }
        List<Disciplina> listDisc;
        List<ProfessorDisciplina> listDiscProf;
        public void loadComboDisc()
        {
            cmbDisci.Items.Clear();
            listDisc = new Disciplina().listTodo();
            foreach (Disciplina item in listDisc)
            {
                cmbDisci.Items.Add(item.disciplina);
           
            }
        }
        public void loadGrid()
        {
            int count = 0;
            guna2DataGridView1.Rows.Clear();
            listDiscProf = ProfessorDisciplina.listTodosByProfId(prof.Id);
            if (listDisc.Count > 0)
                guna2DataGridView1.Rows.Add(listDiscProf.Count);

      
            foreach (ProfessorDisciplina item in listDiscProf)
            {
                guna2DataGridView1.Rows[count].Cells[0].Value = item.Disciplina.disciplina;
                count++;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bool exists = false;
            foreach (ProfessorDisciplina item in listDiscProf)
            {
                if (item.IdDisciplina == listDisc[cmbDisci.SelectedIndex].id)
                {
                    exists = true;
                }
            }
            if (!exists)
            {
                new ProfessorDisciplina(prof.Id, listDisc[cmbDisci.SelectedIndex].id).inserir();
                loadGrid();
            }
            
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProfessorDisciplina.DELETE(listDiscProf[e.RowIndex].Id);
            loadGrid();
        }
    }
}
