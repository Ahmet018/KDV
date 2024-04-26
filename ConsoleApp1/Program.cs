using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı adı ve sifre oluşturdum
            string ad = "admin";
            string sifre = "12345";

            //kullanıcı adı ve şifre istedim
            Console.WriteLine("kullanıcı adı giriniz:");
            string kullanici_adi= Console.ReadLine();

            Console.WriteLine("şifre giriniz");
            string passwd=Console.ReadLine();    


            //kullanıcı adı ve şifrenin başta oluşturduğum kullanıcı adı ve şifreye denk olmasını sağladım
            if (kullanici_adi==ad && passwd==sifre)
            {
                Console.WriteLine("kullanıcı girişi başarılı");
            } 
            //boş değer girilip girilmeğini kontrol ettim
            else if (kullanici_adi=="" && passwd=="")
            {
                Console.WriteLine("kullanıcı adı ve sifre alanı boş bırakılamaz");
            }
            else
            {
                Console.WriteLine("hatalı giriş");
            }
            Console.ReadLine();
        }
    }
}
