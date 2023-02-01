using System;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace SHVFS_P101_GD08_Q3_April
{
    public struct Position
    {
        public float X;
        public float Y;
        public float Z;
        public Position(float x,float y,float z)
        {
            X = x; 
            Y = y;
            Z = z;
        }
    }
    public class GameObject
    {
        public Position pos;
        public string name;

        public GameObject( string name,Position pos)
        {
            this.pos = pos;
            this.name = name;
        }

        public bool CheckPosition(GameObject go)
        {
            if(go.pos.X==pos.X&& go.pos.Y == pos.Y&& go.pos.Z == pos.Z)
            {
                return true;
            }
            return false;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            GameObject[] go = new GameObject[5];
            go[0] = new GameObject("0",new Position(0, 20, 60));
            go[1] = new GameObject("1", new Position(10, 20, 60));
            go[2] = new GameObject("2", new Position(20, 20, 60));
            go[3] = new GameObject("3", new Position(0, 20, 60));
            go[4] = new GameObject("4", new Position(100, 20, 60));
            for (int i=0;i<go.Length-1;i++)
            {
                for(int j=i+1;j<go.Length;j++)
                {
                    if (go[i].CheckPosition(go[j]))
                    {
                        Console.WriteLine($"{go[i].name} and {go[j].name} have the same position");
                    }
                }
            }
        }
        
    }

}

