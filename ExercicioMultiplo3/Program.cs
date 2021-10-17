using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMultiplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo múltiplos de 3:");

            for (int numero = 0; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine( numero + " é divisivel por 3");
                }
            }                
            Console.ReadLine();
        }
    }
}
