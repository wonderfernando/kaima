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
    public partial class FrmMultaPropinaEdit : Form
    {
        Multa multa;
         public FrmMultaPropinaEdit(Multa multa)
        {
            InitializeComponent();
            this.multa = multa;
            txtMulta.Text = multa.multa.ToString();
            if (multa.unica==1)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            txtTime.Value = multa.intervalo;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMultaPropinaEdit_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Multa multaEdit = new Multa(multa.Id,float.Parse(txtMulta.Text), radioButton1.Checked == true ? 1 : 0, int.Parse(txtTime.Value.ToString()), multa.nome);
         
            if (multaEdit.Edit())
            {
                DialogResult = DialogResult.OK;
            }
            
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
