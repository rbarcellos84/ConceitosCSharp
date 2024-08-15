using System;

namespace Abstrata
{
    public class Vaca : Animal
    {
        public void Cantar()
        {
            Console.WriteLine($"{Nome} está cantando: Mu! Mu!");
        }

        public override void EmitirSom()
        {
            Cantar();
        }
    }
}