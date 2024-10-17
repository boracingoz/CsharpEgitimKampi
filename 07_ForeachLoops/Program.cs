using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach!
            //1- Variable
            //2- Variable name
            //3- In
            //4-KOleksiyon, Dizi, Liste adı

            //string[] cities = { "Istanbul", "Ankara", "Bilecik", "Eskisehir" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 5, 20, 10, 3123, 232 };

            //foreach (int nums in numbers)
            //{
            //    Console.WriteLine(nums);
            //}

            //int[] numbers = { 45, 5, 20, 10, 3123, 232 };

            //foreach (int nums in numbers)
            //{
            //    if (nums % 2 == 0)
            //    {
            //        Console.WriteLine(nums);
            //    }
            //}

            //int[] numbers = { 45, 5, 20, 10, 3123, 232 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);   

            //List<int> numbers = new List<int>()
            //{
            //    1,2, 3, 4,5,7,10
            //};

            //foreach (int nums in numbers)
            //{
            //    Console.WriteLine(nums);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Sınav Sistemi Uygulaması
            Console.WriteLine("****C# Eğitim Kampı Sınav Uygulaması****");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("----------------------------------------");
            Console.Write("Sınıfta kaç öğrenci olduğunu giriniz: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            string[] studentName = new string[studentCount];
            double[] studentsExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} adlı öğrencinin {j+1}. öğrencinin sınav notunu giriniz: ");
                    double value = double.Parse( Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentsExamAvg[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentsExamAvg[i]}");
                Console.WriteLine();

                if (studentsExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci ortalamsı dersi geçmeye yeterlidir. Tebrikler!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci ortalamsı dersi geçmeye yeterli değildir. :(...");
                    Console.WriteLine();
                }
            }

            Console.Read();
            #endregion
        }
    }
}
