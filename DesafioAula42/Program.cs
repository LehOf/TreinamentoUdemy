using System;
using DesafioAula42.Desafio;

namespace DesafioAula42
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "pao";
            int idade = 20;

            Desafio d = new Desafio(nome, idade);

            Console.WriteLine(d.Confere());
        }
    }
}
