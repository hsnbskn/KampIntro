using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "hasan", "murat", "engin"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //--------------Koleksiyon--------

            List<string> isimler2 = new List<string> { "hasan", "murat", "engin","halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Cengiz");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
                




        }
    }
}
