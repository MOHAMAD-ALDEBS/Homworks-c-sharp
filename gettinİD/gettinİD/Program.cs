using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * ÖDEV :PersoneIimizin TC kmik Numarasını alacağız ve şu kontrollerin yapılmasını istiyoruz.
SET ŞARTLARI
ı. TC KİMLİK NO 'su 11 karakter olmalı
2- Tüm karakterleri sayisal karakter olmalı
GET ŞARTI
TC kimlik no•sunun ilk 5 karakterini alacağız hepsini değil. 
*/

namespace gettinİD
{
    class personal
    {
        private string id;
        public string ID
        {

            get
            {
                if (id != null)
                {
                    return id.Substring(0, 5);
                }
                return null;
            }

            set
            {
                if ( value.Length !=11 )
                {
                    Console.WriteLine("the tc is not 11 characters !");
                }
                else if (!value.All(char.IsDigit))
                {
                    Console.WriteLine("all characters has to be digit !!");
                }
                else { id = value; }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            personal p1 = new personal();

            while (p1.ID == null)
            {   
                Console.WriteLine("Enter the TC number please : ");
                String input = Console.ReadLine();
                p1.ID = input;      
            }
            Console.WriteLine("the first 5 ch is :" + p1.ID);
        }
    }
}
