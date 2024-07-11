namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Random random = new Random();
            int favNumber = random.Next(1, 100);
            
            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                Console.WriteLine("Guess my Favorite number between 1 and 100!");
                var userInput = int.Parse(Console.ReadLine());
                
                if (userInput < favNumber && userInput < 101)
                {
                    Console.WriteLine("Too Low, Try Again");
                }
                else if (userInput > favNumber && userInput < 101)
                {
                    Console.WriteLine("Too High, Try Again");
                }
                else if (userInput == favNumber && userInput < 101)
                {
                    Console.WriteLine("You got it! Congratulations!");
                    guessedCorrectly = true;
                } else 
                {
                    Console.WriteLine("That number is too high, try to stay under 101.");
                }
            }
            
        }
    }
}
