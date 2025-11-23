// See https://aka.ms/new-console-template for more information
//using System.Threading;

//Console.WriteLine("Hello, World!");
#region Barrier

//Barrier barrier = new(3,(b) => Console.WriteLine("--------------"));//b deyiseni biz yox klas arxada ozu isledir lambda kimi
////ParticipantCount -nece thread ucundu 
////2ci overloadda Action<Barrier>? postPhaseAction - o barriere hamisi catanda etmeli oldugu metod
////Action<Barrier>? postPhaseAction - delegate will be executed after
///// all participants have arrived at the barrier in one phase
//Thread thread1 = new(() =>
//{
//    for (int i = 1; i < 10; i++)
//    {
//        Console.WriteLine($" Thread 1.1 -  {i}");
//    }

//    barrier.SignalAndWait();

//    for (int i = 1; i < 5; i++)
//    {
//        Console.WriteLine($" Thread 1.2 -  {i}");
//    }
//});

//Thread thread2 = new(() =>
//{
//    for (int i = 1; i < 10; i++)
//    {
//        Console.WriteLine($" Thread 2.1 -  {i}");
//    }

//    barrier.SignalAndWait();
    
//    for (int i = 1; i < 5; i++)
//    {
//        Console.WriteLine($" Thread 2.2 -  {i}");
//    }
//});

//Thread thread3 = new(() =>
//{
//    for (int i = 1; i < 10; i++)
//    {
//        Console.WriteLine($" Thread 3.1 -  {i}");
//    }

//    barrier.SignalAndWait();

//    for (int i = 1; i < 5; i++)
//    {
//        Console.WriteLine($" Thread 3.2 -  {i}");
//    }
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion