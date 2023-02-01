using System;
namespace SHVFS_P101_GD08_C7_April_Snake
{
    public class Program
    {
        //UpperCamelCase(recommend)
        //camelCase
        //_camelCase
        public static void Main()
        {
            #region Draw start screen
            var title = "Snakes On A Train";
            Console.CursorLeft = Console.BufferWidth /2 -title.Length/2;//static field
            Console.WriteLine(title);
            //left
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player One's controls:\n\nW - Up\nA - Left\nS - Down\nD - Right");

            //right
            var player2Title = "Player Two's controls:";
            var cursorLeft = Console.BufferWidth - player2Title.Length;
            Console.CursorTop = 1; 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorLeft = cursorLeft;
            Console.WriteLine(player2Title+"\n");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Up Arrow - Up");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Left Arrow - Left");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Down Arrow - Down");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Right Arrow - Right");


            Console.ReadLine();
            //Console.CursorTop,Console.ForegroundColor

            #endregion
        }
    }
    
}
