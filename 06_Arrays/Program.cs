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

            //string[] colors = new string[4];
            //colors[0] = "Siyah";
            //colors[1] = "Beyaz";
            //colors[2] = "Mavi";
            //colors[3] = "Yeşil";

            //Console.WriteLine(colors[0]);

            //string[] country = new string[5];
            //country[0] = "Almanya";
            //country[1] = "Fransa";
            //country[2] = "Brezilya";
            //country[3] = "Mısır";
            //country[4] = "Arjantin";

            //Console.WriteLine(country[4]);

            //int[]numbers=new int[10];
            //numbers[0] = 16;
            //numbers[1] = 28;
            //numbers[6] = 540;
            //numbers[4] = 982;
            //numbers[9] = 332;

            //Console.WriteLine(numbers[6]);

            //Tanımlamadığımız dizilerin değeri 0 olur. Öreneğin burdaki number[7] gibi.

            //string[] cities = { "İstanbul", "Ankara", "Bursa", "Manisa", "Gümüşhane" };

            //Console.WriteLine(cities[4]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Mavi", "Kırmızı", "Siyah", "Sarı", "Mor" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 7, 456, 7432, 5246, 235, 223, 462, 6432, 46773, 84 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 7 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //char[] symbols = { 'A', 'B', 'C', '*', '-', '/', '+' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 1, 24, 53, 2566, 2357, 7346, 235, 13, 64, 27, 853 };

            //int maxNumber = numbers[0];

            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metodları

            // Küçükten Büyüğe Doğru Sıralama

            //int[] numbers = { 23, 24, 63, 76, 42, 98, 12, 65, 85, 45, 3, 6 };

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // Diziyi Tersten Sıralama 

            //int[] numbers = { 23, 24, 63, 76, 42, 98, 12, 65, 85, 45, 3, 6 };

            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 23, 24, 63, 76, 42, 98, 12, 65, 85, 45, 3, 6 };

            //Console.WriteLine("Dizini En Büyük Elemanı : " + numbers.Max()+ " Dizinin En Küçük Elemanı : "+ numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alarak Dizi Oluşturma

            //string[] cities = new string[4];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 23, 24, 63, 76, 42, 98, 12, 65, 85, 45, 3, 6 };
            //Array.Sort(numbers);
            //Console.WriteLine("Çift Sayılar : ");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Tek Sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion



            Console.Read();
        }
    }
}
