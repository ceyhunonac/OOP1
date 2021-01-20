using System;
using System.Collections.Generic;

namespace KampCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ceyhun", "engin", "ediz" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);

            //isimler = new string[5];
            //isimler[3] = "ilker";
            //console.writeline(isimler[3]);
            //console.writeline(isimler[0]);


            List<string> isimler2 = new List<string> { "Ceyhun", "Engin", "Ediz","Sefa" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
