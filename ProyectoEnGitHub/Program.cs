using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            Console.Write("Ingrese algo: ");
            string ingreso = Console.ReadLine();
            Console.WriteLine("");
            Console.ReadKey();

            //crear variable y mostrarla
            string nombre = "Roni";
            Console.WriteLine(nombre);

            //crear variable y escribirla
            Console.Write("Ingrese nombre: ");
            string nombre2 = Console.ReadLine();
            Console.ReadKey();

            //verificar entero
            if (int.TryParse(ingreso, out int entero))
            {
                Console.WriteLine($"Es entero! {entero}");
                Console.WriteLine($"Hoy es {DateTime.Now}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"No es entero! {ingreso}");
                Console.WriteLine($"Hoy es {DateTime.Now}");
                Console.ReadKey();
            }

            //pedirle una cadena al usuario hasta que ingrese algo no vacio
            string ingreso2 = "";
            while (string.IsNullOrWhiteSpace(ingreso2))
            {
                Console.WriteLine("Ingrese algo");
                ingreso2 = Console.ReadLine();
            }

            //pedirle una cadena al usuario hasta que ingrese algo no vacio
            string ingreso3 = "";
            do
            {
                Console.WriteLine("Ingrese algo otra vez");
                ingreso3 = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(ingreso3));

        }   
    }
}
