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
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmCursoCadastrar frmCursoCadastro = new FrmCursoCadastrar();
            if(frmCursoCadastro.ShowDialog() == DialogResult.OK)
            {
                loadDatagrid();
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        List<Curso> cursos;
        public void loadDatagrid()
        {
            Curso curso = new Curso();
            int row = 0;
           cursos = curso.listTodo();
            guna2DataGridView1.Rows.Clear();
            if (cursos.Count > 0)
            {
                guna2DataGridView1.Rows.Add(cursos.Count);
                foreach (Curso item in cursos)
                {
                    guna2DataGridView1.Rows[row].Cells["nome"].Value = item.Nome;
                    guna2DataGridView1.Rows[row].Cells["mensalidade"].Value = item.Mensalidade;
                    guna2DataGridView1.Rows[row].Cells["duracao"].Value = item.area.duracao;
                    guna2DataGridView1.Rows[row].Cells["area"].Value = item.area.area;
                    row++;
                }
            }
            else
            {

            }
        }
        public void loadDatagridQuery()
        {
            Curso curso = new Curso();
            int row = 0;
            cursos = curso.listTodoQuery(guna2TextBox1.Text);
            guna2DataGridView1.Rows.Clear();
            if (cursos.Count > 0)
            {
                guna2DataGridView1.Rows.Add(cursos.Count);
                foreach (Curso item in cursos)
                {
                    guna2DataGridView1.Rows[row].Cells["nome"].Value = item.Nome;
                    guna2DataGridView1.Rows[row].Cells["mensalidade"].Value = item.Mensalidade;
                    guna2DataGridView1.Rows[row].Cells["area"].Value = item.area.area;
                    guna2DataGridView1.Rows[row].Cells["duracao"].Value = item.area.duracao;
                    row++;
                }
            }
            else
            {

            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:

                    FrmCursoCadastrar frmCursoCadastrEdit = new FrmCursoCadastrar(cursos[e.RowIndex]);
                    if (frmCursoCadastrEdit.ShowDialog()== DialogResult.OK)
                    {
                        loadDatagrid();
                    }
                    break;
                case 6:
                        if (MessageBox.Show("Tem a certeza que deseja apagar? ","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                        Curso c = cursos[e.RowIndex];
                            if (Curso.Delete(c.Id))
                            {
                                MessageBox.Show("Curso Apagado");
                                loadDatagrid();
                            }
                        }
                    break;

                case 4:
                      new FrmCursoDisciplinaClasseView(cursos[e.RowIndex].Id).ShowDialog();
                    break;
            }

           
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            loadDatagridQuery();
        }
    }
}
