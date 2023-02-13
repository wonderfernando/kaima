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
    public partial class FrmCursoCadastrar : Form
    {
        public FrmCursoCadastrar()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //salvar dados no banco;
            int t = listArea[comboFormaca.SelectedIndex].id;
            Curso c = new Curso(txtCurso.Text,1, int.Parse(txtMensalidade.Text.ToString()));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<AreaFormacao> listArea = new List<AreaFormacao>();
        public void loadComboArea()
        {
            comboFormaca.Items.Clear();
            List<AreaFormacao> listArea = new AreaFormacao().listTodos();

            foreach (AreaFormacao item in listArea)
            {
                comboFormaca.Items.Add(item.area);
            }
        }
        private void FrmCursoCadastrar_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadComboArea();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            using (FrmDisciplinaCadastro frmDisci = new FrmDisciplinaCadastro())
            {
                if(frmDisci.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("reload listbox");
                }
               
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
