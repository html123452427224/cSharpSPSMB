using System;

namespace setup
{
    public class GuessNumber
    {
        private static Random random = new Random();
        int number1 = random.Next(1, 10);
        private int number2 = random.Next(10, 100);

        public int generateRandomNumber()
        {
            Random random = new Random();
            int generateNumber = random.Next(number1, number2);
            return generateNumber;
        }

        public void guessing()
        {
            bool guess = false;
            int numberOfGuesses = 0;
            int playersGuess;
            int generatedNumber = generateRandomNumber();
            do
            {
                
                Console.WriteLine("please enter the number you think is right");
                playersGuess = int.Parse(Console.ReadLine());
                if (playersGuess == generatedNumber)
                {
                    Console.WriteLine("nice you have guessed the number");
                    guess = true;
                    break;
                }
                else
                {
                    if (playersGuess > generatedNumber)
                    {
                        Console.WriteLine("too high");
                    } else if (playersGuess < generatedNumber)
                    {
                        Console.WriteLine("too low");
                    }
                }



            } while (guess == false);
        }
    }
}