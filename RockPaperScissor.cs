    namespace Games;

    class Program
    {
        static void Main()
        {
            //chooses whatever it wants
            Random rand = new Random();
            bool playAgain = true;
            int playerScore = 0;
            int computerScore = 0;
            int tieCounter = 0;
            int round = 5;
            
            //while loop so we can play over and over again
            while (playAgain)
            {
                //empty strings so it won't print blank
                 String player = "";
                 String computer = "";
                 Console.Clear();
                 
                 //This loop ensures the player chooses only ROCK, PAPER, or SCISSORS.
                 while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                 {
                     Console.Write("Choose ROCK, PAPER OR SCISSORS! ");
                     player = Console.ReadLine();
                     player = player.ToUpper();
                 }


                 //used switch and rand for computer
                 switch (rand.Next(1, 4))
                 {
                     case 1:
                         computer = "ROCK";
                         break;
                     case 2:
                         computer = "PAPER";
                         break;
                     case 3:
                         computer = "SCISSORS";
                         break;
                 }
                        
                 //some interface
                 Console.WriteLine($"The player choose {player}!");
                 Console.WriteLine($"The Computer choose {computer}!");
                     
                 //Check the player choice against the computer choice to determine round winner.
                 switch (player)
                 {
                     case "ROCK":
                         if (computer == "ROCK")
                         {
                             Console.WriteLine("It's a tie!");
                             tieCounter++;
                         }
                         else if (computer == "PAPER")
                         {
                             Console.WriteLine("You lose!");
                             computerScore++;
                         }
                         else
                         {
                             Console.WriteLine("You win!");
                             playerScore++;
                         }

                         break;
                     case "PAPER":
                         if (computer == "PAPER")
                         {
                             Console.WriteLine("It's a tie!");
                             tieCounter++;
                         }
                         else if (computer == "SCISSORS")
                         {
                             Console.WriteLine("You lose!");
                             computerScore++;
                         }
                         else
                         {
                             Console.WriteLine("You win!");
                             playerScore++;
                         }

                         break;
                     case "SCISSORS":
                         if (computer == "SCISSORS")
                         {
                             Console.WriteLine("It's a tie!");
                             tieCounter++;
                         }
                         else if (computer == "ROCK")
                         {
                             Console.WriteLine("You lose!");
                             computerScore++;
                         }
                         else
                         {
                             Console.WriteLine("You win!");
                             playerScore++;
                         }

                         break;
                     default:
                         Console.WriteLine("Invalid Choice!");
                         break;
                 }
                     
                     
                 //prints overall winners
                 for (int i = 1; i < round; i++)
                 {

                     if (playerScore == round)
                     {
                         Console.WriteLine("Player wins overall!");
                         break;
                     }
                     else if (computerScore == round)
                     {
                         Console.WriteLine("Computer wins overall!");
                         break;
                     }
                 }
                
                 //basic leaderboard interface
                 Console.WriteLine($"Computer score: {computerScore} - Player score: {playerScore} - Both Ties: {tieCounter}");
                
                //asking to play again or not
                Console.Write("Do you want to play again? (Y/N): ");
                playAgain = Console.ReadLine().Trim().ToUpper() == "Y";
            }
            //if you press N or something
            Console.WriteLine("Thanks for playing!");
            
        }
    }
