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
        public static void Initialize()
        {
            ObjList.Add(Pacman = new Pacman(new Vector2(240, 450), "pac0"));
        }
    }
}
