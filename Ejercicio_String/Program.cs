using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        //Pedir el nombre de una persona

        static void Main(string[] args)
        {
            String nombre, ciudad;
            Console.WriteLine("Escribe tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe una ciudad:");
            ciudad = Console.ReadLine();
            Console.WriteLine(" Hola \n" + nombre + " Bienvenido a " + ciudad);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
