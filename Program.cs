using ShootingDice;

Player player1 = new Player();
player1.Name = "Bob";

Player player2 = new Player();
player2.Name = "Sue";

player2.Play(player1);

Console.WriteLine("-------------------");

Player player3 = new Player();
player3.Name = "Wilma";

player3.Play(player2);

Console.WriteLine("-------------------");

Player large = new LargeDicePlayer();
large.Name = "Bigun Rollsalot";

player1.Play(large);

Console.WriteLine("-------------------");

SmackTalkingPlayer smack = new SmackTalkingPlayer();
smack.Name = "Brunn";

large.Play(smack);

Console.WriteLine("-------------------");

smack.Play(player1);

Console.WriteLine("-------------------");

OneHigherPlayer oneUp = new OneHigherPlayer();
oneUp.Name = "Oneupman";

oneUp.Play(smack);

Console.WriteLine("-------------------");

HumanPlayer humanPlayer = new HumanPlayer();
humanPlayer.Name = "Roxy";

humanPlayer.Play(player2);

Console.WriteLine("-------------------");

CreativeSmackTalkingPlayer smack2 = new CreativeSmackTalkingPlayer();
smack2.Name = "Deebo";

smack2.Play(smack);

Console.WriteLine("-------------------");

SoreLoserPlayer sucker = new SoreLoserPlayer();
sucker.Name = "Henry";


try
{
    sucker.Play(large);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

Console.WriteLine("-------------------");

UpperHalfPlayer topBoy = new UpperHalfPlayer();
topBoy.Name = "Lewis";

topBoy.Play(player3);

Console.WriteLine("-------------------");

List<Player> players = new List<Player>() {
    player1, player2, player3, large
};

players.Add(smack);
players.Add(oneUp);
players.Add(humanPlayer);
players.Add(smack2);
players.Add(sucker);
players.Add(topBoy);

PlayMany(players);

static void PlayMany(List<Player> players)
{
    Console.WriteLine();
    Console.WriteLine("Let's play a bunch of times, shall we?");

    // We "order" the players by a random number
    // This has the effect of shuffling them randomly
    Random randomNumberGenerator = new Random();
    List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

    // We are going to match players against each other
    // This means we need an even number of players
    int maxIndex = shuffledPlayers.Count;
    if (maxIndex % 2 != 0)
    {
        maxIndex = maxIndex - 1;
    }

    // Loop over the players 2 at a time
    for (int i = 0; i < maxIndex; i += 2)
    {
        Console.WriteLine("-------------------");

        // Make adjacent players play noe another
        Player player1 = shuffledPlayers[i];
        Player player2 = shuffledPlayers[i + 1];

        try
        {
            player1.Play(player2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}