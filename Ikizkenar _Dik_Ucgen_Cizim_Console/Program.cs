using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikizkenar__Dik_Ucgen_Cizim_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yukseklik giriniz:");
            int h = Convert.ToInt32(Console.ReadLine());
            UcgenCiz(h);
            Console.ReadKey();
        }


       static   void UcgenCiz(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}
