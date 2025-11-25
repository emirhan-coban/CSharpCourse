using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double pi = 3.14159;
            #endregion

            #region Char Değişkenler
            //char pi = 'π';
            //char grade = 'A';
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.Write("pi: ");
            //string pi = Console.ReadLine();
            //Console.WriteLine(pi);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri
            //int shoePrice;
            //Console.Write("Ayakkabı Fiyatı: ");
            //shoePrice = int.Parse(Console.ReadLine());
            //Console.WriteLine("Girilen Ayakkabı Fiyatı: " + shoePrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double length, width, area;
            //Console.Write("Uzunluk: ");
            //length = double.Parse(Console.ReadLine());
            //Console.Write("Genişlik: ");
            //width = double.Parse(Console.ReadLine());
            //area = length * width;
            //Console.WriteLine("Alan: " + area);
            #endregion

            #region Klavyeden Karakter Girişleri
            char gender;
            Console.Write("Cinsiyet (E/K): ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Girilen Cinsiyet: " + gender);
            #endregion
            Console.Read();
        }
    }
}
