using System;

namespace Odev1_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen pozitif bir sayı girin: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] dizi=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write((i+1)+"."+" pozitif sayiyi girin: ");
                    dizi[i] =Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("-------- Çift Sayılar --------");
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);
            }
        }
    }
}
