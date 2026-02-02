    namespace PracticeSet12;

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
            //declare multi array 6x6
            //declare random
            Random rand = new Random();
                char[,] board =
                {
                    { '.', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '.' },
                    { '.', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '.' },
                    { '.', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '.' }
                };

                //used random so it can choose number randomly
                int treasureRow = rand.Next(0, 6);
                int treasureCol = rand.Next(0, 6);
                //attempt counts how many times you try to guess
                int attempt = 0;
                //number of lives
                int lives = 8;

                //always start at false cause we didn't find the treasure yet
                bool foundTreasure = false;

                //while and not foundTreasure so we can repeat
                //when lives is 0 then game is over
                

                    while (!foundTreasure && lives > 0)
                    {
                        //clears unnecessary mess
                        Console.Clear();
                        //menu
                        Console.WriteLine("Treasure Hunt V.1.4");
                        Console.WriteLine($"You have {lives} lives left.");

                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                Console.Write($"{board[i, j]} ");
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

                        //puts the accurate guess
                        row--;


                        int col;
                        Console.Write("Enter col (1-6): ");
                        while (!int.TryParse(Console.ReadLine(), out col) || col < 1 || col > 6)
                        {
                            Console.Write("Invalid Input.");
                        }

                        col--;

                        //stop guessing the same spot
                        //used read key when next character is pressed
                        //by the user it prevents the next same character
                        if (board[row, col] != '.')
                        {
                            Console.WriteLine("You already guessed that spot!");
                            Console.ReadKey(true);
                            continue;
                        }



                        //if we put the input then it show this
                        //when correct it shows T if not then X
                        //when guess is wrong then minus lives
                        if (row == treasureRow && col == treasureCol)
                        {
                            board[row, col] = 'T';
                            foundTreasure = true;
                            Console.WriteLine("Congrats you found the Treasure!");
                        }
                        else
                        {
                            board[row, col] = 'X';
                            lives--;
                            Console.WriteLine($"You guessed wrong!");
                            Console.WriteLine($"You have {lives} lives remaining.");
                        }

                        attempt++;
                    }

                    //if lives ran out then we use if
                    //prints where the treasure coordinate was
                    //if you win then it prints guessed treasure with attempts
                    if (foundTreasure)
                    {
                        Console.WriteLine($"You guessed the Treasure with {attempt}!");
                    }
                    else
                    {
                        Console.WriteLine(
                            $"You lost! The treasure was at row {treasureRow + 1}, col {treasureCol + 1}. Better luck next time!");
                        //shows where the treasure is
                        board[treasureRow, treasureCol] = 'T';
                    }

                    //shows where the treasure is
                    board[treasureRow, treasureCol] = 'T';

                    //our final board
                    Console.WriteLine("\nFinal Board: ");
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write($"{board[i, j]} ");
                        }


                        Console.WriteLine();
                    }

                    Console.Write("Do you want to play again? Y/N: ");
            } while (Console.ReadLine().Trim().ToUpper() == "Y");
            Console.WriteLine("Thanks for playing my game! ");

        }
    }
