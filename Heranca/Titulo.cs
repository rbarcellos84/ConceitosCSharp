using System;

namespace Heranca
{
    //classe que não pode ser herdada devido ao sealed
    public sealed class Titulo
    {
        public void ImprimirTitulo(string tipo)
        {
            if (tipo.Equals("F"))
                Console.WriteLine("Dados do funcionário:");
            else
                Console.WriteLine("Dados do cliente:");
        }
    }
}