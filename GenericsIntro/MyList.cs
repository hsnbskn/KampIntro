using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  //T yerine int string vs. yazabiliriz.
    {
        T[] items;

        //constructor -- programdan mylist'i newlediğim zaman otomatik burası çalışır.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item) //Programcı type'ı ne verirse o olsun diye T veriyoruz.Ne verirsen type ile o gelir seninle!
        {
            T[] tempArray = items;  //elemanlarım kaybolmasın diye emanet ettim.
            items = new T[items.Length+1];  //Dizinin eleman sayısını 1 artırıyorum.Dinamik olarak! New dediğimiz yeni refen no alır. eskiler yok olur. o yüzden tmparray var!

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];    //Emanetleri geri alıyoruz.
            }

            items[items.Length - 1] = item; //Burada yeni eleman anca eklenebilir.  
        }
    }
}   

