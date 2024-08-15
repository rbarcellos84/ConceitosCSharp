using System;

namespace Interface
{
    public class Cliente : INotificacao
    {
        public string Nome { get; set; }
        public string Mensagem { get; set; }

        public void Notificar()
        {
            Console.WriteLine($"Cliente {Nome} foi notificado!");

            if (!string.IsNullOrEmpty(Mensagem))
                Console.WriteLine($"Mensagem de notificação! {Mensagem}");
        }
    }
}