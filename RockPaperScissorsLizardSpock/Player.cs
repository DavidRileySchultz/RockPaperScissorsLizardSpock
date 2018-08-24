using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
        //member variables

        //constructors

        //methods
        public virtual void GetPlayerInput()
        {
            Console.WriteLine("Please enter your ATTACK: \n 1) Rock \n 2) Scissors \n 3) Paper \n 4) Lizard \n 5) Spock:");

            bool loopContinue = true;
            while (loopContinue)

            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("You chose Rock! \n Wait for next player's input...");
                        loopContinue = false;
                        break;

                    case "2":
                        Console.WriteLine("You chose Scissors! \n Wait for next player's input...");
                        loopContinue = false;
                        break;

                    case "3":
                        Console.WriteLine("You chose Paper! \n Wait for next player's input...");
                        loopContinue = false;
                        break;

                    case "4":
                        Console.WriteLine("You chose Lizard! \n Wait for next player's input...");
                        loopContinue = false;
                        break;

                    case "5":
                        Console.WriteLine("You chose Spock! \n Wait for next player's input...");
                        loopContinue = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid entry:");
                        break;
                }
            }
        }

    }
}
