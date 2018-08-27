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
        string rules = "Rules for Rock, Scissors, Paper, Lizard, Spock: \n Paper covers Rock \n Scissors cuts Paper \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock \n Rock crushes Scissors \n Best of three to win.";
        int numberOfPlayers;

        //constructor


        //methods
        public void DisplayRules()
        {
            Console.WriteLine(rules);
            Console.ReadKey();
        }
        public void GetPlayers()
        {
            Console.WriteLine("Please enter 1 to play against a computer or 2 to play against another Human");
            numberOfPlayers = int.Parse(Console.ReadLine());

            if(numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if(numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();

            }
        }

        public void PlayRound()
        {
            player1.GetPlayerInput();
            player2.GetPlayerInput();
        }
               
        public void CompareGestures()
        {
            if(player1.gesture == 1 && (player2.gesture == 2 || player2.gesture == 4))
            {
                player1.score += 1;
                Console.WriteLine("Player1 Wins Round!!");
            }
            else if(player1.gesture == 2 && (player2.gesture == 3 || player2.gesture == 4))
            {
                player1.score += 1;
                Console.WriteLine("Player1 Wins Round!!");
            }
            else if(player1.gesture == 3 && (player2.gesture == 1 || player2.gesture == 5))
            {
                player1.score += 1;
                Console.WriteLine("Player1 Wins Round!!");
            }
            else if(player1.gesture == 4 && (player2.gesture == 3 || player2.gesture == 5))
            {
                player1.score += 1;
                Console.WriteLine("Player1 Wins Round!!");
            }
            else if(player1.gesture == 5 && (player2.gesture == 1 || player2.gesture == 2))
            {
                player1.score += 1;
                Console.WriteLine("Player1 Wins Round!!");
            }
            else if(player1.gesture == player2.gesture)
            {
                Console.WriteLine("Round Tie!!");
            }
            else
            {
                player2.score += 1;
                Console.WriteLine("Player2 Wins Round!!");
            }
        }
        public void CompareScores()
        {
            if(player1.score == 2)
            {
                Console.WriteLine("Player1 Wins!!");
            }
            else if(player2.score == 2)
            {
                Console.WriteLine("Player2 Wins!!!");
            }
            else
            {
                PlayRound();
                CompareGestures();
                CompareScores();
            }

            
        }
        public void PlayGame()
        {
            DisplayRules();
            GetPlayers();
            PlayRound();
            CompareGestures();
            CompareScores();
            Console.ReadKey();
        }
    }
}
