using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Manisa", "Tokat", "Konya", "Bilecik", "Lüleburgaz" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 23, 24, 63, 76, 42, 98, 12, 65, 85, 45, 3, 6 };
            //Array.Sort(numbers);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 23, 24, 63, 76, 42, 98, 12, 65, 85, 45, 3, 6 };
            //Array.Sort(numbers);

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //Console.WriteLine("------------------");

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {

            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 23, 24, 63, 76, 42, 98, 12, 65, 85, 45, 3, 6 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    12,35,63,75,23,87,54,24
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Çağrı Harun";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region Örnek Sınav Uygulaması 

            //Console.Write("***** Mustafa Kemal Anadolu Lisesi Sınav Sonuçları *****");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.Write("Sınıfınızda Kaç Öğrenci Olduğunu Giriniz : ");
            //int studentCount = int.Parse(Console.ReadLine());

            //string[]studentNames=new string[studentCount];
            //double [] studentValuesAvarage=new double[studentCount];
            
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}. öğrencinin ismini giriniz :");
            //    studentNames[i] = Console.ReadLine();

            //    double studentTotalPoints = 0;


            //    for(int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz :");
            //        int studentExam=int.Parse(Console.ReadLine());

            //        studentTotalPoints += studentExam;

            //    }
            //    studentValuesAvarage[i] = studentTotalPoints / 2 ;
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------------");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine($"{studentNames[i]} isimli öğrencinin sınav ortalaması :"+ studentValuesAvarage[i]);

            //}
            
            

            //for (int i = 0; i < studentCount; i++)
            //{
            //    if (studentValuesAvarage[i]>= 50 )
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten geçti .");
            //    }

            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı .");
            //    }


            //}

            #endregion

            Console.Read();

        }
    }
}
