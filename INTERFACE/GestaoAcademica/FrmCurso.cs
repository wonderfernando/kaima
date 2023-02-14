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

          //  Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper scroll = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(guna2DataGridView1, guna2VScrollBar1, false);
          //  scroll.UpdateScrollBar();
            guna2DataGridView1.Rows.Add(7);

        //    btnApagar.Image = INTERFACE.Properties.Resources.bt;


            guna2DataGridView1.Rows[0].Cells[0].Value = "Informatica";
            guna2DataGridView1.Rows[0].Cells[1].Value = "Area Tecnica";
            guna2DataGridView1.Rows[0].Cells[2].Value = "25.000";
            guna2DataGridView1.Rows[0].Cells[3].Value = "Visualizar";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Deletar";
            guna2DataGridView1.Rows[0].Cells[5].Value = "Apagar";
         
            guna2DataGridView1.Rows[1].Cells[0].Value = "Eletronica e Telecomunicacoes";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Area Tecnica";
            guna2DataGridView1.Rows[1].Cells[2].Value = "25.000";
            guna2DataGridView1.Rows[1].Cells[3].Value = "Visualizar";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Deletar";
            guna2DataGridView1.Rows[1].Cells[5].Value = "Apagar";

            guna2DataGridView1.Rows[2].Cells[0].Value = "Quimica Analitica";
            guna2DataGridView1.Rows[2].Cells[1].Value = "Area Tecnica";
            guna2DataGridView1.Rows[2].Cells[2].Value = "25.000";
            guna2DataGridView1.Rows[2].Cells[3].Value = "Visualizar";
            guna2DataGridView1.Rows[2].Cells[4].Value = "Deletar";
            guna2DataGridView1.Rows[2].Cells[5].Value = "Apagar";

            guna2DataGridView1.Rows[3].Cells[0].Value = "Quimica Insdustrial";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Area Tecnica";
            guna2DataGridView1.Rows[3].Cells[2].Value = "25.000";
            guna2DataGridView1.Rows[3].Cells[3].Value = "Visualizar";
            guna2DataGridView1.Rows[3].Cells[4].Value = "Deletar";
            guna2DataGridView1.Rows[3].Cells[5].Value = "Apagar";

            guna2DataGridView1.Rows[3].Cells[0].Value = "Enfermagem";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Area Saude";
            guna2DataGridView1.Rows[3].Cells[2].Value = "35.000";
            guna2DataGridView1.Rows[3].Cells[3].Value = "Visualizar";
            guna2DataGridView1.Rows[3].Cells[4].Value = "Deletar";
            guna2DataGridView1.Rows[3].Cells[5].Value = "Apagar";

     


    

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
        public void loadDatagrid()
        {
            Curso curso = new Curso();
            int row = 0;
            List<Curso> cursos = curso.listTodo();
            guna2DataGridView1.Rows.Clear();
            if (cursos.Count > 0)
            {
                guna2DataGridView1.Rows.Add(cursos.Count);
                foreach (Curso item in cursos)
                {
                    guna2DataGridView1.Rows[row].Cells["nome"].Value = item.Nome;
                    guna2DataGridView1.Rows[row].Cells["mensalidade"].Value = item.Mensalidade;
                    guna2DataGridView1.Rows[row].Cells["duracao"].Value = item.area.duracao;
                    row++;
                }
            }
            else
            {

            }
        }

    }
}
