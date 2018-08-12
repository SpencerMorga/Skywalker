using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skywalker
{
    public class Sprite
    {
        public Texture2D image;
        public Vector2 position;
        public Color color;
        public Rectangle sourceRectangle;

        public Sprite (Texture2D image, Vector2 position, Color color)
        {
            this.image = image;
            this.position = position;
            this.color = color;
        }

        public void Draw (SpriteBatch spritebatch)
        {
            spritebatch.Draw(image, position, color);
        }
    }
}
