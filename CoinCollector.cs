namespace PracticeSet9;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        char[,] coin = { { '.', '.', '.', '.' }, { '.', '.', '.', '.' }, { '.', '.', '.', '.' } };

        int coinRow = rand.Next(0, 3);
        int coinCol = rand.Next(0, 3);
        
        Console.WriteLine("Welcome to my First game ever! Which is called Coin Collector!");
        Console.WriteLine("Guess where the coin is! ");

        bool foundCoin = false;
        while (!foundCoin)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{coin[i, j]} ");
                }
            }
            Console.WriteLine();

            int row;
            Console.WriteLine("Enter row (1-3): ");
            while (!int.TryParse(Console.ReadLine(), out row) || row < 1 || row > 3)
            {
                Console.WriteLine("Invalid input!");
            }
            row--;

            int col;
            Console.WriteLine("Enter column (1-3): ");
           while(!int.TryParse(Console.ReadLine(), out col) || col < 1 || col > 3)
           {
               Console.WriteLine("Invalid Input!");
           }
           col--;

            if (row == coinRow && col == coinCol)
            {
                coin[row, col] = 'C';
                foundCoin = true;
                Console.WriteLine("Congrats you found the coin");
            }
            else
            {
                coin[row, col] = 'X';
                Console.WriteLine("Haha, you failed try again!");
            }
        }
        Console.WriteLine("\nFinal Board: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"{coin[i, j]} ");
            }
            Console.WriteLine();
        }

    }
}
