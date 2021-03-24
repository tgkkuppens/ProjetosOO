using System;

namespace Laboratorio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta bobNelson = new Conta("12345-6", "Bob Nelson", 0, true);
            Conta testolfoRocha = new Conta("71717-1", "Testolfo Rocha", 0, false);
            Conta lisaLeite = new Conta("65432-1", "Lisa Leite", 0, true);
            bobNelson.DepositarDinheiro(5000f);
            lisaLeite.DepositarDinheiro(2000f);
            testolfoRocha.DepositarDinheiro(1500f);
            bobNelson.Transferir(600, testolfoRocha);
            lisaLeite.SacarDinheiro(250f);
            lisaLeite.Transferir(400f, testolfoRocha);
            testolfoRocha.Transferir(1000f, bobNelson);
            bobNelson.SacarDinheiro(900f);
            bobNelson.Transferir(1500f, lisaLeite);
            testolfoRocha.Transferir(1200f, lisaLeite);
            bobNelson.SacarDinheiro(2000f);
            lisaLeite.DepositarDinheiro(100f);
            testolfoRocha.Transferir(700, bobNelson);
            bobNelson.VerificarSaldo();
            testolfoRocha.VerificarSaldo();
            lisaLeite.VerificarSaldo();


        }
    }
}
