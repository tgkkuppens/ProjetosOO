using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class Nave
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

        public int NivelCombustivel { get; protected set; }

        public int Energia { get; protected set; }

        public int Velocidade { get; protected set; }

        public int PosicaoX { get; protected set; }
        public int PosicaoY { get; protected set; }

        

        public virtual void Mover( string direcao)
        { if (NivelCombustivel > 0)
            {
                if (direcao == "direita")
                {
                    PosicaoX++;
                    NivelCombustivel--;
                    Console.WriteLine("Você se moveu para a direita");
                    if (PosicaoX > 3)
                    {
                        Console.WriteLine("Impossível passar daqui");
                        PosicaoX = 3;
                    }
                    Console.WriteLine("Sua posição é: " + PosicaoX + "," + PosicaoY);
                }
                if (direcao == "esquerda")
                {
                    PosicaoX--;
                    NivelCombustivel--;
                    Console.WriteLine("Você se moveu para a esquerda");
                    if (PosicaoX == 0)
                    {
                        Console.WriteLine("Impossivel passar daqui");
                        PosicaoX = 0;
                    }
                    Console.WriteLine("Sua posição é: " + PosicaoX + "," + PosicaoY);
                }
                if (direcao == "cima")
                {
                    PosicaoY++;
                    NivelCombustivel--;
                    Console.WriteLine("Você se moveu para cima");
                    if (PosicaoY > 2)
                    {
                        Console.WriteLine("Impossivel passar daqui");
                        PosicaoY = 2;
                    }
                    Console.WriteLine("Sua posição é: " + PosicaoX + "," + PosicaoY);
                }

                if (direcao == "baixo")
                {
                    PosicaoY--;
                    NivelCombustivel--;
                    Console.WriteLine("Você se moveu para baixo");
                    if (PosicaoY <= 0)
                    {
                        Console.WriteLine("Impossivel passar daqui");
                        PosicaoY = 0;
                    }
                    Console.WriteLine("Sua posição é: " + PosicaoX + "," + PosicaoY);
                }
            }
        if (NivelCombustivel <= 0)
            {
                Console.WriteLine("Você está sem combustível");
            }
        }


        public void DanoSofrido(Nave vitima, string dano)
        {

            if (Energia > 0)
            {
                if (dano == "pequeno")
                {
                    vitima.Energia--;
                    Console.WriteLine("O dano sofrido foi pequeno!");
                }
                if (dano == "medio")
                {
                    vitima.Energia = Energia - 2;
                    Console.WriteLine("O dano sofrido foi médio!");

                }
                if (dano == "grande")
                {
                    vitima.Energia = Energia - 3;
                    Console.WriteLine("O dano sofrido foi grande!");

                }
            }
                if (Energia<=0)
            {
                Console.WriteLine(vitima.Nome+ " explodiu!");
                
            }
                
            
        }

        public void Desviar()
        {
            Console.WriteLine("Tiro desviado!");
        }

        public void MostrarPosicao()
        {
            Console.WriteLine("A posição de "+ Nome+ " é: "+ PosicaoX + "," + PosicaoY);
        }


        public void MostrarEnergia()
        {
            Console.WriteLine("A sua energia está em: " + Energia);

        }

    }
}
