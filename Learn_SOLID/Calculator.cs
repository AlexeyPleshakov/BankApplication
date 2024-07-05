using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(ICalculator calculator)
        {
            calculator.CalculateInterest();
        }
    }
}
