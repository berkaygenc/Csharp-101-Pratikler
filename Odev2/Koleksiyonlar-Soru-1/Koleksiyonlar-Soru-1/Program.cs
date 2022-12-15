using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalList = new ArrayList();
            ArrayList list = new ArrayList();

            int sayi = 0;
            while((asalList.Count+list.Count)<5)
            {
                try
                {
                    do
                    {
                        int sayac = 0;
                        Console.Write("Sayıyı girin: ");
                        sayi = Int32.Parse(Console.ReadLine());
                        if (sayi > 0)
                        {
                            for (int j = 1; j <= sayi; j++)
                            {
                                if (sayi % j == 0)
                                {
                                    sayac++;
                                }
                            }
                            if (sayac == 2)
                            {
                                asalList.Add(sayi);
                            }
                            else
                            {
                                list.Add(sayi);
                            }
                        }
                        else
                            Console.WriteLine("Pozitif tam sayı giriniz!");
                    } while (sayi < 0);
                }

                catch (Exception)
                {
                    Console.WriteLine("Sayı formatında bir değer giriniz.");
                }
            }
            Console.WriteLine("----- ASAL LİSTE -----");
            if (asalList.Count > 0)
            {
                double toplam = 0;
                double ort;
                asalList.Sort();
                asalList.Reverse();
                foreach (var item in asalList)
                    Console.WriteLine(item);
                Console.WriteLine("Eleman sayısı: " + asalList.Count);
                foreach (int item in asalList)
                    toplam += item;
                ort = toplam / asalList.Count;
                Console.WriteLine("Ortalaması: " + ort);
            }
            else
                Console.WriteLine("Girdiğiniz sayılarda asal sayı bulunamamıştır!");


            Console.WriteLine("----- LİSTE -----");

            if (list.Count > 0)
            {
                double toplam = 0;
                double ort;
                list.Sort();
                list.Reverse();
                foreach (var item in list)
                    Console.WriteLine(item);
                Console.WriteLine("Eleman sayısı: " + list.Count);
                foreach (int item in list)
                    toplam+=item;
                ort = toplam / list.Count;
                Console.WriteLine("Ortalaması: " + ort);
            }
            else
                Console.WriteLine("Girdiğiniz sayılarda asal sayı dışında sayı bulunamamıştır!");

        }
    }
}
