using System;

namespace Abstrata
{
    //minha classe abstrata
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        //metodo que deve ser implementado para que esta herdando essa classe
        public abstract void EmitirSom();
    }
}