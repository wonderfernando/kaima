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
    public partial class FrmTurno : Form
    {
        public FrmTurno()
        {
            InitializeComponent();
        }
        
        private void FrmTurno_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        public void loadDatagrid()
        {
            Turno turno = new Turno();
            int row = 0;
            List<Turno> turnos = turno.listTodos();
            guna2DataGridView1.Rows.Clear();
            if (turnos.Count > 0)
            {
                guna2DataGridView1.Rows.Add(turnos.Count);
                foreach (Turno item in turnos)
                {
                    guna2DataGridView1.Rows[row].Cells["nome"].Value = item.nome;
                    guna2DataGridView1.Rows[row].Cells["inicio"].Value = item.inicio;
                    guna2DataGridView1.Rows[row].Cells["final"].Value = item.final;
                    row++;
                }
            }
            else
            {
                
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmTurnoCadastro frm = new FrmTurnoCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadDatagrid();
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o turno");
            }
            
        }
    }
}
