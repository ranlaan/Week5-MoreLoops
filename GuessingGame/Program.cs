using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab seda numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //kasutuste arv on piiramatu;
            //programm genereerib juhusliku numrit ühe korra

            Random random = new Random();
            int correctnumber = random.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if(correctnumber == userNumber)
                {
                    string input = Console.ReadLine();

                    Console.WriteLine("Correct number");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            } 

        }
    }
}
