using System;

namespace Odev1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen pozitif bir sayı girin: ");
            int n=Int32.Parse(Console.ReadLine());
            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ". Kelimeyi girin: ");
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
