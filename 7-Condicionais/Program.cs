using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJose = 15;
            int quantidadePessoas = 2;

            if (idadeJose >= 18)
            {
                Console.WriteLine("Jose possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Jose nao possui mais de 18 anos, mas está acompanhado. Pode entrar.");
                }
                else
                {

                    Console.WriteLine("Jose nao possui mais de 18 anos. Não pode entrar.");

                }
            }
            Console.ReadLine();
        }
    }
}
