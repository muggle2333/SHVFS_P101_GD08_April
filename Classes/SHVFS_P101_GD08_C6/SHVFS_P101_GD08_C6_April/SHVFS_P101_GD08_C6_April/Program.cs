using System;
using System.Runtime.ExceptionServices;

namespace SHVFS_P101_GD08_C2_April
{
    public class Program
    {
        public static void Main()
        {
            #region C6
            //PrintAThing("something");
            //PrintAThing(13);
            //PrintAThing("A", "B");

            //var pokemon1 = new Pokemon();
            //pokemon1.EXP = 900;
            //var pokemon2 = new Pokemon(100,10,"test","secret");
            //var pokemon3 = new Pokemon()
            //{
            //    EXP = 9000,
            //    HP = 10
            //}; //empty constructor but can assign the value
            //Console.WriteLine($"{pokemon1.EXP} , {pokemon2.EXP} , {pokemon3.EXP}");
            ////Wrong,can't access the private value
            ////Console.WriteLine($"{pokemon2.EXP} , {pokemon2.HP} , {pokemon2.Name} , {pokemon2.SecretName}");
            ///
            var pikachu = new Pikachu(0,100,"name1","name2");
            pikachu.DeclareForBattle(); //继承类实例可使用base类的虚方法
            pikachu.PrintDetails();
            #endregion
        }
        //Overloads,access modifiers,overrides/virtual methods,inheritance,lists,dictionaries,recursion,try/catch(error handling)
        //methods/Construtors can be overloaded, if the signatures are different

        #region Overload
        //1.Overloads
        public static void PrintAThing(string stringThing)
        {
            Console.WriteLine($"The thing is : {stringThing}");
        }
        //can't PrintAThing(string anotherStringThing)
        //can't have same name but different arguements
        public static void PrintAThing(int anotherStringThing)
        {
            Console.WriteLine($"The thing is : {anotherStringThing}");
        }
        public static void PrintAThing(string stringThing ,string anotherStringThing)
        {
            Console.WriteLine($"The thing is : {stringThing}, another thing is : {anotherStringThing}");
        }
        #endregion
    }
    public class Pokemon
    {
        public int EXP;
        public int HP;
        public string Name;
        //Classes,fields,methods,etc are IMPLICITLY PRIVATE in c# unless you define it's public
        //so it's private,only instance of the class/class itself is static can see their private members
        string SecretName;
        protected string SecretName2;
        //constructors are special,they return nothing
        public Pokemon() { }
        public Pokemon(int exp,int hp,string name,string secretName)
        {
            Console.WriteLine("Pokemon");
            EXP = exp;
            HP = hp;
            Name = name;
            SecretName = secretName;
        }
        //use public method of the class to get private data
        public string GetSecretName()
        {
            return SecretName;
        }

        //Overrides/virtual methods
        //virtual可在不同继承类中重写
        public virtual void DeclareForBattle() //signature of the method is its return type and arguments(take)
        {
            Console.WriteLine("virtual method");
        }
    }
    //Inheritance
    //OO/Polymorphism
    //Pokemon is the base class of Pikachu,so Pikachu gets all his memebers
    //we invoke the POKEMON CONSTRUCTOR with this base keywor
    public class Pikachu : Pokemon
    {
        public Pikachu (int exp,int hp, string name,string secretName) : base (exp,hp, name, secretName) 
        {
            Console.WriteLine("Pikachu");
        }
        public void PrintDetails()
        {
            Console.WriteLine("inherentance");
            Console.WriteLine($"{EXP},{Name},");//can't see the private value,but can see protected /internal
            GetSecretName();
        }

        public override void DeclareForBattle()
        {
            base.DeclareForBattle();//可在内部invoke the vitual method of the base class after
            Console.WriteLine("override method");
        }
    }
}