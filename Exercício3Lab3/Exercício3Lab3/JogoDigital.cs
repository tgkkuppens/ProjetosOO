using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício3Lab3
{
    class JogoDigital : Produto
    {
        public JogoDigital(string titulo, double preco, string console) : base(titulo, preco)
        {
            Plataforma = console;
        }

        public string Plataforma { get; private set; }

        public override void InformarDescricao()
        {
            Console.WriteLine(Titulo + " para " + Plataforma);
        }



    }
}
