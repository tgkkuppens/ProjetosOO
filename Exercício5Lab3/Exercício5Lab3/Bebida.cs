using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício5Lab3
{
    class Bebida : ItemMenu
    {
        int tamanho;



        public Bebida(string nome, int tamanho) : base(nome)
        {
            Tamanho = tamanho;

            if (Tamanho == 1)
            {
                Preco = 5;
            }
            if (Tamanho == 2)
            {
                Preco = 10;
            }
            if (Tamanho == 3)
            {
                Preco = 15;
            }
        }

        public int Tamanho { get => tamanho; protected set => tamanho = value; }


    }
}
