using System;

namespace Heranca
{
    public class Cliente : Pessoa
    {
        public double Saldo { get; set; }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                this.Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Saldo: " + this.Saldo);
        }
    }
}