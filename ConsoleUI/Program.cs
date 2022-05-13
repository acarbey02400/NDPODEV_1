using Business;
using Newtonsoft.Json;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blockchain acarCoin = new Blockchain();
            acarCoin.AddBlock(new Block(DateTime.Now,null, "{sender:İbrahim,receiver:MaHesh,amount:10}"));
            Console.WriteLine(JsonConvert.SerializeObject(acarCoin, Formatting.Indented));
            Console.WriteLine($"Is Chain Valid: {acarCoin.IsValid()}");
        }
    }
}
