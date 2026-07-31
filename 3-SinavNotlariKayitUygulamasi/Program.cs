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

            //Sınıv mevcudu ve öğrenci isimlerini alıyoruz
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.Write("Sınıfınızda kaç öğrenci var?: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");

            string[] studentNames = new string[studentCount];
            double[] totalExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adı: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Sınav notlarını alıyoruz
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrenci {j + 1}. sınav notu: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                totalExamAvg[i] = totalExamResult / 3;
            }

            Console.WriteLine();
            Console.WriteLine("----------- Öğrencilerin Ortalamaları -----------");

            //Öğrencilerin ortalaması ve geçip kalma durumunu yazdırıyoruz
            for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {totalExamAvg[i]:F2}");
                if (totalExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci kaldı.");
                }
            }




            Console.Read();
        }
    }
}
