using static System.Console;

WriteLine("***** Fun with Enums *****\n");
EmpTypeEnum emp = EmpTypeEnum.Contractor;
AskForBonus(emp);
WriteLine("***** Fun with Enums *****\n");
WriteLine("EmpTypeEnum uses a {0} for storage", Enum.GetUnderlyingType((emp.GetType())));


static void AskForBonus(EmpTypeEnum e)
{
    switch (e)
    {
        case EmpTypeEnum.Manager:
            WriteLine("How about stock options instead?");
            break;
        case EmpTypeEnum.Grunt:
            WriteLine("You have got to be kidding...");
            break;
        case EmpTypeEnum.Contractor:
            WriteLine("You already get enough case...");
            break;
        case EmpTypeEnum.VicePresident:
            WriteLine("VERY GOOD, Sir!");
            break;
    }
}

enum EmpTypeEnum : byte
{
    Manager = 102,
    Grunt = 103,
    Contractor = 104,
    VicePresident = 110
}