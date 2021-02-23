using System;
using RestSharp;
using Newtonsoft.Json;

namespace APIER
{
    class Program
    {
        static void Main(string[] args)
        
        {

            System.Console.WriteLine("Vilken Pokemon vill du skaffa information för?");

            string input = Console.ReadLine();

            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/" + input);

            IRestResponse response = client.Get(request);

            System.Console.WriteLine(response.Content);

            Console.ReadLine();
        }
    }
}
