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
            //    Console.WriteLine("Çağrı Harun");
            //    Console.WriteLine("Atahan Kayhan");
            //    Console.WriteLine("Bekir Yılmaz");
            //    Console.WriteLine("Mithat Meydan");
            //}
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 3;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();






            #endregion

            #region Geriye Değer Döndürmeyen String Metotlar

            //void customerName(string name , string surName)
            //{
            //    Console.WriteLine("Müşterinin Adı: "+ name + " "+ surName);
            //}
            //customerName("Mehmet", "Poyraz");
            //customerName("Lamine", "Yamal");
            //customerName("Kenan", "Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen İnt Metotlar

            //void sum (int number1,int number2,int number3)
            //{
            //    int total = number1 + number2 + number3;
            //    Console.WriteLine(total);
            //}
            //sum(2, 3, 4);

            #endregion

            #region Geriye Değer Döndüren  Metotlar

            //string studentCard()
            //{
            //    string name = "Bahadır";
            //    string surName = "Kaya";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(studentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli  Metotlar

            //string CountryCard(string country,string capital,string flagColour)
            //{
            //    string cardİnfo = "Ülke: " + country + " Başkent: " + capital + " Bayrak Rengi: " + flagColour;
            //    return cardİnfo;
            //}
            //string x, y,z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

            #region Geriye Değer Döndüren İnt Parametreli  Metotlar

            //int sum(int number1,int number2)
            //{
            //    int result= number1 + number2; 
            //    return result;
            //}
            //Console.WriteLine(sum(23, 54)); 
            //Console.WriteLine(sum(32, 78)); 
            //Console.WriteLine(sum(65, 98)); 

            #endregion

            #region Örnek Uygulama

            //string studentExamİnfo(string studentName,int exam1,int exam2)
            //{
            //    int result = (exam1 + exam2) / 2;

            //    if (result >= 50)
            //    {
            //        return studentName + " isimli öğrenci başaralı oldu." + " --- Ortalaması --- : " + result;
            //    }
            //    else
            //    {
            //        return studentName + " isimli öğrenci başarısız oldu." + " --- Ortalaması --- : " + result;
            //    }
            //}

            //Console.WriteLine(studentExamİnfo("Mehmet Poyraz",60,56));
            //Console.WriteLine(studentExamİnfo("Baki Demir",40,36));



            #endregion

            Console.Read();
        }
    }
}
