using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliquotaIR

/*Implementar um programa que calcule aliquota de Imposto de Renda conforme as regras:
De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636*/

{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo aliquota do Imposto de renda para o salário");

            double salario = 2000.0;
            double aliquota;

            if (1900.0 < salario && salario < 2800.0)
            {
                aliquota = salario * 0.75;
                Console.WriteLine("Sua aliquota é 7.5% e a dedução é de R$ 142,00");
            }
            else
            {
                if (2800.01 < salario && salario < 3751.0)
                {
                    aliquota = salario * 0.15;
                    Console.WriteLine("Sua aliquota é 15% e a dedução é de R$ 350,00");
                }
                else
                {
                    if (3751.01 < salario  && salario < 4664.0)
                    {
                        aliquota = salario * 0.225;
                        Console.WriteLine("Sua aliquota é 22.5% e a dedução é de R$ 636,00");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
