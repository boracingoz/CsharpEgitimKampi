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
            #region Arrays beginner
            //Dizi syntax = Değişken türü[] DiziAdı = new DeğişkenTürü[Eleman sayısı]
            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Yellow";
            //colors[2] = "White";
            //colors[3] = "Black";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Istanbul";
            //cities[2] = "Lyon";
            //cities[3] = "Vancouver";
            //cities[4] = "New York";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 0;
            //numbers[1] = 2;
            //numbers[2] = 4;
            //numbers[3] = 6;
            //numbers[4] = 8;
            //numbers[8] = 100;

            //Console.WriteLine(numbers[8]); 

            //string[] cities = { "Prag", "Roma", "Ankara", "Tokyo" };

            //Console.WriteLine(cities[1]);
            #endregion

            #region Dizideki Tüm elemanları listeleme

            //string[] colors = { "Red", "Black", "Yellow", "Blue", "Green", "Orange" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbol = { 'a', 'b', 'c', 'd' };

            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //int[] myArray = { 47, 85, 95, 1100, 5, 10, 312, 23, 12321 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);  
            #endregion

            #region Arrays Methods
            //string[] people = { "ali", "ayşe", "fatma", "ahmet", "veli", "kemal" };
            //Console.WriteLine(people.Length);

            //int[] numbers = { 1, 2, 10, 20, 3123, 5, 6 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "buse", "ayşe", "ahmet" }; //dizide bir şey arama!

            //int index = Array.IndexOf(customers, "buse");
            //Console.WriteLine(index);
            #endregion

            #region Kullanıcıdan Değer alma 

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen{i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10, 20, 30, 40, 59};
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            int[] numbers = {21,32, 43, 54, 65, 76, 87, 98, 99, 100};

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();
            Console.WriteLine("---------------------");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2==0)
                {
                    Console.WriteLine(numbers[i]);
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");

            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();
            Console.WriteLine("---------------------");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }

            }

            Console.Read();
            #endregion
        }
    }
}
