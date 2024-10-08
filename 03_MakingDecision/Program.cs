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
            #region IfElse

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string passaword;
            //passaword = Console.ReadLine();
            //if (passaword == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}
            //Console.ReadLine();

            //string capital, country;

            //Console.Write("Bir Ülke girin: ");
            //country = Console.ReadLine();

            //Console.Write("Bir başkent girin: ");
            //capital = Console.ReadLine();

            //if (capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı!");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler hatalı....");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //Console.WriteLine("Öğrenci Sınav Ortalama Hesaplama Uygulaması!");
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine();

            //int exam1, exam2, exam3, average;
            //string result  = "Hata!";
            //Console.Write("1.sınav sonucunuzu yazınız: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sınav sonucunuzu yazınız: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("3.sınav sonucunuzu yazınız: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat..";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 80)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi!";
            //}

            //Console.WriteLine(result);

            //Console.Write("Lütfen şehir giriiş yapınız: ");
            //string city;
            //city = Console.ReadLine();

            //if (city == "adana" || city == "ankara" || city == "bursa")
            //{
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string userName;
            //userName = Console.ReadLine();

            //if (userName != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz Bora bey!");
            //}

            #endregion

            #region Mod

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz");
            //int  number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            #endregion

            #region Char
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.Write("hamsispor");
            //}
            #endregion

            #region Ornek proje uygulaması

            //Console.WriteLine("***Restoran Menü***");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("------------------------");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Ana Yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Balaban Köfte");
            //    Console.WriteLine("2-Köri soslu tavuk");
            //    Console.WriteLine("3-Lazanya");
            //    Console.WriteLine("4-Elbasan tava");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Çorbalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Merco");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Tarhana");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Tatlılar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Şekerpare");
            //    Console.WriteLine("2-Tiramusu");
            //    Console.WriteLine("3-Kemalpaşa");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------İçecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Şalgam");
            //}
            #endregion

            #region HesapMakinesi

            int number1, number2, result;
            char symbol;
            Console.Write("Birinci sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Sonuç:" + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Sonuç: " + result);
                        break;
            }

            Console.Read();
            #endregion
        }
    }
}
