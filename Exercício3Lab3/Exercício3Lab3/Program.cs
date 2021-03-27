using System;

namespace Exercício3Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Só deixando claro que não só peguei o código e coloquei aqui sem pensar em nada, 
            //eu acompanhei o desenvolvimento em sala, por isso deixei os mesmos exemplos para não me gerar confusões.
            Produto jogoFifa = new JogoDigital("Fifa 2021", 200, "PS5");
            Produto jogoGoW = new JogoDigital("God of War", 5, "PS2");
            Produto livro1 = new Livro("O Príncipe", 40, "Maquiavel");
            Produto livro2 = new Livro("A Arte da Guerra", 57.90, "Sun Tzu");

            Produto[] produtos = { jogoFifa, jogoGoW, livro1, livro2 };

            foreach(Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.ReadLine();
            }

        }
    }
}
