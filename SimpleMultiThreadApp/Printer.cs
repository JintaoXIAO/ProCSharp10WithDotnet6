namespace SimpleMultiThreadApp;

public class Printer
{
  public void PrintNumbers()
  {
    Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
    Console.Write("Your numbers: ");
    for(int i = 0; i < 10; i++)
    {
      Console.Write("{0}, ", i);
      Thread.Sleep(2000);
    }
    Console.WriteLine();
  }
}