using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo3Aula1
{
    class Carro
    {
        public string modelo;
        public string cor;
        public int anoFrabricacao;
        public int velocidadeMax;
        public int velocidadeAtual;
        public bool seLigado;

        public Carro(string _modelo, string _cor, int _anoFrabricacao, int _velocidadeMax)
        {
            this.modelo = _modelo;
            this.cor = _cor;
            this.anoFrabricacao = _anoFrabricacao;
            this.velocidadeMax = _velocidadeMax;
            this.velocidadeAtual = 0;
            this.seLigado = false;
        }
        public Carro() { }

        public void Ligar()
        {
            this.seLigado = true;
            Console.WriteLine("Carro ligado!");
            Console.ReadLine();
        }
        public void Acelerar()
        {
            this.velocidadeAtual = velocidadeAtual + 10;
            Console.WriteLine(velocidadeAtual);
            Console.ReadLine();
        }
        public void Frear()
        {
            this.velocidadeAtual = velocidadeAtual - 10;
            Console.WriteLine(velocidadeAtual);
            Console.ReadLine();
        }
    }
}
