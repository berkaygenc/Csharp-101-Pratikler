using System;
using System.Runtime.InteropServices;

namespace Odev1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç sayı girmek istediğinizi girin (n): ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Kontrol sayısını girin (m): ");
            int m = Int32.Parse(Console.ReadLine());

            int[] dizi=new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write((i+1)+".sayıyı girin: ");
                dizi[i]=Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("-------Sonuç-------");
            foreach (var item in dizi)
            {
                if(item%m==0 || item==m)
                    Console.WriteLine(item);
            }
        }
    }
}
