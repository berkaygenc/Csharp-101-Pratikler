using System;

namespace diziler_array_sinifi_metotlar
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("----- Sırasız Liste -----");
            DiziYazdir(sayiDizisi);
            Console.WriteLine();

            Console.WriteLine("----- Sıralı Liste -----");
            Array.Sort(sayiDizisi);
            DiziYazdir(sayiDizisi);

            // Clear
            Console.WriteLine();
            Console.WriteLine("----- Array Clear -----");

            // sayıDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi, 2, 2);
            DiziYazdir(sayiDizisi);

            //Reverse
            Console.WriteLine();
            Console.WriteLine("----- Array Reverse -----");
            Array.Reverse(sayiDizisi);
            DiziYazdir(sayiDizisi);

            //IndexOf
            Console.WriteLine();
            Console.WriteLine("----- Array IndexOf -----");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize
            Console.WriteLine("----- Array Resize -----");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            DiziYazdir(sayiDizisi);
        }

        public static void DiziYazdir(int[] sayiDizisi)
        {
            foreach (var sayi in sayiDizisi)
                Console.Write(sayi + " ");
        }

    }
}
