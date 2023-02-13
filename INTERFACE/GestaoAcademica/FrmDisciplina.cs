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
    public partial class FrmDisciplina : Form
    {
        public FrmDisciplina()
        {
            InitializeComponent();
        }
        public void loadGridView()
        {
             guna2DataGridView1.Rows.Clear();
             guna2DataGridView1.Rows.Add(disci.listTodo().Count);
             int row = 0;
             foreach (Disciplina item in disci.listTodo())
             {
                 guna2DataGridView1.Rows[row].Cells["disciplina"].Value = item.disciplina;
                 row++;
             }
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {

            loadGridView();

            /*
           

            guna2DataGridView1.Rows[0].Cells[0].Value = "Lingua Portuguesa";
            guna2DataGridView1.Rows[0].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[0].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[1].Cells[0].Value = "Matematia";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[1].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[2].Cells[0].Value = "Fisica";
            guna2DataGridView1.Rows[2].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[2].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[3].Cells[0].Value = "Quimica";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[3].Cells[2].Value = "Apagar";

    */
        }
        Disciplina disci = new Disciplina();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmDisciplinaCadastro frmDisciCadastro = new FrmDisciplinaCadastro();
            if (frmDisciCadastro.ShowDialog()== DialogResult.OK)
            {
                loadGridView();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
