//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region SpinLock

//int value = 0;
//SpinLock spinLock = new();

//Thread thread1 = new Thread(() =>
//{
//    bool lockTaken = false;
//    try
//    {
//        spinLock.Enter(ref lockTaken);
//        if (lockTaken)
//        {
//            for (int i = 0; i < 99; i++)
//            {
//                Console.WriteLine("Thread 1 : " + ++value);
//            }
//        }

//    }
//    finally { spinLock.Exit(); }
//});

//Thread thread2 = new Thread(() =>
//{
//    bool lockTaken = false;
//    try
//    {
//        spinLock.Enter(ref lockTaken);
//        if (lockTaken)
//        {
//            for (int i = 0; i < 99; i++)
//            {
//                Console.WriteLine("Thread 2 : " + --value);
//            }
//        }
//    }
//    finally { spinLock.Exit(); }
//});
//thread1.Start();
//thread2.Start();

#endregion

#region SpinWait

////SpinWait-siz 

//bool wait = false; bool condition = false;
//Thread thread1 = new(() =>
//{
//    while (true)
//    {
//        if (wait)
//        {
//            continue;
//        }
//        if (!condition)
//        {
//            continue;
//        }

//        Console.WriteLine("Thread1 isleyir......");
//    }

//});


////SpinWait ile
//Thread thread2 = new(() =>
//{
//    while(true)
//    { 

//        SpinWait.SpinUntil(() =>
//        {
//            Thread.MemoryBarrier();
//            return !(!condition || wait);
//        });

//        Console.WriteLine("Thread2 isleyir.....");
//    }

//});
//thread1.Start();
//thread2.Start();
#endregion