using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace PacMan
{
    class Items
    {
        public static List<Obj> ObjList = new List<Obj>();
        public static Pacman Pacman;
        public static Ghost Red;
        public static Ghost Blue;
        public static Ghost Pink;
        public static Ghost Orange;

        public static void Initialize()
        {
            ObjList.Add(Pacman = new Pacman(new Vector2(240, 450), "pacman"));
            ObjList.Add(Red = new Ghost(new Vector2(330, 450), "redGhost"));
            ObjList.Add(Blue = new Ghost(new Vector2(450, 450), "blueGhost"));
            ObjList.Add(Orange = new Ghost(new Vector2(570, 450), "orangeGhost"));
            ObjList.Add(Pink = new Ghost(new Vector2(700, 450), "pinkGhost"));

        }
    }
}
