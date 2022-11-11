using System;

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
        //public string name;
        public bool CheckPosition(GameObject go)
        {
            if(go.pos.X==this.pos.X&& go.pos.Y == this.pos.Y&& go.pos.Z == this.pos.Z)
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
            go[0].pos = new Position(10, 20, 30);
            go[1].pos = new Position(10, 20, 30);
            go[2].pos = new Position(0, 20, 30);
            go[3].pos = new Position(10, 2, 30);
            go[4].pos = new Position(10, 20, 3);
            for (int i=0;i<go.Length;i++)
            {
                go[i].name = "GameObject" + i;
            }
            for(int i=0;i<go.Length;i++)
            {
                for(int j=1;j<go.Length;j++)
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

