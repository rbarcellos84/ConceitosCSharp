using System;

namespace Interface
{
    public class Funcionario : INotificacao
    {
        public string Nome { get; set; }
        public string Mensagem { get; set; }
        public void Notificar()
        {
            Console.WriteLine($"Funcionário {Nome} foi notificado!");
            
            if (!string.IsNullOrEmpty(Mensagem))
                Console.WriteLine($"Mensagem de notificação! {Mensagem}");
        }
    }
}