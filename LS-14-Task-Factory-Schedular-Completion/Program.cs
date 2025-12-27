// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;

//Console.WriteLine("Hello, World!");

#region Task Factory

//TaskFactory taskFactory = new TaskFactory();//Yeni factory yaratmaq

#region StartNew -yeni task is yaratmaq

//await taskFactory.StartNew(() =>
//{
//    Console.WriteLine("Start New implementation");
//});


#endregion

#region ContinueWhenAll- butun isler bitdikde ise baslayan method

//Task task1 = new Task(() =>
//{
//    Thread.Sleep(3000);
//    Console.WriteLine("task1");
//});

//Task task2 = new Task(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("task2");
//});
//Task[] taskArray=new Task[] { task1, task2 };
//task1.Start();
//task2.Start();
//await taskFactory.ContinueWhenAll(taskArray, (taskArrayProp) =>
//{
//    Console.WriteLine("Task 1 and Task 2 done, now code is running");
//});
#endregion


#region ContinueWhenAny- islerden her hansi biri bitdikde ise baslayan method

//Task task1 = new Task(() =>
//{
//    Thread.Sleep(3000);
//    Console.WriteLine("task1");
//});

//Task task2 = new Task(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("task2");
//});
//Task[] taskArray = new Task[] { task1, task2 };
//task1.Start();
//task2.Start();
//await taskFactory.ContinueWhenAny(taskArray, (taskArrayProp) =>
//{
//    Console.WriteLine("Task 1 and Task 2 done, now code is running");
//});
#endregion


#endregion

#region Task Schedular- tasklar arasindaki is yukunu bolnmeye, scheduled etmeye yariyir

TaskFactory taskFactory = new TaskFactory();//Yeni factory yaratmaq
                                            //default bele olur, TaskSchedulerdan implement edib yeni schedular
                                            //yaratmaq olur amma istifade edilmir genelde
                                            //await taskFactory.StartNew(() =>
                                            //{
                                            //    Console.WriteLine("Start New implementation");
                                            //},CancellationToken.None, TaskCreationOptions.None,TaskScheduler.Default);
#endregion

#region Task Completion

/*
TaskCompletionSource + SetException adətən async olmayan 
(callback-based, event-based) API-ləri 
Task-a çevirmək üçün istifadə olunur
 */

//int state = 0;
//try
//{
//   string stateString= Console.ReadLine();
//   int.TryParse(stateString,out state);
   
//   await myMethod();

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Task<string> myMethod (){
//    TaskCompletionSource<string> taskCompletionSource = new TaskCompletionSource<string>();
//    if (state==1)
//    {
//        taskCompletionSource.SetException(new Exception("Exception Case"));
//    }
//    else  if (state == 2)
//    {
//        taskCompletionSource.SetCanceled();
//    }
//    else
//    {
//        //birbasa return edirik, amma digerinin bundan ferqi
//        //sourceda yaradib sonra isteyende islede bilmeyimizdi
//        //return Task.FromResult("Success");

//        //Task qaytaririq deye Task.Result deyeri konsola cixmir, gorunmur 
//        taskCompletionSource.SetResult("Success Case");
        
//    }

//    return taskCompletionSource.Task;

//}
#endregion