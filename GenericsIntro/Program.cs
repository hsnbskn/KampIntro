using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();   //MyList class'ında T verdiğim için burada type belirteceğim.String verdim.
            isimler.Add("Hasan");



            Console.WriteLine("Hello World!");
        }
    }
}
