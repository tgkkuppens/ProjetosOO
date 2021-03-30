using System;

namespace Exercício5Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida cafezin = new Bebida("Café", 1);
            Console.WriteLine (cafezin.Preco);
            Aperitivo coxinha = new Aperitivo("Coxinha");
            Console.WriteLine(coxinha.Preco);
        }
    }
}
