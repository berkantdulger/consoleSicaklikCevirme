using System;

namespace sıcaklıkCevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            double b;
            Console.WriteLine("Lütfen Fahrenheit cinsinden sıcaklık değerini giriniz");
            double f = Convert.ToDouble(Console.ReadLine());

            b = f - 32;
            c = b / 1.8;

            Console.WriteLine("Celcius değeri " + c );
            Console.ReadLine();
        }
    }
}
