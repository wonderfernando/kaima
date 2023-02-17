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
                loadGrid();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void FrmAnolectvo_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        List<AnoLectivo> listAnoLetivo;
        public void loadGrid()
        {
            guna2DataGridView1.Rows.Clear();
            int count = 0;
            listAnoLetivo = new AnoLectivo().listTodos();
            if (listAnoLetivo.Count>0)
            {
                guna2DataGridView1.Rows.Add(listAnoLetivo.Count);
            }
            foreach (AnoLectivo item in listAnoLetivo)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Ano;
                guna2DataGridView1.Rows[count].Cells["inicio"].Value = item.DataInicio;
                guna2DataGridView1.Rows[count].Cells["fim"].Value = item.DataFinal;
                guna2DataGridView1.Rows[count].Cells["status"].Value = item.Status == 0 ? "INATIVO" : "ACTIVO";
               
                count++;
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 4:
                    FrmAnoLetivoCadastro frmAnoEdit = new FrmAnoLetivoCadastro(listAnoLetivo[e.RowIndex]);
                    frmAnoEdit.ShowDialog();
                    loadGrid();
                    break;
                case 5:
                    if (MessageBox.Show("Deseja eliminar esse ano letivo? Todos os registros relacionado serão apagados", "",MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        if (AnoLectivo.DELETE(listAnoLetivo[e.RowIndex].Id))
                        {
                            MessageBox.Show("Eliminado com sucesso");
                            loadGrid();
                        }
                      ;
                         
                    }
                    break;
            }
        }
    }
}
