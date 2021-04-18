using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {

            NaveGuerra bobNelson = new NaveGuerra(1, 2, "Millenium Nelson ", 5, 5, 10, 0, 0);
            Pirata pirata1 = new Pirata("Nave Pirata 1", 10, 1, 1, 0, 3);
            pirata1.MostrarPosicao();
            Pirata pirata2 = new Pirata("Nave Pirata 2", 10, 1, 1, 1, 3);
            pirata2.MostrarPosicao();
            Pirata pirata3 = new Pirata("Nave Pirata 3", 10, 1, 1, 2, 3);
            pirata3.MostrarPosicao();
            bobNelson.MostrarPosicao();
            Asteroide asteroide1 = new Asteroide(5, 0);
            asteroide1.AsteroideSurgiu();
            bobNelson.Mover("direita");
            asteroide1.AsteroideDesviado();
            bobNelson.Atirar();
            pirata2.DanoSofrido(pirata2, "pequeno");
            bobNelson.Mover("direita");
            bobNelson.Atirar();
            pirata3.DanoSofrido(pirata3, "pequeno");
            Asteroide asteroide2 = new Asteroide(5, 2);
            asteroide2.AsteroideSurgiu();
            bobNelson.Mover("esquerda");
            bobNelson.Mover("esquerda");
            asteroide2.AsteroideDesviado();
            bobNelson.Atirar();
            pirata1.DanoSofrido(pirata1, "pequeno");
            Console.WriteLine("Todos os piratas foram derrotados! Parabéns!");
            Console.WriteLine("");

            Console.WriteLine("Um tempo depois");
            Console.ReadKey();

            NaveTransporte bobTransporte = new NaveTransporte("Bob Cargueiro", 10, 6, 2 , 0, 0);
            Pirata navePirata = new Pirata("Nave Pirata", 10, 5, 5, 3, 3);
            navePirata.MostrarPosicao();
            Pirata navePirata1 = new Pirata("Nave Pirata Um", 10, 5, 5, 1, 3);
            navePirata1.MostrarPosicao();
            bobTransporte.MostrarPosicao();
            bobTransporte.Mover("direita");
            navePirata1.Atirar();
            bobTransporte.DanoSofrido(bobTransporte, "pequeno");
            bobTransporte.MostrarEnergia(); 
            navePirata1.Atirar();
            bobTransporte.Mover("direita");
            bobTransporte.Desviar();
            navePirata.Mover("esquerda");
            navePirata.Atirar();
            bobTransporte.DanoSofrido(bobTransporte, "pequeno");
            bobTransporte.MostrarEnergia();
            bobTransporte.Mover("direita");
            Asteroide sergio = new Asteroide(5, 3);
            sergio.AsteroideSurgiu();
            sergio.AsteroideAcertou();
            bobTransporte.DanoSofrido(bobTransporte, "grande");
            bobTransporte.MostrarEnergia();
            Console.WriteLine("Você conseguiu chegar com vida, e entregou a carga! Parabéns");













        }
    }
}
