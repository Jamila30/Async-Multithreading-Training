// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

#region Sinxron 

//IEnumerable<int> nums = new List<int>();

//await Task.Run(() =>
//{
//	nums = GetNumbers();
//});

////await ve async olmadan sinxron sekilde for etdik hansiki
////default loop ozu sinxron isleyir

//foreach (var number in nums)
//{
//    Thread.Sleep(2000);

//    Console.WriteLine(number);
//}
//IEnumerable<int> GetNumbers()
//{
//    // Simulyasiya: Güya bazadan 1, 2, 3 rəqəmləri gəlir
//    yield return 1;
//    yield return 2;
//    yield return 3;
//}
#endregion

#region Asinxron


//IAsyncEnumerable<int> nums =  GetNumbersAsync(); ;


////await ve async sekildeki collection uzerinden for etdik hansiki
//await foreach (var number in nums)
//{
//    Thread.Sleep(2000);

//    Console.WriteLine(number);
//}
//async IAsyncEnumerable<int> GetNumbersAsync()
//{
//    await Task.Delay(100);
//    // Simulyasiya: Güya bazadan 1, 2, 3 rəqəmləri gəlir
//    yield return 1;
//    yield return 2;
//    yield return 3;
//}
#endregion

#region Custom 

//Numbers nums = new Numbers();
//await foreach (int number in nums)
//    Console.WriteLine(number);

//class Numbers : IAsyncEnumerable<int>
//{
//    private readonly List<int> numbs=new List<int>() { 1,2,3 };
//    public async IAsyncEnumerator<int> GetAsyncEnumerator(CancellationToken cancellationToken = default)
//    {
//        await Task.Delay(1000);
//         foreach (int num in numbs)
//            yield return num;
//    }
//}
#endregion
