namespace PracticeSet11;

class Program
{
    static void Main(string[] args)
    {
        //we declare random so
        //it can randomize what we put on it
        Random rand = new Random();
        char[,] board =
            { { '.', '.', '.', '.' }, { '.', '.', '.', '.' }, { '.', '.', '.', '.' }, { '.', '.', '.', '.' } };
        
        //we declare treasureRows and TreasureCols
        //also attempts to track how mant attempts
        int treasureRow = rand.Next(0, 4);
        int treasureCol = rand.Next(0, 4);
        int attempt = 0;
        
        //menu
        Console.WriteLine("Hello there! Welcome to my Treasure Hunting game V.1.1");
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
            //added clear and attempt here so we can know
            //how many attempts we did and clear every unesscesarry lines here
            Console.Clear();
            Console.WriteLine($"Your attempts so far: {attempt}");
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
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
            int col;
            Console.WriteLine("Enter col (1-4): ");
            while (!int.TryParse(Console.ReadLine(), out col) || col < 1 || col > 4)
            {
                Console.WriteLine("Invalid input!");
            }

            col--;

            int row;
            Console.WriteLine("Enter row (1-4): ");
            while (!int.TryParse(Console.ReadLine(), out row) || row < 1 || row > 4)
            {
                Console.WriteLine("Invalid Input!");
            }

            row--;
            
            //if we got the treausre then it prints this
            //if not then it prints the other one
            if (row == treasureRow && col == treasureCol)
            {
                board[row, col] = 'T';
                foundTreasure = true;
                Console.WriteLine("Congrats you found the treasure!");
            }
            else
            {
                board[row, col] = 'X';
                Console.WriteLine("Try Again!");
            }

            attempt++;
            
        }
        
        //here it prints the final board
        //which where the treasure was found
        Console.WriteLine("\nFinal Board: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine();
            }
        
    }
}
