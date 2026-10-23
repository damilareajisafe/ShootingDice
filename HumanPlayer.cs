namespace ShootingDice;

// TODO: Complete this class

// A player the prompts the user to enter a number for a roll
public class HumanPlayer : Player
{
    public override int Roll()
    {
        // Return a random number between 1 and DiceSize
        int roll = 0;
        Console.WriteLine("Please enter number for a roll");
        while (!int.TryParse(Console.ReadLine(), out roll) || (roll < 1 || roll > DiceSize))
        {
            Console.WriteLine("Enter a valid roll");
        }


        return roll;
    }
}