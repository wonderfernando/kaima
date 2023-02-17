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
    public partial class FrmAnoLetivoCadastro : Form
    {
        AnoLectivo ano;
        public FrmAnoLetivoCadastro()
        {
            InitializeComponent();

        }
        public FrmAnoLetivoCadastro(AnoLectivo ano)
        {
            InitializeComponent();
            this.ano = ano;
            txtAno.Text = ano.Ano;
            txtInicio.Text = ano.DataInicio;
            txtFim.Text = ano.DataFinal;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (ano==null)
            {
                AnoLectivo ano = new AnoLectivo(txtAno.Text,txtInicio.Text, txtFim.Text, 1);
                AnoLectivo a = AnoLectivo.getLast();
                a.Status = 0;
                a.Edit();
                if (ano.Insert())
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Inserido com sucesso");
                }
            }
            else
            {
                ano.Ano = txtAno.Text;
                ano.DataInicio = txtInicio.Text;
                ano.DataFinal = txtFim.Text;
                ano.Edit();
                DialogResult = DialogResult.OK;
            }


            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAnoLetivoCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void dateTimeChartRangeControlClient1_CustomizeSeries(object sender, DevExpress.XtraEditors.ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }

        private void guna2DateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
       
        }
    }
}
