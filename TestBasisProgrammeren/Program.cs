using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBasisProgrammeren
{
    class Program
    {

        static void Bedrag()
        {
            Console.WriteLine("Geef me alstublieft uw factuur:");
            decimal Korting = 0.05M;
            decimal Bedrag = Convert.ToInt32(Console.ReadLine());

            decimal Resultaat = Bedrag * Korting;

            if (Bedrag>5000)
            {
                Console.WriteLine("Een korting van 5% is toegestaanen {0:C} en het resultaat is {1:C}.", Resultaat,Bedrag-Resultaat);
            }
            else
            {
                Console.WriteLine($"Het bedrag is {Bedrag:C}.");
            }
        }



        static void Main(string[] args)
        {
            Bedrag();
        }
    }
}
