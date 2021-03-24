using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio02
{
    class Conta
    {
        string numeroConta;
        string nomeCorrentista;
        float saldoAtual;
        bool contaCorrente;

        public Conta(string numeroConta, string nomeCorrentista, float saldoAtual, bool contaCorrente)
        {
            this.numeroConta = numeroConta;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = saldoAtual;
            this.contaCorrente = contaCorrente;
        }

        public string NumeroConta { get => numeroConta; }
        public string NomeCorrentista { get => nomeCorrentista;  }
        public float SaldoAtual { get => saldoAtual; set => saldoAtual = value; }
        public bool ContaCorrente { get => contaCorrente;   }

        
       



        public void SacarDinheiro(float dinheiroSacado)
        {
            float tarifaSaque = 0f;
            
            
            if (contaCorrente)
            {
                 tarifaSaque = dinheiroSacado * 0.0037f;
            }
            else
            {
                 tarifaSaque = dinheiroSacado * 0.002f;
            }

            if (SaldoAtual < dinheiroSacado + tarifaSaque)
            {
                Console.WriteLine("O seu saldo não pode ser negativo.");
                Console.WriteLine("Operação cancelada.");
                Console.WriteLine("O seu saldo atual é: R$" + SaldoAtual);
            }
            if (SaldoAtual > tarifaSaque + dinheiroSacado)
            {
                saldoAtual = saldoAtual - dinheiroSacado - tarifaSaque;
                Console.WriteLine("Você sacou R$" + dinheiroSacado + ", seu saldo atual é de: R$" + (SaldoAtual - tarifaSaque));
               
            }
            
        }
        public void DepositarDinheiro (float dinheiroDepositado)
        {
            SaldoAtual = SaldoAtual + dinheiroDepositado;
            Console.WriteLine("Você depositou R$" + dinheiroDepositado + " seu saldo total é de: R$" + SaldoAtual);
        }

        public void VerificarSaldo()
        {
            Console.WriteLine( nomeCorrentista + ", o seu saldo é de: R$" + SaldoAtual);
        }

        public void Transferir(float quantidadeTransferida, Conta receptor) 
        {
            float taxaTransferencia = 0;

            if (contaCorrente)
            {
                taxaTransferencia = quantidadeTransferida * 0.001f;
            }
            else
            {
                taxaTransferencia = quantidadeTransferida * 0.0015f;
            }

            if (saldoAtual < quantidadeTransferida + taxaTransferencia)
            {
                Console.WriteLine("Saldo indisponível, operação cancelada.");
            }
            if (saldoAtual >= quantidadeTransferida + taxaTransferencia)
            {
                SaldoAtual -= quantidadeTransferida + taxaTransferencia;
                receptor.saldoAtual += quantidadeTransferida;
                Console.WriteLine("Você transferiu R$" + quantidadeTransferida + "para " + receptor.NomeCorrentista);
            }

        }
    }
}
