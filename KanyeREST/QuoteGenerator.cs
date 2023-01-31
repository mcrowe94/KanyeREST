using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient(); //http request

            var kanyeURL = "https://api.kanye.rest"; //hitting the api 

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result; //getting result of api, aspecifically 

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString(); //parsing JSON OBJECT from response and turning it into a string 

            Console.WriteLine($"Kanye: \"{kanyeQuote}\""); //quote line, prints to console
        }

        public static void RonQuote()
        {
            var client = new HttpClient(); //http request

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes"; //hitting the api

            var ronResponse = client.GetStringAsync(ronURL).Result; //getting result of api, aspecifically 

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim(); //parsing JSON ARRAY from response and turning it into a string

            Console.WriteLine($"Ron: {ronQuote}"); //quote line, prints to console
        }


    }
    
}
