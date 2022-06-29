using System;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace KanyeREST
{
    public class Program
    {
        static void Main(string[] args)
        {
                for (int i = 0; i < 5; i++)
                {
                    QuoteGenerator.KanyeQuote();
                    Console.WriteLine();
                    QuoteGenerator.RonQuote();
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }
            
        }
    }
}
