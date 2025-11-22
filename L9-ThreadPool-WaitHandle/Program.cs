// See https://aka.ms/new-console-template for more information


#region ThreadPool

//for (int i = 0; i < 10; i++) //eyni thread id-lerin ferqli adamlari cagirdiginin simulyasiyasi ucun
//{
//ThreadPool.QueueUserWorkItem<Person>(CallPerson, new Person() { Name="Jamila"},true);
//ThreadPool.QueueUserWorkItem<Person>(CallPerson, new Person() { Name="Lala"}, true);
//ThreadPool.QueueUserWorkItem<Person>(CallPerson, new Person() { Name="Sevinc"}, true);
//ThreadPool.QueueUserWorkItem<Person>(CallPerson, new Person() { Name="Ahmad"}, true);
//ThreadPool.QueueUserWorkItem<Person>(CallPerson, new Person() { Name="Cavad"}, true);//Basqa tez olacaq is

//}

//Console.ReadLine();
//void CallPerson(object? state)
//{
//    Console.WriteLine(ThreadPool.ThreadCount);//Thread Poolda aktiv nece thread var odur (umumi olan deyil!!!)
//    Person person = (Person)state;
//    Console.WriteLine($" {Thread.CurrentThread.ManagedThreadId} is calling with name " + person.Name);
//    Thread.Sleep(1500);
//}

//class Person
//{ 
//    public string Name { get; set; }
//}

#endregion

#region WaitHandle  (hamisi burda) 
//Bu mentiq eslinde umumidir.Threadler arasi siqnal procesini izlemek ucundu,
//ThreadPool ucunde testbiq olunur sadece 
//cunki, threadPooldaki threadlerin arasi siqnallasmani da monitorinqden kecirmek lazim ola bilir

//ilk once WaitHandle tipleri umumi hisse 

#region WaitHandle Types ==> WaitHandle.WaitAll() // WaitHandle.WaitAny(),  // .WaitOne()

//AutoResetEvent autoResetEvent1 = new AutoResetEvent(false);
//AutoResetEvent autoResetEvent2 = new AutoResetEvent(false);
//ManualResetEvent manualResetEvent1 = new ManualResetEvent(false);
//ManualResetEvent manualResetEvent2 = new ManualResetEvent(false);

//Thread.Sleep(2000);

//autoResetEvent1.Set();


//Hamisi siqnal gozleyir , olsa novbeti is hell olur, yoxsa gozlemeye davam edir
//WaitHandle.WaitAll(new WaitHandle[] { autoResetEvent1, autoResetEvent2, manualResetEvent1, manualResetEvent2 }, 2000);

//Her hansi birinden cavab gozleyir, biri siqnal verirse is gorulur(indiki halda autoResetEvent1 siqnal verir)
//WaitHandle.WaitAny(new WaitHandle[] { autoResetEvent1, autoResetEvent2, manualResetEvent1, manualResetEvent2 });

//autoResetEvent1.WaitOne();
//Console.WriteLine("Came"); //Her hansi is gordum burda


#endregion

//Indi waitHandle mentiqini ThreadPoola tetbiq etsek:

//using System.Reflection.Metadata;

//AutoResetEvent autoResetEvent = new AutoResetEvent(false);
//Person person = new Person() { Name = "Jamila" };
//RegisteredWaitHandle registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject(
//    autoResetEvent,
//   new WaitOrTimerCallback(CallPerson),
//    person,
//    2000,
//    false //executeOnlyOnce Bu parametr:
//         //true olarsa → Callback yalnız bir dəfə işləyir. // false olarsa → Callback hər dəfə handle siqnal verdikcə yenidən işləyir.
//    );

//2 sey gozleyir :
//autoResetEvent.Set(); //1) autoEvent siqnallasin 
//funksiyadaki timeout < bizim is vaxtindan // simulyasiya ucun Thread.Sleep eledim
//Thread.Sleep( 6000 );// executeOnlyOnce true yazdim 1 defe mesaj cixdi, false olanda 1+

//registeredWaitHandle.Unregister(autoResetEvent);//Resurs yemesin deye bunu yazmaq onemlidir

////   timedOut:
////     true if the System.Threading.WaitHandle timed out; false if it was signaled.
//void CallPerson(object? state,bool timeout) 
//{
//   // Console.WriteLine(ThreadPool.ThreadCount);//Thread Poolda aktiv nece thread var odur (umumi olan deyil!!!)
//    Person person = (Person)state;
//    Console.WriteLine($" {Thread.CurrentThread.ManagedThreadId} is calling with name " + person.Name);
//}

//class Person
//{
//    public string Name { get; set; }
//}
#endregion
