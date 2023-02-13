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
    public partial class FrmAnolectvo : Form
    {
        public FrmAnolectvo()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            FrmAnoLetivoCadastro frmAnoLetivoCadastro = new FrmAnoLetivoCadastro();
            if (frmAnoLetivoCadastro.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("reload dataGridView");
                
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void FrmAnolectvo_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(4);

            guna2DataGridView1.Rows[0].Cells[0].Value = "2020/2021";
            guna2DataGridView1.Rows[0].Cells[1].Value = "10/02/2020";
            guna2DataGridView1.Rows[0].Cells[2].Value = "11/10/2020";
            guna2DataGridView1.Rows[0].Cells[3].Value = "Inativo";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Editar";

            guna2DataGridView1.Rows[1].Cells[0].Value = "2022/2023";
            guna2DataGridView1.Rows[1].Cells[1].Value = "10/02/2022";
            guna2DataGridView1.Rows[1].Cells[2].Value = "11/10/2022";
            guna2DataGridView1.Rows[1].Cells[3].Value = "Inativo";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Editar";


            guna2DataGridView1.Rows[2].Cells[0].Value = "2023/2024";
            guna2DataGridView1.Rows[2].Cells[1].Value = "10/02/2023";
            guna2DataGridView1.Rows[2].Cells[2].Value = "11/10/2023";
            guna2DataGridView1.Rows[2].Cells[3].Value = "Inativo";
            guna2DataGridView1.Rows[2].Cells[4].Value = "Editar";


        }
    }
}
