using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //double applePrice, tomatoPrice, potatoPrice, strawberryPrice, watermelonPrice;
            //applePrice = 18.25;
            //tomatoPrice = 14.50;
            //potatoPrice = 8.00;
            //strawberryPrice = 50.75;
            //watermelonPrice = 13.60;
            //Console.WriteLine("Elmanın Kilo Fiyatı : "+  applePrice+"  TL'dir");
            //Console.WriteLine();
            //Console.WriteLine("Domatesin Kilo Fiyatı : " + tomatoPrice + "  TL'dir.");
            //Console.WriteLine();
            //Console.WriteLine("Patatesin Kilo Fiyatı : " + potatoPrice + "  TL'dir.");
            //Console.WriteLine();
            //Console.WriteLine("Çileğin Kilo Fiyatı : " + strawberryPrice + "  TL'dir.");
            //Console.WriteLine();
            //Console.WriteLine("Karpuzun Kilo Fiyatı : " + watermelonPrice + "  TL'dir.");

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine();

            //double appleGram , tomatoGram , potatoGram , strawberryGram , watermelonGram ;

            //appleGram = 1.25;
            //tomatoGram = 2.5;
            //potatoGram = 5.67;
            //strawberryGram = 0.68;
            //watermelonGram = 15.35;

            //double appleTotalPrice = applePrice * appleGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double watermelonTotalPrice = watermelonPrice * watermelonGram;

            //Console.WriteLine("Alınan Elmanın Fiyatı : "+ appleTotalPrice + " TL'dir");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Domatesin Fiyatı : " + tomatoTotalPrice + " TL'dir");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Patatesin Fiyatı : " + potatoTotalPrice + " TL'dir");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Çileğin Fiyatı : " + strawberryTotalPrice + " TL'dir");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Karpuzun Fiyatı : " + watermelonTotalPrice + " TL'dir");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");







            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("******* İstanbul Havaalanı Yolcunun Bilgileri *******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();

            //string passangerName , passangerSurname , passangerCity , passangerAge , passangerİd , passangerDistrict ;

            //Console.Write("İsminizi Giriniz : ");
            //passangerName = Console.ReadLine();
            //Console.Write("Soy İsminizi Giriniz : ");
            //passangerSurname = Console.ReadLine();
            //Console.Write("TC Kimlik Numaranızı Giriniz : ");
            //passangerİd = Console.ReadLine();
            //Console.Write("Yaşınızı Giriniz : ");
            //passangerAge = Console.ReadLine();
            //Console.Write("İkamet Ettiğiniz İlin İsmini Giriniz : ");
            //passangerCity = Console.ReadLine();
            //Console.Write("İkamet Ettiğiniz İlçenin İsmini Giriniz : ");
            //passangerDistrict = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Yolcunun İsmi :"+ passangerName + " --- " + "Yolcunun Soyismi :"+ passangerSurname + " --- " + "Yolcunun TC Kimlik Numarası :" + passangerİd + " --- " + "Yolcunun Yaşı :"+ passangerAge + " --- " + "Yolcunun Bulunduğu İl :"+passangerCity + " --- " + "Yolcunun Bulunduğu İlçe : " + passangerDistrict );




            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int computerPrice, phonePrice, tvPrice;

            //computerPrice = 5000;
            //phonePrice = 12000;
            //tvPrice = 5000;

            //int computerCount , phoneCount , tvCount ;

            //Console.Write("Aldığınız bilgisayar sayısını giriniz : ");
            //computerCount=int.Parse(Console.ReadLine());
            //Console.Write("Aldığınız telefon sayısını giriniz : ");
            //phoneCount = int.Parse(Console.ReadLine());
            //Console.Write("Aldığınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine();

            //int totalPrice;
            //totalPrice = computerPrice * computerCount + phonePrice * phoneCount + tvPrice * tvCount;
            //Console.Write("Aldığınız ürünlerin toplam fiyatı :" +totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, resault;

            //Console.Write("Lütfen 1.sınav notunuzu girin:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunuzu girin:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunuzu girin:");
            //exam3 = double.Parse(Console.ReadLine());

            //resault = (exam1+exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınavlarınızın Ortalama Notu:" + resault);





            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz:");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);

            #endregion

      

            Console.Read();
        }
    }
}
