using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saiyuki_VS_Skywalker
{
    public class Dhalsim : MovingAnimation
    {
        Dictionary<DhalsimEnums.DhalsimFrames, List<Frame>> animation4;
        DhalsimEnums.DhalsimFrames dhalsimstates;
        DhalsimEnums.DhalsimFrames currentframestate4
        {
            get { return dhalsimstates; }
            set
            {
                if (dhalsimstates != value)
                {
                    dhalsimstates = value;
                    currentframeIndex = 0;
                }
            }
        }

        public Dhalsim (Texture2D image, Vector2 position, Vector2 speed, Color color, List<Frame> frames)
            : base (image, position, speed, color, frames)
        {
            
        }
    }
}
