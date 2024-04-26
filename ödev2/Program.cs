using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kdv hesapladığım için double değer girdim
            Console.WriteLine("ürün fiyatı giriniz");
            double urun_fiyat=Convert.ToDouble(Console.ReadLine());

            //kotogoriyi metinsel seçebilmek için string yaptım
            Console.WriteLine("ürün katogorisi seçin elektronik/gıda/diğer");
            string katogori=Console.ReadLine();

            //başlangıç değeri için kdv 0 olarak başladı değişkenlik gösterebilir
            double kdv = 0;

            if (katogori == "elektronik")
            {
                kdv = 0.22;
            }
            else if (katogori == "gıda")
            {
                kdv = 0.20;
            }
            else if (katogori == "diğer")
            {
                kdv = 0.23;
            }
            //toplam isimli bir değişken oluşturdum ve ürün fiyatı ve ürünün kdv değerini toplayıp tek bir değişkene atabilirm
            double toplam = urun_fiyat + (urun_fiyat * kdv);
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
