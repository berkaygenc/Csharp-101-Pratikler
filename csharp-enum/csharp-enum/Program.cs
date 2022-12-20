using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);

            int sicaklik = 32;

            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarı çıkmak için havanın ısınmasını bekleyelim");
            else if (sicaklik >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dısarıya cıkmak icin cok sıcak bir gün");
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik >= (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi dısarıya cıkalım");
        }
    }
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soğuk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30,
    }
}
