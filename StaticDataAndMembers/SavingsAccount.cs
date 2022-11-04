using System;

namespace StaticDataAndMembers;

public class SavingsAccount
{
    public static double currInterestRate = 0.04;

    public static void SetInterestRate(double newRate)
    {
        currInterestRate = newRate;
    }

    public static double GetInterestRate() => currInterestRate;

    static SavingsAccount()
    {
        Console.WriteLine("In static constructor!");
        currInterestRate = 0.4;
    }
    
    public double currBalance;

    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }

    public static double InterestRate
    {
        get => currInterestRate;
        set => currInterestRate = value;
    }
    
}