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
    class Obj
    {
        public Texture2D Texture = null;                //texture 
        public string TextureName = String.Empty;       //texture name
        public Vector2 Center = Vector2.Zero;           //center of the texture
        public Vector2 Position = Vector2.Zero;         //position obj on the screen
        public float Rotation = 0.0f;                   //rotation value of the obj
        public float Scale = 1.0f;                      //scale of the obj
        public float Speed = 0.0f;                      //speed of the obj
        public bool isAlive = true;                     //current state of the obj


        public Obj(Vector2 pos)
        {

        }
        public Obj() { }

        public virtual void LoadContent(ContentManager content)
        {
            Texture = content.Load<Texture2D>(this.TextureName);
            Center = new Vector2(Texture.Width / 2, Texture.Height / 2);
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (!isAlive) return;

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, Position, null, Color.White, MathHelper.ToRadians(Rotation), Center, Scale, SpriteEffects.None, 0);
            spriteBatch.End();
        }

    }
}
