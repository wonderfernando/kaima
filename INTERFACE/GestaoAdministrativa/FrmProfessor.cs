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
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new FrmProfessorDisplina().ShowDialog();
        }
        List<Professor> listProf;
        public void loadGrid()
        {
            listProf = new Professor().listTodos();
            int count = 0;
            if (listProf.Count>0)
            {
                guna2DataGridView1.Rows.Add(listProf.Count);
            }
            foreach (Professor item in listProf)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Funcionario.Nome; 
                count++;
            }
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    FrmProfessorDisciplinaView frmProfTurma = new FrmProfessorDisciplinaView(listProf[e.RowIndex]);
                    frmProfTurma.ShowDialog();
                    break;
                case 2:
                    FrmProfessorDisciplina frm = new FrmProfessorDisciplina(listProf[e.RowIndex]);
                    frm.ShowDialog();
                    break;
            }
        }
    }
}
