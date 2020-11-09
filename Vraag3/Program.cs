using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = new string('*', 100);
            int[] Postnummer = new int[] { 9300, 2000, 1000, 9200, 9000, 8500, 9700, 2300 };
            string[] Naamstad = new string[] { "Aalst", "Antwerpen", "Brussel", "Dendermonde", "Gent", "Kortrijk", "Oudenaarde", "Turnhout" };


            int infos;
            do
            {
                Console.WriteLine(line);
                Console.WriteLine("\tKies 1 om naar postcode te zoeken of 2 per stad");
                infos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(line);
                switch (infos)
                {
                    case 1:
                        Console.Write("Postcode alstublieft : ");
                        int codeIngevoerd = Convert.ToInt32(Console.ReadLine());
                        if (codeIngevoerd == Postnummer[0])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Naamstad[0]);
                        }
                        else if (codeIngevoerd == Postnummer[1])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Naamstad[1]);
                        }
                        else if (codeIngevoerd == Postnummer[2])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Naamstad[2]);
                        }
                        else if (codeIngevoerd == Postnummer[3])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Naamstad[3]);
                        }
                        else if (codeIngevoerd == Postnummer[4])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Naamstad[4]);
                        }
                        else if (codeIngevoerd == Postnummer[5])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Naamstad[5]);
                        }
                        else if (codeIngevoerd == Postnummer[6])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Naamstad[6]);
                        }
                        else if (codeIngevoerd == Postnummer[7])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Naamstad[7]);
                        }



                        Console.WriteLine(line);


                        break;

                    case 2:
                        Console.Write("Staad naam alstublieft : ");

                        string stadnaamIngevoerd = Console.ReadLine();
                        if (stadnaamIngevoerd == Naamstad[0])
                        {
                            Console.WriteLine("U heeft de Naam van stad ingevoerd " + Postnummer[0]);
                        }
                        else if (stadnaamIngevoerd == Naamstad[1])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Postnummer[1]);
                        }
                        else if (stadnaamIngevoerd == Naamstad[2])
                        {
                            Console.WriteLine("U heeft de postcode voor stad ingevoerd " + Postnummer[2]);
                        }


                        Console.WriteLine(line);
                        break;

                    default:
                        Console.WriteLine("infos passen niet bij ons repertoire");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (infos != 3);
        }
    }
}
