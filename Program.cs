using System;


public class Program
{
        public static void Main(string[] args)
        {

            //Creation of the player with the default values
            BettingGuy player = new BettingGuy() { Cash = 100, Name = "The player", Availability = true };

            //Displays introduction
            player.WriteMyInfo();

            while(player.Availability) 
            {
            if(player.Cash > 0)
                {
                    Console.Write("How much do you want to bet: ");
                    String howMuch = Console.ReadLine();

                    player.howMuchDoYouWantToBet(howMuch);
                    player.playerPlays();
                }
            else
                {
                player.Availability = false;
                }
            }
    }
}
