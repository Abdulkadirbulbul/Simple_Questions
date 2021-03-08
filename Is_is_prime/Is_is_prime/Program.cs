using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_is_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gives the information whether the entered number is Prime or not.
            // Girilen Sayının Asal olup olmadığının bilgisini verir. 
            Console.WriteLine("Enter the number...");
            int number = Convert.ToInt32(Console.ReadLine());
            int divider = 2;                   // Asal sayıların bölenlerini bulabilmek için böleni 2 den başlatmak gerekir...
                                               // Çünkü 2 en küçük çift olan Asal sayıdır.
            Boolean result = false;    
            while (divider<number)
            {
                if (number % divider == 0)     // Girilen sayının bölene modu alınır , kalan 0 ise Asal olmadığı için
                                               // Boolean değerimizi false yapıp , break komutu ile While Döngüsünden
                                               // çıkıyoruz. Eğer bölünmez ise bu işlem bölenin sayıya eşit olana dek 
                                               // devam edecektir.
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
                divider++;


            }
            Console.WriteLine();
            String output;                    // Çıktımızı kullanabilmek için referans oluşturuyoruz.
            if (result == false)
            {
                output = " = It is not Prime!";
            }
            else
            {
                output = " = It is Prime!";
            }
            Console.WriteLine(number + output);        // Yazdırma işlemini  yapıyoruz. 
           
            Console.ReadKey();
        }
    }
}
