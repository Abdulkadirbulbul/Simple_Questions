using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Girilen 10 Sayının Tek Çift Olduğunu Yazan Program 
            //   The Program that Writes That 10 Numbers Entered Are Odd Even

            Console.WriteLine("Enter the number....");
            Console.WriteLine("");
            int []array = new int[10];
            int index = 0;
            // User is expected to enter value
            while (index < 10)
            {
                array[index]= Convert.ToInt32(Console.ReadLine());
                index++;
            }
            //  We take the values ​​into mode 2 and print the remainder in the if loop as odd or even.
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            for (int j = 0; j < 10; j++)
            {
                int mod = array[j] % 2;
                if (mod == 0)
                {
                    Console.WriteLine(array[j] + " = Double");
                }
                else
                {
                    Console.WriteLine(array[j] + " = Odd");
                }
            }
            Console.ReadKey();
         // Github AbdulkadirBulbul

        }
    }
}
