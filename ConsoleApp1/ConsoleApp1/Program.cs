using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/*
 * Bir Tane öğrencimiz olucak ; öğrencinin oğrencNo. isim. soyisim . vize1, vize2. final ve okul ismi adında değişkenlerim olacak erişim
belirleyicileri private yapacağız yapıcı metot kullanarak değtşkenlere değerleri atayacağız..


ogrencıOrtaiamasBul() metodu olacak
okulGetjr() metodu obcak
Öğrencinin secimdne göre işlemler yapacağız
1- Öğrenci bi19deri Göster
2- Öğrenci Ortalaması Göster
3- Öğrencmm Okulunu Öğren
4- Çıkış Yap 
*/

namespace ConsoleApp1
{
    class ogrenci
    {
        //private int OgrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int final;
        private int vize2;
        private string okul;

        public int OgrenciNo { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public int Vize1 { get; set; }
        public int Vize2 { get; set; }
        public int Final { get; set; }
        public string Okul { get; set; }


        public ogrenci(int OgrenciNo, string İsim, string Soyisim, int Vize1, int Vize2, int Final, string Okul)
        {
            this.OgrenciNo = OgrenciNo;
            this.İsim = İsim;
            this.Soyisim = Soyisim;
            this.Vize1 = Vize1;
            this.Vize2 = Vize2;
            this.Final = Final;
            this.Okul = Okul;
        }

        public double ogrencininortalamasiBul()
        {
            return ((Vize1 + Vize2 + Final) / 3);
        }


        public void okulugetir()
        {
            Console.WriteLine(Okul);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrn1 = new ogrenci(2110206583, "muhammed", "aldebs", 90, 85, 80, "Karabük Üniversitesi");

            while (true) {

                Console.WriteLine("1- Öğrenci Bilgilerini Göster");
                Console.WriteLine("2- Öğrenci Ortalamasını Göster");
                Console.WriteLine("3- Öğrencinin Okulunu Öğren");
                Console.WriteLine("4- Çıkış Yap");
                Console.Write("Bir seçim yapınız: ");
                Console.WriteLine();

                int secim = Convert.ToInt16(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("öğrencinin numarası : " + ogrn1.OgrenciNo);
                        Console.WriteLine("öğrencinin isim,soyismi : " + ogrn1.İsim + " " + ogrn1.Soyisim);
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.WriteLine("öğrencinin ortalamasi : "+ ogrn1.ogrencininortalamasiBul());
                        Console.WriteLine();

                        break;
                    case 3:
                        ogrn1.okulugetir();
                        Console.WriteLine();

                        break;
                    case 4:
                        Console.WriteLine("cikiş yapiliyor ..");
                        Console.WriteLine();

                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        Console.WriteLine();

                        break;
                }
            }
        }
    }
}
