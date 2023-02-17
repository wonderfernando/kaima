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
        List<Disciplina> listDisci;
        public FrmDisciplina()
        {
            InitializeComponent();
        }
        public void loadGridView()
        {
             listDisci = disci.listTodo();
             guna2DataGridView1.Rows.Clear();
             guna2DataGridView1.Rows.Add(listDisci.Count);
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

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    FrmDisciplinaCadastro frmDisciCadastro = new FrmDisciplinaCadastro(listDisci[e.RowIndex]);
                    if (frmDisciCadastro.ShowDialog() == DialogResult.OK)
                    {
                        loadGridView();
                    }
                    break;
                case 2:
                    if (MessageBox.Show("Deseja apagar essa disciplina ?")== DialogResult.OK)
                    {
                        Disciplina.DELETE(listDisci[e.RowIndex].id);
                        loadGridView();
                    }
                    break;
            }
        }
    }
}
