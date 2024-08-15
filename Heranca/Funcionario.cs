using System;

namespace Heranca
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }

        public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Salario: " + this.Salario);
        }
    }
}