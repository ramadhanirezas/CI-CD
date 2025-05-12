using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Title = "Kalkulator Sederhana";
            do
            {
                int hasil;
                Console.Write("Inputkan nilai a= ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b= ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pilih menu kalkulator: \n" +
                    "1. Penambahan \n" +
                    "2. Pengurangan \n" +
                    "3. Perkalian \n" +
                    "4. Pembagian \n");
                Console.Write("Menu: ");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        hasil = a + b;
                        Console.WriteLine("Penambahan: " + hasil); 
                        break;
                    case "2":
                        hasil = a - b;
                        Console.WriteLine("Pengurangan: " + hasil);
                        break;
                    case "3":
                        hasil = a * b;
                        Console.WriteLine("Perkalian: " + hasil);
                        break;
                    case "4":
                        hasil = a / b;
                        Console.WriteLine("Pembagain: " + hasil);
                        break;
                    default: 
                        Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                        break;
                }
                Console.WriteLine("\nTekan sembarang key untuk keluar");
                Console.ReadKey();
            }
            while (false);
        }
    }
}