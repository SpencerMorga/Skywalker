
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saiyuki_VS_Skywalker
{
    public class Chun_LiStuff : MovingAnimation
    {
        Dictionary<Chun_LiEnums.ChunLiFrames, List<Frame>> animation3;
        Chun_LiEnums.ChunLiFrames chunlistates;
        Chun_LiEnums.ChunLiFrames currentframestate3
        {
            get { return chunlistates; }
            set
            {
                if (chunlistates != value)
                {
                    chunlistates = value;
                    currentframeIndex = 0;
                }
            }
        }
        public Chun_LiStuff(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Frame> frames)
            : base (image, position, speed, color, frames)
        {
            List<Frame> stand = new List<Frame>()
            {
                
            };
        }
    }
}
