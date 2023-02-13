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
    public partial class FrmTurma : Form
    {
        public FrmTurma()
        {
            InitializeComponent();
        }

        private void FrmTurma_Load(object sender, EventArgs e)
        {
      
            guna2DataGridView1.Rows.Add(4);
            guna2DataGridView1.Rows[0].Cells[0].Value = "IG10A";
            guna2DataGridView1.Rows[0].Cells[1].Value = "Informarica de Gestão";
            guna2DataGridView1.Rows[0].Cells[2].Value = "10 Classe";
            guna2DataGridView1.Rows[0].Cells[3].Value = "50";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Manha";
            guna2DataGridView1.Rows[0].Cells[5].Value = "Jose Gonsalves";
            guna2DataGridView1.Rows[0].Cells[6].Value = "Ver todos";
            guna2DataGridView1.Rows[0].Cells[7].Value = "Editar";
            guna2DataGridView1.Rows[0].Cells[8].Value = "Apagar";

            guna2DataGridView1.Rows[1].Cells[0].Value = "IG11A";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Informarica de Gestão";
            guna2DataGridView1.Rows[1].Cells[2].Value = "11 Classe";
            guna2DataGridView1.Rows[1].Cells[3].Value = "20";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Tarde";
            guna2DataGridView1.Rows[1].Cells[5].Value = "Manuel Eduardo";
            guna2DataGridView1.Rows[1].Cells[6].Value = "Ver todos";
            guna2DataGridView1.Rows[1].Cells[7].Value = "Editar";
            guna2DataGridView1.Rows[1].Cells[8].Value = "Apagar";

            guna2DataGridView1.Rows[2].Cells[0].Value = "GG10C";
            guna2DataGridView1.Rows[2].Cells[1].Value = "Enfermagem";
            guna2DataGridView1.Rows[2].Cells[2].Value = "10 Classe";
            guna2DataGridView1.Rows[2].Cells[3].Value = "45";
            guna2DataGridView1.Rows[2].Cells[4].Value = "Manha";
            guna2DataGridView1.Rows[2].Cells[5].Value = "Suzarit Manuel";
            guna2DataGridView1.Rows[2].Cells[6].Value = "Ver todos";
            guna2DataGridView1.Rows[2].Cells[7].Value = "Editar";
            guna2DataGridView1.Rows[2].Cells[8].Value = "Apagar";

            guna2DataGridView1.Rows[3].Cells[0].Value = "IG10A";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Informarica de Gestão";
            guna2DataGridView1.Rows[3].Cells[2].Value = "10 Classe";
            guna2DataGridView1.Rows[3].Cells[3].Value = "50";
            guna2DataGridView1.Rows[3].Cells[4].Value = "Manha";
            guna2DataGridView1.Rows[3].Cells[5].Value = "Jose Gonsalves";
            guna2DataGridView1.Rows[3].Cells[6].Value = "Ver todos";
            guna2DataGridView1.Rows[3].Cells[7].Value = "Editar";
            guna2DataGridView1.Rows[3].Cells[8].Value = "Apagar";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new FrmTurmaCadastro().ShowDialog();
        }
    }
}
