namespace Empmoyees;

public class SalesPerson : Employee
{
    public int SalesNumber { get; set; }

    public sealed override void GiveBonus(float amount)
    {
        int salesBonus = 0;
        if (SalesNumber >= 0 && SalesNumber <= 100)
        {
            salesBonus = 10;
        }
        else
        {
            salesBonus = 20;
        }
        base.GiveBonus(amount * salesBonus);
    }

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine("Number of Sales: {0}", SalesNumber);
    }

    public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numbOfSales)
        : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Commission)
    {
        SalesNumber = numbOfSales;
    }
    
    public SalesPerson(){}
}