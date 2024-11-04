using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Thread t = new Thread(() => {
            DemoThread("Thread 1");
        });
        t.Start();

        Thread t2 = new Thread(() => {
            DemoThread("Thread 2");
        });
        t2.Start();

        Thread t3 = new Thread(() => {
            DemoThread("Thread 3");
        });
        t3.Start();

        Console.ReadLine();
    }

    static void DemoThread(string threadIndex)
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1)); //Giả lập độ trễ
            Console.WriteLine(threadIndex + " - " + i);
        }
    }
}


