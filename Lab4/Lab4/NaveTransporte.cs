using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class NaveTransporte : Nave
    {
        public NaveTransporte(string nome, int nivelCombustivel, int energia, int velocidade, int posicaoX, posicaoY) : base(nome, nivelCombustivel, energia, velocidade, posicaoX, posicaoY)
        {
        }
    }
}
