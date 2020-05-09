using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Donusumleri_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan adı, soyadı, yaşı ve cinsiyet bilgilerini alınız. Bilgileri aldıktan sonra kullanıcıya bir mesaj içerisinde bilgilerini toplu bir şekilde gösteriniz.
            string ad, soyad, cinsiyet;
            byte yas;
            Console.Write("Adınız: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();
            Console.Write("Yaşınız: ");
            yas = Convert.ToByte(Console.ReadLine());
            Console.Write("Cinsiyetiniz: ");
            cinsiyet = Console.ReadLine();
            Console.WriteLine("\n\nVerdiğiniz bilgilere göre;\nAdınız " + ad + "\nSoyadınız " + soyad + "\nYaşınız " + yas + "\nVe cinsiyetiniz " + cinsiyet + "'idir.");
            Console.ReadKey();
        }
    }
}
// \n : Bir alt satıra iner.
// \r : Satır başına iner.
// \t : Tab (5 space kadar boşluk bırakır).
