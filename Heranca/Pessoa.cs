using System;

namespace Heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public virtual void Imprimir()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("CPF: " + this.CPF);
        }
    }
}