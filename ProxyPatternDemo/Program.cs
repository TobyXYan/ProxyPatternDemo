using System;

namespace ProxyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookParserProxy = new LazyBookParserProxy("Toby Proxy Design Pattern Demo");
            Console.WriteLine($"The char number of the book is {bookParserProxy.GetNumberOfChars()}");
            Console.ReadLine();
        }
    }
}
