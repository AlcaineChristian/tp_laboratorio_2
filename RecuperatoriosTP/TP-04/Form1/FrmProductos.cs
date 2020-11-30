using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            FrmCargarProductos auxFrm = new FrmCargarProductos();
            auxFrm.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmStock auxFrm = new FrmStock();
            auxFrm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
