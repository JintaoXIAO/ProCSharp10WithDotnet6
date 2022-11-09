using AddWithThreads;

Console.WriteLine("Adding with thread objects");
Console.WriteLine("ID of thread in Main(): {0}", Environment.CurrentManagedThreadId);

AutoResetEvent _waitHandle = new AutoResetEvent(false);

AddParams ap = new AddParams(10, 10);
Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start((ap, _waitHandle));

_waitHandle.WaitOne();
Console.WriteLine("Other thread is done!");

static void Add(object obj)
{
  var (ap, handle) = obj as Tuple<AddParams, AutoResetEvent>;
  Console.WriteLine("ID of thread in Add(): {0}", Environment.CurrentManagedThreadId);
  Console.WriteLine("{0} + {1} is {2}", ap.a, ap.b, ap.a + ap.b);
  handle.Set();  
}