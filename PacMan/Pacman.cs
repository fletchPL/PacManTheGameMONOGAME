using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace PacMan 
{
    class Pacman : Obj
    {
        private KeyboardState currentKeyboardState;
        private KeyboardState previousKeyboardState;
        private Animation pacmanAnimation;
        private bool walking;


        public Pacman(Vector2 pos, string texctureName)
        {
            TextureName = texctureName;
            Position = pos;
            isAlive = true;
            Speed = 2.0f;
            pacmanAnimation = new Animation();

        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);

            pacmanAnimation.Initialize(Texture, Position, 32, 32, 8, 25, Color.White, Scale, true, 0);
            Center = new Vector2(pacmanAnimation.FrameWidth / 2, pacmanAnimation.FrameHeight / 2);
        }

        public override void Update(GameTime gameTime)
        {
            currentKeyboardState = Keyboard.GetState();

            if (!isAlive) return;
            walking = false; 
            if (currentKeyboardState.IsKeyDown(Keys.Up))
            {
                walking = true;
                Rotation = (int)RotationEnum.North;
                Position.Y -= Speed;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Down))
            {
                walking = true;
                Rotation = (int)RotationEnum.South;
                Position.Y += Speed;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Right))
            {
                walking = true;
                Rotation = (int)RotationEnum.East;
                Position.X += Speed;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Left))
            {
                walking = true;
                Rotation = (int)RotationEnum.West;
                Position.X -= Speed;
            }

            pacmanAnimation.Position = Position;
            pacmanAnimation.Rotation = Rotation;
            pacmanAnimation.Update(gameTime);

            previousKeyboardState = currentKeyboardState;
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if(isAlive)
            {
                pacmanAnimation.Draw(spriteBatch, Center, walking);
            }
        }


    }
}
