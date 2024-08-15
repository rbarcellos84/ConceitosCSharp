using System;

namespace Abstrata
{
    public class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{Nome} está latindo: Au Au!");
        }
        public override void EmitirSom()
        {
            Latir();
        }
    }
}