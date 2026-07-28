using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_bakteri_sayisi_siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int bakeriSayisi = 1;
            for (int i = 1; i <= 24; i++)
            {    
                Console.WriteLine($"{i}. Saat sonunda bakteri sayısı: {bakeriSayisi *= 2}");
            }


            Console.ReadLine();
        }
    }
}
