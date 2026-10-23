namespace ShootingDice;
// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player
{
    public string Taunt { get; } = "feeel my wrath!";

    public override int Roll()
    {
        Console.WriteLine($"{"feel my wrath"}, {Name} taunts");
        return base.Roll();
    }


}
