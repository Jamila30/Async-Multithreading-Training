
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region Task class-declare with 3 different ways

//1-ci usul
//Task task1 = new Task(() =>
//{
//    Console.WriteLine("test1");
//});
//task1.Start();//elemesen islemir

////2-ci usul
//Task task2 = Task.Run(() =>
//{
//    Console.WriteLine("Test2");
//});

//Task task3 = Task.Factory.StartNew(() =>
//{
//    Console.WriteLine("test3");
//    Task.Run(() =>
//    {
//        Console.WriteLine("Subtask1");
//    });

//    Task.Run(() =>
//    {
//        Console.WriteLine("Subtask2");
//    });
//});
#endregion

#region  Wait(),WaitAll(), WaitAny()

//Task task = Task.Run(() =>
//{
//    Console.WriteLine("Test");
//});

//Task task2 = Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine(i);
//    Console.WriteLine("Test2");
//});
//task.Wait();//task bitmeden novbeti setri icra etmir
//Console.WriteLine("novbeti setrdeki isler");

//lambda ile de yazila biler,
//her ikisi isini bitirir sonra novbeti setr run olur
//Task.WaitAll(task, task2);
//Console.WriteLine("novbeti setrdeki isler");

// Task.WaitAny(task, task2); //her hansi biri en azi isini bitirmelidir
//Console.WriteLine("novbeti setr"); 
#endregion

#region ContinueWith


//Task task1 = Task.Run(() =>
//{
//    Console.WriteLine("Test1");
//});
//Task task2 = Task.Run(() =>
//{
//    Console.WriteLine("Test2");
//});

//task1.ContinueWith(t =>
//{

//    Console.WriteLine("Continue with this line");
//});
#endregion