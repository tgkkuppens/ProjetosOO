using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class Asteroide
    {
        public int Energia { get; protected set; }
        public int Posicao { get; protected set; }

        public Asteroide(int energia, int posicao)
        {
            Energia = energia;
            Posicao = posicao;
        }

        public void AsteroideDesviado()
        {
            Console.WriteLine("Você desviou do asteroide!");
        }

        public void AsteroideAcertou()
        {
            Console.WriteLine("Você foi acertado pelo asteroide!");
        }

        public void AsteroideSurgiu()
        {
            Console.WriteLine("Um asteroide surgiu em X: "+ Posicao);
        }

    }
}
