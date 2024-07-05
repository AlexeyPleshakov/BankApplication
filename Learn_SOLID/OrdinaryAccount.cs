using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    public class OrdinaryAccount : ICalculator
    {
        public readonly Account account = new();
        public void CalculateInterest()
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
            Console.WriteLine("ordinaryacc");
        }
    }
}
