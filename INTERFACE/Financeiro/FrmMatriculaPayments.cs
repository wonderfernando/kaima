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

namespace INTERFACE.Financeiro
{
    public partial class FrmMatriculaPayments : Form
    {
        public FrmMatriculaPayments()
        {
            InitializeComponent();
        }
        List<MatriculaPayment> listMutriculaPayments;
        public void loadGrid()
        {
            guna2DataGridView1.Rows.Clear();
            int count = 0;
            listMutriculaPayments = new MatriculaPayment().listTodo();
            if (listMutriculaPayments.Count > 0)
                guna2DataGridView1.Rows.Add(listMutriculaPayments.Count);
            foreach (MatriculaPayment item in listMutriculaPayments)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Nome;
              
                guna2DataGridView1.Rows[count].Cells["preco"].Value = item.Preco;
               
                count++;
            }
        }
        private void FrmMatriculaPayments_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadGrid();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==2)
            {
                new FrmMudarpPreco(listMutriculaPayments[e.RowIndex]).ShowDialog();
            }
        }
    }
}
