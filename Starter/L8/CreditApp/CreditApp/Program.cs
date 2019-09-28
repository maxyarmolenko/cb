using System;
namespace CreditApp
{
    class Program
    {
        static void Loanstatus(int payment)
        {
            Console.WriteLine ("Your payment is {0}", payment); 
            int amountOfDebt = 0;
            if (payment >= 700)
            {
                Console.WriteLine("You haven't any amount of debt", payment);
            }
            if (payment < 700)
            {
                amountOfDebt = 700 - payment;
                Console.WriteLine("Your amountOfDebt is {0}", amountOfDebt);
            }
            if (payment > 700)
            {
                int overpayment = payment - 700;
                Console.WriteLine("Overpayment is {0}", overpayment);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter payment amount");
            int payment;
            int.TryParse(Console.ReadLine(), out payment);
            Loanstatus(payment);
            Console.ReadKey();
        }
    }
}
