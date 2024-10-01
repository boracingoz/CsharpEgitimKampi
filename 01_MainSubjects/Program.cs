using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Hello World");
            //Console.Write("Hi");

            //Console.WriteLine("***** Food Category *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion
            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Murat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Bora";
            //customerSurname = "Cingöz";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adrees: " + district + "/" + city);
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adrees: " + district + "/" + city);
            //Console.WriteLine("-----------------------------");

            #endregion

            #region Int Degiskenler
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Resteron Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("----> Hamburger Fiyatı: " + hamburgerPrice + " " + "TL");
            Console.WriteLine("----> Kola Fiyatı : " + pizzaPrice + " " + "TL");
            Console.WriteLine("----> Su Fiyatı : " + waterPrice + " " + "TL");
            Console.WriteLine("----> Patate Kızartması Fiyatı : " + friesPrice + " " + "TL");
            Console.WriteLine("----> Pizza Fiyatı : " + pizzaPrice + " " + "TL");
            Console.WriteLine("----> Limonata Fiyatı : " + lemonadePrice + " " + "TL");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("**** Resteron Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            int totalCokePrice;

            

            hamburgerCount = 5;
            cokeCount = 3;
            waterCount = 4;
            friesCount = 5;
            pizzaCount = 4;
            lemonadeCount = 1;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalWaterPrice = waterPrice * waterCount;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalCokePrice = cokeCount * cokePrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();
            int totalPrice = totalHamburgerPrice + totalCokePrice + totalLemonadePrice + totalFriesPrice + totalWaterPrice + totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " " + "TL");

            #endregion
            Console.Read();
        }
    }
}
