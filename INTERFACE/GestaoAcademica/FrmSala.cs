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
    public partial class FrmSala : Form
    {
        public FrmSala()
        {
            InitializeComponent();
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            loadDatagrid();

        }
        Sala sala = new Sala();
        public void loadDatagrid()
        {
            int row = 0;
            listSala = sala.listTodos();
            guna2DataGridView1.Rows.Clear();
            if (listSala.Count>0)
            {
                guna2DataGridView1.Rows.Add(listSala.Count);
                foreach (Sala item in listSala)
                {
                    guna2DataGridView1.Rows[row].Cells["nome"].Value = item.nome;
                    guna2DataGridView1.Rows[row].Cells["capacidade"].Value = item.capacidade;
                    guna2DataGridView1.Rows[row].Cells["tipo"].Value = item.tipo;
                    row++;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma sala cadastrada");
            }
        }
        List<Sala> listSala;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmSalaCadastro frm = new FrmSalaCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadDatagrid();
            }
            else
            {
                MessageBox.Show("Nao foi possivel cadastrar a sala");
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:
                    FrmSalaCadastro frmSalaEdit = new FrmSalaCadastro(listSala[e.RowIndex]);
                    frmSalaEdit.ShowDialog();
                    loadDatagrid();
                    break;
                case 4:
                    if (MessageBox.Show("Deseja apagar essa sala?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Sala.DELETE(listSala[e.RowIndex].Id);
                        loadDatagrid();
                    }
                    break;
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
