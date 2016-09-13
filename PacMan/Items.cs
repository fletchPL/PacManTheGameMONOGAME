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
            ObjList.Add(Pacman = new Pacman(new Vector2(240, 450), "pacman_animation"));
            ObjList.Add(Red = new Ghost(new Vector2(330, 450), "red_ghost_animation",2));
            ObjList.Add(Blue = new Ghost(new Vector2(450, 450), "red_ghost_animation", 4));
            ObjList.Add(Orange = new Ghost(new Vector2(570, 450), "red_ghost_animation", 6));
            ObjList.Add(Pink = new Ghost(new Vector2(700, 450), "red_ghost_animation", 0));

        }
    }
}
