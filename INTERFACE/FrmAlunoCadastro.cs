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
    public partial class FrmAlunoCadastro : Form
    {
        Aluno aluno;
        public FrmAlunoCadastro(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
            lblText.Text = "EDITAR ALUNO";
            txtNome.Text = aluno.Nome;
            txtTelefone.Text = aluno.Telefone;
            txtMorada.Text = aluno.Morada;
            txtDate.Text = aluno.DataNascimento;
            txtBI.Text = aluno.Bi;
            if (aluno.Img != "")
                guna2PictureBox1.Image = Image.FromFile(aluno.Img);

        }
        public FrmAlunoCadastro()
        {
            InitializeComponent();
        }

        private void FrmAlunoCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadComboEnc();

            if (aluno != null) { 
                cmbEncarregado.Text = aluno.Encarregado.Nome;
                cmbSexo.Text = aluno.Sexo;
            }
        }
        List<Encarregado> listEncarregado;
        string img;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (aluno==null)
            {
                Aluno newAluno = new Aluno(txtNome.Text,txtTelefone.Text,txtMorada.Text,txtDate.Text, cmbSexo.SelectedItem.ToString(),listEncarregado[cmbEncarregado.SelectedIndex].Id,txtBI.Text,img);
                if (newAluno.Insert())
                {
                    MessageBox.Show("Adicionado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                aluno.Nome = txtNome.Text;
                aluno.Telefone = txtTelefone.Text;
                aluno.Morada = txtMorada.Text;
                aluno.Sexo = cmbSexo.SelectedItem.ToString();
                aluno.Bi = txtBI.Text;
                aluno.DataNascimento = txtDate.Text;
                aluno.EncarregadoId = listEncarregado[cmbEncarregado.SelectedIndex].Id;
                if (aluno.Edit())
                {
                    MessageBox.Show("Editado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }

            Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Arquivos de imgem |(*.jpg;*.png;*.jpeg;*.pdf)";
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                img = open.FileName;
                guna2PictureBox1.Image = Image.FromFile(open.FileName);
            }
            if (aluno != null)
                aluno.Img = img;

        }
        string bi;

        public void loadComboEnc()
        {
            listEncarregado = new Encarregado().listTodos();
            cmbEncarregado.Items.Clear();
            foreach (Encarregado item in listEncarregado)
            {
                cmbEncarregado.Items.Add(item.Nome) ;
            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
