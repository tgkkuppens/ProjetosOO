using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class Pirata : Nave
    {
        public Pirata(string nome, int nivelCombustivel, int energia, int velocidade, int posicaoX, int posicaoY) : base(nome, nivelCombustivel, energia, velocidade, posicaoX, posicaoY)
        {

        }
        public void Atirar()
        {
            Console.WriteLine("Pirata atirou!");
        }
    }     
}
