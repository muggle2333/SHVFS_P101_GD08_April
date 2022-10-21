using System;
namespace SHVFS_P101_GD08_C4_April
{
    public class Program
    {
        public static void Main()
        {
            //Arithmetic operators
            //+=,-=,*=,/=,%=,++,--

            //var arithmeticOperatiorMultiplu = 5; 
            //arithmeticOperatiorMultiplu *= 10;//++
            //Console.WriteLine(arithmeticOperatiorMultiplu); //50/6

            //Loops
            //1.for loop
            //a. assign a value to our variable,and declare one if it need to be declared
            //b. check
            //c. inrecment/decrement our variable at the end of the loop

            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"I is {i}");
            //}

            //2.while loop
            //while(true) is technically fine and has its use,but BE CAREFUL VERY dangerous,quick hack to get something
            /*var input = "";
            while(input !="quit")
            {
                Console.Clear();
                Console.WriteLine($"Enter \"quit\" to win the game!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Congratulation!");*/

            //3.do while
            //Not Tested/Evaluated until loop run Once

            /*int i;
            Console.WriteLine("Enter 1 for options\n"
                             + "      2 to quit\n"
                             + "      3 to start game");
            do
            {
                Console.WriteLine("selection");
                i = Convert.ToInt32(Console.ReadLine());
            } while ( i  < 1 || i > 3);
            Console.WriteLine("end");*/

            //nested for loos
            //outer loop
            /*for(int i=0;i<10;i++)
            {
                //inner loop
                for(int j=0;j<10;j++)
                {
                    Console.WriteLine($"i is:{i},j is:{j}");
                }
            }*/


            //arrays
            //Arrays start at index 0 //"new" keyword
            //arrrays hold STUFF/THINGS,and can set size
            int[] score = new int[5]; //can also var
            int[] score1 = new int[5] { 0, 2, 5, 4, 4 }; //can set values for the array when declare //even don't need to declare the length
            var score2 = new[] { 0, 2, 5, 4, 4 }; //even can be shorter
            score[1] = 1; //property

            for (int i = 0; i < score.Length; i++) //score.Length to make it more flexible
            {
                Console.WriteLine($"{i} : {score[i]}");
            }

            //1.age calculater:enter age,give avg
            //2.number guessing game:codo num1~100,hint too high/low ,sucess back to start menu
            //start menu ask 3 things:age_calculter,number guessign,quit
            //20 mins


        }
    }
}
