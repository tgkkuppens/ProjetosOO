using System;

namespace Exercício3Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto jogoDota = new JogoDigital("Dota 3", 500 , "PC");
            Produto jogoHalfLife = new JogoDigital("Half-Life 3", 3000, "PS§");
            Produto livro1 = new Livro("O Príncipe", 40, "Maquiavel");
            Produto livro2 = new Livro("A Arte da Guerra", 57.90, "Sun Tzu");

            Produto[] produtos = { jogoDota, jogoHalfLife, livro1, livro2 };

            foreach(Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.ReadLine();
            }

        }
    }
}
