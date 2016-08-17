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





    }
}
