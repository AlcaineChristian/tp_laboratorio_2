using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Personas
    {
        string nombre;
        string apellido;

        Personas()
        {
            this.apellido = "";
            this.nombre = "";           
        }
        public Personas(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;            
        }
        public string Apellido
        {
            get 
            { 
                return this.apellido; 
            }
        }
        public string Nombre
        {
            get 
            {
                return this.nombre; 
            }
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.Append($"Apellido: {this.Apellido}");
            

            return sb.ToString();
        }
    }
}
