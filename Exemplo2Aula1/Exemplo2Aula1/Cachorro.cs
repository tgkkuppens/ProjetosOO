using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo2Aula1
{
    class Cachorro
    {
       public string nome;
       public string raca;
       public int idade;
       public string genero; 

        public void AbanarRabo()
        {
            Console.WriteLine("Rabinho balançando!!!");
            Console.ReadLine();
        }
        public void Latir()
        {
            Console.WriteLine("Au Au Au");
            Console.ReadLine();
        }

    }
}
