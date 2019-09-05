using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platillo
{
    class Platillo
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public List<Ingredientes> Lista { get; set; }
        private int _precio;
        public Platillo()
        {
            Lista = new List<Ingredientes>();
        }

        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if (value >= 50)
                {
                    _precio = value;
                }

                else
                {
                    throw new Exception("Precio menor a $50");
                }

            }




        }
    }
}
