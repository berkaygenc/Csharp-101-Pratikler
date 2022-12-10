using System;

namespace donguler_while_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console`a yazdıran program.

            Console.Write("Bir sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac = 1, toplam=0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: "+ toplam / sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console`a yazdır.
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character+" ");
                character++;
            }
            Console.WriteLine();

            //Foreach
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
