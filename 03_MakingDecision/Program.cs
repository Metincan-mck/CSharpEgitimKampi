﻿using System;
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
            #region if Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number =int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "hata";

            //Console.Write("Sına1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sına2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sına3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();" | c

            //if (city == "adana" |  city == "ankaraity == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut degil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1 sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2 sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1 sayının 2 sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

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
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** c# Eğitim Kampı Restorant ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem  == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Köri Soslu Tavuk");
            //    Console.WriteLine("2 - Kızartma Tabagı");
            //    Console.WriteLine("3 - Fasulye Pilav");
            //    Console.WriteLine("4 - Fırında Somon");
            //    Console.WriteLine("5 - Patlıcan Musakka");
            //    Console.WriteLine("------------ Ana Yemekler ------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Mercimek Çorbası");
            //    Console.WriteLine("2 - Ezogelin çorbası");
            //    Console.WriteLine("------------ Çorbalar ------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Akdeniz Pizza");
            //    Console.WriteLine("2 - Margaritha");
            //    Console.WriteLine("2 - Tavuklu Pizza");
            //    Console.WriteLine("------------ Pizzalar ------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Kola");
            //    Console.WriteLine("2 - Ayran");
            //    Console.WriteLine("2 - Su");
            //    Console.WriteLine("------------ İçecekler ------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Triliçe");
            //    Console.WriteLine("2 - Kazandibi");
            //    Console.WriteLine("2 - Sütlaç");
            //    Console.WriteLine("------------ Tatlılar ------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Agustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kaım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break; 
            //}

            #endregion

            #region Switch Case Hesap Makinası 

            //int number1, number2, resukt;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        resukt = number1 + number2;
            //        Console.WriteLine("Toplam: " + resukt);
            //        break;

            //    case '-':
            //        resukt = number1 - number2;
            //        Console.WriteLine("Fark: " + resukt);
            //        break;

            //    case '*':
            //        resukt = number1 * number2;
            //        Console.WriteLine("Çarpım: " + resukt);
            //        break;

            //    case '/':
            //        resukt = number1 / number2;
            //        Console.WriteLine("Bölüm: " + resukt);
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}