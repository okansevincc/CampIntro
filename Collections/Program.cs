using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] names = new string[] {"Okan","Emir","Ahmet"};

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            //names = new string[4];
            //names[3] = "Mehmet";
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[0]);

            List<string> names2 = new List<string> {"Okan","Emir","Ahmet"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Mehmet");
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[0]);
            
        }
    }
}
