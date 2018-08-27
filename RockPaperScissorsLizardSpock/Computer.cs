using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        //member variables
        Random randomGesture = new Random();
        //constructor

        //methods
        public override void GetPlayerInput()
        {
            Console.WriteLine("The Computer is coming for ya! Look out...");
            int number = randomGesture.Next(1, 6);
            
                switch (number)
                {
                    case 1:
                        Console.WriteLine("The Computer chose Rock!");
                        gesture = 1;                  
                        break;

                    case 2:
                        Console.WriteLine("Computer chose Scissors!");
                        gesture = 2;
                        break;

                    case 3:
                        Console.WriteLine("The Computer chose Paper!");
                        gesture = 3;
                        break;

                    case 4:
                        Console.WriteLine("The Computer chose Lizard!");
                        gesture = 4;
                        break;

                    case 5:
                        Console.WriteLine("The Computer chose Spock!");
                        gesture = 5;
                        break;
                }
        }

        public override void GetPlayerName()
        {

        }
    }
}
 
