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

// add SmackTalkingPlayer
Player smackTalkingPlayer = new SmackTalkingPlayer();
smackTalkingPlayer.Name = "Smack Talker";

Player oneHigherPlayer = new OneHigherPlayer();
oneHigherPlayer.Name = "One Higher";

Player humanPlayer = new HumanPlayer();
humanPlayer.Name = "Human";

Player creativeSmackTalker = new CreativeSmackTalkingPlayer();
creativeSmackTalker.Name = "Creative Smack Talker";

Player soreLoser = new SoreLoserPlayer();
soreLoser.Name = "Sore Loser";

Player upperHalf = new UpperHalfPlayer();
upperHalf.Name = "Upper Half";

Player soreLoserUpperHalf = new SoreLoserUpperHalfPlayer();
soreLoserUpperHalf.Name = "Sore Loser Upper Half";

List<Player> players = new List<Player>() {
    player1, player2, player3, large, smackTalkingPlayer, oneHigherPlayer, humanPlayer, creativeSmackTalker, soreLoser, upperHalf, soreLoserUpperHalf
};

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

        // Make adjacent players play one another
        Player player1 = shuffledPlayers[i];
        Player player2 = shuffledPlayers[i + 1];
        player1.Play(player2);
    }
}