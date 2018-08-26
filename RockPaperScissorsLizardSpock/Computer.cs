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
            Console.WriteLine("Please enter your ATTACK: \n 1) Rock \n 2) Scissors \n 3) Paper \n 4) Lizard \n 5) Spock:");
            int number = randomGesture.Next(1, 5);
            
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You chose Rock! \n Wait for next player's input...");
                        gesture = 1;                  
                        break;

                    case 2:
                        Console.WriteLine("You chose Scissors! \n Wait for next player's input...");
                        gesture = 2;
                        break;

                    case 3:
                        Console.WriteLine("You chose Paper! \n Wait for next player's input...");
                        gesture = 3;
                        break;

                    case 4:
                        Console.WriteLine("You chose Lizard! \n Wait for next player's input...");
                        gesture = 4;
                        break;

                    case 5:
                        Console.WriteLine("You chose Spock! \n Wait for next player's input...");
                        gesture = 5;
                        break;
                }
        }
    }
}
 
