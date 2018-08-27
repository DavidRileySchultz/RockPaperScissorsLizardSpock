using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        //member variables

        //constructors

        //methods
        public override void GetPlayerInput()
        {
            Console.WriteLine("Please enter your ATTACK (1-5): \n1: Rock \n2: Scissors \n3: Paper \n4: Lizard \n5: Spock");

            bool loopContinue = true;
            while (loopContinue)

            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("You chose Rock! \nPress (Enter) and let next player choose input...");
                        Console.ReadKey();
                        Console.Clear();
                        gesture = 1;
                        loopContinue = false;
                        break;

                    case "2":
                        Console.WriteLine("You chose Scissors! \nPress (Enter) and let next player choose input...");
                        Console.ReadKey();
                        Console.Clear();
                        gesture = 2;
                        loopContinue = false;
                        break;

                    case "3":
                        Console.WriteLine("You chose Paper! \nPress (Enter) and let next player choose input...");
                        Console.ReadKey();
                        Console.Clear();
                        gesture = 3;
                        loopContinue = false;
                        break;

                    case "4":
                        Console.WriteLine("You chose Lizard! \nPress (Enter) and let next player choose input...");
                        Console.ReadKey();
                        Console.Clear();
                        gesture = 4;
                        loopContinue = false;
                        break;

                    case "5":
                        Console.WriteLine("You chose Spock! \nPress (Enter) and let next player choose input...");
                        Console.ReadKey();
                        Console.Clear();
                        gesture = 5;
                        loopContinue = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid input:");
                        break;
                }
            }
        }

        public override void GetPlayerName()
        {
            
        }
    }
}
