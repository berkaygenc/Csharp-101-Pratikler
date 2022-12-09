using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("İsminizi Giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Soyisminizi Giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
