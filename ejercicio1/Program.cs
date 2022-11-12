using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("6s Plus","iPhone");
            
            Console.WriteLine("Ingrese el numero telefonico:");
            t1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo de operador: (1,2 o 3)");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine("SU TELEFONO:");
            Console.WriteLine("Marca: " + t1.Marca);
            Console.WriteLine("Modelo: " + t1.Modelo);
            Console.WriteLine("Numero telefonico: " + t1.NumeroTelefonico);
            Console.WriteLine("Codigo Operador: " + t1.CodigoOperador);
            Console.WriteLine();
            Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("Tomi"));
            Console.ReadKey();

        }
    }
}
