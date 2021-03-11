using System;

namespace Exemplo2Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bidu = new Cachorro();
            bidu.nome = "Bidu Da Silva";
            bidu.raca = "Pitbull";
            bidu.genero = "Macho";
            bidu.idade = 3;

            bidu.Latir();
            bidu.AbanarRabo();
        }
    }
}
