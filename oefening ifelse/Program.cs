using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            // oefening 1

            Console.WriteLine("Oefening 1: ");
            Console.Write("\nGetal 1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Getal 2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Het grootste getal is: " + Math.Max(getal1, getal2));

            // oefening 2 

            Console.WriteLine("\nOefening 2: ");

            Console.Write("\nGetal: ");
            int getal3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((getal3 >= 5)?"Geslaagd!":"Gebuisd...");

            // oefening 3 

            Console.WriteLine("\nOefening 3: ");
            Console.Write("\nGetal: ");
            int getal4 = Convert.ToInt32(Console.ReadLine());

            if ((getal4 >= 0) && (getal4 <= 9))
            {
                Console.WriteLine("Dat is een " + ((getal4 % 2 == 0) ? "even" : "oneven") + " getal.");
            }
            else
            {
                Console.WriteLine("Dat is een geen juist getal");
            }
            

            // oefening 4

            Console.WriteLine("\nOefening 4: ");
            Console.Write("\nPrijs fiets: ");
            int getal5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prijs na 20% korting: " + ((getal5 >= 400) ? (getal5 * 0.8) : (getal5)) + " getal.");

            // oefening 5

            Console.WriteLine("\nOefening 5: ");
            Console.Write("\nOh nee! Het brandalarm gaat af!\nIs er iemand thuis? (Y/N): ");
            char bThuis = Convert.ToChar(Console.ReadLine().ToUpper());

            if (bThuis == 'Y')
            {
                Console.Write("\nHeeft u de situatie onder controle? (Y/N)");
                char bControle = Convert.ToChar(Console.ReadLine().ToUpper());
                if (bControle == 'Y')
                {
                    Console.WriteLine("Het alarm wordt uitgeschakeld.");
                }
                else
                {
                    if (bControle == 'N')
                    {
                        Console.WriteLine("De brandweer wordt verwittigd.");
                    }
                }
            }
            else
            {
                if (bThuis == 'N')
                {
                    Console.WriteLine("De brandweer wordt verwittigd.");
                }
            }

            // oefening 6

            Console.WriteLine("\nOefening 6: ");
            Console.Write("\nHeb je vandaag moeten lachen? (Y/N): ");
            char bLachen = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("Heb je vandaag iets productief gedaan? (Y/N): ");
            char bPos = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("Scheen de zon vandaag? (Y/N): ");
            char bZon = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("Heb je iets lekkers gegeten vandaag? (Y/N): ");
            char bLekker = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("Kijk je uit naar morgen? (Y/N): ");
            char bMorgen = Convert.ToChar(Console.ReadLine().ToUpper());

            int teller;

            teller = (bLachen == 'Y')?1:0;
            teller += (bPos == 'Y') ? 1 : 0;
            teller += (bZon == 'Y') ? 1 : 0;
            teller += (bLekker == 'Y') ? 1 : 0;
            teller += (bMorgen == 'Y') ? 1 : 0;

            Console.WriteLine((teller>3)?"Super! :)":"");

            // oefening 7

            Console.WriteLine("\nOefening 7: ");
            Console.Write("\nGetal 1: ");
            int getal71 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Getal 2: ");
            int getal72 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Getal 3: ");
            int getal73 = Convert.ToInt32(Console.ReadLine());
            int temp; 

            if (getal71<getal72)
            {
                if (getal71>getal73)
                {
                    temp = getal71;
                    getal71 = getal73;
                }
                
            }
            else
            {
                if (getal72<getal73)
                {
                    temp = getal71;
                    getal71 = getal72;
                    getal72 = temp;
                }
                else
                {
                    temp = getal71;
                    getal71 = getal73;
                    getal73 = temp;
                }
            }
            Console.WriteLine($"\n {getal71} - {getal72} - {getal73}");

            // oefening 8

            Console.WriteLine("\nOefening 8: ");
            Console.Write("\nWiskunde: ");
            int wiskunde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aarderijkskunde: ");
            int aarderijkskunde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Economie: ");
            int economie = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geschiedenis: ");
            int geschiedenis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Frans: ");
            int frans = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nederlands: ");
            int nederlands = Convert.ToInt32(Console.ReadLine());
            Console.Write("Engels: ");
            int engels = Convert.ToInt32(Console.ReadLine());
            Console.Write("ICT: ");
            int ict = Convert.ToInt32(Console.ReadLine());

            int aantalBuizen;
            double gemiddelde;

            aantalBuizen = (wiskunde < 50) ? 1 : 0;
            aantalBuizen += (aarderijkskunde < 50) ? 1 : 0;
            aantalBuizen += (economie < 50) ? 1 : 0;
            aantalBuizen += (geschiedenis < 50) ? 1 : 0;
            aantalBuizen += (frans < 50) ? 1 : 0;
            aantalBuizen += (nederlands < 50) ? 1 : 0;
            aantalBuizen += (engels < 50) ? 1 : 0;
            aantalBuizen += (ict < 50) ? 1 : 0;

            gemiddelde = ((double)wiskunde + aarderijkskunde + economie + geschiedenis + frans + nederlands + engels + ict) / 8;

            Console.WriteLine($"\nJe hebt {aantalBuizen} buizen.\nJouw gemiddelde is {Math.Round(gemiddelde,2)}");

            // oefening 10

            Console.WriteLine("\nOefening 10: ");
            Console.WriteLine("Hey ik ben een chatrobot! Alles goed?");
            Console.WriteLine("1: Ja met mij gaat het goed, met jou?");
            Console.WriteLine("2: Neen :(");
            Console.Write("Antwoord?: ");

            char Antwoord = Convert.ToChar(Console.ReadLine());
                       

            // wachten

            Console.ReadLine();
        }
        static public char chatKeuze(string vraag, string antwoord1, string antwoord2)
        {
            Console.WriteLine("Hey ik ben een chatrobot! Alles goed?");

            return ' ';
        }
    }
}
