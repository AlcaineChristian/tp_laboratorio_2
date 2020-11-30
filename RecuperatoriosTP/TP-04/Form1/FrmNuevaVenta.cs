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
    public delegate bool DelegadoVenta(Ventas ventas);
    public partial class FrmNuevaVenta : Form
    {
        public event DelegadoVenta venta;
        public List<Compras> listaVenta;
        double auxPrecioTotal;


        public double AuxPrecioTotal
        {
            get
            {
                return this.auxPrecioTotal;
            }
        }

        public FrmNuevaVenta()
        {
            InitializeComponent();
            listaVenta = new List<Compras>();
            auxPrecioTotal = 0;
        }



        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {
            this.dgvListaProductos.DataSource = Hardcodeo.listaProductos;

        }



        private void dgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string auxNombre;
            double auxPrecio;
            int idProducto;
            int auxCantidad;
            int auxStock;



            if (int.TryParse(this.txtCantidad.Text, out auxCantidad))
            {

                auxNombre = (string)dgvListaProductos.CurrentRow.Cells["Nombre"].Value;
                auxPrecio = (double)dgvListaProductos.CurrentRow.Cells["Precio"].Value;
                idProducto = (int)dgvListaProductos.CurrentRow.Cells["IdProducto"].Value;
                auxStock = (int)dgvListaProductos.CurrentRow.Cells["Stock"].Value;

                if (Hardcodeo.ValidarCantidad(auxNombre, auxCantidad))
                {



                    listaVenta.Add(new Compras(auxNombre, idProducto, auxPrecio, auxCantidad));


                    for (int i = 0; i < Hardcodeo.listaProductos.Count; i++)
                    {
                        if (auxNombre == Hardcodeo.listaProductos[i].Nombre)
                        {
                            Hardcodeo.listaProductos[i].Stock = Hardcodeo.listaProductos[i].Stock - auxCantidad;
                        }
                    }


                    auxPrecioTotal += (auxPrecio * auxCantidad);
                    lblPrecioTotal.Text = auxPrecioTotal.ToString();
                    this.dgvListaProductos.DataSource = null;
                    this.dgvListaProductos.DataSource = Hardcodeo.listaProductos;
                    this.dgvProductosElegidos.DataSource = null;
                    this.dgvProductosElegidos.DataSource = this.listaVenta;

                }
                else
                {
                    MessageBox.Show("No hay suficiente stock del producto solicitados");
                }

            }
            else
            {
                MessageBox.Show("Por favor, agregue cantidad antes de continuar");
            }

            this.txtCantidad.Clear();
        }







        private void dgvProductosElegidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listaVenta.Count > 0)
            {
                string auxNombre = (string)dgvProductosElegidos.CurrentRow.Cells["Nombre"].Value;
                double auxPrecio = (double)dgvProductosElegidos.CurrentRow.Cells["Precio"].Value;
                int idProducto = (int)dgvProductosElegidos.CurrentRow.Cells["IdProducto"].Value;
                int auxCantidad = (int)dgvProductosElegidos.CurrentRow.Cells["Cantidad"].Value;

                for (int i = 0; i < listaVenta.Count(); i++)
                {
                    if (auxNombre == listaVenta[i].Nombre && auxPrecio == listaVenta[i].Precio && idProducto == listaVenta[i].IdProducto)
                    {
                        listaVenta.Remove(listaVenta[i]);
                        Hardcodeo.listaProductos[i].Stock = Hardcodeo.listaProductos[i].Stock + auxCantidad;
                        auxPrecioTotal = auxPrecioTotal - (auxPrecio * auxCantidad);
                        lblPrecioTotal.Text = auxPrecioTotal.ToString();
                        this.dgvProductosElegidos.DataSource = null;
                        this.dgvProductosElegidos.DataSource = this.listaVenta;
                        this.dgvListaProductos.DataSource = null;
                        this.dgvListaProductos.DataSource = Hardcodeo.listaProductos;
                        break;
                    }
                }


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (listaVenta.Count() == 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Vacie el carrito antes de salir");
            }
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if (auxPrecioTotal > 0)
            { 
                int auxId = Hardcodeo.listaVentas.Count + 1;
                Ventas v = new Ventas(auxPrecioTotal, auxId);

                Hardcodeo.listaVentas.Add(v);
                ManejadorSQL.InstertarVenta(v);

                venta += Ventas.GuardarXml;
                venta.Invoke(v);

                this.dgvProductosElegidos.DataSource = null;
                for (int i = 0; i < listaVenta.Count(); i++)
                {
                    listaVenta.Remove(listaVenta[i]);
                }


                MessageBox.Show("Venta realizada con exito");
                auxPrecioTotal = 0;
                lblPrecioTotal.Text = auxPrecioTotal.ToString();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado productos");
            }
        }
    }
}
