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

namespace INTERFACE.GestaoAdministrativa
{
    public partial class FrmFuncionarioCadastro : Form
    {
        Funcionario funcionario;
        public FrmFuncionarioCadastro()
        {
            InitializeComponent();

        }
        public FrmFuncionarioCadastro(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
            lblText.Text = "EDITAR FUNCIONARIO";
            txtNome.Text = funcionario.Nome;
            txtEndereco.Text = funcionario.Morada;
            txtTelefone.Text = funcionario.Telefone;
            txtEmail.Text = funcionario.Email;
            panel1.Visible = false;
        }
        List<Disciplina> listDisciplina;
        List<Cargo> listCargo;
        public void loadDisci()
        {
            checkedListBoxControl1.Items.Clear();
            listDisciplina = new Disciplina().listTodo();
            
            foreach (Disciplina item in listDisciplina)
            {
                checkedListBoxControl1.Items.Add(item.disciplina);
            }
        }
        public void loadComboCargo()
        {
            listCargo = new Cargo().listTodos();
            cmbCargo.Items.Clear();
            foreach (Cargo item in listCargo)
            {
                cmbCargo.Items.Add(item.Nome);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (funcionario==null)
            {
                    Funcionario func = new Funcionario(txtNome.Text, txtTelefone.Text, txtEndereco.Text, cmbSexo.SelectedItem.ToString(), listCargo[cmbCargo.SelectedIndex].Id, txtEmail.Text);
                                int idCargo = listCargo[cmbCargo.SelectedIndex].Id;
                                if (func.Insert())
                                {
                                    if (cmbCargo.SelectedIndex == 0)
                                    {
                                        Professor prof = new Professor(Funcionario.getLast().Id); 
                    
                                            if (prof.Insert())
                                            {
                                                int idProf = Professor.getLast().Id;
                                                for (int i = 0; i < checkedListBoxControl1.Items.Count; i++)
                                                {
                                                    if (checkedListBoxControl1.Items[i].CheckState == CheckState.Checked)
                                                    {
                                                        ProfessorDisciplina profDisc = new ProfessorDisciplina(idProf, listDisciplina[i].id);
                                                        profDisc.inserir();
                                                    }
                                                }
                            
                                                MessageBox.Show("Funcionario professor inserido com sucesso ");
                                                DialogResult = DialogResult.OK;
                                             }
                    
                                    }
                                    else
                                    {
                                        
                                        MessageBox.Show("inserido com sucesso");
                                        DialogResult = DialogResult.OK;
                                    }
                            }


            }
            else
            {
                funcionario.Nome = txtNome.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.Morada = txtEndereco.Text;
                funcionario.Sexo = cmbSexo.SelectedItem.ToString();
                funcionario.IdCargo = listCargo[cmbCargo.SelectedIndex].Id;
                if (funcionario.Edit())
                {
                    if (cmbCargo.SelectedIndex == 0)
                    {
                       if (Professor.findByFuncId(funcionario.Id)==null)
                        {
                            Professor prof = new Professor(funcionario.Id);
                            prof.Insert();
                        }

                    }
                    else
                    {
                        Professor.findByFuncId(funcionario.Id).DELETE();
                    }
                    MessageBox.Show("Editado com sucesso");
                    DialogResult = DialogResult.OK;
                }
            }

            Close();
        }

        private void FrmFuncionarioCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadDisci();
            loadComboCargo();
            if (funcionario != null)
            {
                cmbCargo.Text = funcionario.Cargo.Nome;
                cmbSexo.Text = funcionario.Sexo;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
             
            Close();
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(funcionario==null)
            if (cmbCargo.SelectedIndex==0)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
    }
}
