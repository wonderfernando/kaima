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
    public partial class FrmMulta : Form
    {
        public FrmMulta()
        {
            InitializeComponent();
            loadGrid();
        }
        List<Multa> listMulta;
        public void loadGrid()
        {
            guna2DataGridView1.Rows.Clear();
            int count = 0;
            listMulta = new Multa().listMulta();
            if (listMulta.Count > 0)
                guna2DataGridView1.Rows.Add(listMulta.Count);
            foreach (Multa item in listMulta)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.nome;
                guna2DataGridView1.Rows[count].Cells["multa"].Value = item.multa +" %";
                guna2DataGridView1.Rows[count].Cells["unico"].Value = item.unica==0 ? "Não":"Sim";
                guna2DataGridView1.Rows[count].Cells["periodo"].Value = item.intervalo +" dias";
                count++;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMulta_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                new FrmMultaPropinaEdit(listMulta[e.RowIndex]).ShowDialog();
                loadGrid();
            }
        }
    }

}
