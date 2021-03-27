using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício3Lab3
{
    class Produto
    {
        public Produto(string titulo, double preco)
        {
            Titulo = titulo;
            Preco = preco;
        }

        public string Titulo { get; protected set; }
        public double Preco { get; protected set; }


        public virtual void InformarDescricao()
        {
            Console.WriteLine("Item da loja");
        }

    public void InformarPreco()
        {
            Console.WriteLine("R$" + Preco);
        }



    }
}
