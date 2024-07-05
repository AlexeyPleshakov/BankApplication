using Learn_SOLID;

class Program
{
    static void Main()
    {
        OrdinaryAccount ordinaryAccount = new();
        SalaryAccount salaryAccount = new();
        ordinaryAccount.CalculateInterest();
        salaryAccount.CalculateInterest();
    }
}