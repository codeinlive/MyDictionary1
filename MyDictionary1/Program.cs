using System;

namespace MyDictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ad1 = new MyDictionary<int, string>();
            {
                ad1.Ekle(01, "Adana");
                ad1.Ekle(34, "İstanbul");

            }

        }

        class MyDictionary<T1, T2>
        {
            T1[] dizi1;
            T2[] dizi2;

            T1[] tempDizi1;
            T2[] tempDizi2;
            public MyDictionary()
            {
                dizi1 = new T1[0];
                dizi2 = new T2[0];

            }
            public void Ekle(T1 anahtar, T2 deger)
            {
                tempDizi1 = dizi1;
                tempDizi2 = dizi2;

                dizi1 = new T1[dizi1.Length + 1];
                dizi2 = new T2[dizi2.Length + 1];

                for (int i = 0; i < tempDizi1.Length; i++)
                {
                    dizi1[i] = tempDizi1[i];
                    dizi2[i] = tempDizi2[i];
                }

                dizi1[dizi1.Length - 1] = anahtar;
                dizi2[dizi2.Length - 1] = deger;
                Console.WriteLine(anahtar + " : " + deger);


            }



        }


    }
}