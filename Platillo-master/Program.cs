using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platillo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Platillo> platillos = new List<Platillo>();
            
            Platillo sandwich = new Platillo();
            sandwich.Codigo = "Servido";
            sandwich.Nombre = "Sandwich";
            sandwich.Descripcion = "Muy rico";
            platillos.Add(sandwich);

            Ingredientes Pan1 = new Ingredientes("Pan", "Arriba");
            Ingredientes Jamon = new Ingredientes("Jamón","En medio arriba");
            Ingredientes Queso = new Ingredientes("Queso", "En medio abajo");
            Ingredientes Mayonesa = new Ingredientes("Mayonesa", "Embarrada");
            Ingredientes Pan2 = new Ingredientes("Pan", "Abajo");

            sandwich.Lista.Add(Pan1);
            sandwich.Lista.Add(Jamon);
            sandwich.Lista.Add(Queso);
            sandwich.Lista.Add(Mayonesa);
            sandwich.Lista.Add(Pan2);

            foreach (Platillo platillo in platillos)
            {
                Console.WriteLine("Nombre: " + platillo.Nombre);
                Console.WriteLine("Ciudad: " + platillo.Codigo);
                Console.WriteLine("Entrenador: " + platillo.Nombre);
                Console.WriteLine("Jugadores: " + platillo.Descripcion);
                Console.WriteLine(" ");
                Console.WriteLine("Lista de jugadores: ");
                foreach (Ingredientes ingredientes in platillo.Lista)
                {
                    Console.WriteLine("° " + ingredientes.Nombre);
                }
                Console.WriteLine(" ");
            }


            try
            {
                sandwich.Precio = 21000;
                Console.WriteLine("Precio: $" + sandwich.Precio);
            }

            catch (Exception se)
            {
                Console.WriteLine("Precio menor de $50");
            }
            Console.ReadLine();
        }
    }
}
