using System;
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
            listwords[11] = "hassasin";
            listwords[12] = "myers";
            listwords[13] = "holmes";
            listwords[14] = "mengele";
            listwords[15] = "cuomo";
            listwords[16] = "kingping";
            listwords[17] = "ivan";
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
            Console.WriteLine("Pick a letter for your clue");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '_';

            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
            }
        }
    }
}
