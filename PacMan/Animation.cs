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
    class Animation
    {
        private float scale;    //scale use to display the sprite strip
        private int elipsedTime; // time  since  we last update the frame
        private int frameTime;      //time we display frame until the nexone 
        private int currentFrame;   //the index of the current frame we are displaing 
        private Color color;        //the color of the frame we will be displaing 
        private Rectangle sourceRect = new Rectangle(); //its the area of the image stript we want to display


        public Rectangle DestinationRect = new Rectangle();     //the area where we want to display the image on screen
        public Texture2D SpritesStrip;                          //the image representing the collection of image used for the animation
        public int FrameCoutn;                                  //frameCounter 
        public int FrameWidth;
        public int FrameHeight;
        public bool IsActive;                                   //the state of animation
        public bool IsLooping;

        public Vector2 Position;                                //the position of animation
        public float Rotation;                                  //the rotation value of animation


        public void Initialize(Texture2D texture, Vector2 position, int frameWidth, int frameHeigt, int frameCount, int frameTime,Color color, float scale, bool looping, int startFrame)
        {
            this.color = color;
            this.FrameWidth = frameWidth;
            this.FrameHeight = frameHeigt;
            this.FrameCoutn = frameCount;
            this.frameTime = frameTime;
            this.scale = scale;

            IsLooping = looping;
            Position = position;
            SpritesStrip = texture;

            elipsedTime = 0;

            currentFrame = startFrame;

            IsActive = true;
        }
        
        public void Update(GameTime gameTime)
        {
            if (!IsActive) return;

            elipsedTime += (int)gameTime.ElapsedGameTime.TotalMilliseconds;

            if(elipsedTime > frameTime ) //if ET is bigger than FT we need to switch frame 
            {
                currentFrame++;

                if(currentFrame == FrameCoutn)
                {
                    currentFrame = 0;

                    if(!IsLooping)
                    {
                        IsActive = false;
                    }
                }
                elipsedTime = 0;
            }
            sourceRect = new Rectangle(currentFrame * FrameWidth, 0, FrameWidth, FrameHeight);
            DestinationRect = new Rectangle((int)Position.X - (int)(FrameWidth*scale)/2, (int)Position.Y - (int)(FrameHeight*scale)/2, (int)(FrameWidth*scale),(int)(FrameHeight*scale));
           

        }


    }
}
