namespace ShootingDice;
// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player // inherits properties from Player.cs
{
    public string Taunt { get; }

    public override int Roll()
    {
        Console.WriteLine("Smart Ass taunts, 'Your mother was a hamster and your father smelled of elderberry!'");
        // Return a random number between 1 and DiceSize
        return new Random().Next(DiceSize) + 1;
    }
}
