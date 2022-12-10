using System;

namespace hata_yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı!");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz!!!");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük değer girdiniz!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Başarıyla Tamamlandı!");
            }
        }
    }
}
