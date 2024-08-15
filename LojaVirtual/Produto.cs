using System;
using LojaVirtual;

//definição do meu namespace do projeto
namespace LojaVirtual
{
    //definição da classe produto
    public class Produto
    {
        //atributo da minha classe
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public int Codigo { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        //construtor padrão
        public Produto()
        {
            //vazio
        }

        //construtor com parâmetros
        public Produto(string nome, decimal preco, string descricao, int codigo, int quantidadeEmEstoque, string categoria)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Descricao = descricao;
            this.Codigo = codigo;
            this.QuantidadeEmEstoque = quantidadeEmEstoque;
            this.Categoria = categoria;
            this.DataCadastro = DateTime.Now;
            this.Ativo = true;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Produto: {this.Nome}");
            Console.WriteLine($"Código: {this.Codigo}");
            Console.WriteLine($"Preço: R${this.Preco}");
            Console.WriteLine($"Descrição: {this.Descricao}");
            Console.WriteLine($"Quantidade em estoque: {this.QuantidadeEmEstoque}");
            Console.WriteLine($"Categoria: {this.Categoria}");
            Console.WriteLine($"Data de cadastro: {this.DataCadastro}");
            Console.WriteLine($"Ativo: {(this.Ativo ? "Sim" : "Não")}");
        }
    }
}

