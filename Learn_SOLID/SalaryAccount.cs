using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    public class SalaryAccount : ICalculator
    {
        public readonly Account account = new();
        public void CalculateInterest()
        {
            account.Interest = account.Balance * 0.5;
            Console.WriteLine("salaryacc");
        }
    }
}
