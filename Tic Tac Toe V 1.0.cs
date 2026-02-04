namespace TicTacToe;

static class Program
{
    public static void Main(string[] args)
    {
        //outter loop for "play again" functionality
        do
        {
            //initialize 3x3 board
            char[,] board = new char[3, 3];
            
            //random generator for our ai moves
            Random rand = new Random();
            bool gameOver = false;

            //Fills the board with spots with '.'
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '.';
                }
            }

            //game loop runs until someone win, lose or draw
            while (!gameOver)
            {
                Console.Clear();
                Console.WriteLine("Tic Tac Toe V 1.0");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{board[i, j]} ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
                
                //player moves
                int row;
                Console.Write("Enter where to put O(row): ");
                if (!int.TryParse(Console.ReadLine(), out row) || row < 1 || row > 3)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                
                //convert to 0 based
                row--;

                int col;
                Console.Write("Enter where to put O(col): ");
                if (!int.TryParse(Console.ReadLine(), out col) || col < 1 || col > 3)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                col--; //convert to 0 based

                if (board[row, col] != '.')
                {
                    Console.WriteLine("You or AI guessed that spot again!");
                    Console.ReadKey();
                    continue;
                }
                
                //checks if the spots is taken
                if (board[row, col] == '.')
                {
                    board[row, col] = 'O';
                }
                
                //AI
                int aiCol;
                int aiRow;
                
                //AI picks random empty spot
                do
                {
                    //Picks a random spot   
                    aiRow = rand.Next(0, 3);
                    aiCol = rand.Next(0, 3);
                } while (board[aiRow, aiCol] != '.');

                board[aiRow, aiCol] = 'X';
                //WIN CHECK FOR PLAYER
                //CHECK ROWS
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == 'O' && board[i, 1] == 'O' && board[i, 2] == 'O')
                    {
                        Console.WriteLine("You win!");
                        gameOver = true;
                        break;
                    }
                    //WIN CHECK FOR AI
                    if (board[i, 0] == 'X' && board[i, 1] == 'X' && board[i, 2] == 'X')
                    {
                        Console.WriteLine("Ai win!");
                        gameOver = true;
                        break;
                    }
                }
                //CHECK COLUMS
                for (int c = 0; c < 3; c++)
                {
                    if (board[0, c] == 'O' && board[1, c] == 'O' && board[2, c] == 'O')
                    {
                        Console.WriteLine("You win!");
                        gameOver = true;
                        break;
                    }

                    if (board[0, c] == 'X' && board[1, c] == 'X' && board[2, c] == 'X')
                    {
                        Console.WriteLine("Ai win!");
                        gameOver = true;
                        break;
                    }
                }
                //CHECK DIAGONALS
                if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O' ||
                    board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
                {
                    Console.WriteLine("You win!");
                    gameOver = true;
                    break;
                }

                if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X' ||
                    board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
                {
                    Console.WriteLine("Ai win!");
                    gameOver = true;
                    break;
                }
                //CHECK DRAW
                bool draw = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '.')
                        {
                            draw = false;
                        }
                    }
                }

                if (draw && !gameOver)
                {
                    Console.WriteLine("Draw!");
                    gameOver = true;
                }
            }
            //ask the user if the players wants to play again
            Console.WriteLine("Do you want to play again? (Y/N): ");
        } while (Console.ReadLine().Trim().ToUpper() == "Y");
        Console.Clear();
        Console.WriteLine("Thanks for playing!");
    }
}
