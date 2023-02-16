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
    public partial class FrmCursoDisciplinaClasse : Form
    {
      
        public FrmCursoDisciplinaClasse(int idCurso)
        {
            InitializeComponent();
            this.idCurso = idCurso;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCursoDisciplinaClasse_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadComboClasse();
            loadComboDiscipina();
        }
        List<Classe> listClasse = new List<Classe>();
        List<Disciplina> listDisci = new List<Disciplina>();
        List<Disciplina> listDisciClasse = new List<Disciplina>();

        public void loadComboClasse()
        {
            listClasse = new Classe().listTodos();
            foreach (Classe item in listClasse)
            {
                cmbClasse.Items.Add(item.Nome);
            }
        }
        public void loadComboDiscipina()
        {
            listDisci = new Disciplina().listTodo();
            foreach (Disciplina item in listDisci)
            {
                cmbDisci.Items.Add(item.disciplina);
            }

        }
        List<ClasseDisciplinaCurso> listDiscClasse;
        public void loadGird(int idClasse, int idCurso)
        {
            guna2DataGridView1.Rows.Clear();
            listDiscClasse = ClasseDisciplinaCurso.listForClasseCurso(idCurso,idClasse);
            int count = 0;
            if (listDiscClasse.Count>0)
            {
                guna2DataGridView1.Rows.Add(listDiscClasse.Count);
            }
            foreach (ClasseDisciplinaCurso item in listDiscClasse)
            {
                guna2DataGridView1.Rows[count].Cells["nome"].Value = item.Disciplina.disciplina;
                count++;
            }
        }
        int idCurso;
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            bool exists = false;
            if (cmbDisci.SelectedIndex >=0 && cmbClasse.SelectedIndex>=0)
            {
                int idClasse = listClasse[cmbClasse.SelectedIndex].Id;
                int idDisc = listDisci[cmbDisci.SelectedIndex].id;
                foreach (ClasseDisciplinaCurso item in listDiscClasse)
                {
                    if (idClasse == item.IdClasse && idDisc == item.IdDisciplina && idCurso == item.IdCurso)
                    {
                        exists = true;
                    }
                }
                if (exists)
                {
                    MessageBox.Show("Essa disciplina ja esta adicionada");

                }
                else
                {
                    ClasseDisciplinaCurso cdc = new ClasseDisciplinaCurso(idCurso, idClasse, idDisc);
                    if (cdc.inserir())
                    {
                        loadGird(idClasse, idCurso);
                       
                    }
                }
               
            }
        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbClasse.SelectedIndex >= 0)
            {
                loadGird(listClasse[cmbClasse.SelectedIndex].Id, idCurso);
            }
         
        }

        private void cmbDisci_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Deseja remover?","",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    if (listDiscClasse[e.RowIndex].DELETE())
                    {
                        loadGird(listClasse[cmbClasse.SelectedIndex].Id, idCurso);
                    }
                }
            }
        }
    }
}
