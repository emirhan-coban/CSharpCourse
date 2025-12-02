using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] meyveler = { "Elma", "Armut", "Muz", "Çilek" };
            //Console.WriteLine("Meyveler dizisinin eleman sayısı: " + meyveler.Length);
            //Console.WriteLine("İlk meyve: " + meyveler[0]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Kırmızı", "Yeşil", "Mavi", "Sarı" };
            //Console.WriteLine("Renkler dizisinin elemanları:");
            //for (int i = 0 ; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            #endregion

            #region Dizi Metotları
            //string[] customers = { "Ahmet", "Mehmet", "Ayşe", "Fatma" };
            //int index = Array.IndexOf(customers, "Ayşe");
            //Console.WriteLine("Ayşe'nin dizideki indexi: " + index);

            //int[] numbers = { 5, 2, 8, 1, 4 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehrini Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            #endregion
            
            Console.Read();
        }
    }
}
