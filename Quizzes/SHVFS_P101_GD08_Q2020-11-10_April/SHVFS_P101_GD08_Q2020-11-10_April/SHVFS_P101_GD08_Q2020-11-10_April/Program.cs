using System;
namespace SHVFS_P101_GD08_Q2_April
{
    public class Program
    {
        public static void Main()
        {
            char guess = ' ' ;
            char[] array = new char[2]{'c','d'};
            Random random = new Random();
            int i = random.Next(1);
            int time = 0;
            Console.WriteLine("Hello,welcome!What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            while (guess != array[i])
            {
                Console.WriteLine($"{name}, Guess a word !");
                guess = Convert.ToChar(Console.ReadLine());
                if (guess == array[i])
                {
                    Console.WriteLine("Right");
                }
                else
                {
                    Console.WriteLine("Wrong!Again");
                }
                Console.Clear();
                time++;
            }
            Console.Clear();
            Console.WriteLine($"Right,you have guess {time}times");

        }
    }
}