using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    abstract class Nave
    {
        
        protected Nave(string nome, int nivelCombustivel, int energia, int velocidade, int posicaoX, int posicaoY)
        {
            Nome = nome;
            NivelCombustivel = nivelCombustivel;
            Energia = energia;
            Velocidade = velocidade;
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
        }


        
        

        public string Nome { get; protected set; }

        public int NivelCombustivel { get;protected set; }

        public int Energia { get;protected set; }

        public int Velocidade { get;protected set; }

        public int PosicaoX { get; protected set; }
        public int PosicaoY { get; protected set; }

        public virtual void Mover()
        {

        }


    }
}
