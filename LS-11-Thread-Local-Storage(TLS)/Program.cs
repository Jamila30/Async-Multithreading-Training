//Linkler:
//https://www.c-sharpcorner.com/UploadFile/b942f9/thread-local-storage-of-data-in-net/

#region ThreadStatic

//class Program
//{
//    //Sadece static deyerle islenir
//    [ThreadStatic]
//    static int x; //X-i her thread ucun ayrica kopyalayir bu sebeble data consistency qorunur.

//    static void Main(string[] args)
//    {
//        Thread thread1 = new(() =>
//        {
//            for (int i = 1; i < 10; i++)
//            {
//                Console.WriteLine($" Thread 1 -  {++x}");
//            }
//        });

//        Thread thread2 = new(() =>
//        {
//            for (int i = 1; i < 10; i++)
//            {
//                Console.WriteLine($" Thread 2 -  {++x}");
//            }
//        });
//        thread1.Start();
//        thread2.Start();
//    }
//}


#endregion

#region ThreadLocal<T>

////instance ve ya  static deyerle islene bilir
//ThreadLocal<int> x = new ThreadLocal<int>(() => 1); //X-i her thread ucun ayrica kopyalayir bu sebeble data consistency qorunur.

//Thread thread1 = new(() =>
//{
//    for (int i = 1; i < 10; i++)
//    {
//        Console.WriteLine($" Thread 1 -  {++x.Value}");
//    }
//});

//Thread thread2 = new(() =>
//{
//    for (int i = 1; i < 10; i++)
//    {
//        Console.WriteLine($" Thread 2 -  {++x.Value}");
//    }
//});
//thread1.Start();
//thread2.Start();



#endregion

#region GetData and setData

//Getter/Setterlerle is gorur
//Melumatlat ucun slotlar yaradiriq

#region Ferqli numune 1

//LocalDataStoreSlot localDataStoreSlot = Thread.GetNamedDataSlot("x");
//✔️ 1.AllocateNamedDataSlot-Yeni, benzersiz bir isimli slot oluşturur.Aynı ada sahip bir slot daha önce varsa → üzerine yazmaz, hata da vermez; tamamen yeni bir slot üretir.Yani bu metod mutlaka yeni slot tahsis eder.
//✔️ 2.GetNamedDataSlot-Bu isimle daha önce oluşturulmuş slotu getirir.Eğer yoksa → yeni bir slot oluşturur ve o isimle kaydeder.Yani hem “bulup getirir” hem de “yoksa oluşturur”.

//Thread thread1 = new(() =>
//{
//    // Her thread başlangıç değeri set edilmeli
//    Thread.SetData(localDataStoreSlot, 0);

//    for (int i = 0; i < 10; i++)
//    {
//        int value = (int)Thread.GetData(localDataStoreSlot);
//        value++;
//        Thread.SetData(localDataStoreSlot, value);

//        Console.WriteLine($"Thread 1 - {value}");
//    }
//});

//Thread thread2 = new(() =>
//{
//    Thread.SetData(localDataStoreSlot, 0);   

//    for (int i = 0; i < 10; i++)
//    {
//        int value = (int)Thread.GetData(localDataStoreSlot);
//        value++;
//        Thread.SetData(localDataStoreSlot, value);

//        Console.WriteLine($"Thread 2 - {value}");
//    }
//});

//thread1.Start();
//thread2.Start();


#endregion

#region Ferqli numune 2

//class Program
//{
//    static LocalDataStoreSlot localDataStoreSlot = Thread.GetNamedDataSlot("x");

//    static int x
//    {
//        get
//        {
//            var data = Thread.GetData(localDataStoreSlot);
//            return (int)(data is null ? 0 : data);
//        }
//        set
//        {
//            Thread.SetData(localDataStoreSlot, value);
//        }
//    }
//    static void Main(string[] args)
//    {
//        Thread thread1 = new(() =>
//        {
//            for (int i = 1; i < 10; i++)
//            {
//                Console.WriteLine($" Thread 1 -  {++x}");
//            }
//        });

//        Thread thread2 = new(() =>
//        {
//            for (int i = 1; i < 10; i++)
//            {
//                Console.WriteLine($" Thread 2 -  {++x}");
//            }
//        });
//        thread1.Start();
//        thread2.Start();
//    }
//}


#endregion

#endregion
