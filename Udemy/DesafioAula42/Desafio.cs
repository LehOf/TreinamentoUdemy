using System;

namespace DesafioAula42
{
    public class Desafio
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Desafio(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Confere()
        {
            if(Nome == "pao")
            {
                Idade += 2;
            }
            else
            {
               Idade -= 2;
            }
        }
    }
}