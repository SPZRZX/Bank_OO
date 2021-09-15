using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente contaDaBarbara = new ContaCorrente(Barbara, 1234, 789, 100.50);
            /*contaDaBarbara.titular = "Barbara";
            contaDaBarbara.agencia = 1234;
            contaDaBarbara.conta = 789;
            contaDaBarbara.saldo = 100.50; */
            ContaCorrente contaDoGabriel = new ContaCorrente(Gabriel, 1234, 987, 120);
            /*contaDoGabriel.titular = "Gabriel";
            contaDoGabriel.agencia = 1234;
            contaDoGabriel.conta = 987;
            contaDoGabriel.saldo = 120; */

           Console.WriteLine("O titular da conta é:" + contaDoGabriel.titular);

           contaDaBarbara.Sacar(50);

           Console.WriteLine("O saldo da conta é de: " + contaDaBarbara.saldo);

           contaDaBarbara.Depositar(150);

        }
    }
}
