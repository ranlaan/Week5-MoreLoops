using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab seda numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset number ära arvata;
            //programm genereerib juhusliku numrit ühe korra

            Random random = new Random();
            int correctnumber = random.Next(1, 11);

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Guess a random number");
                int usernumber = Convert.ToInt32(Console.ReadLine());

                if (correctnumber == usernumber)
                {
                    Console.WriteLine("Correct number");
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    if (i < 3)
                    {
                        Console.WriteLine($"Wrong number, {3 - i} guesses left");
                    }
                    else
                    {
                        Console.WriteLine("Computer wins");
                    }
                }
            }
        }
    }
}
