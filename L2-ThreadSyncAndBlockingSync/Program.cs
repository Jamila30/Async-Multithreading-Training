//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region Thread Spinning

//bool thread1Condition = false;
//bool thread2Condition = false;
//Thread thread1 = new Thread(() =>
//{
//    while (true)
//    {
//        if (!thread2Condition)
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Thread 1 : " + i);
//            }
//            thread2Condition = true;
//            break;
//        }
//    }
//});

//Thread thread2 = new Thread(() =>
//{
//    while (true)
//    {
//        if (!thread1Condition)
//        {
//            for (int i = 10; i > 0; i--)
//            {
//                Console.WriteLine("Thread 2 : " + i);
//                thread1Condition = true;
//            }
//            break;
//        }
//    }

//});
//thread1.Start();
//thread2.Start();

#endregion

#region Monitor.Enter / Monitor.Exit

//int i = 0;
//object _locking = new object();
//Thread thread1 = new Thread(() =>
//{
//    try
//    {
//        Monitor.Enter(_locking);
//        for (i = 0; i < 10; i++)
//        {
//            Console.WriteLine("Thread 1 : " + i);
//        }

//    }
//    finally { Monitor.Exit(_locking); }

//});

//Thread thread2 = new Thread(() =>
//{
//    try
//    {
//        Monitor.Enter(_locking);
//        for (i = 0; i < 10; i++)
//        {
//            Console.WriteLine("Thread 2 : " + i);
//        }

//    }
//    finally { Monitor.Exit(_locking); }
//});

//thread1.Start();
//thread2.Start();

#endregion

#region LockTaken


//int i = 0;
//object _locking = new object();
//Thread thread1 = new Thread(() =>
//{
//    try
//    {
//        bool lockTaken = false;
//        Monitor.Enter(_locking, ref lockTaken);
//        if (lockTaken)
//            for (i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Thread 1 : " + i);
//            }

//    }
//    finally { Monitor.Exit(_locking); }

//});

//Thread thread2 = new Thread(() =>
//{
//    try
//    {
//        bool lockTaken = false;
//        Monitor.Enter(_locking, ref lockTaken);
//        if (lockTaken)
//            for (i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Thread 2 : " + i);
//            }

//    }
//    finally { Monitor.Exit(_locking); }
//});

//thread1.Start();
//thread2.Start();

#endregion

#region Monitor.TryEnter

//int i = 0;
//object _locking = new object();
//Thread thread1 = new Thread(() =>
//{
//    bool result = Monitor.TryEnter(_locking, 100);//100 ms erzinde kilidlemeni bacarirsa try/catch-a gir
//    if (result)
//        try
//        {
//            for (i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Thread 1 : " + i);
//            }

//        }
//        finally { Monitor.Exit(_locking); }

//});

//Thread thread2 = new Thread(() =>
//{
//    bool result = Monitor.TryEnter(_locking, 1);//1 ms erzinde kilidlemeni bacarirsa try/catch-a gir
//    if (result)
//        try
//        {
//            for (i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Thread 2 : " + i);
//            }

//        }
//        finally { Monitor.Exit(_locking); }
//});

//thread1.Start();
//thread2.Start();
#endregion

#region Mutex Sinifi

//int i = 0;
//Mutex mutex = new Mutex();
//Thread thread1 = new Thread(() =>
//{
//    mutex.WaitOne();

//    for (i = 0; i < 10; i++)
//    {
//        Console.WriteLine("Thread 1 : " + i);
//    }

//    mutex.ReleaseMutex();
//});

//Thread thread2 = new Thread(() =>
//{
//    mutex.WaitOne();

//    for (i = 0; i < 10; i++)
//    {
//        Console.WriteLine("Thread 2 : " + i);
//    }

//    mutex.ReleaseMutex();
//});

//thread1.Start();
//thread2.Start();
#endregion

#region Mutex -Single Instance Application

//Eger  bir instance adi proyekti run ederek yaradiriqsa
//Sonra gedib bin folderinden ikinci sefer .exe-ni run edemmirik
//public class Program
//{
//    static Mutex _mutex;
//    static string _programName = "Example Project";
//    static void Main(string[] args)
//    {
//        Mutex.TryOpenExisting(_programName,out _mutex);
//        if (_mutex == null)
//        { 
//            _mutex=new Mutex(true,_programName);
//            Console.WriteLine("Program Ready");
//            Console.Read();
//        }
//        else
//        {
//            _mutex.Close();
//            return;
//        }
//    }
//}
#endregion