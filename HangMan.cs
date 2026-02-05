namespace HangMan;

class Program
{
    public static void Main(string[] args)
    {
        //loop for play again
        do
        {
            //guess words to answer
            string[] words = { "sukuna", "gojo", "toji", "yuji", "mahoraga", "megumi", "mahito", "geto", "choso", "yuki", "maki", "panda", "hakari", "nobara", "todo", "jogo", "nanami", "uraumi", "kashimo", "mechamaru",  "mai", "naobito", "dagon", "hanami", "kusakabe", "higuruma", "miguel"};
            //random so it can pick randomly
            Random rand = new Random();
            //chooses what words
            string secretWord = words[rand.Next(0, words.Length)];
            //always start false to keep going
            bool win = false;
            //list
            List<char> guessedLetters = new List<char>();
            //lives
            int lives = 8;
            int maxLives = lives;
            
            //char since we use single word to find out then store secret word
            char[] display = new char [secretWord.Length];
            //menu
            Console.WriteLine("\n===================");
            Console.WriteLine("|Welcome to HangMan!|");
            Console.WriteLine("===================");
            Console.WriteLine();
            //secret word converts to _
            for (int i = 0; i < secretWord.Length; i++)
            {
                display[i] = '_';
            }
            
            //user input
            while (lives > 0 && !win)
            {

                Console.WriteLine("Guess a letter.");
                Console.WriteLine($"You have {lives} / {maxLives} lives left.");
                Console.WriteLine(string.Join("", display));
                // convert input to lowercase for case-insensitive match
                char guessLetter = Convert.ToChar(Console.ReadLine()?.ToLower() ?? "");
                
                
                //if guessed it again it prints this
                if (guessedLetters.Contains(guessLetter))
                {
                    Console.WriteLine("You guessed it again!");
                    continue;
                }
                
                //puts the correct letters
                guessedLetters.Add(guessLetter);
                
                //if got the letter correct it continues
                bool correct = false;
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guessLetter)
                    {
                        display[i] = guessLetter;
                        correct = true;

                    }
                }
                
                //if we put the wrong letter we lose lives
                if (!correct)
                {
                    Console.WriteLine("Incorrect!");
                    lives--;
                }
                else
                {
                    Console.WriteLine("Correct!");
                }
                    
                //win condition
                if (!display.Contains('_'))
                {
                    win = true;
                }
            }
            
            //ternary for congratulate us or if we lose it will reveal the secret wrod
            Console.WriteLine(win ? "Congratulations! You solved the word!" : $"You lose the word was {secretWord}");
            Console.WriteLine("Do you want to play again?: ");
            //ask the user if he/she wants to play again
        } while (Console.ReadLine()?.Trim().ToUpper() == "YES");
        //if we press no or anything it ends and prints this then clear everything
        Console.Clear();
        Console.WriteLine("Thanks for playing!");
        
    }
}
