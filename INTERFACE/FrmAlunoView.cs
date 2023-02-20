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
    public partial class FrmAlunoView : Form
    {
        public FrmAlunoView()
        {
            InitializeComponent();
        }
        public FrmAlunoView(FrmMatriculaCadastro frmMatriculaC)
        {
            InitializeComponent();
            this.frmMatriculaC = frmMatriculaC;
        }
        List<Aluno> listAluno =  new Aluno().listTodos();
        FrmMatriculaCadastro frmMatriculaC;
        private void FrmAlunoView_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadGrid();
        }
        public void loadGrid()
        {
            int count = 0;
            List<Matricula> listMatricula = new Matricula().listTodos();
            guna2DataGridView1.Rows.Clear();
            if (listAluno.Count>0)
                guna2DataGridView1.Rows.Add(listAluno.Count);
            foreach (Aluno item in listAluno)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Nome;
                guna2DataGridView1.Rows[count].Cells["tel"].Value = item.Telefone;
                guna2DataGridView1.Rows[count].Cells["bi"].Value = item.Bi;
                List<Matricula> listM = listMatricula.Where<Matricula>(m => m.IdAluno == item.Id && m.Status == 1).ToList();
                
                if (listM.Count > 0)
                {
                    guna2DataGridView1.Rows[count].Cells[3].Value = "Matriculado";
                }
                else
                {
                    DataGridViewCellStyle gdvC = new DataGridViewCellStyle();
                    gdvC.ForeColor = Color.Red;
                    guna2DataGridView1.Rows[count].Cells[3].Style = gdvC;
                    guna2DataGridView1.Rows[count].Cells[3].Value = "Não Matriculado";
                }
              
          
                count++;
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                
                if (frmMatriculaC!= null)
                {
                    frmMatriculaC.setAluno(listAluno[e.RowIndex].Id);
                    Close();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            listAluno = new Aluno().listTodos().Where(a => a.Nome.Contains(guna2TextBox1.Text)).ToList();
            loadGrid();
        }
    }
}
