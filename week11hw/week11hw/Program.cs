using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. Topla_Carp(int a, int b, ref/out int add, ref/out int mult)  
isimli bir fonksiyon yazınız.Bu fonksiyon içerisinden 
hesaplanan topla ve carp değerlerini ana fonksiyon içerisinden
 ekrana yazdırınız.
*/

namespace week11hw
{
    internal class Program
    {

        public void topla_carp(int a, int b , out int add , out int mult)
        {
            add = a + b;
            mult = a * b;

        }



        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            int a, b;
            Console.WriteLine("Enret the value of a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enret the value of b :");
            b = Convert.ToInt32(Console.ReadLine());
            
            Program p = new Program();
            int add, mult;

            p.topla_carp(a, b, out add, out mult);

            Console.WriteLine("the sum of a and b is :" + add);
            Console.WriteLine("the multi of a and b is :" + mult);
        }
    }
}
