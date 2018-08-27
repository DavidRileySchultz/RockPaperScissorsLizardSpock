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
        string rules = "Rules for Rock, Scissors, Paper, Lizard, Spock: \nPaper covers Rock \nScissors cuts Paper \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock \nRock crushes Scissors \nBest of three to win. \nPress Enter to continue...";
        int numberOfPlayers;
        int playAgain;
        List<string> gestureList = new List<string>
            {"The available gestures are:", "Rock", "Scissors", "Paper", "Lizard", "Spock"};
        //constructor


        //methods
        public void DisplayRules()
        {
            Console.WriteLine(rules);
            Console.ReadKey();
        }
        public void DisplayGestures()
        {
            gestureList.ForEach(Console.WriteLine);  
        }
        public void GetPlayers()
        {
            Console.WriteLine("Please enter (1) to play against a Computer or (2) to play against another Human");
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
            else
            {
                GetPlayers();
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
                Console.WriteLine("Player 1 Wins Round!!");
            }
            else if(player1.gesture == 2 && (player2.gesture == 3 || player2.gesture == 4))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 Wins Round!!");
            }
            else if(player1.gesture == 3 && (player2.gesture == 1 || player2.gesture == 5))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 Wins Round!!");
            }
            else if(player1.gesture == 4 && (player2.gesture == 3 || player2.gesture == 5))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 Wins Round!!");
            }
            else if(player1.gesture == 5 && (player2.gesture == 1 || player2.gesture == 2))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 Wins Round!!");
            }
            else if(player1.gesture == player2.gesture)
            {
                Console.WriteLine("Round Tie!!");
            }
            else
            {
                player2.score += 1;
                Console.WriteLine("Player 2 Wins Round!!");
            }
        }
        public void CompareScores()
        {
            if(player1.score == 2)
            {
                Console.WriteLine("Player 1 Wins!!");
            }
            else if(player2.score == 2)
            {
                Console.WriteLine("Player 2 Wins!!!");
            }
            else
            {
                PlayRound();
                CompareGestures();
                CompareScores();
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine("Do you want to play again? Press (1) for yes. Press (2) for no.");
            playAgain = int.Parse(Console.ReadLine());

            if(playAgain == 1)
            {
                Console.WriteLine("Get ready to play another game!!");
                PlayGame();
            }
            else if(playAgain == 2)
            {
                Console.WriteLine("You must be scared...");
            }
            else
            {
                PlayAgain();
            }

        }
        public void PlayGame()
        {
            DisplayRules();
            DisplayGestures();
            GetPlayers();
            PlayRound();
            CompareGestures();
            CompareScores();
            PlayAgain();
            Console.ReadKey();
        }
    }
}
