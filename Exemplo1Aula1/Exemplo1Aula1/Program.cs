using System;

namespace Exemplo1Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cao1 = new Cachorro();
            var cao2 = new Cachorro();
            Cachorro cao3 = new Cachorro();
            var cao4 = new Cachorro();
            var cao5 = new Cachorro();

            Cachorro[] cachorros = { cao1, cao2, cao3, cao4, cao5 };
        }
    }
}
