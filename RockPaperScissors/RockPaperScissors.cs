namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            ConsoleColor foreground = Console.ForegroundColor;

            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ", Console.ForegroundColor = ConsoleColor.Blue);
            Console.ResetColor();
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock" || playerMove == "Rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper" || playerMove == "Paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors" || playerMove == "Scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...", Console.ForegroundColor = ConsoleColor.Cyan);
                Console.ResetColor();
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1: computerMove = Rock; break;
                case 2: computerMove = Paper; break;
                case 3: computerMove = Scissors; break;
            }

            Console.WriteLine($"The computer chose {computerMove}.", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.ResetColor();

            if ((playerMove == Rock && computerMove == Scissors) ||
                (playerMove == Paper && computerMove == Rock) ||
                (playerMove == Scissors && computerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win.");
                Console.ResetColor();
            }
            else if ((playerMove == Rock && computerMove == Paper) ||
                     (playerMove == Paper && computerMove == Scissors) ||
                     (playerMove == Scissors && computerMove == Rock))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You lose.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game was a draw.");
                Console.ResetColor();
            }    
        }
    }
}
