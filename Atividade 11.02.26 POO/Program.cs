using System;
using System.Globalization;
namespace Atividade_11._02._26_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o numeros de produto a ser adcionado no estoque: ");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atuaizados: " + p);


            Console.WriteLine("Digite o numeros de produto a ser removidos no estoque: ");
            qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atuaizados: " + p);
        }
    }
    }