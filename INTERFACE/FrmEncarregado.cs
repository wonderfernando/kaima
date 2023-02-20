using BUSSINESS;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace INTERFACE
{
    public partial class FrmEncarregado : Form
    {
        public FrmEncarregado()
        {
            InitializeComponent();
        }

        private void FrmEncarregado_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        List<Encarregado> listEncarregado;
        public void loadGrid()
        {
            guna2DataGridView1.Rows.Clear();
            int count = 0;
            listEncarregado = new Encarregado().listTodos();
            if (listEncarregado.Count > 0)
                guna2DataGridView1.Rows.Add(listEncarregado.Count);
            foreach (Encarregado item in listEncarregado)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Nome;
                guna2DataGridView1.Rows[count].Cells["telefone"].Value = item.Telefone;
                guna2DataGridView1.Rows[count].Cells["email"].Value = item.Email;
                guna2DataGridView1.Rows[count].Cells["sexo"].Value = item.Sexo;
                count++;
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 4:
                    FrmEncarregadoCadastro frm = new FrmEncarregadoCadastro(listEncarregado[e.RowIndex]);
                    frm.ShowDialog();
                    loadGrid();
                    break;
                case 5:
                    if (MessageBox.Show("Deseja apagar esse encarregado?","",MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        Encarregado.DELETE(listEncarregado[e.RowIndex].Id);
                        loadGrid();
                    }
                    break;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new FrmEncarregadoCadastro().ShowDialog();
            loadGrid();
        }
    }
}
