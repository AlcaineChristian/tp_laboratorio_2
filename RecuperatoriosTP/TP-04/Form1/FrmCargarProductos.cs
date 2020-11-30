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
    public partial class FrmCargarProductos : Form
    {
        Producto auxProducto;
        public FrmCargarProductos()
        {
            InitializeComponent();
        }

        private void FrmCargarProductos_Load(object sender, EventArgs e)
        {
            this.cmbTipoProducto.DataSource = Enum.GetValues(typeof(Producto.ETipo));
            txtId.Text = Convert.ToString(Hardcodeo.listaProductos.Count + 1);
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            double precio;
            int stock;
            int id;





            if (double.TryParse(this.txtPrecio.Text, out precio) && precio > 0 && int.TryParse(this.txtStock.Text, out stock)
                && int.TryParse(this.txtId.Text, out id))
            {
                if (this.cmbTipoProducto.SelectedIndex != -1)
                {
                    auxProducto = new Producto(this.txtProdcuto.Text, id, precio, stock, (Producto.ETipo)this.cmbTipoProducto.SelectedValue);

                    if (Hardcodeo.listaProductos + auxProducto)
                    {
                        MessageBox.Show("Producto cargado con exitos");
                        this.txtId.Text = Convert.ToString(Hardcodeo.listaProductos.Count + 1);
                        this.txtProdcuto.Text = "";
                        this.txtPrecio.Text = "";
                        this.txtStock.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Verifique tipo de producto seleccionado");
                }
            }
            else
            {
                MessageBox.Show("Verificar datos ingresados");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
