using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2_UcunKatlariBulucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------- 3'e Bölünebilen Sayılar ---------- ");



            Console.WriteLine();
            Console.Write("Kontrol etmek istediğiniz sayıları boşluk bırakarak girin: ");
            BigInteger[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), BigInteger.Parse);

            List<BigInteger> girilenSayilar = new List<BigInteger>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.Write("3'e bölünebilen sayı: ");
                    Console.WriteLine(numbers[i] + " ");
                    Console.Write("3'e bölümü: ");
                    Console.WriteLine(numbers[i] / 3);
                    Console.WriteLine();

                    girilenSayilar.Add(numbers[i]);
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("3'e tam bölünemeyen sayı: " + numbers[i]);
                    Console.WriteLine();
                    Console.WriteLine();
                }


            }


            BigInteger[] depo = girilenSayilar.ToArray();
            Array.Sort(depo);

            Console.WriteLine("--- 3'e Bölünen Sayılar ---");
            if (depo.Length > 0)
            {
                foreach (BigInteger sayi in depo)
                {
                    Console.Write(sayi + ", ");
                }
            }
            else
            {
                Console.WriteLine("3'e bölünen hiç sayı girilmedi.");
            }

            Console.Read();
        }
    }
}
