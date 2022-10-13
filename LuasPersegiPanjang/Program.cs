using System;

namespace LuasPersegiPanjang
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Program Menghitung luas persegi panjang
            double totalPP, panjang, lebar, result;

            Console.WriteLine("\t*** Menghitung Luas Persegi Panjang Menggunakan C# ***");
            
            Console.Write("\tMasukkan total persegi panjang yang ingin di hitung luasnya : ");
            totalPP = double.Parse(Console.ReadLine());

            for (var i = 1; i <= totalPP; i++)
            {
                Console.Write("\n\tMasukkan panjang persegi panjang ke-{0} cm) : ", i);
                panjang = double.Parse(Console.ReadLine());

                Console.Write("\tMasukkan lebar persegi panjang ke-{0} (cm) : ", i);
                lebar = double.Parse(Console.ReadLine());

                result = panjang * lebar;
                Console.WriteLine("\n\tLuasnya adalah : {0} cm", result);   
            }
        }
    }
}