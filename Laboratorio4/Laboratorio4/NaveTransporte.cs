using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class NaveTransporte : Nave
    {

        public NaveTransporte(string nome, int nivelCombustivel, int energia, int velocidade, int posicaoX, int posicaoY) : base(nome, nivelCombustivel, energia, velocidade, posicaoX, posicaoY)
        {
        }
    }
}
