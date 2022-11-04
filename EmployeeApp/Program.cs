using EmployeeApp;
using static System.Console;

WriteLine("***** Fun with Encapsulation *****\n");

Employee emp = new("Marvin", 32, 456, 40_000, "00233242343");
WriteLine(emp.Pay);
emp.GiveBonus(1000);
WriteLine(emp.Pay);
emp.DisplayStatus();

emp.Name = "Marv";
WriteLine($"Employee is named: {emp.Name}");
