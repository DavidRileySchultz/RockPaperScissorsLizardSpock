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
        
        //constructor

        //methods
        public override void GetPlayerInput()
        {
            Random randomGesture = new Random();
            Console.WriteLine($"{name} is coming for ya! Look out...");
            int number = randomGesture.Next(1, 6);
            
                switch (number)
                {
                    case 1:
                        Console.WriteLine($"{name} chose Rock!");
                        gesture = 1;                  
                        break;

                    case 2:
                        Console.WriteLine($"{name} chose Scissors!");
                        gesture = 2;
                        break;

                    case 3:
                        Console.WriteLine($"{name} chose Paper!");
                        gesture = 3;
                        break;

                    case 4:
                        Console.WriteLine($"{name} chose Lizard!");
                        gesture = 4;
                        break;

                    case 5:
                        Console.WriteLine($"{name} chose Spock!");
                        gesture = 5;
                        break;
                }
        }

        public override void GetPlayerName()
        {
            Console.WriteLine("\nPlease enter a name for the Computer");
            name = Console.ReadLine();
        }
    }
}
 
