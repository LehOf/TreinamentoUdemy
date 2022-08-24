using System;
using System.Globalization;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0;
            
            int valorMonetario = int.Parse(Console.ReadLine());
            Console.ReadKey();

            if (valorMonetario >= 100)
            {
                nota100 += 1;
            }
            else if (valorMonetario >= 50 && valorMonetario < 100)
            {
                nota50++;
            }
            else if (valorMonetario >= 20 && valorMonetario < 50)
            {
                nota20++;
            }
            else if (valorMonetario >= 10 && valorMonetario < 20)
            {
                nota10++;
            }
            else if (valorMonetario >= 5 && valorMonetario < 10)
            {
                nota5++;
            }
            else
            {
                nota2++;
            }

            Console.WriteLine($"NOTAS: \n {nota100} nota(s) de R$ 100.00 \n {nota50} nota(s) de R$ 50.00 \n {nota20} nota(s) de R$ 20.00 \n {nota10} nota(s) de R$ 10.00 \n {nota5} nota(s) de R$ 5.00 \n {nota2} nota(s) de R$ 2.00");

        }
    }
}

