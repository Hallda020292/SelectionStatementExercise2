using System.Linq.Expressions;

namespace SelectionStatementsExercise2
{
    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite school subject?");
            var reponse = Console.ReadLine();

            switch (reponse)
            {
                case "math":
                    Console.WriteLine($"math is fun!");
                    break;
                case "English":
                    Console.WriteLine("thats cool but im illiterate");
                    break;
                default:
                    Console.WriteLine("Never heard if that one, must be new!");
                    break;



            }




       
        }

    }

}