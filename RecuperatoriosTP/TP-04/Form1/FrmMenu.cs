using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Form1
{
    public partial class FrmMenu : Form
    {
        SoundPlayer auxSonido;
        string directorio = Directory.GetCurrentDirectory();
        public FrmMenu()
        {
            InitializeComponent();
            auxSonido = new SoundPlayer();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmNuevaVenta frmNuevaVenta = new FrmNuevaVenta();
            frmNuevaVenta.Show();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            ManejadorSQL sql = new ManejadorSQL();
            Hardcodeo.Ventas();
            Hardcodeo.Productos();           
            auxSonido.SoundLocation = String.Concat(directorio, "\\sonido.wav");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmproductos = new FrmProductos();
            frmproductos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            auxSonido.Play();
            this.Hide();
            MessageBox.Show("Gracias vuelva prontos");
            System.Threading.Thread.Sleep(2000);
            Ventas.PrintTicket(ManejadorSQL.ListarVentas());
            this.Close();  
        }
        
    }
}
