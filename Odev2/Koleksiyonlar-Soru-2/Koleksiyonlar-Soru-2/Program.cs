using System;
using System.Collections;
namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[6];
            ArrayList kücük= new ArrayList();
            ArrayList buyuk = new ArrayList();

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayı Girin: ");
                int sayi = Int32.Parse(Console.ReadLine());
                sayilar[i] = sayi;
            }

            Array.Sort(sayilar);
            kücük.Add(sayilar[0]);
            kücük.Add(sayilar[1]);
            kücük.Add(sayilar[2]);

            Array.Reverse(sayilar);
            buyuk.Add(sayilar[0]);
            buyuk.Add(sayilar[1]);
            buyuk.Add(sayilar[2]);


            Console.WriteLine("Dizinin En Küçük 3 Elemanının Ortalaması: " + Ortalama(kücük));
            Yazdır(kücük);

            Console.WriteLine("Dizinin En Büyük 3 Elemanının Ortalaması: " + Ortalama(buyuk));
            Yazdır(buyuk);

            int ortalama_toplam = Ortalama(kücük) + Ortalama(buyuk);
            Console.WriteLine("\nİki grubun ortalama toplamları: " + ortalama_toplam);

        }

        public static void Yazdır(int[] dizi)
        {
            foreach (var item in dizi)
                Console.WriteLine(item);
        }
        public static void Yazdır(ArrayList arraylist)
        {
            foreach (var item in arraylist)
                Console.WriteLine(item);
        }

        public static int Ortalama(ArrayList arraylist)
        {
            int toplam = 0,ort=0;
            foreach (int item in arraylist)
                toplam += item;
            ort = toplam / arraylist.Count;
            return (ort);
        }
    }

}
