using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İf Else

            //string password;
            //Console.Write("Lütfen şifrenizi giriniz: ");
            //password = Console.ReadLine();

            //if (password == "chs" )
            //{
            //    Console.WriteLine("Girdiğiniz şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Şehrinizi giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkenizi giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "gümüşhane"& country == "türkiye")
            //    {
            //    Console.WriteLine("Girdiğiniz veriler doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz veriler hatalı");
            //}

            //float exam1, exam2, exam3, avarage;
            //string result = "HATA";

            //Console.Write("1.sınav notunuzu giriniz: ");
            //exam1=float.Parse(Console.ReadLine());
            //Console.Write("2.sınav notunuzu giriniz: ");
            //exam2 = float.Parse(Console.ReadLine());
            //Console.Write("3.sınav notunuzu giriniz: ");
            //exam3 = float.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavlarınızın otalama notu: "+avarage);

            //if (avarage>=0 & avarage<=50)
            //{
            //    result = "Sonuç vasat "; 
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Sonuç ortalama ";
            //}
            //if (avarage > 70 & avarage < 85)
            //{
            //    result = "Sonuç iyi ";
            //}
            //if (avarage > 85)
            //{
            //    result = "Sonuç çok iyi ";
            //}
            //Console.WriteLine(result);

            #endregion

            #region Mod İşlemleri

            //int number = 27;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result= number1 % number2;
            //Console.WriteLine("1. sayının 2.sayıya bölümünden kalan : "+ result);

            //Console.Write("Sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Char Değişkenlerle Karar Yapıları
            //char team;
            //Console.Write("Takım sembolü giriniz : ");
            //team=char.Parse(Console.ReadLine());    

            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Başlangıçlar");
            //Console.WriteLine("3-Ana Yemekler");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine();

            //string menu= "0";

            //Console.Write("İstediğiniz kategoriyi seçiniz: ");
            //menu=Console.ReadLine();


            //if(menu == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Domates");
            //    Console.WriteLine("3-Yayla");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}

            //if (menu == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Başlangıçlar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Dolma");
            //    Console.WriteLine("2-Salata");
            //    Console.WriteLine("3-Börek");
            //    Console.WriteLine("----------Başlangıçlar----------");
            //    Console.WriteLine();
            //}

            //if (menu == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Fırında Tavuk");
            //    Console.WriteLine("2-Beşemal Soslu Bonfile");
            //    Console.WriteLine("3-Tuzda Balık");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}

            //if (menu == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Profiterol");
            //    Console.WriteLine("3-Helva");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //}

            //if (menu == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen gün girişi yapınız: ");
            //int dayNumber=int.Parse(Console.ReadLine());

            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.Write("Pazartesi");
            //        break;
            //    case 2:
            //        Console.Write("Salı");
            //        break;
            //    case 3:
            //        Console.Write("Çarşamba");
            //        break;
            //    case 4:
            //        Console.Write("Perşembe");
            //        break;
            //    case 5:
            //        Console.Write("Cuma");
            //        break;
            //    case 6:
            //        Console.Write("Cumartesi");
            //        break;
            //    case 7:
            //        Console.Write("Pazar");
            //        break;
            //    default: Console.WriteLine("Hatalı Giriş");
            //        break;
            //}


            #endregion

            #region Hesap Makinesi

            //int number1 , number2, result=0;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1= int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Sembolu Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = (number1 + number2);
            //        Console.WriteLine("Sonucunuz : "+ result);
            //        break;

            //    case '-':
            //        result = (number1 - number2);
            //        Console.WriteLine("Sonucunuz : " + result);
            //        break;

            //    case '*':
            //        result = (number1 * number2);
            //        Console.WriteLine("Sonucunuz : " + result);
            //        break;

            //    case '/':
            //        result = (number1 / number2);
            //        Console.WriteLine("Sonucunuz : " + result);
            //        break;


            //    default:
            //        Console.WriteLine("Doğru Sembolü Giriniz ");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
