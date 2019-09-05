using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platillo
{
    class Ingredientes
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public Ingredientes(string nombre, string codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
        }
    }
}
