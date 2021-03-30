using System;

namespace Exercício5Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida cafezin = new Bebida("Café", 5, 10, 15);
            Bebida energetico = new Bebida("Energético", 10, 20, 30);
            Bebida vitamina = new Bebida("Vitamina de Banana", 8, 15, 20);
            Aperitivo coxinha = new Aperitivo("Coxinha");
            Aperitivo bolovo = new Aperitivo("Bolovo");

            ItemMenu[] menu = { cafezin, energetico, vitamina, coxinha, bolovo };


            foreach (ItemMenu item in menu)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.ReadLine();
            }
        }
    }
}
