using System;
namespace SHVFS_P101_GD08_C2_April
{
    public class Program
    {
        public static void Main()
        {
            ////the boolean/bool type
            ////relational operators
            ////>,<,>=,<=,=,!=
            ////var is syntactic sugar,the compiler can infer the type is int
            //var firstNumber = 20;
            //var secondNumber = 20;

            ////bool can be true or false
            ////implicitly type var
            //var evaluation = firstNumber > secondNumber;
            ////Ecplicitly type bool
            //bool altEvaluation = firstNumber > secondNumber;
            //Console.WriteLine($"Evaluation is {evaluation},as int it is {Convert.ToInt32(evaluation)}");

            //Guess
            //int numberToGuess = 80;
            //int guess;
            //Console.WriteLine("Guess the number:");
            //guess = Convert.ToInt32(Console.ReadLine());
            //if(guess<numberToGuess)
            //{
            //    Console.WriteLine("To Low");
            //}
            //else if(guess>numberToGuess)
            //{
            //    Console.WriteLine("To High");
            //}
            //else
            //{
            //    Console.WriteLine("You Got It!");
            //}

            //Logical operators
            //&&(and),||(pipe),
            var rand = new Random();
            var randomBoolA = Convert.ToBoolean(rand.Next(2));//random.Next(<范围的非负整数)
            var randomBoolB = Convert.ToBoolean(rand.Next(2));
            var randomBoolC = Convert.ToBoolean(rand.Next(2));
            bool answer;
            Console.Clear();
            Console.WriteLine("Answer with true for TRUE,or false for FALSE");
            Console.WriteLine($"A is {randomBoolA},B is {randomBoolB},C is {randomBoolC}");
            Console.WriteLine("A is {0},B is {1},C is {2}",randomBoolA,randomBoolB,randomBoolC);
            Console.WriteLine($"A is "+ randomBoolA+" B is "+randomBoolB+" C is "+randomBoolC);//NOT Appreciate

            //Question
            answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("What is A && B？");
            if (answer == (answer && randomBoolA))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }


        }
    }
}
