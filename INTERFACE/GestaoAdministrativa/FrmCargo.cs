using BUSSINESS;
using INTERFACE.GestaoAdministrativa;
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
    public partial class FrmCargo : Form
    {
        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (new GestaoAdministrativa.FrmCargoCadastro().ShowDialog() == DialogResult.OK)
                loadGrid();
        }
        List<Cargo> listCargo;
        Cargo cargo = new Cargo();        
        public void loadGrid()
        {
            guna2DataGridView1.Rows.Clear();
            listCargo = cargo.listTodos();
            if (listCargo.Count>0)
            {
                guna2DataGridView1.Rows.Add(listCargo.Count);
            }
            int count = 0;
            foreach (Cargo item in listCargo)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Nome;
                count++;
            }

        }
        public void loadGridQuery(string txt)
        {
            guna2DataGridView1.Rows.Clear();

            listCargo = cargo.listQuery(txt);
            if (listCargo.Count > 0)
            {
                guna2DataGridView1.Rows.Add(listCargo.Count);
            }
            int count = 0;
            foreach (Cargo item in listCargo)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Nome;
                count++;
            }



        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                FrmCargoCadastro frm = new FrmCargoCadastro(listCargo[e.RowIndex]);
                if (frm.ShowDialog()== DialogResult.OK)
                {
                    loadGrid();
                }
            }
            else if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Tem a certeza que deseja excluir esse cargo ? ","",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    cargo.Id = listCargo[e.RowIndex].Id;
                    if (cargo.Delete())
                    {
                        loadGrid();
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            loadGridQuery(txtSearch.Text);
        }
    }
}
