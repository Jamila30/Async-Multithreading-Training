// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region AutoResetEvent


// 1-1 signalling
//AutoResetEvent autoResetEvent = new AutoResetEvent(false);    
//Thread thread1 = new Thread(() => {
//    Console.WriteLine("Thread1");
//    autoResetEvent.Set();
//});

//Thread thread2 = new Thread(() =>{
//    autoResetEvent.WaitOne();
//    Console.WriteLine("Thread2");
//    autoResetEvent.Set();
//});

//Thread thread3 = new Thread(() =>{
//    autoResetEvent.WaitOne();
//    Console.WriteLine("Thread3");
//    autoResetEvent.Set();
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();




#endregion

#region ManualResetEvent  - n to n signalling 

//ManualResetEvent manualResetEvent = new ManualResetEvent(false);
//Thread thread1 = new Thread(() =>
//{
//    Console.WriteLine("Thread1");
//    manualResetEvent.Set();
//    manualResetEvent.Reset();
//});

//Thread thread2 = new Thread(() =>
//{
//    manualResetEvent.WaitOne();
//    Console.WriteLine("Thread2");
//});

//Thread thread3 = new Thread(() =>
//{
//    manualResetEvent.WaitOne();
//    Console.WriteLine("Thread3");
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();

#endregion

#region EventWaitHandle

//EventWaitHandle eventWaitHandle=new(false,EventResetMode.AutoReset);

//Thread thread1 = new Thread(() =>
//{
//    Console.WriteLine("Thread1");
//    eventWaitHandle.Set();
//});

//Thread thread2 = new Thread(() =>
//{
//    eventWaitHandle.WaitOne();
//    Console.WriteLine("Thread2");
//});

//Thread thread3 = new Thread(() =>
//{
//    eventWaitHandle.WaitOne();
//    Console.WriteLine("Thread3");
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();

#endregion

#region CountdownEvent

////wait=ler count qeder siqnal gormeden run olmur, 3 yazmisamsa 3 signal gormese run olmayacaq meselen 4,5 , gorse vardirsa run olur
///
//CountdownEvent countdownEvent = new(4);
//Thread thread1 = new Thread(() =>
//{
//    Console.WriteLine("Thread1");
//    countdownEvent.Signal();
//});

//Thread thread2 = new Thread(() =>
//{
//    countdownEvent.Signal();
//    Console.WriteLine("Thread2");
//});

//Thread thread3 = new Thread(() =>
//{
//    countdownEvent.Signal();
//    Console.WriteLine("Thread3");
//});


//Thread thread4 = new Thread(() =>
//{
//    countdownEvent.Wait();
//    Console.WriteLine("Thread4");
//});


//Thread thread5 = new Thread(() =>
//{
//    countdownEvent.Wait();
//    Console.WriteLine("Thread5");
//});
//thread1.Start();
//thread2.Start();
//thread3.Start();
//thread4.Start();
//thread5.Start();


#endregion