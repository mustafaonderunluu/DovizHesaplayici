using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DövizHesaplayıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                // Döviz kurları
                double usdToTry = 32.15;
                double eurToTry = 34.85;

                Console.WriteLine("Hoş geldiniz!");
                Console.WriteLine("Lütfen dönüştürmek istediğiniz miktarı ve döviz türünü seçin.");
                Console.WriteLine("1. USD to TRY");
                Console.WriteLine("2. EUR to TRY");

                Console.Write("Miktar: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Seçenek: ");
                int option = Convert.ToInt32(Console.ReadLine());

                double result = 0;

                switch (option)
                {
                    case 1:
                        result = amount * usdToTry;
                        Console.WriteLine("{0} USD, {1} TRY'ye eşittir.",amount,result);
                        break;
                    case 2:
                        result = amount * eurToTry;
                        Console.WriteLine("{0} EUR, {1} TRY'ye eşittir.",amount,result);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek!");
                        break;
                }

                Console.WriteLine("İyi günler!");
             Console.ReadKey();
            }
        }

    }


