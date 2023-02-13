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
    public partial class FrmProfessorDisplina : Form
    {
        public FrmProfessorDisplina()
        {
            InitializeComponent();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new FrmDisciplinaAdd().ShowDialog();
        }

        private void FrmProfessorDisplina_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
