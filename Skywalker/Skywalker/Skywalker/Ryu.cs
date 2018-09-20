
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
                    currentframeIndex = 0;
                }

            }

        }
        public Ryu(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Frame> frames)
            : base(image, position, speed, color, frames)
        {
            List<Frame> stand = new List<Frame>()
            {
                new Frame(new Rectangle(1, 40, 24, 60), new Vector2()),
                new Frame(new Rectangle(1, 40, 24, 60), new Vector2()),
                new Frame(new Rectangle(30, 39, 23, 61), new Vector2()),
                new Frame(new Rectangle(30, 39, 23, 61), new Vector2()),
                new Frame(new Rectangle(57, 38, 23, 62), new Vector2()),
                new Frame(new Rectangle(57, 38, 23, 62), new Vector2()),
            };
            animation2 = new Dictionary<SaiyukiEnums.SaiyukiFrames, List<Frame>>();
            animation2.Add(SaiyukiEnums.SaiyukiFrames.Stand, stand);
            List<Frame> punch = new List<Frame>()
            {
                new Frame(new Rectangle(302, 40, 28, 60), new Vector2()),
                new Frame(new Rectangle(302, 40, 28, 60), new Vector2()),
                new Frame(new Rectangle(335, 40, 26, 60), new Vector2()),
                new Frame(new Rectangle(335, 40, 26, 60), new Vector2()),
                new Frame(new Rectangle(364, 40, 44, 60), new Vector2()),
                new Frame(new Rectangle(364, 40, 44, 60), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.Punch, punch);
            List<Frame> kick = new List<Frame>()
            {
                new Frame(new Rectangle(515, 40, 28, 60), new Vector2()),
                new Frame(new Rectangle(515, 40, 28, 60), new Vector2()),
                new Frame(new Rectangle(546, 40, 31, 60), new Vector2()),
                new Frame(new Rectangle(546, 40, 31, 60), new Vector2()),
                new Frame(new Rectangle(578, 40, 45, 60), new Vector2()),
                new Frame(new Rectangle(578, 40, 45, 60), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.Kick, kick);
            List<Frame> forward = new List<Frame>()
            {
                new Frame(new Rectangle(1, 143, 25, 60), new Vector2()),
                new Frame(new Rectangle(1, 143, 25, 60), new Vector2()),
                new Frame(new Rectangle(29, 143, 23, 60), new Vector2()),
                new Frame(new Rectangle(29, 143, 23, 60), new Vector2()),
                new Frame(new Rectangle(55, 143, 27, 60), new Vector2()),
                new Frame(new Rectangle(55, 143, 27, 60), new Vector2()),
                new Frame(new Rectangle(85, 143, 29, 60), new Vector2()),
                new Frame(new Rectangle(85, 143, 29, 60), new Vector2()),
                new Frame(new Rectangle(118, 143, 23, 60), new Vector2()),
                new Frame(new Rectangle(118, 143, 23, 60), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.WalkForward, forward);
            List<Frame> backward = new List<Frame>()
            {
                new Frame(new Rectangle(156, 144, 28, 60), new Vector2()),
                 new Frame(new Rectangle(156, 144, 28, 60), new Vector2()),
                new Frame(new Rectangle(187, 144, 27, 59), new Vector2()),
                new Frame(new Rectangle(187, 144, 27, 59), new Vector2()),
                new Frame(new Rectangle(217, 143, 28, 61), new Vector2()),
                new Frame(new Rectangle(217, 143, 28, 61), new Vector2()),
                new Frame(new Rectangle(248, 142, 28, 62), new Vector2()),
                new Frame(new Rectangle(248, 142, 28, 62), new Vector2()),
                new Frame(new Rectangle(277, 143, 27, 60), new Vector2()),
                new Frame(new Rectangle(277, 143, 27, 60), new Vector2()),

            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.WalkBackwards, backward);
            /*
            List<Frame >  = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame >  = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame >  = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            List<Frame >  = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames);
            */
        }

        public void Update(GameTime gtime, KeyboardState ks)
        {
            frames = animation2[currentframestate2];

            if (currentframestate2 == SaiyukiEnums.SaiyukiFrames.Punch)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate2 = SaiyukiEnums.SaiyukiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Up))
            {
                currentframestate2 = SaiyukiEnums.SaiyukiFrames.Punch;
            }
        
            //////////////////////////////////////////////////////////////////
            if (currentframestate2 == SaiyukiEnums.SaiyukiFrames.Kick)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate2 = SaiyukiEnums.SaiyukiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Down))
            {
                currentframestate2 = SaiyukiEnums.SaiyukiFrames.Kick;
            }
            //////////////////////////////////////////////////////////////////
            if (currentframestate2 == SaiyukiEnums.SaiyukiFrames.WalkForward)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate2 = SaiyukiEnums.SaiyukiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Right))
            {
                currentframestate2 = SaiyukiEnums.SaiyukiFrames.WalkForward;
                position.X += speed.X;
            }

            //////////////////////////////////////////////////////////////////
            if (currentframestate2 == SaiyukiEnums.SaiyukiFrames.WalkBackwards)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate2 = SaiyukiEnums.SaiyukiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Left))
            {
                currentframestate2 = SaiyukiEnums.SaiyukiFrames.WalkBackwards;
                position.X -= speed.X;
            }



            base.Update(gtime);
        }
    }
}

