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
    public partial class FrmAlunoFicha : Form
    {
        Aluno aluno;
        public FrmAlunoFicha()
        {
            InitializeComponent();
        }
        public FrmAlunoFicha(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlunoFicha_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

            guna2PictureBox1.Image = Image.FromFile(aluno.Img);
            guna2DataGridView1.Rows.Add(8);
            guna2DataGridView1.Rows[0].Cells[0].Value = "Estado";
            guna2DataGridView1.Rows[1].Cells[0].Value = "Nome";
            guna2DataGridView1.Rows[2].Cells[0].Value = "Telefone";
            guna2DataGridView1.Rows[3].Cells[0].Value = "Endereço";
            guna2DataGridView1.Rows[4].Cells[0].Value = "BI";
            guna2DataGridView1.Rows[5].Cells[0].Value = "Data de Nascimento";
            guna2DataGridView1.Rows[6].Cells[0].Value = "Sexo";
            guna2DataGridView1.Rows[7].Cells[0].Value = "Encarregado";

            guna2DataGridView1.Rows[0].Cells[1].Value = Matricula.listForIdAlunoAno(aluno.Id).Where(m => m.Status == 1).ToList().Count > 0 ? "Matriculado": "Não matriculado";
            guna2DataGridView1.Rows[1].Cells[1].Value = aluno.Nome;
            guna2DataGridView1.Rows[2].Cells[1].Value = aluno.Telefone;
            guna2DataGridView1.Rows[3].Cells[1].Value = aluno.Morada;
            guna2DataGridView1.Rows[4].Cells[1].Value = aluno.Bi;
            guna2DataGridView1.Rows[5].Cells[1].Value = aluno.DataNascimento;
            guna2DataGridView1.Rows[6].Cells[1].Value = aluno.Sexo;
            guna2DataGridView1.Rows[7].Cells[1].Value = aluno.Encarregado.Nome;
        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

           


        }
    }
}
