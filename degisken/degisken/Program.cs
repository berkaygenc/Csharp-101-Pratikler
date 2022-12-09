using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            bool b1 = true;
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;


            byte b = 5;     // 1 byte
            sbyte c = 5;    // 1 byte

            short s = 5;    // 2 byte
            ushort us = 5;  // 2 byte
            Int16 i16 = 2;  // 2 byte
            char ch = '2';  // 2 byte


            int i = 2;      // 4 byte
            Int32 i32 = 2;  // 4 byte
            uint ui = 2;    // 4 byte
            long l = 4;     // 4 byte
            ulong ul = 4;   // 4 byte
            float f = 6;    // 4 byte

            double d = 5;   // 8 byte
            Int64 i64= 2;   // 8 byte

            decimal de = 5;         // 16 byte
            string str = "Berkay"; //sınırsız


            //string
            string str1 = string.Empty;
            str1 = "Berkay Genç";
            string ad = "Berkay";
            string soyad = "Genç";
            string tamIsim = ad + " " + soyad;

            //int
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean
            bool bool1 = 10 > 2;

            //degisken dönüsümleri
            string str20 = "20";
            int int20 = 20;

            string yenideger = str20 + int20;
            Console.WriteLine(yenideger); // Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20); // Çıktısı 40
            int int22 = int20 + Int32.Parse(str20); // Çıktısı 40
            Console.WriteLine(int21);

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);
        }
    }
}
