class Program
{
    static void Sleep3k()
    {
        Console.WriteLine("Sleep1: " + Thread.CurrentThread.ManagedThreadId);
        for (int i = 0; i < 1000000000; i++)
        {
            if (i % 2 == 0)
                Math.Sqrt(i);
        }
        Console.WriteLine("Sleep1 passed.");
    }
    static void Sleep2k()
    {
        Console.WriteLine("Sleep2k: " + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        Console.WriteLine("2k passed.");
    }
    static async Task Sleep4kAsync()
    {
        Console.WriteLine("Sleep4kAsync: " + Thread.CurrentThread.ManagedThreadId);
        await Task.Delay(4000);
        Console.WriteLine("4k passed asyncronacly .");
    }
    static void Main(string[] args)
    {
        Thread threadMethod1 = new Thread(Sleep3k);
        threadMethod1.Start();
        Thread threadMethod2 = new Thread(Sleep2k);
        threadMethod2.Start();
        Sleep4kAsync().Wait();
    }
}