using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Pyramidal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         ****TR
             Kare piramidal sayı (square pyramidal number), 
             ilk doğal sayıların karelerinin toplamını temsil eder. 
             İlk birkaç kare piramidal sayı 1, 5, 14, 30, 55, 91, 
             140, 204, 285, 385, 506,… şeklindedir.

         ****ENG
             The square pyramidal number represents the sum of the 
             squares of the first natural numbers. 
             The first few square pyramidal numbers 
             */
            Console.WriteLine("Enter in number");
            int n = Convert.ToInt32(Console.ReadLine());
         
             int result = 0;     
             string print = " ";
             for(int i=1;i<=n;i++)    
             {
                print = print + i + "^2 ";   
                result = result + i * i;                      
                Console.WriteLine(print + " = " + result);
             }
            //Sorular https://www.yazilimkodlama.com/ sitesinden alınmıştır.
            Console.ReadKey();






        }
    }
}
