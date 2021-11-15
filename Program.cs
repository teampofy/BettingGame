using System;


public class Program
{
        public static void Main(string[] args)
        {
            //Create random object
            Random random = new Random();

            //Creation of the player with the default values
            BettingGuy player = new BettingGuy() { Cash = 100, Name = "The player" };

            //Displays cash
            player.WriteMyInfo();

        while (true)
            {
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();

                // Want to know what happens when a string is detected what will return
                if (howMuch == "")
                    return;

                // Use int.TryParse to try to convert the howMuch string to an int
                if (int.TryParse(howMuch, out int amount))
                {
                    player.makeABet(amount, random.NextDouble());
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }

        }
}
