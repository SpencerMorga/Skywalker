
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saiyuki_VS_Skywalker
{
    public class Ryu : MovingAnimation
    {
        Dictionary<SaiyukiEnums.SaiyukiFrames, List<Frame>> animation2;
        SaiyukiEnums.SaiyukiFrames saiyukistates;
        SaiyukiEnums.SaiyukiFrames currentframestate2
        {
            get
            {
                return saiyukistates;
            }
            set
            {
                if (saiyukistates != value)
                {
                    saiyukistates = value;
                    currentframestate2 = 0;
                }

            }

        }
        public Ryu(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Frame> frames)
            : base (image, position, speed, color, frames)
        {
            List<Frame> /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame > /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame > /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame > /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame > /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame > /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame > /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame > /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame > /**/ = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
        }
        
        public void Update(GameTime gtime, KeyboardState ks)
        {
            frames = animation2[currentframestate2];

            if (currentframestate2 == SaiyukiEnums.SaiyukiFrames)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate2 = SaiyukiEnums.SaiyukiFrames;
                }
            }
            if (ks.IsKeyDown(Keys.))
            {
                currentframestate2 = SaiyukiEnums.SaiyukiFrames;
            }
            //////////////////////////////////////////////////////////////////
            if (currentframestate2 == SaiyukiEnums.SaiyukiFrames)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate2 = SaiyukiEnums.SaiyukiFrames;
                }
            
            if (ks.IsKeyDown(Keys.))
            {
                currentframestate2 = SaiyukiEnums.SaiyukiFrames;
            }
            //////////////////////////////////////////////////////////////////
            if (currentframestate2 == SaiyukiEnums.SaiyukiFrames)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate2 = SaiyukiEnums.SaiyukiFrames;
                }
            }
        }
    }
}

