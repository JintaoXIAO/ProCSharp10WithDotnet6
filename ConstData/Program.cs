using System;
using ConstData;
using static System.Console;

WriteLine("***** Fun with Const *****\n");
WriteLine("The value of PI is: {0}", MyMathClass.PI);

static void LocalConstStringVariable()
{
    const string fixedStr = "Fixed string Data";
    WriteLine(fixedStr);
}