namespace PracticeSet10;

class Program
{
    static void Main(string[] args)
    {
        //we declare random so
        //it can randomize what we put on it
        Random rand = new Random();
        //multidimensional array for board
        char[,] board = { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } };
        
        //we declare treasureRows and TreasureCols
        //also attempts to track how mant attempts
        int attempts = 0;
        int treasureRows = rand.Next(0, 2);
        int treasureCols = rand.Next(0, 2);
        
        //basic menu
        Console.WriteLine("Hello there! Welcome to my Treasure finding game!");
        Console.WriteLine("Guess where the treasure is and good luck!");
        
        //boolean as false
        //so it can repeat
        //then stops when it founds the treasure
        //which is true
        bool foundTreasure = false;
        //used |or not to continue if did not find
        //the treasure
        //used nested for since its multi array
        //and printed board so we can know where
        //we put our guesses or something
        while (!foundTreasure)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
            }

            Console.WriteLine();

            //here we put our input
            //used !so we can keep going
            //until we get the treasure
            //also used tryparse
            //for practice
            //and we used decrement
            //so it can print the remaining
            //unravelled treasure
            int row;
            Console.Write("Enter row(1-2): ");
            while (!int.TryParse(Console.ReadLine(), out row) || row < 1 || row > 2)
            {
                Console.WriteLine("What are you doing? That's wrong!");
            }
            row--;

            int col;
            Console.Write("Enter column(1-2): ");
            while (!int.TryParse(Console.ReadLine(), out col) || col < 1 || col > 2)
            {
                Console.WriteLine("What are you doing? That's wrong!");
            }

            col--;
            
            //if we got the treausre then it prints this
            //if not then it prints the other one
            if (row == treasureRows && treasureCols == col)
            {
                board[row, col] = 'T';
                foundTreasure = true;
                Console.WriteLine("Congratulations! You found the treasure!");
            }
            else
            {
                board[row, col] = 'X';
                Console.WriteLine("Try Again!");
            }

            attempts++;
        }
        //here it prints the final board
        //which where the treasure was found
        Console.WriteLine("\nFinal Board: ");
        for(int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"{board[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Attempt so far: {attempts}");
    }
}
