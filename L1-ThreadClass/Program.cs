//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


#region Thread teyini
//class Programm
//{
//    private static void Main(string[] args)
//    {
//        //Console.WriteLine("Hello world");
//        Thread thread = new Thread(CustomThreadMethod);//Basqa void olan method gondere bilirem cunki delegate-dir
//        //Thread iki cur teyin oluna biler :
//        Thread customThreadWithLambdaExp = new Thread(() =>
//        {
//            Console.WriteLine("Thread added");
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(i);
//            }
//        });

//        //Bele build in metod olan ThreadStart da var bunun Parametrli formasi da var
//        Thread customThreadWithThreadStart = new Thread(new ThreadStart(() =>
//        {
//            Console.WriteLine("Thread start added");
//        }));

//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine("main thread-" + i);
//        }

//        thread.Start();//Baslatmaq ucun
//        customThreadWithLambdaExp.Start();
//        customThreadWithThreadStart.Start();
//    }

//    static void CustomThreadMethod()
//    {
//        Console.WriteLine("AAA");
//    }
//}

#endregion

#region Thread -Id
//class Programm
//{
//    private static void Main(string[] args)
//    {

//        Thread customThreadWithLambdaExp = new Thread(() =>
//        {
//            Console.WriteLine("Thread added");
//        });

//        //Bele build in metod olan ThreadStart da var bunun Parametrli formasi da var
//        Thread customThreadWithThreadStart = new Thread(new ThreadStart(() =>
//        {
//            Console.WriteLine("Thread start added");
//            Console.WriteLine("Worker Thread- System.Environment.CurrentManagedThreadId : {0} ", System.Environment.CurrentManagedThreadId);
//            Console.WriteLine("Worker Thread- AppDomain.GetCurrentThreadId() : {0}", AppDomain.GetCurrentThreadId());//Sehv melumat vere biler ve depricateddir-'AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads)
//            Console.WriteLine("Worker Thread- Thread.CurrentThread.ManagedThreadId : {0}", Thread.CurrentThread.ManagedThreadId);

//        }));


//        //Thread id-ni almaq ucun istifade edile biler: (bu main threadin melumatlari olacaq)
//        Console.WriteLine(" System.Environment.CurrentManagedThreadId : {0} ", System.Environment.CurrentManagedThreadId);
//        Console.WriteLine(" AppDomain.GetCurrentThreadId() : {0}", AppDomain.GetCurrentThreadId());//Sehv melumat vere biler ve depricateddir-'AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads)
//        Console.WriteLine(" Thread.CurrentThread.ManagedThreadId : {0}", Thread.CurrentThread.ManagedThreadId);

//        Console.WriteLine("customThreadWithThreadStart-in id-si: " + customThreadWithThreadStart.ManagedThreadId.ToString());
//        customThreadWithLambdaExp.Start();
//        customThreadWithThreadStart.Start();
//    }
//}
#endregion

#region Thread IsBackgorund
//class Programm
//{
//    private static void Main(string[] args)
//    {

//        Thread customThreadWithBackground = new Thread(() =>
//        {
//            Console.WriteLine("Background thread");
//            for (int i = 10; i > 0; i--)
//            {
//                Thread.Sleep(2000);
//            }
//            Console.WriteLine("Background thread isini bitirdi");
//        });

//        Thread customThreadWithoutBackgorund = new Thread(new ThreadStart(() =>
//        {
//            Console.WriteLine("Foreground Thread");
//            for (int i = 10; i > 0; i--)
//            {
//                Thread.Sleep(2000);
//            }
//            Console.WriteLine("Foreground thread isini bitirdi");
//        }));


//        customThreadWithBackground.IsBackground = true;//main thred ile birge islesin deyirik, main thread dayansa bu threadde isi dayandirir.Default false-deyeridir.
//        customThreadWithoutBackgorund.IsBackground = false;
//        customThreadWithBackground.Start();
//        customThreadWithoutBackgorund.Start();
//        Console.WriteLine("Main thread bitirdi;");
//    }
//}
#endregion

#region Thread State

//Thread customThread = new Thread(() =>
//{
//    Console.WriteLine("Worker Thread started");
//    for (int i = 10; i > 0; i--)
//    {
//        Thread.Sleep(2000);
//    }
//    Console.WriteLine("Worker Thread finished");
//});

//Console.WriteLine("Worker thread state1 : {0}", customThread.ThreadState);

//customThread.Start();
//while (true)
//{
//    var state = customThread.ThreadState;

//    if ((state & ThreadState.Stopped) != 0)
//        break; // stopped bayrağı varsa, çıx

//    if ((state & ThreadState.WaitSleepJoin) != 0)
//        Console.WriteLine("Worker thread state : WaitSleepJoin");
//    else if ((state & ThreadState.Running) != 0)
//        Console.WriteLine("Worker thread state : Running");
//    else
//        Console.WriteLine("Worker thread state : " + state);

//    Thread.Sleep(500); // çox sıx yoxlama, CPU yüklənməsin
//}

//Console.WriteLine("Worker thread state : {0}",customThread.ThreadState);
//Console.WriteLine("Main thread finsihed");

#endregion

#region Race Condition - Thread Lock / Thread.Sleep() / .Join()

//object _locking = new object();

//int i = 1;
//Thread customThreadIncrease = new Thread(() =>
//{
//    lock (_locking)
//    {
//        while (i <= 10)
//        {
//            i++;
//            Console.WriteLine("increaser thread : " + i);
//        }
//    }
//});

//Thread customThreadDecrease = new Thread(() =>
//{
//    lock (_locking)
//    {

//        while (i > 0)
//        {
//            i--;
//            Console.WriteLine("decreaser thread : " + i);
//        }
//    }
//});
////customThreadIncrease.Start();
////customThreadDecrease.Start();

//customThreadIncrease.Start();
//customThreadIncrease.Join();
//customThreadDecrease.Start();

#endregion

#region Thread Dayandirma -Graceful shutdown /  Cancellation token

//1.ci yol:

//bool shouldStop = false;//flag olaraq teyin edirik
//Thread customThread = new Thread(() =>
//{
//    while (!shouldStop) // Graceful shutdown
//    {
//        Console.WriteLine("Thread is running");
//    }
//    Console.WriteLine("Thread stopped");
//});

//2.ci yol:

//Thread customThreadWithCancellation = new Thread(( cancellationToken) =>
//{
//    CancellationTokenSource _cancellationToken=cancellationToken as CancellationTokenSource;
//    while (!_cancellationToken!.IsCancellationRequested) // cancellationToken check
//    {
//        Console.WriteLine("Thread is running");
//    }
//    Console.WriteLine("Thread stopped");
//});
//CancellationTokenSource cancellationToken = new CancellationTokenSource();
//customThreadWithCancellation.Start(cancellationToken);
//Thread.Sleep(1000);
//cancellationToken.Cancel();

#endregion

#region Thread interrupt

//Thread customThread = new Thread(() =>
//{
//    try
//    {
//        Thread.Sleep(Timeout.Infinite);
//    }
//    catch (ThreadInterruptedException)
//    {
//        Console.WriteLine("Thread interrupted exception throwed");
//    }
//});
//customThread.Start();
//customThread.Interrupt();
#endregion//// See https://aka.ms/new-console-template for more information

