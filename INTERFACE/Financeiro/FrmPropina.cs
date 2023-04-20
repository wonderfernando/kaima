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
    public partial class FrmPropina : Form
    {
        public FrmPropina()
        {
            InitializeComponent();
            listAno = new AnoLectivo().listTodos();
            
            loadGridAno();
        }
        Aluno aluno;
        public void setAluno(Aluno aluno)
        {
            this.aluno = aluno;
            txtAluno.Text = aluno.Nome;
            if (cmbAno.SelectedIndex >= 0 && aluno != null)
            {
                if (cboxPago.Checked && cboxNaoPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).ToList();
                    loadGrid(listPropinas);
                }
                else if (cboxPago.Checked && !cboxNaoPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).Where(p => p.Status == 1).ToList();
                    loadGrid(listPropinas);
                }
                else if (cboxNaoPago.Checked && !cboxPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).Where(p => p.Status == 0).ToList();
                    loadGrid(listPropinas);
                }
                else
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).ToList();
                    loadGrid(listPropinas);
                }
            }
            }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPropina_Load(object sender, EventArgs e)
        {

        }
        List<AnoLectivo> listAno;
         List<Propina> listPropinas;
        public void loadGridAno()
        {
            foreach (AnoLectivo item in listAno)
            {
                cmbAno.Items.Add(item.Ano);
            }
            cmbAno.Text = AnoLectivo.getLast().Ano;
        }
        
        public void loadGrid(List<Propina> propinas)
        {
            guna2DataGridView3.Rows.Clear();
            if (propinas.Count > 0)
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
                guna2DataGridView3.Rows[count].Cells["multa"].Value = item.Multa.multa;
                guna2DataGridView3.Rows[count].Cells["status"].Value = item.Status == 0 ? "Não pago" : "Pago";
                count++;

                if (item.Status == 0)
                    divida += item.Total;
            }
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new FrmAlunoView(this).ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbAno.SelectedIndex >= 0 && aluno != null)
            {
                if (cboxPago.Checked && cboxNaoPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).ToList();
                    loadGrid(listPropinas);
                }
                else if (cboxPago.Checked && !cboxNaoPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).Where(p => p.Status == 1).ToList();
                    loadGrid(listPropinas);
                }
                else if (cboxNaoPago.Checked && !cboxPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).Where(p => p.Status == 0).ToList();
                    loadGrid(listPropinas);
                }
                else
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).ToList();
                    loadGrid(listPropinas);
                }
            }
        }
        private void cboxNaoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbAno.SelectedIndex >= 0 && aluno != null)
            {
                if (cboxPago.Checked && cboxNaoPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).ToList();
                    loadGrid(listPropinas);
                }
                else if (cboxPago.Checked && !cboxNaoPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).Where(p => p.Status == 1 ).ToList();
                    loadGrid(listPropinas);
                }
                else if(cboxNaoPago.Checked && !cboxPago.Checked)
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).Where(p => p.Status == 0).ToList();
                    loadGrid(listPropinas);
                }
                else
                {
                    listPropinas = Propina.listForAlunoId(aluno.Id).ToList();
                    loadGrid(listPropinas);
                }
            }
        }
    }
}
