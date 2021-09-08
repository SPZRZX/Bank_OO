using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBarbara = new ContaCorrente();

            contaDaBarbara.titular = "Barbara";
            contaDaBarbara.agencia = 1234;
            contaDaBarbara.conta = 789;
            contaDaBarbara.saldo = 100.50;

            ContaCorrente contaDoGabriel = new ContaCorrente();

            contaDoGabriel.titular = "Gabriel";
            contaDoGabriel.agencia = 1234;
            contaDoGabriel.conta = 987;
            contaDoGabriel.saldo = 120;

           Console.WriteLine("O titular da conta é:" + contaDoGabriel.titular);

        }
    }
}
