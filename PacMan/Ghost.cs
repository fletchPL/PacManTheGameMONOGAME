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
    class Ghost : Obj
    {
        public Ghost(Vector2 pos, string textureName)
        {
            TextureName = textureName;
            Position = pos;
            isAlive = true;

        }
    }
}
