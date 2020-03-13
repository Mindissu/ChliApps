using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Displays
    {
        public void Home()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t-|--| ---------- |--|-\n");
            Console.WriteLine("\n");
            Console.WriteLine("\tWillkomme bei SDLehrer !");
            Console.WriteLine("\n");
            Console.WriteLine("\t-- w. Wortschatz");
            Console.WriteLine("\t-- p. Prüfungen");
            Console.WriteLine("\n");
            Console.WriteLine("\t¦| v. Verlassen");
            Console.WriteLine("\n");
            Console.Write("\t: ");
        }

        public void Header()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t-|--| <- r. Rückkehr\t¦| v. Verlassen |--|-\n");
        }

        public void Wortschatz()
        {
            Header();
            Console.WriteLine("\t Wortschatz");
        }

        public void Prüfung()
        {
            Header();
            Console.WriteLine("\n");
            Console.WriteLine("\tPrüfung Menu");
            Console.WriteLine("\n");
            Console.WriteLine("\t-- k. Konjugation");
            Console.WriteLine("\t-- t. Tunwort");
            Console.WriteLine("\t-- p. Partizip Perfekt");
            Console.WriteLine("\t-- a. Vorsiube");
            Console.WriteLine("\n");
            Console.Write("\t: ");
        }
    }
}
