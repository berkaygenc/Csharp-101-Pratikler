﻿using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinelemeli fonksiyon 
            // 3^4 = 3*3*3*3

            int result = 1;
            for (int i = 1; i <= 4; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3, 4));

            // Extension Metotlar
            string ifade = "Berkay Genç";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.SortArray();
            dizi.diziYazdir();

            int sayi = 5;
            sayi.ciftOrTek();

            Console.WriteLine(ifade.GetFirstCharacter());
        }

        
        }
        public class Islemler
        {

            public int Expo(int sayi, int üs)
            {
                if (üs < 2)
                    return sayi;
                return Expo(sayi, üs - 1) * sayi;
            }
            //  Expo(3,4)
            //  Expo(3,3) * 3;
            //  Expo(3,2) * 3 * 3;
            //  Expo(3,1) * 3 * 3 * 3 ;
            //  3 * 3 * 3 * 3 = 3^4;

        }

        public static class Extension{
            public static bool CheckSpaces(this string param)
            {
                return param.Contains("");
            }
            public static string RemoveWhiteSpaces(this string param)
            {
                string[] dizi = param.Split(" ");
                return string.Join("*", dizi);
            }
            public static string MakeUpperCase(this string param)
            {
                return param.ToUpper();
            }
            public static string MakeLowerCase(this string param)
            {
                return param.ToLower();
            }
            public static int[] SortArray(this int[] param)
            {
                Array.Sort(param);
                return param;
            }
            public static void diziYazdir(this int[] param)
            {
                foreach (var item in param)
                {
                    Console.Write(item+ " ");
                }
            }
            public static void ciftOrTek(this int param)
            {
                if (param % 2 == 0)
                    Console.WriteLine("\n"+param +" Sayısı Çifttir");
                else
                    Console.WriteLine("\n"+param + " Sayısı Tektir");
            }
            public static string GetFirstCharacter(this string param)
            {
                return param.Substring(0,1);
            }
    }
}
