namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        { // Number Guessing Game

            //var r = new Random();
            //var favNumber = r.Next(1, 1000);

            //Console.WriteLine("Pick a number from 1 to 1000");
            //var userInput = int.Parse(Console.ReadLine());

            //if(userInput < favNumber)
            //{
            //    Console.WriteLine($"{userInput} is too low");
            //}
            // else if(userInput > favNumber)
            //{
            //    Console.WriteLine($"{userInput} is too high");
            //}
            //else
            //{
            //    Console.WriteLine("You guessed it!");
            //}

            //switch case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();
            switch (subject.ToLower())
            {
                case"math":
                Console.WriteLine("I hate math!");
                break;
                case "english":
                Console.WriteLine("English is the best!");
                break ;
                case "science":
                Console.WriteLine("Science is fun!");
                break;
                case "history":
                Console.WriteLine("History is intresting!");
                break;
                case "art":
                Console.WriteLine("Art is messy!");
                break; 
                default:
                Console.WriteLine("I don't know that subject");
                break;
            }

        }
    }
}
