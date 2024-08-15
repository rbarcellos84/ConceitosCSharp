using System;

namespace Record
{
    //o tipo record só pode ser implementado no .net9 e ele tem como objetivo realizar comparações entre objetos, conteudo
    //public record Curso
    public class Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        //para este exemplo, basta decomentar o "public record Curso" e comentar toda a funcionalidade abaixo
        //por default o record ja tem toda essa funcionalidade descrita abaixo de comparação
        public override bool Equals(object? obj)
        {
            //validações
            if (obj == null) return false;

            if (obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }

            return base.Equals(obj);
        }

        public static bool operator == (Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Curso a, Curso b)
        {
            return !(a == b);
        }
    }
}