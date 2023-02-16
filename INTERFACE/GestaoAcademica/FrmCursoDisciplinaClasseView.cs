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
    public partial class FrmCursoDisciplinaClasseView : Form
    {
        int idCurso;
        public FrmCursoDisciplinaClasseView(int idCurso)
        {
            InitializeComponent();
            this.idCurso = idCurso;
        }

        private void FrmCursoDisciplinaClasseView_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            loadGrid  ();
        }

        public void loadGrid()
        {
            guna2DataGridView1.Rows.Clear();
            List<ClasseDisciplinaCurso> classe1 = ClasseDisciplinaCurso.listForClasseCurso(idCurso, 1);
            List<ClasseDisciplinaCurso> classe2 = ClasseDisciplinaCurso.listForClasseCurso(idCurso, 2);
            List<ClasseDisciplinaCurso> classe3 = ClasseDisciplinaCurso.listForClasseCurso(idCurso, 3);
            List<ClasseDisciplinaCurso> classe4 = ClasseDisciplinaCurso.listForClasseCurso(idCurso, 4);
          /*  int maior = classe1.Count;
            if (classe2.Count > maior)
            {
                maior = classe2.Count;
            }
            if (classe3.Count>maior)
            {
                maior = classe3.Count;
            }
            if (classe4.Count > maior)
            {
                maior = classe4.Count;
            }
            */
            int maior1 = Math.Max(classe1.Count, classe2.Count);
            int maior2 = Math.Max(classe3.Count,classe4.Count);
            int maior = Math.Max(maior1,maior2);
         
            if(maior>0)
            guna2DataGridView1.Rows.Add(maior);
            int count = 0;

            foreach (ClasseDisciplinaCurso item in classe1)
            {
                guna2DataGridView1.Rows[count].Cells[0].Value = item.Disciplina.disciplina;
                count++;
            }
            count = 0;
            foreach (ClasseDisciplinaCurso item in classe2)
            {
                guna2DataGridView1.Rows[count].Cells[1].Value = item.Disciplina.disciplina;
                    count++; 
            }

            count = 0;
            foreach (ClasseDisciplinaCurso item in classe3)
            {
                guna2DataGridView1.Rows[count].Cells[2].Value = item.Disciplina.disciplina;
                count++;
            }

            count = 0;
            foreach (ClasseDisciplinaCurso item in classe4)
            {
                guna2DataGridView1.Rows[count].Cells[3].Value = item.Disciplina.disciplina;
                count++;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (new FrmCursoDisciplinaClasse(idCurso).ShowDialog() == DialogResult.OK)
            {
                loadGrid();
            }
        }
    }
}
