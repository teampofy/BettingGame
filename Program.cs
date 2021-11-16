using System;


public class Program
{
    public static void Main(string[] args)
    {

        //Creation of the player with the default values
        BettingGuy player = new BettingGuy() { Cash = 100, Name = "The player", Availability = true };

        //Displays introduction
        player.WriteMyInfo();

        while (player.Availability)
        {
            if (player.Cash > 0)
            {
                //Only display if the user has at least 1 dollar
                Console.Write("How much do you want to bet: ");
                String howMuch = Console.ReadLine();

                //only run if customer places a eligble bet
                if (player.howMuchDoYouWantToBet(howMuch))
                {
                    //if customer plays an eligble wage play the game
                    player.playerPlays();
                }
            }

            //if customer doesnt have any money to place a bet turn off game
            else
            {
                player.Availability = false;
            }
        }
    }
}
