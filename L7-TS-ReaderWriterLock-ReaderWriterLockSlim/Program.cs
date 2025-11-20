//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int value = 1;
//ReaderWriterLock readerWriterLock = new ReaderWriterLock();
//Thread thread1 = new Thread(() =>
//{
//	try
//	{
//		readerWriterLock.AcquireReaderLock(Timeout.Infinite);
//		for (int i = 0; i < 100; i++)
//		{
//            Console.WriteLine("ThreadRead : "+ value);
//		}

//	}
//	finally { 
//		readerWriterLock.ReleaseReaderLock();
//	}
//}
//) ;


//Thread thread2 = new Thread(() =>
//{
//    try
//    {
//        readerWriterLock.AcquireWriterLock(Timeout.Infinite);
//        for (int i = 0; i < 100; i++)
//        {
//            Interlocked.Increment(ref value);
//            Thread.Sleep(200);
//            Console.WriteLine("ThreadWriter " +value);
//        }

//    }
//    finally
//    {
//        readerWriterLock.ReleaseWriterLock();
//    }
//}
//);

//thread1.Start();
//thread2.Start();
