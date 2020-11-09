using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag2
{
    class Program
    {
        static void PasswordGenerator()
        {
        
            char[] array1 = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7','8','9'};
            char[] array2 = new char[5];
            var random = new Random();
		
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[random.Next(array1.Length)];
            }
            Console.Write("Paswoord van 5 willekeurige karakters ");
            Console.WriteLine("\n-------------------------------------------------------");
            Console.WriteLine(array2);
		    Console.WriteLine("\n-------------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Een paswoord moet gegenereerd");
            Console.WriteLine("Met 1. ja of 2. nee");
            int infos = Convert.ToInt32(Console.ReadLine());
           
                switch (infos)
                {
                    case 1:                       
						
						// Console.Write("Postcode alstublieft : ");
						PasswordGenerator();
             
                        break;

                    case 2:
                        Console.Write("Tot ziens  ");
              
                        break;


                }
        }
    }
}
