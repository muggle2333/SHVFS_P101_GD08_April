using System;
namespace SHVFS_P101_GD08_HW1
{
    public class Program
    {
         public static void Main()
        {
            float number1;
            Console.WriteLine("please input Fahrenheight:");
            float.TryParse(Console.ReadLine(), out number1);
            Console.Clear();
            float number2 = (number1 - 32) / 1.8f;
            Console.WriteLine($"the Celsius is {number2.ToString("#0.00")}");
            Console.ReadLine();
        }
    }
}
