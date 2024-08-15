using System;

namespace TipoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite outro número (diferente de zero): ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int resultado = num1 / num2;
                Console.WriteLine("O resultado da divisão é: " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro: Você não digitou um número válido.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
            }
        }
    }
}