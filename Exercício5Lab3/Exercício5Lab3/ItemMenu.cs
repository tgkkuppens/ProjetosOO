using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício5Lab3
{
    class ItemMenu
    {
        string nome;
        float preco;

        public ItemMenu(string nome)
        {
            this.Nome = nome;
            
        }

        public string Nome { get => nome; protected set => nome = value; }
        public float Preco { get => preco; protected set => preco = value; }

        

        public void ImprimirNome()
        {
            Console.WriteLine(Nome);
        }
        public virtual void ImprimirPreco()
        {
            Console.WriteLine("O preço é: R$" + Preco);
        }

        
    }
}
