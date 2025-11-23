

#region Threading.Timer


//Timer timer = new Timer((name) =>
//{
//    WriteNameToConsole(name);
//},//Neyi run elesin
//"Jane",//Metod state
//100,//Ne qeder gozlesin(dueTime)
//3000);//Ne qeder perioddan bir etsin(period)

//Thread.Sleep(1000);

//Console.WriteLine("Vaxt araligi deyisdi");

//timer.Change(5000, 1000); // (dueTime,period)
//void WriteNameToConsole(object? name)
//{
//    Console.WriteLine("Name : " + name.ToString());
//}

//Console.ReadLine();

#endregion

#region Timers.Timer

//System.Timers.Timer timer = new System.Timers.Timer();
//timer.Start();//Startin evvel ve ya sonra olmasi intervali resetlemesine mane olmur, qebul olunur(overrite) cavabi biz yazan kimi
//timer.Elapsed += (r, e) => WriteNameToConsole("Jane");
//timer.Interval = 2000;

//Thread.Sleep(15000);//bu thread sleepe qoysaqda timer isleyir, sayir 
//Console.WriteLine("--");

//timer.Stop();
//void WriteNameToConsole(object? name)
//{
//    Console.WriteLine("Name : " + name.ToString());
//}

#endregion