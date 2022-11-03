using static System.Console;

WriteLine("***** Fun with Enums *****\n");
EmpTypeEnum emp = EmpTypeEnum.Contractor;
AskForBonus(emp);
WriteLine("***** Fun with Enums *****\n");
WriteLine("EmpTypeEnum uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
WriteLine("EmpTypeEnum uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpTypeEnum)));

WriteLine("emp is a {0}.", emp.ToString());
WriteLine("{0} = {1}", emp.ToString(), (byte)emp);

WriteLine("**** Fun with Enums ****");
EmpTypeEnum e2 = EmpTypeEnum.Contractor;

DayOfWeek day = DayOfWeek.Monday;
ConsoleColor cc = ConsoleColor.Gray;

EvaluateEnum(e2);
EvaluateEnum(day);
EvaluateEnum(cc);


static void EvaluateEnum(System.Enum e)
{
    WriteLine("=> Information about {0}", e.GetType().Name);
    WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

    Array enumData = Enum.GetValues(e.GetType());
    WriteLine("This enum has {0} members", enumData.Length);
    for (int i = 0; i < enumData.Length; i++)
    {
        WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
    }
}

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