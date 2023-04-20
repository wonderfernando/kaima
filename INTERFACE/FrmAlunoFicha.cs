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
            /////////////////////////////

            int count = 0;
            listMatricula = Matricula.listForIdAlunoAno(aluno.Id);
            lblEstado.Text = Matricula.listForIdAlunoAno(aluno.Id).Where(m => m.Status == 1).ToList().Count > 0 ? "Matriculado" : "Não matriculado";
            if(listMatricula.Count>0)
            guna2DataGridView2.Rows.Add(listMatricula.Count);
            foreach (Matricula item in listMatricula)
            {
              
                guna2DataGridView2.Rows[count].Cells["numero"].Value = item.Nmatricula;
                guna2DataGridView2.Rows[count].Cells["ano"].Value = AnoLectivo.findId(item.IdAno).Ano;
                guna2DataGridView2.Rows[count].Cells["classe"].Value = item.Turma.Classe.Nome;
                guna2DataGridView2.Rows[count].Cells["curso"].Value = item.Turma.Curso.Nome;
                guna2DataGridView2.Rows[count].Cells["turno"].Value = item.Turma.Turno.nome;
                guna2DataGridView2.Rows[count].Cells["turma"].Value = item.Turma.Turno.nome;
                guna2DataGridView2.Rows[count].Cells["tipo"].Value = item.Tipo;
                guna2DataGridView2.Rows[count].Cells["estado"].Value = item.Status == 0 || item.Status == 2 ? "Não Matriculado" : "Matriculado";

                count++;
            }
            if (Matricula.listForIdAlunoAno(aluno.Id).Where(m => m.Status == 1).ToList().Count > 0)
            {
                btnAnular.Visible = true;
            }
            listProp = Propina.listForAlunoId(aluno.Id);
            loadGrid(listProp);

        }
        List<Propina> listProp;
        List<Matricula> listMatricula;

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

           


        }

        private void guna2DataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Cancelar Matricula")== DialogResult.Yes)
            {
                Matricula.fecharMatricular(aluno.Id);
                
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
      
            if (Matricula.listForIdAlunoAno(aluno.Id).Where(m => m.Status == 1).ToList().Count > 0)
            {
                if (MessageBox.Show("Esse aluno ja se encontra matriculado, deseja continuar mesmo assim")== DialogResult.Yes)
                            {
                  FrmMatriculaCadastro frmMatricula = new FrmMatriculaCadastro();
                  frmMatricula.setAluno(aluno.Id);
                  frmMatricula.ShowDialog();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Matricula.listForIdAlunoAno(aluno.Id).Where(m => m.Status == 1).ToList().Count > 0)
            {
                Matricula.fecharMatricular(aluno.Id);
                lblEstado.Text = "Não Matriculado";
            }
        }
        

        public void loadGrid(List<Propina> propinas)
        {
            guna2DataGridView3.Rows.Clear();
            if (propinas.Count>0)
            {
                guna2DataGridView3.Rows.Add(propinas.Count);
            }
            int count = 0;
            float divida = 0;
            foreach (Propina item in propinas)
            {
                guna2DataGridView3.Rows[count].Cells["vencimento"].Value = item.DataVencimento;
                guna2DataGridView3.Rows[count].Cells["totalpagar"].Value = item.Total;
                guna2DataGridView3.Rows[count].Cells["totalpago"].Value = item.TotalPago;
                guna2DataGridView3.Rows[count].Cells["datapagamento"].Value = item.DataPago;
                guna2DataGridView3.Rows[count].Cells["multa"].Value = item.Multa.multa ;
                guna2DataGridView3.Rows[count].Cells["status"].Value = item.Status == 0 ? "Não pago" : "Pago";
                count++;

                if (item.Status == 0)
                    divida += item.Total;
            }
            lblToPay.Text = divida.ToString()+"Kz";
        }

        private void tabNavigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Quer liquidar essa propina?","",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Propina.Pay(listProp[e.RowIndex].Id, listProp[e.RowIndex].Total);
                listProp = Propina.listForAlunoId(aluno.Id);
                FrmReportView frm = new FrmReportView(Propina.getLast());
                frm.ShowDialog();
                loadGrid(listProp);
            }
        }
    }
}
