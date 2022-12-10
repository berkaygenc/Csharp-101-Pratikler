using System;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            int[] dizi;
            dizi = new int[5];
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını alan program
            Console.Write("Lütfen dizinin eleman sayısını girin: ");
            int dizi_lenght = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[dizi_lenght];

            for (int i = 0; i < dizi_lenght; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1); //Generic
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0,ortalama=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            ortalama = toplam / dizi_lenght;
            Console.WriteLine("Ortalama: " + ortalama);
        }
    }
}
