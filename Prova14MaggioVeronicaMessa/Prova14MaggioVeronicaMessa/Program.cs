using System;

namespace Prova14MaggioVeronicaMessa
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<CreditCardMovement> creditCards = new Account<CreditCardMovement>();
            Account<TransfertMovement> transfertMovements = new Account<TransfertMovement>();
            Account<CashMovement> cashMovements = new Account<CashMovement>();


            creditCards.Versa(new CreditCardMovement { Tipologia= Tipo.AMEX, NumeroCarta= 12345, Importo = 10000, DataDelMovimento= DateTime.Today });
            //creditCards.Versa(new CreditCardMovement { Tipologia = Tipo.MASTERCARD, NumeroCarta = 34567, Importo = 1000, DataDelMovimento = DateTime.Today });
            //creditCards.Preleva(new CreditCardMovement { Tipologia = Tipo.VISA, NumeroCarta = 7890, Importo = 2000, DataDelMovimento = DateTime.Today });

            //foreach (var credit in creditCards)
            //    Console.WriteLine($"{credit.Importo}");
            //decimal saldo = creditCards.Saldo;
            //Console.WriteLine(saldo);



        }
    }
}
