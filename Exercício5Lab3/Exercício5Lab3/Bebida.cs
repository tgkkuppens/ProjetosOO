using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício5Lab3
{
    class Bebida : ItemMenu
    {
      



        public Bebida(string nome, float valorPequeno, float valorMedio, float valorGrande) : base(nome)
        {
             ValorPequeno = valorPequeno;
             ValorMedio = valorMedio;
            ValorGrande = valorGrande;

        }
        public double ValorPequeno { get; private set; }
        public double ValorMedio { get;private set; }
        public double ValorGrande { get; private set; }

        public override void ImprimirPreco()
        {
            Console.WriteLine("Os preços são: Pequeno - R$"+ ValorPequeno +", Médio - R$" + ValorMedio+ ", Grande - R$" + ValorGrande);
        }



    }
}
