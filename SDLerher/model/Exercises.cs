using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Exercises
    {
        Displays display = new Displays();
        Menu menu = new Menu();

        public void KonjugationPrüfung(List<TunwortClass> tunwortList)
        {
            var random = new Random();

            string entry = "";
            string answer = "";
            string hilfsverb = "";
            string hilfsverbForm = "";
            string pronomen = "";

            bool play = true;
            do
            {
                int index = random.Next(tunwortList.Count);
                int formIndex = random.Next(3);
                int pronomenIndex = random.Next(5);

                if (tunwortList[index].Hilfsverb) { hilfsverb = "sy"; }
                if (!tunwortList[index].Hilfsverb) { hilfsverb = "ha"; }

                if (pronomenIndex == 0) { pronomen = "I"; }
                if (pronomenIndex == 1) { pronomen = "Du"; }
                if (pronomenIndex == 2) { pronomen = "Är, Sie, Äs"; }
                if (pronomenIndex == 3) { pronomen = "Mir"; }
                if (pronomenIndex == 4) { pronomen = "Dir"; }
                if (pronomenIndex == 5) { pronomen = "Sie"; }

                foreach (TunwortClass tunwort in tunwortList)
                {
                    if (tunwort.Tunwort == hilfsverb) { hilfsverbForm = tunwort.Gägewart[pronomenIndex]; ; }
                }

                if (formIndex == 0) { answer = pronomen + " " + tunwortList[index].Gägewart[pronomenIndex]; }
                if (formIndex == 1) { answer = pronomen + " " + hilfsverbForm + " " + tunwortList[index].PartizipPerfekt; }
                if (formIndex == 2) { answer = pronomen + " " + tunwortList[index].Gägewart[pronomenIndex] + " de"; }
                if (formIndex == 3) { answer = pronomen + " " + tunwortList[index].Möglechkeitsform[pronomenIndex]; }

                play = true;
                display.Header();

                Console.WriteLine("\n");
                Console.WriteLine("\tKonjugation Prüfung");
                Console.WriteLine("\n");
                Console.WriteLine("\tSchreib '" + answer + "'.");
                Console.Write("\t: ");
                entry = Console.ReadLine();
                Console.WriteLine("");

                if (entry == "r") { menu.PrüfungMenu(); }
                if (entry == "v") { Environment.Exit(0); }

                entry = Console.ReadLine();
                if (entry == "r") { menu.PrüfungMenu(); }
                if (entry == "v") { Environment.Exit(0); }
            } while (true);
        }

        public void TunwortPrüfung(List<TunwortClass> tunwortList)
        {
            var random = new Random();
            string entry, answer;

            bool play = true;
            do
            {
                int index = random.Next(tunwortList.Count);
                answer = tunwortList[index].Tunwort;
                play = true;
                display.Header();

                Console.WriteLine("\n");
                Console.WriteLine("\tTunwort Prüfung");
                Console.WriteLine("\n");
                Console.WriteLine("\tWie seit mir '" + tunwortList[index].Übersetzung + "' uf switzerdütsch ?");
                Console.Write("\t: ");
                entry = Console.ReadLine();
                Console.WriteLine("");

                if (entry == "r") { menu.PrüfungMenu(); }
                if (entry == "v") { Environment.Exit(0); }

                if (entry == answer)
                {
                    Console.WriteLine("\tRichtig !");
                }
                else
                {
                    Console.WriteLine("\tFalsch !");
                }
                Console.WriteLine("\tD Antwort isch '" + answer + "' !");

                entry = Console.ReadLine();
                if (entry == "r") { menu.PrüfungMenu(); }
                if (entry == "v") { Environment.Exit(0); }
            } while (true);
        }

        public void PartizipPerfektPrüfung(List<TunwortClass> tunwortList)
        {
            var random = new Random();
            string entry, answer;

            bool play = true;
            do
            {
                int index = random.Next(tunwortList.Count);
                answer = tunwortList[index].PartizipPerfekt;
                play = true;
                display.Header();

                Console.WriteLine("\n");
                Console.WriteLine("\tPartizip Perfekt Prüfung");
                Console.WriteLine("\n");
                Console.WriteLine("\tWas isch s Partizip perfekt von '" + tunwortList[index].Übersetzung + "' uf switzerdütsch ?");
                Console.Write("\t: ");
                entry = Console.ReadLine();
                Console.WriteLine("");

                if (entry == "r") { menu.PrüfungMenu(); }
                if (entry == "v") { Environment.Exit(0); }

                if (entry == answer)
                {
                    Console.WriteLine("\tRichtig !");
                }
                else
                {
                    Console.WriteLine("\tFalsch !");
                }
                Console.WriteLine("\tD Antwort isch '" + answer + "' !");

                entry = Console.ReadLine();
                if (entry == "r") { menu.PrüfungMenu(); }
                if (entry == "v") { Environment.Exit(0); }
            } while (true);
        }
    }
}
