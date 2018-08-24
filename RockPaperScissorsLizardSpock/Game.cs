using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variable
        Player player1;
        Player player2;

        //constructor


        //methods
       public void Getplayers()
        {
            if(numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
    }
}
