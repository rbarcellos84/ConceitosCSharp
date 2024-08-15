using System;
using Record;

namespace Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //neste momento eles são diferentes pois as classes estão sendo instanciadas na memoria em posições diferentes mesmo tendo o mesmo conteudo
            var objeto1 = new Objeto{Id = 1, Descricao = "Caderno"};
            var objeto2 = new Objeto{Id = 1, Descricao = "Caderno"};
            //todos os retornos serão false
            Console.WriteLine($"Os cursos são iguai? {objeto1 == objeto2}");
            Console.WriteLine($"Os cursos são iguai? {objeto1.Equals(objeto2)}");

            //depois que implementamos as rotinas de comparação na classe, as mesmas foram capazes de comparar o conteudo do objeto, retornar os valores igual a true
            var curso1 = new Curso{Id = 1, Descricao = "Aula de .Net"};
            var curso2 = new Curso{Id = 1, Descricao = "Aula de .Net"};
            //todos os retornos serão true
            Console.WriteLine($"Os cursos são iguai? {curso1 == curso2}");
            Console.WriteLine($"Os cursos são iguai? {curso1.Equals(curso2)}");

            //se utilizarmos a classe curso como record curso, vai ser possivel comparar o conteudo dos objetos e a resposta seria true
            var curso3 = new Curso{Id = 1, Descricao = "Aula de .Net"};
            var curso4 = new Curso{Id = 1, Descricao = "Aula de .Net"};
            Console.WriteLine($"Os cursos são iguai? {curso3 == curso4}");
            Console.WriteLine($"Os cursos são iguai? {curso3.Equals(curso4)}");
        }
    }
}