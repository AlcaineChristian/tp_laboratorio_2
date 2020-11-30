using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Form1
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            CargarStockTotal();
        }
        private void CargarStockTotal()
        {

            this.dgvStock.DataSource = Hardcodeo.listaProductos;
        }
       

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarStockTotal();
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
