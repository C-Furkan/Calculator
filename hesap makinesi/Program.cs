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
            double n_1 = Convert.ToDouble(Console.ReadLine());
            double n_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sonuç = "+bölme(n_1,n_2));
        }

        public static double bölme(double number_1,double number_2)
        {
            double result = 0;
            result = number_1 / number_2;
            return result;
        }
    }
}
