using System;

namespace Abstrata
{
    public class Gato : Animal
    {
        public void Miar()
        {
            Console.WriteLine($"{Nome} está miando: Miau! Miau!");
        }

        public override void EmitirSom()
        {
            Miar();
        }
    }
}