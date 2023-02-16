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
    public partial class FrmTurma : Form
    {
        public FrmTurma()
        {
            InitializeComponent();
        }

        private void FrmTurma_Load(object sender, EventArgs e)
        {

            loadGrid();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new FrmTurmaCadastro().ShowDialog();
        }
        List<Turma> listTurma;
        public void loadGrid()
        {
            guna2DataGridView1.Rows.Clear();
            listTurma = new Turma().listTodos();
            if (listTurma.Count>0)
            {
                guna2DataGridView1.Rows.Add(listTurma.Count);
            }
            int count = 0;
            foreach (Turma item in listTurma)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Nome;
                guna2DataGridView1.Rows[count].Cells["curso"].Value = item.Curso.Nome;
                guna2DataGridView1.Rows[count].Cells["classe"].Value = item.Classe.Nome;
                guna2DataGridView1.Rows[count].Cells["turno"].Value = item.Turno.nome;
                guna2DataGridView1.Rows[count].Cells["res"].Value = item.Professor.Funcionario.Nome;
                guna2DataGridView1.Rows[count].Cells["ano"].Value = item.AnoLectivo.Ano;
                guna2DataGridView1.Rows[count].Cells["sala"].Value = item.Sala.nome ;
                count++;
                                     
            }
    
        }
    }
}
