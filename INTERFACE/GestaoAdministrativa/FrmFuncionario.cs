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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new FrmFuncionarioCadastro().ShowDialog();
            loadGrid();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        List<Funcionario> listFunc;
        public void loadGrid()
        {
            listFunc = new Funcionario().listTodos();
            guna2DataGridView1.Rows.Clear();
            if(listFunc.Count>0)
            guna2DataGridView1.Rows.Add(listFunc.Count);
            int count = 0;
            foreach (Funcionario item in listFunc)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Nome;
                guna2DataGridView1.Rows[count].Cells["telefone"].Value = item.Telefone;
                guna2DataGridView1.Rows[count].Cells["morada"].Value = item.Morada;

                guna2DataGridView1.Rows[count].Cells["sexo"].Value = item.Sexo;
                guna2DataGridView1.Rows[count].Cells["cargo"].Value = item.Cargo.Nome;
                count++;
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    FrmFuncionarioCadastro frmFuncCadastroEdit = new FrmFuncionarioCadastro(listFunc[e.RowIndex]);
                    frmFuncCadastroEdit.ShowDialog();
                    loadGrid();
                    break;
                case 6:
                    if (MessageBox.Show("Deseja Apagar?","", MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        Funcionario.DELETE(listFunc[e.RowIndex].Id);
                        loadGrid();
                    }               
                    break;
            }
        }
    }
}
