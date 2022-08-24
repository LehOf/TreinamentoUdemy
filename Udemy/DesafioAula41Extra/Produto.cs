using System;
using System.Globalization;
using System.Collections.Generic;


namespace DesafioAula41Extra
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
           return Quantidade* Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return "Dados do produto: " + Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +  Quantidade + " unidades," 
                + " Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
