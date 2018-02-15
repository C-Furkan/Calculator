using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string islem = "";
            Console.Write("1. sayi : ");
            double n_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayi : ");
            double n_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İsleminiz : ");
            islem = Console.ReadLine();
            if (islem == "+")                                            //Mzeycan
            {

            }
            else if (islem == "-")
            {

            }
            else if (islem == "*")
            {
                Console.WriteLine("Sonuç = " + carpma(n_1, n_2));
            }
            else if (islem == "/")
            {
                Console.WriteLine("Sonuç = " + bölme(n_1, n_2));             //Mzeycan
            }
        }

        public static double bölme(double number_1, double number_2)
        {
            double result = 0;
            result = number_1 / number_2;
            return result;

        }
        public static double carpma(double x, double y)               //Mzeycan
        {
            double sonuc = 0;
            sonuc = x * y;
            return sonuc;
        }
    }
}
