    namespace PracticeSet12;

    class Program
    {
        static void Main(string[] args)
        {
            //declare multi array 6x6
            //declare random
            Random rand = new Random();
            char[,] board =
            {
                { '.', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '.' }
            };
            
            //used random so it can choose number randomly
            int treasureRow = rand.Next(0, 6);
            int treasureCol = rand.Next(0, 6);
            int attempt = 0;
            
            
            //always start at false cause we didn't find the treasure yet
            bool foundTreasure = false;
            
            //while and not foundTreasure so we can repeat
            while (!foundTreasure)
            {
                //clears unessesary mess
                //menu
                //lastly attempts
                Console.Clear();
                Console.WriteLine("Treasure Hunt V.1.2");
                Console.WriteLine($"Your attempts so far: {attempt}");

                for (int i = 0; i < 6; i++)
                {
                    for(int j = 0; j < 6; j++)
                    {
                        Console.Write($"{board [i, j]} ");
                    }
                    Console.WriteLine();
                }
                
                Console.WriteLine();
                
                //declare row
                //row input
                //repeat until valid
                int row;
                Console.Write("Enter row (1-6): ");
                while (!int.TryParse(Console.ReadLine(), out row) || row < 1 || row > 6)
                {
                    Console.WriteLine("Invalid input.");
                }

                row--;
                
                
                int col;
                Console.Write("Enter col (1-6): ");
                while (!int.TryParse(Console.ReadLine(), out col) || col < 1 || col > 6)
                {
                    Console.Write("Invalid Input.");
                }

                col--;
                
                //stop guessing the same spot
                //used readkey when next character is pressed
                //by the user it prevents the next same character
                if (board[row, col] != '.')
                {
                    Console.WriteLine("You already guessed that spot!");
                    Console.ReadKey(true);
                    continue;
                }
                
                //if we put the input then it show this
                //when correct it shows T if not then X
                if (row == treasureRow && col == treasureCol)
                {
                    board[row, col] = 'T';
                    foundTreasure = true;
                    Console.WriteLine("Congrats you found the Treasure!");
                }
                else
                {
                    board[row, col] = 'X';
                    Console.WriteLine("Try again!");
                }

                attempt++;
            }
            
            //our final board
            Console.WriteLine("\nFinal Board: ");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{board [i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
