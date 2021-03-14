using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratório01
{
    class Usuário
    {
        public string nome;
        public int idade;
        public double altura;
        public int peso;

        public Usuário(string _nome, int _idade, double _altura, int _peso)
        {
            this.nome = _nome;
            this.idade = _idade;
            this.altura = _altura;
            this.peso = _peso;

        }
        public void Imc()
        {
           double imc =  this.peso / (this.altura * this.altura);
            double pesoIdeal = 24.9 * (this.altura * this.altura);


            if ((imc >= 18.5) && (imc <= 24.9))
            {
             Console.WriteLine("Parabéns "+ this.nome+", seu IMC é de: " + imc.ToString("n2") + " e você está em seu peso normal!");
            }
            if ((imc >= 25.0) && (imc <= 29.9))
            {
                Console.WriteLine(this.nome + ", seu IMC é de: " + imc.ToString("n2") + " e você está acima de seu peso ideal."); 
               Console.WriteLine("Seu peso normal seria de, no máximo: " + pesoIdeal.ToString("n2") + "kgs.");
            }
            if ((imc >= 30.0) && (imc <= 34.9))
            {
                Console.WriteLine(this.nome + ", seu IMC é de: " + imc.ToString("n2") + " e você está no nível de obesidade grau I.");
                Console.WriteLine("Seu peso normal seria de, no máximo: " + pesoIdeal.ToString("n2") + "kgs.");
            }
            if ((imc >= 35.0) && (imc <= 39.9))
            {
                Console.WriteLine(this.nome + ", seu IMC é de: " + imc.ToString("n2") + " e você está no nível de obesidade grau II.");
                Console.WriteLine("Seu peso normal seria de, no máximo: " + pesoIdeal.ToString("n2") + "kgs.");
            }
            if (imc >= 40)
            {
                Console.WriteLine(this.nome + ", seu IMC é de: " + imc.ToString("n2") + " e você está nos níveis de obesidade grau III e IV.");
                Console.WriteLine("Seu peso normal seria de, no máximo: " + pesoIdeal.ToString("n2") + "kgs.");
            }
        
        
        
        
        
        }




    }
}
