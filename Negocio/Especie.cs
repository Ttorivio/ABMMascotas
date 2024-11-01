using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMMascotas.Negocio
{
    public class Especie
    {
        int codigo;
        string nombre;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Especie()
        {
            this.codigo = 0;
            this.nombre = string.Empty;
        }
        public Especie(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return "Codigo: " + Codigo + "Nombre: " + Nombre;
        }
    }
}
