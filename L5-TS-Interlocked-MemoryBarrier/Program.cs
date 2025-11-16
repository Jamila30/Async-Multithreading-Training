//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region Interlocked

//int i = 1;
//Interlocked.Add(ref i, 1);
//    int returnValue1 =Interlocked.Add(ref i, 7);// i+5 bu case ucun, nece yazsaq elave edir.
//    Console.WriteLine(returnValue1);//geriye elave edilmias deyeri, location i deki deyeri qaytarir
//    Console.WriteLine(i);
//    Interlocked.Increment(ref i); //+1 emeliyyati
//    Console.WriteLine(i);
//    Interlocked.Decrement(ref i); //-1 emeliyyati
//    Console.WriteLine(i);
//    int returnValue2=Interlocked.Exchange(ref i, 10);//deyerleri deyisir yeni deyerle, amma geriye kohneni qaytarir
//    Console.WriteLine(returnValue2);
//    Console.WriteLine(i);


//Thread thread1 = new(() =>
//{
//    while (i <= 10)
//    {
//       // i++; yazmaq evezine:
//        Interlocked.Increment(ref i);
//        Console.WriteLine("thread1 : " + i);
//    }
//});

//Thread thread2 = new(() =>
//{
//    while (i > 0)
//    {
//        //i--; yazmaq evezine:
//        Interlocked.Decrement(ref i);   
//        Console.WriteLine("thread2 : " + i);
//    }
//});
//thread1.Start();
//thread2.Start();
#endregion

#region Thread.MemoryBarier()

// int i = 1;
//Thread thread1 = new(() =>
//{
//    while (i <= 50)
//    {
//        Interlocked.Increment(ref i);
//        Thread.MemoryBarrier();
//    }
//});

//Thread thread2 = new(() =>
//{
//    while (i>0)
//    {
//        Thread.MemoryBarrier();
//        Console.WriteLine("i : " + i);
//    }
//});
//thread1.Start();
//thread2.Start();

#endregion
