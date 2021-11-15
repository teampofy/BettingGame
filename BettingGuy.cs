using System;

public class BettingGuy
{
    //1st list the properties of the class
    public string Name;
    public int Cash;
    public double odds = .75;
    public static int potBalance = 0;

    //2nd list the methods of the class

    //method 1 will display the name and the amount of cash held
    public void WriteMyInfo()
    {
        Console.WriteLine("Welcome to the casino. The odds are "+odds+".\n" +
            "The player has "+Cash+" bucks.");
    }

    //method 2 what happens when the player places a bet
    public void makeABet(int amount, double randomGeneratedOdds)
    //place all code in this block
    {
        if (amount <= 0)
        {
            Console.WriteLine("Sorry "+ amount + " isn't a valid amount");
        }

        else if (amount > Cash)
        {
            Console.WriteLine("You don't have enough cash to place this bet!");
        }

        //place code that uses amount and places into another agrument
        else
        {

            //if win the bet, we must double the cash , and return the won amount
            if (randomGeneratedOdds >= odds)
            {
                //to calculate the amount won
                amount *= 2;
                //add calculated amount won to winnings
                Cash += amount * 2;
                //Display what was won and new balance
                Console.WriteLine("You won " + amount + " which means you won " +
                    "and now have " + Cash + " dollars.\n");
            }
            else
            {
                //remove the money lost
                Cash -= amount;
                //add lost amount back to the calculated amount won to winnings
                potBalance += amount;
                //Display what was won and new balance
                Console.WriteLine("You lost " + amount + " which means you now only have "
                    + Cash + " dollars.\n");
            }
                 
        }

    }

    }
