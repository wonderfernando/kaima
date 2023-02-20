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
    public partial class FrmAluno : Form
    {
        List<Aluno> listAluno;
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (new FrmAlunoCadastro().ShowDialog()== DialogResult.OK)
            {
                loadGrid(listAluno);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            listAluno = new Aluno().listTodos();
            loadGrid(listAluno);
        }
      
        public void loadGrid(List<Aluno> list)
        {
            int count = 0;
            guna2DataGridView1.Rows.Clear();
          
            if (list.Count > 0)
                guna2DataGridView1.Rows.Add(list.Count);
            foreach (Aluno item in list)
            {
                 
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Nome;
                guna2DataGridView1.Rows[count].Cells["telefone"].Value = item.Telefone;
                guna2DataGridView1.Rows[count].Cells["morada"].Value = item.Morada;
                guna2DataGridView1.Rows[count].Cells["sexo"].Value = item.Sexo;
                guna2DataGridView1.Rows[count].Cells["nascimento"].Value = item.DataNascimento;
                guna2DataGridView1.Rows[count].Cells["bi"].Value = item.Bi;
                guna2DataGridView1.Rows[count].Cells["encarregado"].Value = item.Encarregado.Nome;
                count++;
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 7:
                    FrmAlunoCadastro frmAlunoEdit = new FrmAlunoCadastro(listAluno[e.RowIndex]);
                    frmAlunoEdit.ShowDialog();
                    loadGrid(listAluno);
                    break;
                case 8:
                    if (MessageBox.Show("Deseja apagar?","",MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        Aluno.DELETE(listAluno[e.RowIndex].Id);
                        loadGrid(listAluno);
                    }
                    break;
                case 0:
                    new FrmAlunoFicha(listAluno[e.RowIndex]).ShowDialog();
                    break;
            }

        }
        List<Aluno> newListAlunos = new Aluno().listTodos();

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            listAluno = newListAlunos.Where<Aluno>(a => a.Nome.Contains(guna2TextBox1.Text)).ToList();
            loadGrid(listAluno);
        }
    }
}
