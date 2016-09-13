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
        private int startFrame;
        public Animation GhostAnimation;

        public Ghost(Vector2 pos, string textureName, int startFrame)
        {
            TextureName = textureName;
            Position = pos;
            isAlive = true;
            this.startFrame = startFrame;
            GhostAnimation = new Animation();
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);

            GhostAnimation.Initialize(Texture, Position, 32, 32, 8, 90, Color.White, 1f, true, startFrame);
        }

        public override void Update(GameTime gameTime)
        {
            GhostAnimation.Position = Position;
            GhostAnimation.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if(isAlive)
            {
                GhostAnimation.Draw(spriteBatch);
            }
        }
    }
}
