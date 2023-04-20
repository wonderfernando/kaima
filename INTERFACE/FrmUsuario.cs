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

namespace INTERFACE
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
              
             loadGrid();
        }
        List<Usuario> listUser;
        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
        public void loadGrid()
        {
            listUser = new Usuario().listTodos();
            guna2DataGridView1.Rows.Clear();
            if (listUser.Count > 0)
                guna2DataGridView1.Rows.Add(listUser.Count);
            int count = 0;
            foreach (Usuario item in listUser)
            {
                guna2DataGridView1.Rows[count].Cells[0].Value = item.username;
                guna2DataGridView1.Rows[count].Cells[1].Value = "********";
                count++;
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==2)
            {
                FrmPayPropina frm = new FrmPayPropina(listUser[e.RowIndex]);
                frm.ShowDialog();
                loadGrid();
            }
            else if (e.ColumnIndex==3)
            {
                if (MessageBox.Show("Gostaria de Apagar esse usuario?","",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    Usuario.DELETE(listUser[e.RowIndex].Id);
                    loadGrid();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmPayPropina frm = new FrmPayPropina();
            frm.ShowDialog();
            loadGrid();
        }
    }
}
