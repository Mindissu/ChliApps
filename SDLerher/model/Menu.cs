using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

using model;

namespace model
{
    public class Menu
    {
        Displays display = new Displays();

        public void mainMenu()
        {
            string menuOption;
            display.Home();

            menuOption = Console.ReadLine();
            switch (menuOption)
            {
                case "w":
                    display.Wortschatz();
                    break;
                case "p":
                    PrüfungMenu();
                    break;
                case "v":
                    Environment.Exit(0);
                    break;
                default:
                    mainMenu();
                    break;
            }
        }

        public void PrüfungMenu()
        {
            string konjugationOption;
            string tunwortPath = @"..\..\..\..\data\tunwort.json";
            string fileText = File.ReadAllText(tunwortPath);
            List<TunwortClass> tunwortList = JsonConvert.DeserializeObject<List<TunwortClass>>(fileText);
            Exercises exercise = new Exercises();

            display.Prüfung();

            konjugationOption = Console.ReadLine();
            switch (konjugationOption)
            {
                case "k":
                    exercise.KonjugationPrüfung(tunwortList);
                    break;
                case "t":
                    exercise.TunwortPrüfung(tunwortList);
                    break;
                case "p":
                    exercise.PartizipPerfektPrüfung(tunwortList);
                    break;
                case "a":
                    break;
                case "r":
                    mainMenu();
                    break;
                case "v":
                    Environment.Exit(0);
                    break;
                default:
                    PrüfungMenu();
                    break;
            }
        }
    }
}
