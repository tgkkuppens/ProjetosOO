using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício5Lab3
{
    class Aperitivo : ItemMenu
    {
        float preco; 
        public Aperitivo(string nome) : base(nome)
        {
            

        }

        public float Preco { get => preco; protected set => preco = value; }
    }
}
