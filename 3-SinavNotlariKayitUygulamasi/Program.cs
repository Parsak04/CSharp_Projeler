using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SinavNotlariKayitUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Sınav Notları Kayıt Uygulaması --------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var?: ");
            int sınıfMevcudu = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            string[] ogrenciAdi = new string[sınıfMevcudu];
            double[] ortalama = new double[sınıfMevcudu];

            for (int i = 0; i < sınıfMevcudu; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adı: ");
                ogrenciAdi[i] = Console.ReadLine();

                double toplam = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{ogrenciAdi[i]} adlı öğrenci {j + 1}. sınav notu: ");
                    double value = double.Parse(Console.ReadLine());
                    toplam += value;
                }
                Console.WriteLine();
                ortalama[i] = toplam / 3;
            }
            

            Console.WriteLine();
            Console.WriteLine("----------- Öğrencilerin Ortalamaları -----------");


            for (int i = 0; i < sınıfMevcudu; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{ogrenciAdi[i]} adlı öğrencinin ortalaması: {ortalama[i]:F2}");
                if (ortalama[i] >= 50)
                {
                    Console.WriteLine($"{ogrenciAdi[i]} adlı öğrenci geçti.");
                }
                else
                {
                    Console.WriteLine($"{ogrenciAdi[i]} adlı öğrenci kaldı.");
                }

                

            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------- Ortalama Notlarının Sıralaması ---------");
            Console.WriteLine();
            Array.Sort(ortalama, ogrenciAdi);
            Array.Reverse(ortalama);
            Array.Reverse(ogrenciAdi);

            for (int i = 0; i < ortalama.Length; i++)
            {
                Console.Write($"{ogrenciAdi[i]}: {ortalama[i]:F2} ");
            }

            Console.Read();
        }
    }
}
