using System;
using Abstrata;

namespace Abstrato
{
    public class Program
    {
        void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro { Nome = "Rex", Idade = 5 };
            Gato gato = new Gato { Nome = "Mina", Idade = 2 };
            Vaca vaca = new Vaca { Nome = "Piu", Idade = 1 };

            //chamando o método abstrato EmitirSom()
            cachorro.EmitirSom();
            gato.EmitirSom();
            vaca.EmitirSom();
        }
    }
}