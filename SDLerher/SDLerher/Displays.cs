using System;
using System.Collections.Generic;
using System.Text;

namespace SDLerher
{
    public class Displays
    {
        public void Home()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\tGrüessech bei SDLerher !");
            Console.WriteLine("\n");
            Console.WriteLine("\tw. Wortschatz");
            Console.WriteLine("\tk. Konjugation");
            Console.WriteLine("\tq. Quit");
            Console.WriteLine("\n");
            Console.WriteLine("\t: ");
        }

        public void Header()
        {
            Console.Clear();
            Console.WriteLine("\n\tq.Quit\n");
        }

        public void Wortschatz()
        {
            Console.WriteLine("\t Wortschatz");
        }
    }
}
