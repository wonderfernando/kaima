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
        int Task;
        public FrmAlunoCadastro(int Task)
        {
            InitializeComponent();
            this.Task = Task;
        }
        public FrmAlunoCadastro()
        {
            InitializeComponent();
        }

        private void FrmAlunoCadastro_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
