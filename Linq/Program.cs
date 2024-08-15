using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //where -------------------------------------------------------------------
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Filtrar os números pares
            var numerosPares1 = numeros.Where(num => num % 2 == 0);

            foreach (var numero in numerosPares1)
            {
                Console.WriteLine(numero);
            }

            // Criando uma função de filtro personalizada usando Func<int, bool>
            Func<int, bool> ehPar = num => num % 2 == 0;
            // Filtrando os números pares usando a função personalizada
            var numerosPares2 = numeros.Where(ehPar);

            foreach (var numero in numerosPares2)
            {
                Console.WriteLine(numero);
            }

            // Em modo de consulta
            var numerosPares3 = from n in numeros where n % 2 == 0 select n;

            foreach (var numero in numerosPares3)
            {
                Console.WriteLine(numero);
            }

            //Order By ----------------------------------------------------------------
            List<int> numeros2 = new List<int> { 5, 2, 8, 1, 9 };

            // Ordenando os números em ordem crescente
            var numerosOrdenados1 = numeros2.OrderBy(n => n);

            foreach (var numero in numerosOrdenados1)
            {
                Console.WriteLine(numero);
            }

            // Ordenando os números em ordem crescente
            var numerosOrdenados2 = numeros2.OrderByDescending(n => n);

            foreach (var numero in numerosOrdenados2)
            {
                Console.WriteLine(numero);
            }

            //Take --------------------------------------------------------------------
            List<string> nomes = new List<string> { "Ana", "Bruno", "Carlos", "Daniela", "Eduardo" };

            // Pegando os primeiros 3 nomes
            var primeirosTresNomes = nomes.Take(3);

            foreach (var nome in primeirosTresNomes)
            {
                Console.WriteLine(nome);
            }

            // Utilizando todos os metodos listados acima
            var resultadoMaior = numeros.Where(num => num > 3).OrderBy(num => num).Take(2);

            foreach (var numero in resultadoMaior)
            {
                Console.WriteLine(numero);
            }

            //Count -------------------------------------------------------------------
            // Filtrar os números pares
            var contador = numeros.Count(n => n >= 4);

            Console.WriteLine(contador);

            //First FirstOrDefault ----------------------------------------------------
            var pnumero1 = numeros.OrderBy(n => n).First(n => n > 3);

            Console.WriteLine(pnumero1);

            // Se não coloar o segundo parametro o retorno default zero se colocar o parametro irá retornar o parametro indocado depois da virgula
            var pnumero2 = numeros.OrderBy(n => n).FirstOrDefault(n => n > 3, -1);

            Console.WriteLine(pnumero2);

            //Single SingleOrDefault --------------------------------------------------
            List<int> numeros3 = new List<int> { 1, 2, 3, 4, 5 };

            // Encontrar o único número par
            int numeroPar = numeros3.Single(n => n % 2 == 0);
            Console.WriteLine(numeroPar); // Imprime 2

            // Tentar encontrar um número maior que 10 (nenhum elemento)
            // Isso lançará uma InvalidOperationException
            // int numeroMaiorQueDez = numeros.Single(n => n > 10);

            // Encontrar o único número par ou retornar 0 se não houver
            int primeiroNumeroParOuZero = numeros3.SingleOrDefault(n => n % 2 == 0);
            Console.WriteLine(primeiroNumeroParOuZero); // Imprime 2

            // Tentar encontrar um número maior que 10 (nenhum elemento) e retornar 0
            int numeroMaiorQueDezOuZero = numeros3.SingleOrDefault(n => n > 10);
            Console.WriteLine(numeroMaiorQueDezOuZero); // Imprime 0

            // Criar uma lista com dois números pares
            List<int> numerosPares = new List<int> { 2, 4 };
            // Tentar encontrar o único número par (mais de um elemento)
            // Isso lançará uma InvalidOperationException
            // int unicoNumeroPar = numerosPares.Single(n => n % 2 == 0);

            //Min Max -----------------------------------------------------------------
            List<int> numeros4 = new List<int> { 5, 2, 8, 1, 9 };

            // Encontrando o menor valor
            int menorValor = numeros4.Min();
            Console.WriteLine($"O menor valor é: {menorValor}");

            // Encontrando o maior valor
            int maiorValor = numeros4.Max();
            Console.WriteLine($"O maior valor é: {maiorValor}");
        }
    }
}