using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //Console.Write("Lütfen yazdırmak istediğiniz kelimenin adedini giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Şampiyon Trabzonspor");
            //}




            #endregion

            #region For Döngüsüyle Karar Yapıları

            //for (int i = 0; i<= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{

            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 0; i <=20 ; i++)
            //{
            //    if (i % 2 ==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //    for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count += 1;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+". saat sonundaki bakteri sayısı: "+bacterium);
            //}



            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Dünyalı");
            //    i++;
            //}

            //int i = 1;
            //while (i<=60)
            //{
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine("Naber Müdür");
            //    }
            //    i++;
            //}



            #endregion

            #region Örnek Sınav Sorusu

            //Console.Write("3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones = 0, tens = 0, hundreds = 0;

            //int totalValue = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 100 == 0)
            //    {
            //        hundreds += 1;
                    
            //    }
                
            //}

            //tens = (number % 100) / 10;

            //ones = number % 10;


            //totalValue = ones + tens +  hundreds;
            //Console.WriteLine("Girdiğiniz sayının basamaklarındaki sayıların toplamı: "+totalValue);

            #endregion

            Console.Read();
        }
    }
}
    
