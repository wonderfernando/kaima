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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            
        }
        
      
        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
       
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        { 
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrou");
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ImageCheckBox1.Checked)
            {
                guna2ImageCheckBox1.Image = Properties.Resources.nolook;
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                guna2ImageCheckBox1.Image = Properties.Resources.look;
                txtSenha.UseSystemPasswordChar = true;
            }
        }
      //  BUSSINESS.Usuario usuario = new BUSSINESS.Usuario(txtUsuario.Text, txtSenha.Text);
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = Usuario.login(txtUsuario.Text, txtSenha.Text);
            if (usuario!=null)
            {
                new Dashboard(usuario).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario ou senha errado");
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
