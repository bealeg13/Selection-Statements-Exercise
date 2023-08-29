namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           // int myFavoriteNum = 30;
           // Console.WriteLine("Try to guess my favorite number between 1 - 50");
           // int userInput = int.Parse(Console.ReadLine());  

           // if (userInput < myFavoriteNum)
           // {
           //     Console.WriteLine("Too low");
           // }
           // else if (userInput > myFavoriteNum)
           // {
           //     Console.WriteLine("Too high");
           // }
           // else
           // {
           //     Console.WriteLine("You guessed it!");
           // }



            Console.WriteLine("What is your favorite school subject?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "english":
                    Console.WriteLine("English is a great subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is a great subject!");
                    break;
                case "math":
                    Console.WriteLine("Math is a great subject!");
                    break;
                case "art":
                    Console.WriteLine("Art is a great subject!");
                    break;
                case "music":
                    Console.WriteLine("Music is a great subject");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't understand.");
                    break;
                



            }


        }
    }
}
