using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı sıralamak istersiniz? : ");
            int adet = int.Parse(Console.ReadLine());

            int[] sayilar = new int[adet];

            for(int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sayilar);
            Console.WriteLine();

            Console.Write("Sayıların sıralanmış hali: ");
            
            foreach (int s in sayilar)
            {
                Console.Write(s + " ");
            }

            Console.ReadLine();
        }
    }
}
