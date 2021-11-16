using System;

public class BettingGuy
{
    //1st list the properties of the class
    public string Name;
    public int Cash;
    public bool Availability;


    Random random = new Random();
    public static double randomValue;
    public static int wage;
    public static double odds = .75;
    public static int potBalance = 0;



    //method 0 will display the name and the amount of cash held
    public bool WriteMyInfo()
    {
        Console.WriteLine("Welcome to the casino. \n" +
            "The odds are " + odds + ".\n" +
            "The player has " + Cash + " bucks.");
        return true;
    }

    //method 1 captures customer input

    public bool howMuchDoYouWantToBet(string howMuch)
    {
    //check if user enters a numerical value
            if (int.TryParse(howMuch, out int amount))
            {
                wage = amount;

                //here we know the customer has at least 1 dollar
                //so now we can check if use as enough money to make bet
                if (wage > Cash)
                {
                    Console.WriteLine("You don't have enough cash to " +
                        "place this bet!\n");
                    return false;
                }
                //if user has enough money for wage then we run the code
                else
                {
                    return true;
                }
            }
            else
            {
                //need to add a statement to end user about issue
                Console.WriteLine("Sorry " + wage + " isn't a valid amount\n");
                return false;
            }
    }




    //method 2 to check if player wins
    public bool playerPlays()
    {
        randomValue = random.NextDouble();

        if (randomValue > odds)
        {
            //if user odds is greater than the fixed percentage user wins
            //add the winnings to the user
            //to calculate the amount won
            wage = (wage * 2);
            //add calculated amount won to winnings
            Cash = (Cash + wage);
            //Display what was won and new balance
            Console.WriteLine("You won " + wage + " which means you now have " + Cash +
                " dollars.\n");
            return true;

        }

        else
        {
            //else remove the wage from user and add wage to pot
            //remove the money lost
            Cash -= wage;
            //add lost amount back to the calculated amount won to winnings
            potBalance += wage;
            //Display what was lost and new balance
            Console.WriteLine("You lost " + wage + " which means you now only have "
                    + Cash + " dollars.\n");

            return false;
        }
    }
}

          
