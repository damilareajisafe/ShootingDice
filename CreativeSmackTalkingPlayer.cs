namespace ShootingDice;
// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
public class CreativeSmackTalkingPlayer : Player
{
    public List<string> taunts = new List<string>()
    {
        "You suck!",
        "Just try to beat me, will you?",
        "Let's see what you got!",
        "In your dreams",
        "Who are you again?",
        "What did you say your name was again?",
        "I always win!"
    };

    public override int Roll()
    {
        string taunt = taunts[new Random().Next(0, taunts.Count)];
        Console.WriteLine($"{taunt}, {Name} taunts");
    }

}