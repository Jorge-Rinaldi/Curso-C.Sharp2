using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefono T1 = new Telefono("GS200", "Samsung");
            Console.WriteLine("El modelo del telefono es: " + T1.modelo + " y la marca es: " + T1.marca);
            Console.WriteLine("Ingrese el telefono al que desea llamar:");
            T1.NumTelefono = (Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de operador:");
            T1.CodOper = int.Parse(Console.ReadLine());
            Console.WriteLine(T1.Llamar());
            Console.WriteLine(T1.Llamar("Negocio"));
            Console.ReadKey();
        }
    }
}
