#region Stracture of a program
//region help you structure and organize your code 
using System; //to use 
//namespace 
//contain classes
//like a dictionary made for us,or by us,and provide commands and tools we can use
//noete the syntax
//keyword/reserved word namespace,followed by the name of our namespace,opening and closing curly braces
//words that we ARE NOT ALLOWED to us
namespace SHVFS_P101_GD08_C1_April
{//opening curly brace
    //class
    //Contain variables fields and parameters to store data,and methods to do things(functions)
    
    public class Program
    {//curly barce

        //Technically methods are in object oriented programming c# but they are basically used interchangeably
        //method contain statements that do things
        //the main method is the entry point for our program
        //Syntax:public:access modifiers访问修饰符,static,return type,arguments参数/parameters
        public static void Main(string[] args)
        {
            //int 4bytes
            //var syntactic sugar(implict var)
            //int i = 0;
            //var j = 2;

            //Console.WriteLine($"my money is {i}");
            //Console.WriteLine($"my father's money is also {j}");
            //Console.WriteLine("my money is {0}+{1}", i,j);

            //float myfirtFloat = 1.225f;//float 8 bytes
            //var mySecondFloat = 1.26454545f; //float
            //var myThirdSomething = 454121.45454;//double 没有备注f的var变量默认为double
            //double myTrueDouble = 454611.5465465;//double 16 bytes
            //Console.WriteLine($"My first float is:{myfirtFloat},and my first double is:{myTrueDouble}");
            //Console.ReadLine();

            //Tyepcast/typecasting
            //int myFirtNumberChar = 'A';
            //char myFirstCharNumber = (char)65;
            //Console.WriteLine($"My first float is:{myFirtNumberChar},and my first double is:{myFirstCharNumber}");

            //statements
            //statements always end in semi-conlons-> ;
            //Everything we've written inside our main method,has been statements
            //Statements can assign variablies,write to the console,read from console

            //string 
            //string together a bunch of chararcters(char)
            //string myFirstString = "hello,Chris!";
            //myFirstString += "characters!";
            //Console.WriteLine($"{myFirstString} has\n {myFirstString.Length}charachters");
            //Console.ReadLine();

            //Type can be declared all on the same line,and use commas if they're the same type
            //Readline waits for the user to type somthing,retur
            //string name, age;int idealAge = 21;
            //Console.Clear();
            //Console.WriteLine("HI!What's YOUR name?");
            //name = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Annd what's your age?");
            //age = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine($"Oh,hello {name},nice to know you're {age} years old.Too bad you're not {idealAge}!");

            //var number1 = 5;
            //var number2 = 3;
            //int total1;
            //float total2;
            //total1 = number1 + number2;
            //Console.WriteLine($"Addition:{total1}");
            //total1 = number1 - number2;
            //Console.WriteLine($"Subtraction:{total1}");
            //total1 = number1 * number2;
            //Console.WriteLine($"Multiplication:{total1}");
            //total2 = number1 / number2;
            //Console.WriteLine($"Division1:{total2}");
            //total2 = number1 / (float)number2;
            //Console.WriteLine($"Division2:{total2}");
            //total1 = number1 % number2;
            //Console.WriteLine($"Modules:{total1}");
            //total1 = (number1 + number2)*2;
            //Console.WriteLine($"Mathsss1:{total1}");
            //total1 = number1 + number2 * 2;
            //Console.WriteLine($"Mathsss:{total1}");

            //Covert string input to numbers!
            //string number1;
            //string number2;
            //Console.WriteLine("Hi,number");
            //number1 = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("secondnumber");
            //number2 = Console.ReadLine();
            //Console.Clear();
            //var num1Converted = Convert.ToInt32(number1);
            //var num2Converted = Convert.ToInt32(number2);
            //Console.WriteLine($"the sum is \n {num1Converted+num2Converted}");
            //Console.ReadLine();


            //calculator convert Fahrenheight to Celsius
            float number1;
            Console.WriteLine("please input Fahrenheight:");
            float.TryParse(Console.ReadLine(),out number1);
            Console.Clear();
            float number2 = (number1 - 32) / 1.8f;
            Console.WriteLine($"the Celsius is {number2.ToString("#0.00")}");
            Console.ReadLine();

        }
    }
}//closing curly brace
#endregion
/**/
