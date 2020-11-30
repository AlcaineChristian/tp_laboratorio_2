using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca
{
    public class ManejadorSQL
    {
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        string connectionString = "Server=.\\sqlexpress;Database=VentasDB;Trusted_Connection=True;";

        public ManejadorSQL()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public static void InstertarVenta(Ventas venta)
        {
            try
            {
                string command = "INSERT INTO Ventas(IdVenta,Monto) VALUES (@IdVenta,@Monto);";
                sqlCommand = new SqlCommand(command, sqlConnection);


                sqlCommand.Parameters.AddWithValue("idventa", venta.IdVenta);
                sqlCommand.Parameters.AddWithValue("monto", venta.PrecioTotal);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new ExcepcionesArchivos("Falla al intentar trabajar sobre la base de datos", e);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static List<Ventas> ListarVentas()
        {
            try
            {
                string command = "SELECT * FROM Ventas";

                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Ventas> ventas = new List<Ventas>();
                while (reader.Read())
                {
                    int idVenta = (int)reader["idventa"];
                    double monto = (double)Convert.ToDouble(reader["monto"]);
                    Ventas venta = new Ventas(monto, idVenta);
                    ventas.Add(venta);
                }
                return ventas;
            }
            catch (Exception e)
            {
                throw new ExcepcionesArchivos("Falla al intentar leer sobre la base de datos", e);
            }
            finally
            {
                sqlConnection.Close();
            }


        }

    }
}
