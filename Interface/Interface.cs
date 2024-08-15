using System;

namespace Interface
{
    public interface INotificacao
    {
        string Nome { get; }
        string Mensagem { get; }
        void Notificar();
    }
}