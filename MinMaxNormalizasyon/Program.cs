using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[] sayiDizisi = new int[10];
            Console.WriteLine("aralık değerini giriniz");
            string araliks = Console.ReadLine();
            int aralik = Convert.ToInt32(araliks);
            int sayi = 0;
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                sayi = rnd.Next(aralik);
                sayiDizisi[i] = rnd.Next(aralik);
                Console.WriteLine("veriler : " + sayiDizisi[i]);
                toplam = toplam + sayiDizisi[i];

            }
            int ortalama = toplam / 10;
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < 10; i++)
            {
                double sonuc = maxminnormalizasyon(sayiDizisi[i], sayiDizisi.Min(), sayiDizisi.Max());
                Console.WriteLine("maxmin normalizasyon// " + i + ". indis = " + sonuc);

            }
            Console.WriteLine("------------------------------------");
            double[] standart = new double[10];
            int deger = 0;
            double cevap = 0;
            for (int i = 0; i < 10; i++)
            {
                deger = sayiDizisi[i] - ortalama;
                cevap = cevap+Math.Pow(deger, 2);
            }
            double standartsapma = cevap / (ortalama-1);
            for(int i = 0; i < 10; i++)
            {
                double sonuc2 = zscore(sayiDizisi[i], ortalama, standartsapma);
                Console.WriteLine("z score normalizasyon// " + i + ". indis = " + sonuc2);
            }


            Console.ReadKey();


        }
        static double maxminnormalizasyon(double sayi, double min, double max)
        {
            double sonuc = (sayi - min) / (max - min);
            return sonuc;
        }
        static double zscore(double sayi, double ortalama, double standart)
        {
            double sonuc = (sayi - ortalama) / standart;
            return sonuc;
        }
    }
}
