using csharp9;
using System;

// Before
//namespace csharp9
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

// Now
var s = new AsyncService();
var result = await s.MyAsyncMethod();
Console.WriteLine($"Hello {args[0]}! result: {result}");
return 1;