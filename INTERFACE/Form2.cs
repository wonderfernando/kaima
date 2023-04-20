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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            busca();
        }
        List<Propina> listPropinas;
 
        private void Form2_Load(object sender, EventArgs e)
        {
           
         //   loadGrid();
           
            
        }
       
        public async void busca()
        {

            var prop = await Task.Run(()=> new Propina().listToPay());
            load.Visible = false;
            loadGrid(prop);
        } 

        public void loadGrid(List<Propina> list)
        {
           // listPropinas = new Propina().listToPay();

            guna2DataGridView3.Rows.Clear();
            if (list.Count > 0)
            {
                guna2DataGridView3.Rows.Add(list.Count);
            }
            int count = 0;
            float divida = 0;
            foreach (Propina item in list)
            {
                guna2DataGridView3.Rows[count].Cells["vencimento"].Value = item.DataVencimento;
                guna2DataGridView3.Rows[count].Cells["totalpagar"].Value = item.Total;
                guna2DataGridView3.Rows[count].Cells["totalpago"].Value = item.TotalPago;
                guna2DataGridView3.Rows[count].Cells["datapagamento"].Value = item.DataPago;
                guna2DataGridView3.Rows[count].Cells["multa"].Value = item.Multa.multa;
                guna2DataGridView3.Rows[count].Cells["status"].Value = item.Status == 0 ? "Não pago" : "Pago";
                count++;

                if (item.Status == 0)
                    divida += item.Total;
            }
            lblTotal.Text = divida.ToString() + "Kz";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
               
        }
    }
}
