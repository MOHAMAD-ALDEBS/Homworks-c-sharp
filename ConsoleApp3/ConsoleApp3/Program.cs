using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
         double getavrg ( int[]arr,int size)
        {
            double avg;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            for (int i = 0; i < size; i++)
            {
                sum = sum + arr[i];
            }
            avg =(double )sum / size;
            return avg;
        }

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


            double avg;
            Program a = new Program();
            avg = a.getavrg(myarr, 10);
            Console.WriteLine();

            Console.WriteLine("your dizi now is ");
            foreach (int i in myarr)
            {
                Console.Write(i + " ,");
            }

            Console.WriteLine();
            Console.WriteLine("the avrege of arr after kare is : "+avg);

        }
    }
}


