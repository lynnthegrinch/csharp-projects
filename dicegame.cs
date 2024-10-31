// two methods: should play and win or loose
// two variables target and roll both random


Random random = new Random();
int target = random.Next(1, 6);
int roll = random.Next(1, 6);

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        
        target = diceRoll();
        roll = diceRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose());
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string answer = Console.ReadLine().ToLower();
    if (answer != null)
        if ((answer ==  "y") || (answer == "yes"))
        {
            return true;
        }
        else { return false; }
    return false;
}
string WinOrLose()
{      
    if (target > roll) return "You lost!";
    else if (roll > target) return "you win!";
    else return "it's a tie";
}
int diceRoll()
    { return random.Next(1, 7); }
