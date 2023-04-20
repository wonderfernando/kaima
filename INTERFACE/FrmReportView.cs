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
    public partial class FrmReportView : Form
    {
        public FrmReportView(Propina pro)
        {
            InitializeComponent();
            XtraReport1 xr = new XtraReport1();
            xr.initDate(pro);
            xr.CreateDocument();
            documentViewer1.DocumentSource = xr;

        }
    }
}
