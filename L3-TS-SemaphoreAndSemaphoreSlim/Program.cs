//// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Semaphore

//List<int> numbers = new();
//Semaphore semaphore = new(2, 2);// initial Count / maximum count

//Thread thread1 = new Thread(() =>
//{
//    semaphore.WaitOne();//icaze isteyir -1 olur=> 2-1=1

//    int i = 0;
//    while (i < 10)
//    {
//        Console.WriteLine("Thread 1 : " + ++i);
//        numbers.Add(i);
//        Thread.Sleep(100);
//    }
//    semaphore.Release();//is bitdi verilen icaze geri alinir : current=current+1
//});

//Thread thread2 = new Thread(() =>
//{
//    semaphore.WaitOne();

//    int i = 10;
//    while (i < 20)
//    {
//        Console.WriteLine("Thread 2 : " + ++i);
//        numbers.Add(i);
//        Thread.Sleep(100);
//    }
//    semaphore.Release();
//});

//Thread thread3 = new Thread(() =>
//{
//    semaphore.WaitOne();

//    int i = 20;
//    while (i < 30)
//    {
//        Console.WriteLine("Thread 3 : " + ++i);
//        numbers.Add(i);
//        Thread.Sleep(100);
//    }
//    semaphore.Release();
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion

#region SemaphoreSlim

//List<int> numbers = new();
//SemaphoreSlim semaphoreSlim = new(2, 2);// initial Count / maximum count - initialCount<=maximumCount else exception throws
////SemaphoreSlim asinxron isleye bilir
//Thread thread1 = new Thread(async () =>
//{
//    await semaphoreSlim.WaitAsync();//icaze isteyir -1 olur=> 2-1=1 //Async versiyasi

//    int i = 0;
//    while (i < 10)
//    {
//        Console.WriteLine("Thread 1 : " + ++i);
//        numbers.Add(i);
//        Thread.Sleep(100);
//    }
//    semaphoreSlim.Release();//is bitdi verilen icaze geri alinir : current=current+1
//});

//Thread thread2 = new Thread(() =>
//{
//    semaphoreSlim.Wait();

//    int i = 10;
//    while (i < 20)
//    {
//        Console.WriteLine("Thread 2 : " + ++i);
//        numbers.Add(i);
//        Thread.Sleep(100);
//    }
//    semaphoreSlim.Release();
//});

//Thread thread3 = new Thread(() =>
//{
//    semaphoreSlim.Wait();

//    int i = 20;
//    while (i < 30)
//    {
//        Console.WriteLine("Thread 3 : " + ++i);
//        numbers.Add(i);
//        Thread.Sleep(100);
//    }
//    semaphoreSlim.Release();
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion

