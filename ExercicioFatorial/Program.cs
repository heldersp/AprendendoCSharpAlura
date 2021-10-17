using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFatorial
{
    class Program
    {
        /*crie uma nova classe, escreva um for que inicie uma variável n (número atual)
         * como 1 e fatorial (resultado total) como 1.
         * Faça seu laço entre 1 a 10 e calcule o resultado*/
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto de cálculo fatorial de 1 a 10");

            int f = 1;
            for (int n = 1; n <= 20; n++)
            {
                f = f * n;
                Console.WriteLine("O fatorial de " + n + " é: " + f);
            }

            Console.ReadLine();
        }
    }
}
