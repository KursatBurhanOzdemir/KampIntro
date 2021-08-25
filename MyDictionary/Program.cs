using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> Name = new MyDictionary<string>();

            Name.Add("Kürşat Burhan Özdemir");
            Name.Add("Özlem Özlem");
            Console.WriteLine(Name.Count);
        }
    }
}
