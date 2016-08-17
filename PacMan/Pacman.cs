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
    class Pacman : Obj
    {
        public Pacman(Vector2 pos, string texctureName)
        {
            TextureName = texctureName;
            Position = pos;
            isAlive = true;
        }


    }
}
