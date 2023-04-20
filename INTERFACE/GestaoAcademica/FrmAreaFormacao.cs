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


        List<AreaFormacao> list;
        public void loadGridView()
        {
            guna2DataGridView1.Rows.Clear();
            list = area.listTodos();
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
        public void loadGridViewQuery()
        {
            guna2DataGridView1.Rows.Clear();
            list = area.listQuery(guna2TextBox1.Text);
            if (list.Count > 0)
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

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("Tem a certeza que deseja remover ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (new Curso().listTodo().Where(c=>c.areaId== list[e.RowIndex].id).ToList().Count>0)
                    {
                        MessageBox.Show("Não é possivel apagar uma area com cursos ja cadastrados");
                    }
                    else
                    {
                        if (AreaFormacao.Delete(list[e.RowIndex].id))
                        {
                            MessageBox.Show("Apagado do sucesso");
                            loadGridView();
                        }
                    }
                   
                }
            }
            else if (e.ColumnIndex == 2)
            {
                AreaFormacao area = list[e.RowIndex]; 
                FrmAreaFormacaoCadastro frmAreaCadastroEdit = new FrmAreaFormacaoCadastro(area);
                if (frmAreaCadastroEdit.ShowDialog() == DialogResult.OK)
                {
                    loadGridView();
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            loadGridViewQuery();
        }
    }
}
