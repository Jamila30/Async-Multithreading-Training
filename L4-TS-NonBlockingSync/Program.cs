namespace L4_TS_NonBlockingSync;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Run();
    }

    volatile static int i;//ve belelikle emin ola bilerik ki storageden gelir data
    static volatile int j;//bu yerde de yaza bilerik
    static int k;//volatile keywordu yerine Volatile sinifi isletmek ucun
    private static void Run()
    {
        Thread thread1 = new Thread(() =>
        {
            while (true)
            {
                i++;
                Volatile.Write(ref k, Volatile.Read(ref k) + 1);
            }
        });

        Thread thread2 = new Thread(() =>
        {
            while (true)
            {
                Console.WriteLine(i);//Data register bu hissede kohne datani getire bilir
                 Volatile.Read(ref k);//Volatile Sinifi isledersek
            }
        });
        Thread thread3 = new Thread(() =>
        {
            while (true)
            {
                i--;
                Volatile.Write(ref k, Volatile.Read(ref k) - 1);
            }
        });
        thread1.Start();
        thread2.Start();
        thread3.Start();
    }
}
