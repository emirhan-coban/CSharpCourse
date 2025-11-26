using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //int i;
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("For Döngüsü: " + i);
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("Çift Sayı: " + i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tek Sayı: " + i);
            //    }
            //}
            #endregion

            #region While Döngüsü
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("While Döngüsü: " + i);
                i++;
            }
            #endregion
            Console.Read();
        }
    }
}
