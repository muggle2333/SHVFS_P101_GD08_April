using System;
namespace SHVFS_P101_GD08_Q2_April
{
    public class Program
    {
        public static void Main()
        {
            string guess = " ";
            string[] array = new string[]{"hello","world","Chris"};
            Random random = new Random();
            int i = random.Next(array.Length);
            int time = 0;
            Console.WriteLine("Hello,welcome!What's your name?");
            string name = Console.ReadLine();
            Console.Clear();
            while (guess != array[i])
            {
                Console.WriteLine($"{name}, Guess a word !");
                guess = Console.ReadLine();
                //if (guess == array[i])
                //{
                //    Console.WriteLine("Right");
                //}
                //else
                //{
                //    Console.WriteLine("Wrong!Again");
                //}
                Console.Clear();
                time++;
            }
            Console.Clear();
            Console.WriteLine($"Right,you have guessed {time} times!");

        }
    }
}