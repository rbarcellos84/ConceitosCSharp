using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente { Nome = "Joaquim", Mensagem = "Parabéns pelo conhecimento!" };
            Funcionario funcionario = new Funcionario { Nome = "Parabéns pela promoção" };

            cliente.Notificar();
            funcionario.Notificar();
        }
    }
}