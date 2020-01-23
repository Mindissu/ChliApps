using System;
using System.Collections.Generic;

using model;

namespace SDLerher
{
    class Program
    {
        static void Main(string[] args)
        {
            Displays display = new Displays();
            TunwortClass tunwortClass = new TunwortClass();
            tunwortClass.Gägewart = new List<string>();
            var random = new Random();
            string answer;

            tunwortClass.Gägewart.Add("Aafo");
            tunwortClass.Gägewart.Add("Sy");
            tunwortClass.Gägewart.Add("Ha");
            tunwortClass.Gägewart.Add("Mache");
            tunwortClass.Gägewart.Add("Gse");

            string menuOption;

            display.Home();

            menuOption = Console.ReadLine();
            switch (menuOption)
            {
                case "w":
                    display.Header();
                    display.Wortschatz();
                    break;
                case "k":
                    menuOption = Console.ReadLine();
                    switch (menuOption)
                    {
                        case "k":
                            display.Header();
                            int index = random.Next(tunwortClass.Gägewart.Count);
                            Console.WriteLine(tunwortClass.Gägewart[index]);

                            answer = Console.ReadLine();
                            if(answer == tunwortClass.)
                            break;
                        case "t":
                            display.Header();
                            break;
                        case "v":
                            display.Header();
                            break;
                    }
                    break;
                case "q":
                    display.Header();
                    break;
                default:
                    display.Header();
                    break;
            }
        }
    }
}
