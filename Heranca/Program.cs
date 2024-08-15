using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulo do sistema
            Titulo titulo = new Titulo();

            //criando uma conta bancária
            Cliente conta = new Cliente();
            conta.Nome = "João da Silva";
            conta.CPF = "123.456.789-10";
            conta.Saldo = 1000;

            //criando um funcionário
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Maria Souza";
            funcionario.CPF = "987.654.321-00";
            funcionario.Salario = 2500;

            // Acessando os atributos herdados
            Console.WriteLine("**********************************");
            titulo.ImprimirTitulo("C");
            conta.Sacar(500);
            conta.Imprimir();
            Console.WriteLine("**********************************");
            titulo.ImprimirTitulo("F");
            funcionario.Imprimir();
            Console.WriteLine("**********************************");
            
        }
    }
}