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
    public partial class FrmAreaFormacao : Form
    {
        public FrmAreaFormacao()
        {
            InitializeComponent();
        }

        
          
        public void loadGridView()
        {
            guna2DataGridView1.Rows.Clear();
            List<AreaFormacao> list = area.listTodos();
            if (list.Count>0)
            {
                guna2DataGridView1.Rows.Add(list.Count);
                int row = 0;
                foreach (AreaFormacao item in list)
                {
                    guna2DataGridView1.Rows[row].Cells["nome"].Value = item.area;

                    guna2DataGridView1.Rows[row].Cells["duracao"].Value = item.duracao;
                    row++;
                }
            }
           
        }
        AreaFormacao area = new AreaFormacao();

        private void FrmAreaFormacao_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmAreaFormacaoCadastro frmArea = new FrmAreaFormacaoCadastro();
             if (frmArea.ShowDialog() == DialogResult.OK)
            {
                loadGridView();
            }
        }
    }
}
