using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> array = new Dictionary<string, int>();
            array.Add("ali", 250);
            array.Add("veli", 350);
            array.Add("ahmet", 450);
            array.Add("salih", 550);

            Console.WriteLine(array.Count);
        }
    }
}
