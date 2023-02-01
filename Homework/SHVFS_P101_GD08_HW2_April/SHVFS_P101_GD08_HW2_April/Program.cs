using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;


namespace SHVFS_P101_GD08_HW2_April
{
    public class Program
    {
        // we need to track score
        // we need chars to represent players
        private static Player playerOne = new Player()
        {
            Direction = Vector2.Right,
            Score = 0,
            #region Data structures
            InputDirections = new Dictionary<ConsoleKey, Vector2>()
            {
                {
                    ConsoleKey.W, Vector2.Up
                },
                {
                    ConsoleKey.S, Vector2.Down
                },
                {
                    ConsoleKey.A, Vector2.Left
                },
                {
                    ConsoleKey.D, Vector2.Right
                }
            }
            #endregion
        };

        private static Player playerTwo = new Player()
        {
            Direction = Vector2.Left,
            Score = 0,
            #region Data structures
            InputDirections = new Dictionary<ConsoleKey, Vector2>()
            {
                {
                    ConsoleKey.UpArrow, Vector2.Up
                },
                {
                    ConsoleKey.DownArrow, Vector2.Down
                },
                {
                    ConsoleKey.LeftArrow, Vector2.Left
                },
                {
                    ConsoleKey.RightArrow, Vector2.Right
                }
            }
            #endregion
        };

        private static bool[,] usedGridPositions;
        private const int timeScale = 100;
        private const string currentScoreText = "Current Score: ";
        private const string pressAnyKeyText = "Press any key to continue...";
        private static string result = "";

        public static void Main(string[] args)
        {
            #region Draw start screen
            var title = "Snakes On A Train";

            Console.CursorLeft = Console.BufferWidth / 2 - title.Length / 2;
            Console.WriteLine(title);

            // Some things you may want to use...
            // Console.CursorTop, Console.ForegroundColor...
            Console.ForegroundColor = ConsoleColor.Yellow;
            // \ -> is called an escape character, \n means "new line"
            Console.WriteLine("Player One's controls:\n\n" +
                              "W - Up\n" +
                              "A - Left\n" +
                              "S - Down\n" +
                              "D - Right");

            var playerTwoControlTitle = "Player Two's controls:";
            var cursorLeft = Console.BufferWidth - playerTwoControlTitle.Length;
            Console.CursorTop = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Player 2's controls:\n");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Up Arrow - Up");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Left Arrow - Left");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Down Arrow - Down");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Right Arrow - Right");
            Console.ReadKey();
            Console.Clear();

            #endregion
            Start();
        }
        private static void Start()
        {
            SetupPlayArea();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    // Set player directions
                    if (playerOne.InputDirections.ContainsKey(key.Key))
                    {
                        playerOne.Direction = playerOne.InputDirections[key.Key];
                    }
                    else if (playerTwo.InputDirections.ContainsKey(key.Key))
                    {
                        playerTwo.Direction = playerTwo.InputDirections[key.Key];
                    }
                    //playerOne.InputDirections.TryGetValue(key.Key, out playerOne.Direction); //WILL DISTURB EACH OTHER
                }
                // Set player positions
                playerOne.Position += playerOne.Direction;
                playerTwo.Position += playerTwo.Direction;

                //Measure who dies
                if(IfCrash(playerOne.Position.x, playerOne.Position.y) && IfCrash(playerTwo.Position.x, playerTwo.Position.y))
                {
                    //Hit the wall at the same time
                    result = "Nobody wins!";
                    SetupScoreScreen();
                    break;
                }
                else if(IfCrash(playerOne.Position.x, playerOne.Position.y) || IfCrash(playerTwo.Position.x, playerTwo.Position.y))
                {
                    if (IfCrash(playerOne.Position.x, playerOne.Position.y))
                    {
                        result = "PlayerTwo Wins!";
                        playerTwo.Score++;
                    }
                    else
                    {
                        result = "PlayerOne Wins!";
                        playerOne.Score++;
                    }
                    SetupScoreScreen();
                    break;
                }
                else if(playerOne.Position == playerTwo.Position)
                {
                    result = "Nobody wins!";
                    SetupScoreScreen();
                    break;
                }
                else
                {
                    //No one die
                    usedGridPositions[playerOne.Position.x, playerOne.Position.y] = true;
                    usedGridPositions[playerTwo.Position.x, playerTwo.Position.y] = true;
                    DrawPlayer(playerOne.Position.x, playerOne.Position.y, '*', ConsoleColor.Yellow);
                    DrawPlayer(playerTwo.Position.x, playerTwo.Position.y, '*', ConsoleColor.Cyan);
                }


                Thread.Sleep(timeScale);
            }
        }
        private static void DrawPlayer(int positionX, int positionY, char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
        }

        private static void SetupPlayArea()
        {
            Console.WindowHeight = 30;
            Console.BufferHeight = 30;
            Console.WindowWidth = 99;
            Console.BufferWidth = 99;

            usedGridPositions = new bool[Console.WindowWidth, Console.WindowHeight];

            playerOne.Direction = Vector2.Right;
            playerOne.Position.x = 0;
            playerOne.Position.y = Console.WindowHeight / 2;

            playerTwo.Direction = Vector2.Left;
            playerTwo.Position.x = Console.WindowWidth - 1;
            playerTwo.Position.y = Console.WindowHeight / 2;
        }


        private static bool IfCrash(int positionX, int positionY)
        {
            //If crush to the edge
            if (positionX < 0 || positionX >= Console.WindowWidth || positionY < 0 || positionY >= Console.WindowHeight)
            {
                return true;
            }
            //If crush body
            else if (usedGridPositions[positionX, positionY])
            {
                return true;
            }
            return false;
        }
        private static void SetupScoreScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(result);
            string currentScore = currentScoreText + playerOne.Score + "-" + playerTwo.Score;
            Console.WriteLine(currentScore);
            Console.WriteLine(pressAnyKeyText);
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    break;
                }
            }
            Console.Clear();
            Start();              
        }
    }
}
