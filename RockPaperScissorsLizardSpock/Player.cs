using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {
        //member variables
        public int gesture;
        public int score;
        public string name;
        //constructors

        //methods
        public abstract void GetPlayerInput();


        public abstract void GetPlayerName();
    }
}
