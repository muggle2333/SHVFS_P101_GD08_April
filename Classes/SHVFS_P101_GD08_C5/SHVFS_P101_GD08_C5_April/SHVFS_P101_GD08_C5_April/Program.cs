using System;

namespace SHVFS_P101_GD08_C5_April
{
    //Classes sort like template, and used/reused to create OBJECTS
    //we use the new keyword to create an instance of a class
    //this runs the classes'construtor --which is public'
    //It creates a version of it in memory--an instance--assigning it the variable name

    //!!!!!Scope --local and global variable
    //Local variable are only accessibel inside the methods in which they're defined
    public class Program
    {
        
        public static void Main(string[] args)
        {
            //Jump statements
            //1.break
            //Terminates the closest enclosing loop
            /*string input = "";
            while(true) //never do
            {
                Console.Clear();
                Console.WriteLine("Type 'y' to quit");
                input = Console.ReadLine();
                if(input == "y")
                {
                    break;
                }
                Console.WriteLine("quiting..");
            }
            Console.WriteLine("quit");*/

            //Continue
            //Proceeds to the next iteration of the loop
            /*for(var i =0;i<10;i++)
            {
                if(i==4)
                {
                    //break;
                    continue;//skip to next interation
                }
                Console.WriteLine(i);
            }*/

            /*//using methods
            Print();
            //The argument I'm passing is"April"
            PrintName("April");
            //
            int[] array = new int[]{ 0, 8, 9, 4, 6 };
            var max = GetMaxEXP(array);
            Console.WriteLine(max);
            //smilyface
            var smileyFace = ReturnSmileyFace();
            Console.WriteLine(smileyFace);*/

            //out modifer Must be set before ANYTHING is returned.
            /*string inputs;
            int radius;
            double MyCircumference;
            double myArea;
            do
            {
                Console.WriteLine("enter a radius");
                inputs = Console.ReadLine();
            } while (!int.TryParse(inputs, out radius)||!TryCircle(radius,out MyCircumference,out myArea));
            Console.WriteLine($"radius is {radius},circumference is {MyCircumference},area is {myArea}");*/
            /*string inputs;
            int radius;
            double MyCircumference;
            double myArea;
            do
            {
                Console.WriteLine("enter a radius");
                inputs = Console.ReadLine();
            } while (!int.TryParse(inputs, out radius) || !TryCircle(radius, out MyCircumference, out myArea));
            Console.WriteLine($"radius is {radius},circumference is {MyCircumference},area is {myArea}");*/

            //class-应用类型 指向同一个地址
            var pikachu1 = new Pokemon(20);
            var pikachu2 = pikachu1;
            pikachu2.Hp = 999;
            Console.WriteLine(pikachu1.Hp + " " + pikachu2.Hp);

            //struct-值类型 指向不同地址，但值相同（赋值时）
            var pokemonData1 = new PokemonData(48);
            var pokemonData2 = pokemonData1;
            pokemonData2.EXP = 464;
            Console.WriteLine(pokemonData1.EXP + " " + pokemonData2.EXP);
            Console.WriteLine(Pokemon.baseType1);//public 才行


            

        }
        //methods/functions are blocks of code that Do Things we can reues
        //must inside the class
        //They can have inputs --parameters in the defination/arguments that are passed -- and outs -- return
        //methods can only return ONE value,5 parameters is ok

        //this method has no parameters in the SIGNATURE and retruns NOTING
        public static void Print()
        {
            Console.WriteLine("hello");
        }
        //this method has one parameters,a string called 'name',in its SIGNATURE and returns Nothing
        public static void PrintName(string name)
        {
            Console.WriteLine(name);
        }
        //this method has one parameters in its signature,and return an int
        public static int GetMaxEXP(int[] intArray)
        {
            var maximum = intArray[0];
            for (var i = 1; i < intArray.Length; i++)
            {
                maximum = maximum > intArray[i] ? maximum : intArray[i];
            }
            return maximum;
        }
        //this method has no parameters,has one return
        public static string ReturnSmileyFace()
        {
            Console.WriteLine("Smile");
            return ":)";
        }

        //*out/ref modifiers
        //out modifer Must be set before ANYTHING is returned.
        //ref don't  change the parameter
        public static bool TryCircle(int radius,out double circumference,out double area)
        {
            // they must be set
            circumference = 0;
            area = 0;

            if(radius==0)
            {
                Console.WriteLine("enter a radius");
                return false;
            }
            circumference = Math.PI * radius * 2;
            area = Math.Pow(radius, 2) * Math.PI;
            return true;

        }
        //With the ref modifier we tell the compiler that WE WILL SET IT LATER
        //ref 要在用方法前赋初始值，out 不用但需要在方法中用前赋初始值
        public static bool TryCircleRef(int radius, ref double circumference, ref double area)
        {

            if (radius == 0)
            {
                Console.WriteLine("enter a radius");
                return false;
            }
            circumference = Math.PI * radius * 2;
            area = Math.Pow(radius, 2) * Math.PI;
            return true;

        }
        //cf
        public static bool TryCircleR0ps(int radius, double circumference, double area)
        {

            if (radius == 0)
            {
                Console.WriteLine("enter a radius");
                return false;
            }
            circumference = Math.PI * radius * 2;
            area = Math.Pow(radius, 2) * Math.PI;
            return true;

        }





    }
    //Class is reference type
    public class Pokemon
    {
        //static fields are accessed on the class ITSELF,NOT INSTANCES of the class
        public static string baseType1 = "po";
        private static string baseType2 = "po";
        //Non-static public field
        //it is public,so other classes can see/access it
        //Since it's non-static,it is accessed on INSTANCES of the class
        public int Hp;

        //构造函数（用于初始化新对象的数据成员，实例后赋值方便）
        //The constructor is a special method uesd to create a version/object/instance
        //The constructor name and class name Must MATCH
        //It runs ONCE,return types with constructors
        //We can use them to assign fields/properties
        public Pokemon(int hp)
        {
            Hp = hp;
        }
    }
    //struct is value type
    public struct PokemonData
    {
        public int EXP;
        public PokemonData(int exp)
        {
            EXP = exp;
        }
    }
}
