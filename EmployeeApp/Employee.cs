using System;

namespace EmployeeApp;

public class Employee
{
    private string _empName;
    private int _empId;
    private float _currPay;
    private int _empAge;
    private string _empSSN;
    private EmployeePayTypeEnum _payType;
    private DateTime _hireDate;

    private DateTime HireDate
    {
        get => _hireDate;
        set => _hireDate = value;
    }

    public EmployeePayTypeEnum PayType
    {
        get => _payType;
        set => _payType = value;
    }
    
    public string SocialSecurityNumber
    {
        get => _empSSN; 
        private set => _empSSN = value;
    }
    public int Age
    {
        get => _empAge; 
        set => _empAge = value; 
    }

    public string Name
    {
        get { return _empName; }
        set
        {
            if (value.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = value;
            }
        }
    }

    public int Id
    {
        get { return _empId; }
        set { _empId = value; }
    }

    public float Pay
    {
        get { return _currPay; }
        set { _currPay = value; }
    }

    public Employee(){}

    public Employee(string name, int age, int id, float pay, string ssn)
        : this(name, age, id, pay, ssn, EmployeePayTypeEnum.Salaried, DateTime.Today){}
    public Employee(string name, int age, int id, float pay, string ssn, EmployeePayTypeEnum payType, DateTime hireDate)
    {
        Name = name;
        Id = id;
        Pay = pay;
        Age = age;
        SocialSecurityNumber = ssn;
        PayType = payType;
        HireDate = hireDate;
    }

    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            { PayType: EmployeePayTypeEnum.Commission, HireDate:{ Year: > 2020 }} => Pay += .10F * amount,
            { PayType: EmployeePayTypeEnum.Hourly, HireDate: { Year: > 2020 }} => Pay += 40F * amount / 2080F,
            { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
            _ => Pay += 0,
        };
    }

    public void DisplayStatus()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("ID: {0}", Id);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Pay: {0}", Pay);
    }
}