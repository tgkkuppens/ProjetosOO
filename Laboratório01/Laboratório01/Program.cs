using System;

namespace Laboratório01
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuário bob = new Usuário("Bob Nelson", 37, 1.70, 78);
            bob.Imc();
            Console.WriteLine("");
            Usuário testolfo = new Usuário("Testolfo Rocha", 43, 1.65, 60);
            testolfo.Imc();
            Console.WriteLine("");
            Usuário lisa = new Usuário("Lisa Leite", 22, 1.72, 92);
            lisa.Imc();
            Console.ReadLine();
        }
    }
}
