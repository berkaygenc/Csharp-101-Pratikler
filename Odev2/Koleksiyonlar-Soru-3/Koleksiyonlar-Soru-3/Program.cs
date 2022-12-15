using System;
using System.Collections;


namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cumledeki_Sesliler=new ArrayList();
            Console.Write("Cümle Giriniz: ");
            string cumle = Console.ReadLine().ToLower();
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            foreach (char karakter in cumle)
            {
                foreach (char sesli in sesliler)
                {
                    if (karakter == sesli)
                    {
                        cumledeki_Sesliler.Add(karakter);
                    }
                }
            }
            Console.WriteLine("Cümlede "+ cumledeki_Sesliler.Count+ " Tane Sesli Harf Vardır: ");

            foreach (var item in cumledeki_Sesliler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
