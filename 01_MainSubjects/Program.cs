using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlanğıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //değişken_türü değişken_adı;

            //string name;
            //name = "Metin";
            //Console.Write(name);

            //string custonerName;
            //string custonerSurname;
            //string custonerPhone;
            //string custonerEmail, district, city;

            //custonerName = "Ali";
            //custonerSurname = "Çınar";
            //custonerPhone = "+90 500 400 30 20";
            //custonerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + custonerName + " " + custonerSurname);
            //Console.WriteLine("İletişim:" + custonerPhone);
            //Console.WriteLine("Email Adresi: " + custonerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine();

            //custonerName = "Ayşegül";
            //custonerSurname = "Kaya";
            //custonerPhone = "+90 400 300 80 70";
            //custonerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + custonerName + " " + custonerSurname);
            //Console.WriteLine("İletişim:" + custonerPhone);
            //Console.WriteLine("Email Adresi: " + custonerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("--------------------------------------------------");

            #endregion

            #region İnt Değişkenler

            //int
            //int number = 24;
            //Console.Write(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemmonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hanburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("----- Kola: " + cokePrice + "Tl");
            Console.WriteLine("----- Limonata: " + lemmonadePrice + "TL");
            Console.WriteLine("----- Kızartma: " + friesPrice + "tl");
            Console.WriteLine("----- Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menu Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemmonadePrice;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalPizzaPrice +
                totalWaterPrice + totalLemonadePrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");

            #endregion

            Console.Read();
        }
    }
}




// yazdırma komutları