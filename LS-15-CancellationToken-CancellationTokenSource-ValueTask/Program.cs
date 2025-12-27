// See https://aka.ms/new-console-template for more information
using System.Threading;

Console.WriteLine("Hello, World!");

#region ConfigureAwait 

//await Task.Run(() =>
//{
//    Console.WriteLine("Task");
//}).ConfigureAwait(false);//Eyni context ile taski davam eletdirmek mecburiyyeti olmur
////taski await eleyib icrasindan sonraki setrleri ferqli contextler 
////nezerate ala bilerler, isi onlar davam ede bilerler


//await Task.Run(() =>
//{
//    Console.WriteLine("Task");
//}).ConfigureAwait(true);//Eyni context ile taski davam eletdir,mutleq
////hansi context bu taski eledise eynisi novbeti setrleri icra etsin

#endregion

#region CancellationToken AND CancellationTokenSource

//CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();


////bunu await qoymadim cunki,await olabda cancel eden bu task bitene qeder gozleyir ve novbeti setre ele kecir
////ve novbeti doProcess run olanda artiq token cancelled statusunda oldugundan
////foreach-in ilk dongusunde ele xeta atir
//Task.Run(async () => 
//{
//    Thread.Sleep(3000);
//     await cancellationTokenSource.CancelAsync();
//});

//try
//{

// await DoProcessAsync(cancellationTokenSource.Token);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//async Task DoProcessAsync(CancellationToken cancellationToken)
//{
//    for (int i = 1; i <= 5; i++)
//    {    
//      cancellationToken.ThrowIfCancellationRequested();
//      Console.WriteLine("Token is not request yet i= "+ i);
//      Thread.Sleep(1000);
//    }
//}





#endregion

#region ValueTask vs Task

//async Task X() //referans bir classdir ve heaple isleyir
//{

//}

//async ValueTask Y()  //structdu, stack ile isleyir // cox sade islerde isledilmesi meslehetlidir
//{

//}
#endregion
