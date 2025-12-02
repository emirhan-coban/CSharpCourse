using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //void CustomerList() 
            //{
            //    List<string> customers = new List<string>()
            //    {
            //        "Ali", "Ayşe", "Fatma", "Ahmet", "Mehmet"
            //    };
            //    foreach (string customer in customers)
            //    {
            //        Console.WriteLine(customer);
            //    }
            //}
            //CustomerList();
            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar
            //void WriteMethod(string message, int number)
            //{
            //    Console.WriteLine($"Message: {message}, Number: {number}");
            //}
            //WriteMethod("Hello, World!", 42);
            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string GetCurrentDate()
            //{
            //    return DateTime.Now.ToLongDateString();
            //}
            //string currentDate = GetCurrentDate();
            //Console.WriteLine(currentDate);
            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar
            //string GetWelcomeMessage(string name)
            //{
            //    return $"Welcome, {name}!";
            //}
            //string message = GetWelcomeMessage("Ali");
            //Console.WriteLine(message);
            #endregion

            Console.Read();
        }
    }
}
