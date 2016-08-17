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

        public Pacman(Vector2 pos, string texctureName)
        {
            TextureName = texctureName;
            Position = pos;
            isAlive = true;
            Speed = 2.0f;

        }

        public override void Update(GameTime gameTime)
        {
            currentKeyboardState = Keyboard.GetState();

            if (!isAlive) return;

            if (currentKeyboardState.IsKeyDown(Keys.Up))
            {
                Rotation = (int)RotationEnum.North;

                Position.Y -= Speed;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Down))
            {
                Rotation = (int)RotationEnum.South;

                Position.Y += Speed;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Right))
            {
                Rotation = (int)RotationEnum.East;
                Position.X += Speed;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Left))
            {
                Rotation = (int)RotationEnum.West;
                Position.X -= Speed;
            }


            previousKeyboardState = currentKeyboardState;
            base.Update(gameTime);
        }


    }
}
