using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 10 elemanlı integer sayılardan oluşan bir dizi oluşturulacak. 
Diziyi tersten, sıralıi string ifadeye çevrilmiş ve dizinin kullanıcının istediği
 elemanını ekrana yazdıran programı Array class methodları kullanarak yazınız. */


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] myarr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter the {0}. value please :", i + 1);
                myarr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("your dizi is :");
            foreach (int i in myarr)
            {
                Console.Write(i + " ,");
            }
            Array.Reverse(myarr);
            Console.WriteLine();
            Console.WriteLine("your dizi after reversing is:");
            foreach (int i in myarr)
            {
                Console.Write(i + " ,");
            }
            Array.Sort(myarr);
            Console.WriteLine();
            Console.WriteLine("your dizi after sorting is :");
            foreach (int i in myarr)
            {
                Console.Write(i + " ,");
            }

            int index;
            Console.WriteLine("which eleman you want to see :");
            index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(myarr[index - 1]);
        }
       
    }
}
