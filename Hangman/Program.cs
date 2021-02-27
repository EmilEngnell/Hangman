using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("You wanna play a game?\nLet's do a round of Hangman!");
            Console.WriteLine(" \nYou have been found at a murderscene\nAnd the polise suspects you of being the murderer\nHow scary");
            Console.WriteLine("Your only chanse of escape execution through hanging is to catch the real killer\n A killer that you saw running away from the scene");
            Console.WriteLine("Put letters together as clues to the killer's true identity in order to redeem yourself\n You have 10 days");
            string[] listwords = new string[25];
            listwords[0] = "bundy";
            listwords[1] = "vlad";
            listwords[2] = "hannibal";
            listwords[3] = "zodiac";
            listwords[4] = "ripper";
            listwords[5] = "joker";
            listwords[6] = "scarface";
            listwords[7] = "jeff";
            listwords[8] = "jason";
            listwords[9] = "kruger";
            listwords[10] = "creed";
            listwords[11] = "pennywise";
            listwords[12] = "myers";
            listwords[13] = "holmes";
            listwords[14] = "mengele";
            listwords[15] = "cuomo";
            listwords[16] = "kingping";
            listwords[17] = "macbeth";
            listwords[18] = "brutus";
            listwords[19] = "stalin";
            listwords[20] = "ciccero";
            listwords[21] = "manson";
            listwords[22] = "lucien";
            listwords[23] = "malcolm";
            listwords[24] = "bluebeard";
            Random randGen = new Random();
            var idx = randGen.Next(0, 24);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];

            StringBuilder displayToPlayer = new StringBuilder(mysteryWord.Length);
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '_';

            List<char> correctLetter = new List<char>();
            List<char> incorrectLetter = new List<char>();

            int lives = 10;
            bool won = false;
            int lettersRevealed = 0;

            string input;
            char playerGuess;

            while (!won && lives > 0);
            {
                Console.WriteLine("Pick a letter for your clue");

                input = Console.ReadLine().ToUpper();
                playerGuess = input[0];

                if (correctLetter.Contains(playerGuess))
                {
                    Console.WriteLine("Yeah, I heard you last time you said '{0}', you need some other clues as well.", playerGuess);
                    continue;
                }
                else if (incorrectLetter.Contains(playerGuess))
                {
                    Console.WriteLine("Look, you have already tried '{0}', and it's still wrong.", playerGuess);
                    continue;
                }

                if (mysteryWord.Contains(playerGuess))
                {
                    correctLetter.Add(playerGuess);

                    //char playerGuess = char.Parse(Console.ReadLine());
                    for (int j = 0; j < mysteryWord.Length; j++)
                    {
                        if (playerGuess == mysteryWord[j])
                        {
                            guess[j] = playerGuess;
                            lettersRevealed++;

                        }

                    }

                    if (lettersRevealed == mysteryWord.Length)
                        won = true;
                }
                else
                {
                    incorrectLetter.Add(playerGuess);

                    Console.WriteLine("Oops! Looks like '{0}' has no connection to the real culprit!");
                    lives--;
                }

                if (won)
                    Console.WriteLine("Congratulations! You gathered enought clues to catch the real killer!\n You have managed to survive the Hangman\n Unlike the real killer.");
                else
                    Console.WriteLine("How sad, the killer got away...\n And you got Hanged in his place");
                Console.WriteLine(guess);
            }
        }
    }
}
