using System;
using System.Threading;

class Program
{
    static Timer _timer;

    static void Main()
    {
        _timer = new Timer(TimerCallback, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));

        Console.WriteLine("Timer started. Press Enter to exit.");
        Console.ReadLine();

        _timer.Dispose();
    }

    static void TimerCallback(object state)
    {
        Console.WriteLine("Timer callback executed at: " + DateTime.Now);
    }
}
