using System;
using StaticDataAndMembers;

Console.WriteLine("***** Fun with Static Data *****\n");
SavingsAccount s1 = new(50);
SavingsAccount s2 = new(100);
SavingsAccount s3 = new SavingsAccount(10000.23);

TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();
