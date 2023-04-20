using BUSSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACE
{
    public partial class Dashboard : Form
    {
        Form activeForm;
        public Dashboard(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            label1.Text = usuario.username;
        }
        public Dashboard( )
        {
            InitializeComponent();
  
        }
        Usuario usuario;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            
        }

        private void menuclick(object sender, EventArgs e)
        {

        }
        public void resetButtonMenu(Guna.UI2.WinForms.Guna2Button btn = null)
        {

            btnAdemica.Checked = false;
            btnAdmin.Checked = false;
            btnCurso.Checked = false;
            btnDashboard.Checked = false;
            btnFormacao.Checked = false;
            btnTurma.Checked = false;
            btnRelatorio.Checked = false;
            btnAdemica.Checked = false;
            btnAnoLetivo.Checked = false;
            btnSala.Checked = false;
            btnTurno.Checked = false;

            guna2Button4.Checked = false;

            guna2Button11.Checked = false;
            guna2Button12.Checked = false;

            guna2Button14.Checked = false;
           
            guna2Button3.Checked = false;
            guna2Button1.Checked = false;

            //      guna2Button19.Checked = false;
            //0         guna2Button20.Checked = false;
            guna2Button8.Checked = false;
            btnSala.Checked = false;

            if(btn != null)
            {
                btn.Checked = true;
            }
           
        }

         public void hideSubMenu()
        {
            submenuAcademinc.Visible = false;
            subMenuAdmin.Visible = false;
            submenuRelatorio.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (!guna2Button2.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                openChildForm(new Form2());
            }


        }
     
       public void openForm(Form frmChild)
        {
         //   activeForm = frmChild;
        }
        private void guna2Button12_Click_1(object sender, EventArgs e)
        {
            /*
            if (!guna2Button12.Checked)
            {
                resetButtonMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                submenu.Visible = true;
                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
               // conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                //from.Show();
            }
            else
            {
                hideMenu();
                guna2Button12.Checked = false;
            }*/
              
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        { 
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            /*
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            submenu.Visible = true;
            Form2 from = new Form2();
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            conteiner.Controls.Add(from);
            conteiner.Tag = from;
            from.BringToFront();
            from.Show();*/
        }
        public void showSubmenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                submenu.Visible = true;
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (!btnAdemica.Checked)
            {
                 resetButtonMenu();
                if (submenuAcademinc.Visible == false)
                {
                  
                    hideSubMenu();
                    (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                    showSubmenu(submenuAcademinc);
                }
                else
                {
                   
                    hideSubMenu();
                }
            
            
            }
            else
            {
                hideSubMenu();
                resetButtonMenu();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!btnFormacao.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
                //   conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                // from.Show();
            }
        }

        private void conteiner_Paint(object sender, PaintEventArgs e)
        {

        }
        GestaoAcademica.FrmAreaFormacao frmAreaFormacao = new GestaoAcademica.FrmAreaFormacao();
        Form2 frmDashboard = new Form2();


        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Academica > Area de Formação";
            if (!guna2Button2.Checked)
            {
                resetButtonMenu(btnAdemica);
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                openChildForm(new GestaoAcademica.FrmAreaFormacao());
            }
           
             
        }
      
        public void openChildForm(Form child)
        {
            child.Dock = DockStyle.Fill;
            if (activeForm != null)
            {
                if(activeForm != child)
                {
                    activeForm.Close();
                   // conteiner.Controls.Remove(activeForm);
                   // activeForm.Dispose();

                    child.TopLevel = false;
                    child.Dock = DockStyle.Fill;
                    child.BringToFront();  
                    conteiner.Tag = child;
                    child.FormBorderStyle = FormBorderStyle.None;
                    conteiner.Controls.Add(child);
                    child.Show();
                }   
            }
            else
            {
                child.TopLevel = false;
                child.Dock = DockStyle.Fill;
                child.FormBorderStyle = FormBorderStyle.None;
                child.BringToFront();
                conteiner.Tag = child;
                conteiner.Controls.Add(child);
                child.Show();
            }
            activeForm = child;
        }

        private enum gf
        {
            Masculino ,
            Femenino
        };
        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Academica > Cursos";

            if (!guna2Button2.Checked)
            {
                resetButtonMenu(btnAdemica);

                 (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                 openChildForm(new GestaoAcademica.FrmCurso());
            }
        
            
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Academica > Turmas";

            resetButtonMenu(btnAdemica);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAcademica.FrmTurma());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Academica > Discplinas";

            resetButtonMenu(btnAdemica);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAcademica.FrmDisciplina());
        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Academica > Salas";

            resetButtonMenu(btnAdemica);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAcademica.FrmSala());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
             
                /*
                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
             //   conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                // from.Show();*/

                if (!btnAdmin.Checked)
                {
                    resetButtonMenu();
                    if (subMenuAdmin.Visible == false)
                    {

                        hideSubMenu();
                        (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                        showSubmenu(subMenuAdmin);
                    }
                    else
                    {
                        hideSubMenu();
                    }


                }
                else
                {
                    hideSubMenu();
                    resetButtonMenu();
                }
            }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;

            //so Pra nao dar erro
            if (conteiner.Controls.Count>0)
            {
                activeForm.Dock = DockStyle.Fill;
                openChildForm(activeForm);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          //  conta.Visible = !conta.Visible;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            lblSource.Text = "Alunos";

            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAdministrativa.FrmAluno());

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            if (!guna2Button14.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                /*
            Form2 from = new Form2();
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            conteiner.Controls.Add(from);
            conteiner.Tag = from;
            from.BringToFront();
            from.Show();*/
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            if (!btnRelatorio.Checked)
            {
                resetButtonMenu();
                if (submenuAcademinc.Visible == false)
                {

                    hideSubMenu();
                    (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                    showSubmenu(submenuRelatorio);
                }
                else
                {
                    hideSubMenu();
                }


            }
            else
            {
                hideSubMenu();
                resetButtonMenu();
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTop_DoubleClick(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pnlTop_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void pnlTop_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Administratica > Cargos";

            resetButtonMenu(btnAdmin);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAcademica.FrmCargo());
        }

        private void guna2Button12_Click_2(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Administratica > Funcionarios";

            resetButtonMenu(btnAdmin);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAdministrativa.FrmFuncionario());
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            resetButtonMenu(btnRelatorio);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            resetButtonMenu(btnRelatorio);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            if (guna2ShadowPanel1.Width > 0)
            {
                guna2ShadowPanel1.Width = 0;
            } 
            else
            {
                guna2ShadowPanel1.Width = 323;
            }
            //so Pra nao dar erro
             
            if (conteiner.Controls.Count > 0)
            {

                openChildForm(activeForm);
            }

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

            GestaoAcademica.FrmAnolectvo fromAno = new GestaoAcademica.FrmAnolectvo();
            openChildForm(fromAno);
            /* from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            conteiner.Controls.Add(from);
            conteiner.Tag = from;
            from.BringToFront();
            from.Show(); */

        }

        private void conteiner_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Academica > Turnos";
            resetButtonMenu(btnAdemica);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAcademica.FrmTurno());
        }

        private void btnAnoLetivo_Click(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAcademica.FrmAnolectvo());
        }

        private void btnAnoLetivo_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Academica > Ano Lectivo";

            resetButtonMenu(btnAdemica);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAcademica.FrmAnolectvo());
        }

        private void guna2Button1_Click_3(object sender, EventArgs e)
        {
            lblSource.Text = "Gestão Administratica > Professores";

            resetButtonMenu(btnAdmin);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAdministrativa.FrmProfessor());
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Aluno";
            hideSubMenu();
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAdministrativa.FrmAluno());
        }

        private void guna2Button14_Click_1(object sender, EventArgs e)
        {
            new FrmMatriculaCadastro().ShowDialog();
        }

        private void guna2Button15_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Aluno";
            hideSubMenu();
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAdministrativa.FrmAluno());
        }

        private void btnRelatorio_Click_1(object sender, EventArgs e)
        {
            if (!btnRelatorio.Checked)
            {
                resetButtonMenu();
                if (submenuRelatorio.Visible == false)
                {

                    hideSubMenu();
                    (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                    showSubmenu(submenuRelatorio);
                }
                else
                {
                    hideSubMenu();
                }


            }
            else
            {
                hideSubMenu();
                resetButtonMenu();
            }
        }

        private void guna2Button16_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Aluno";
            hideSubMenu();
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new GestaoAdministrativa.FrmAluno());
        }

        private void guna2Button7_Click_2(object sender, EventArgs e)
        {
            lblSource.Text = "Encarregado";
            hideSubMenu();
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new FrmEncarregado());
        }

        private void btnOculta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            lblSource.Text = "Usuarios";

            resetButtonMenu(btnAdmin);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new FrmUsuario());

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void submenuAcademinc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            new Financeiro.FrmMulta().ShowDialog();
        }

        private void guna2Button15_Click_2(object sender, EventArgs e)
        {
            new Financeiro.FrmMatriculaPayments().ShowDialog();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            lblSource.Text = "Pagementos > Propinas";

            resetButtonMenu(btnAdmin);
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            openChildForm(new Financeiro.FrmPropina());
        }
    }
}
