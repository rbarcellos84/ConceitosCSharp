using System;
using LojaVirtual;

namespace LojaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodo statico
            Titulo.ImprimirCabecalho();

            //criando um novo produto
            Produto novoProduto = new Produto();

            Console.Write("Digite o nome do produto: ");
            novoProduto.Nome = Console.ReadLine();
            Console.Write("Digite o Preço do produto: ");
            novoProduto.Preco =  decimal.Parse(Console.ReadLine());
            Console.Write("Digite a descricao do produto: ");
            novoProduto.Descricao = Console.ReadLine();
            Console.Write("Digite o codigo do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o quantidade do produto: ");
            novoProduto.QuantidadeEmEstoque = int.Parse(Console.ReadLine());
            Console.Write("Digite a categoria do produto: ");
            novoProduto.Categoria = Console.ReadLine();

            novoProduto.DataCadastro = DateTime.Now;
            novoProduto.Ativo = true;

            //exibindo as informações do produto cadastrado
            Console.WriteLine("\nProduto cadastrado com sucesso!");
            novoProduto.ExibirInformacoes();
        }
    }
}
