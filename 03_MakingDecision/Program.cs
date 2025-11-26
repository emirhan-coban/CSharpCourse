using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "123")
            //{
            //    Console.WriteLine("Şifreniz doğru, sisteme giriş yapabilirsiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreniz yanlış, lütfen tekrar deneyiniz.");
            //}

            //string capital, country;
            //Console.Write("Lütfen bir ülke ismi giriniz: ");
            //country = Console.ReadLine().ToLower();
            //Console.Write("Lütfen başkent ismini giriniz: ");
            //capital = Console.ReadLine().ToLower();
            //if (country == "türkiye" && capital == "ankara")
            //{
            //    Console.WriteLine("Tebrikler, doğru bildiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Maalesef yanlış cevap.");
            //}
            #endregion

            #region Mod İşlemleri
            //int number = 10;
            //int result = number % 3;
            //Console.WriteLine(result); // Output: 1
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char grade;
            //Console.Write("Lütfen notunuzu giriniz (A, B, C, D, F): ");
            //grade = Convert.ToChar(Console.ReadLine().ToUpper());
            //if (grade == 'A')
            //{
            //    Console.WriteLine("Mükemmel! Harf notunuz: A");
            //}
            //else if (grade == 'B')
            //{
            //    Console.WriteLine("Çok iyi! Harf notunuz: B");
            //}
            //else if (grade == 'C')
            //{
            //    Console.WriteLine("İyi! Harf notunuz: C");
            //}
            //else if (grade == 'D')
            //{
            //    Console.WriteLine("Geçtiniz! Harf notunuz: D");
            //}
            //else if (grade == 'F')
            //{
            //    Console.WriteLine("Maalesef kaldınız. Harf notunuz: F");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz not girdiniz.");
            //}
            #endregion

            #region Switch Case Yapısı
            Console.Write("Lütfen Ay Girişi Yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch(monthNumber)
            {
                case 1: Console.Write("Ocak"); break;
                case 2: Console.Write("Şubat"); break;
                case 3: Console.Write("Mart"); break;
                case 4: Console.Write("Nisan"); break;
                case 5: Console.Write("5"); break;
                case 61: Console.Write("6"); break;
                case 7: Console.Write("7"); break;
                case 8: Console.Write("8"); break;
                case 9: Console.Write("9"); break;
                case 10: Console.Write("10"); break;
                case 11: Console.Write("11"); break;
                case 12: Console.Write("12"); break;
                default: Console.Write("Hatalı veri girişi."); break;
            }
            #endregion

            Console.Read();
        }
    }
}
