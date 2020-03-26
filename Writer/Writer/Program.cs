using System;
using System.Threading;

namespace Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string text = "'J'ai fait tout ce que je pouvais.' Cependant, 'tout' est illusoire, car 'tout' exprime l'intégralité du concevable. Le concevable demeurant sans fin, cette lexie demeure absurde. J'en ai marre.', 'J'ai la flemme.' ou 'Je n'ai plus d'idée.', c'est conforme comme honnête, c'est juste.";
            int waitTime = 0;

            foreach(char letter in text)
            {
                switch (letter)
                {
                    case '.':
                        waitTime = 400;
                        break;
                    case ';':
                        waitTime = 300;
                        break;
                    case ',':
                        waitTime = 200;
                        break;
                    default:
                        waitTime = random.Next(0, 125);
                        break;
                }
                Console.Write(letter);
                Thread.Sleep(waitTime);
            }
        }
    }
}
