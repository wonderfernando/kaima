using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using BUSSINESS;

namespace INTERFACE
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        public void initDate(Propina propina)
        {
      
            objectDataSource1.DataSource = propina;
        }
    }
}
