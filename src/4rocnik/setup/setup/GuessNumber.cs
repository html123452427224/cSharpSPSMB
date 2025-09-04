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
            int generatedNumber = generateRandomNumber();
            while (guess == false)
            {
                Console.WriteLine("guess the number between" + number1 + " and " + number2);
                Console.ReadLine();
            }
        }
         
         
        
        
    }
}