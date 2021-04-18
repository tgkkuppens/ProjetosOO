using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class NaveGuerra : Nave
    {

        public NaveGuerra(int potenciaTiro, int velocidadeTiro,string nome, int nivelCombustivel, int energia, int velocidade, int posicao) : base(nome, nivelCombustivel, energia, velocidade, posicaoX, posicaoY)
        {
            PotenciaTiro = potenciaTiro;
            VelocidadeTiro = velocidadeTiro;
        }

        public int PotenciaTiro { get; private set; }
        public int VelocidadeTiro { get; private set; }
    }
}
