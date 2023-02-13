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
            List<Sala> salas = sala.listTodos();
            guna2DataGridView1.Rows.Clear();
            if (salas.Count>0)
            {
                guna2DataGridView1.Rows.Add(salas.Count);
                foreach (Sala item in salas)
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
    }
}
