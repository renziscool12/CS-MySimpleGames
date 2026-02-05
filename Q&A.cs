namespace QuestionAndAnswer;

class Program
{
    static void Main(string[] args)
    {
       //array question
        string[] question =
        { "Who is the strongest sorcerer in history", "How many days are there?", "I think therefore I am", 
            "Gojo vs Sukuna, Who won?", "How many months are there?"};
        
        //array answer
        string[] answer = { "Ryoumen Sukuna", "365", "Rene Descartes", "Sukuna", "12"};
        
        //put choice so it won,t be blank
        string choice = "";

        //game loop if no then it stops
        while (choice != "n")
        {
            //menu
            Console.WriteLine("Welcome to Q&A! today you are going to answer these questions and good luck");
            Console.WriteLine("Would you like to try? Y/N:  ");
            choice = Console.ReadLine().ToLower();
            
            //if yes it continues
            if (choice == "y")
            {
                Console.Clear();
                Console.WriteLine("Starting the game. . .");
                
                //execute once
                do
                {
                    
                    //score
                    int score = 0;
                    
                    //user input
                    for (int i = 0; i < question.Length; i++)
                    {
                        Console.WriteLine(question[i]);
                        string userAnswer = Console.ReadLine() ??"";

                        //used string comparison ordinalignore case since our answer isn't case sensetive
                        if (userAnswer.Trim().Equals(answer[i], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("\nCorrect");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong Answer!");
                        }
                    }

                    //score
                    Console.WriteLine($"Overall score {score} out of {question.Length} questions");

                 
                    Console.WriteLine("Do you want to try again? Y/N: ");
                    //if yes then it repeats the game
                }  while (Console.ReadLine().Trim().ToUpper() == "Y");
                Console.Clear();
                Console.WriteLine("Thanks for playing!");
            }
            //if no then it stops and clears
            else if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("Okay see ya later!");
            }
        }
    }
}
