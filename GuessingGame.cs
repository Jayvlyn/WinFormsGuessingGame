using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace worsesteamgames
{
    internal class GuessingGame
    {
        public int num1, num2, num3;

        public int[] prevGuesses1, prevGuesses2, prevGuesses3;
        public string prevResult1, prevResult2, prevResult3;

        public int guessesLeft;
        public int maxGuesses;

        public bool won = false;

        public GuessingGame() 
        {
            Random r = new Random();
            num1 = r.Next(1, 10);
            num2 = r.Next(1, 10);
            num3 = r.Next(1, 10);

            prevGuesses1 = new int[3]; 
            prevGuesses2 = new int[3]; 
            prevGuesses3 = new int[3];

            prevResult1 = "----";
            prevResult2 = "----";
            prevResult3 = "----";

            maxGuesses = 10;
            guessesLeft = maxGuesses;
        }

        public string MakeGuess(int guess1, int guess2, int guess3)
        {
            if (!won)
            {
                if (guessesLeft > 0)
                {
                    guessesLeft--;
                    UpdateLog(guess1, guess2, guess3);

                    int correctGuesses = 0;
                    if (num1 == guess1) correctGuesses++;
                    if (num2 == guess2) correctGuesses++;
                    if (num3 == guess3) correctGuesses++;

                    string result = "";
                    switch (correctGuesses)
                    {
                        case 3:
                            result = "Correct";
                            won = true;
                            break;
                        case 2:
                            result = "Close";
                            break;
                        default:
                            result = "Not close";
                            break;
                    }

                    prevResult3 = prevResult2;
                    prevResult2 = prevResult1;
                    prevResult1 = result;

                    return result;
                }
                return "YOU ARE OUT OF GUESSES, YOU LOSE";
            }
            return "You Won! stop trying to guess silly goober! press RESET";
        }

        public void UpdateLog(int g1, int g2, int g3)
        {
            prevGuesses3[0] = prevGuesses2[0];
            prevGuesses3[1] = prevGuesses2[1];
            prevGuesses3[2] = prevGuesses2[2];

            prevGuesses2[0] = prevGuesses1[0];
            prevGuesses2[1] = prevGuesses1[1];
            prevGuesses2[2] = prevGuesses1[2];

            prevGuesses1[0] = g1;
            prevGuesses1[1] = g2;
            prevGuesses1[2] = g3;
        }
    }
}
