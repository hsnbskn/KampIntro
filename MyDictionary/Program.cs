using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> plakaSehir = new MyDictionary<int, string>();
            plakaSehir.Add(16, "Bursa");
            plakaSehir.Add(34, "İstanbul");
            plakaSehir.Add(07, "Antalya");
            plakaSehir.Add(53, "Rize");

        }


        class MyDictionary<T, K>
        {
            T[] key_Array;  //anahtar tutar
            T[] key_TempArray; //anahtar tamponu

            K[] value_Array; //deger tutar
            K[] value_TempArray; //degerlerin tamponu

            public MyDictionary()
            {
                key_Array = new T[0];
                value_Array = new K[0];
            }


            public void Add(T key, K value)
            {
                key_TempArray = key_Array;
                value_TempArray = value_Array;

                key_Array = new T[key_Array.Length + 1];
                value_Array = new K[value_Array.Length + 1];

                for (int i = 0; i < key_TempArray.Length; i++)
                {
                    key_Array[i] = key_TempArray[i];
                    value_Array[i] = value_TempArray[i];
                }

                key_Array[key_Array.Length - 1] = key;
                value_Array[value_Array.Length - 1] = value;

                Console.WriteLine(key + " : " + value + " added in MyDictionary with succesful.");

            }


        }

    }
}
