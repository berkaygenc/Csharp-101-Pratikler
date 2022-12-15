using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic;
            // T-> object türündedir.

            List<int> sayiListesi=new List<int> {};
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string> { };
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //count 
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (var item in sayiListesi)
                Console.WriteLine(item);
            foreach (var item in renkListesi)
                Console.WriteLine(item);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi List`e çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };

            List<string> hayvanlarList = new List<string>(hayvanlar);

            // Listeyi nasıl temizleriz?
            hayvanlarList.Clear();


            //List içerisinde nesne tutmak 
            List<Kullanıcılar> kullaniciList = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas = 26;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas = 36;

            kullaniciList.Add(kullanici1);
            kullaniciList.Add(kullanici2);

            List<Kullanıcılar> yeniList = new List<Kullanıcılar>();

            yeniList.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (Kullanıcılar item in kullaniciList)
                Console.WriteLine(item.Isim+" "+item.Soyisim+" "+item.Yas);

            kullaniciList.ForEach(kullanici=>Console.WriteLine(kullanici.Isim+" "+kullanici.Soyisim+" "+kullanici.Yas));

            yeniList.Clear();
        }
    }
    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
