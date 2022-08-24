using System;
using System.Globalization;

namespace DesafioAula41Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produtos: ");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto();
            produto.Nome = Nome;
            produto.Preco = Preco;
            produto.Quantidade = Quantidade;
            Console.WriteLine("");

            Console.WriteLine($"{produto}" );
            Console.WriteLine("");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            Quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(Quantidade);
            Console.WriteLine("");

            Console.WriteLine($"{produto}");
            Console.WriteLine("");

            Console.Write("Digie o número de produtos a ser removido do estoque");
            Quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(Quantidade);
            Console.WriteLine("");

            Console.WriteLine($"{produto}");
        }
    }
}
