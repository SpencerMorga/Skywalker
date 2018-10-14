using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using System.Linq;
using System.Text;

namespace Saiyuki_VS_Skywalker
{
    public class MBison : MovingAnimation
    {
        Dictionary<MBisonEnums.MBisonFrames, List<Frame>> animation5;
        MBisonEnums.MBisonFrames mbisonstates;
        MBisonEnums.MBisonFrames currentframestate5
        {
            get { return mbisonstates; }
            set { if (mbisonstates != value) { mbisonstates = value; currentframeIndex = 0; } }
        }

        public MBison (Texture2D image, Vector2 position, Vector2 speed, Color color, List<Frame> frames)
            : base (image, position, speed, color, frames)
        {
            List<Frame> stand = new List<Frame>()
            {
                new Frame(new Rectangle(2, 21, 46, 64), new Vector2()),
                new Frame(new Rectangle(50, 22, 47, 64), new Vector2()),
                new Frame(new Rectangle(100, 24, 46, 64), new Vector2()),
                new Frame(new Rectangle(148, 22, 47, 64), new Vector2()),
            };
            animation5 = new Dictionary<MBisonEnums.MBisonFrames, List<Frame>>();
            animation5.Add(MBisonEnums.MBisonFrames.Stand, stand);
            

            List<Frame> punch = new List<Frame>()
            {
                new Frame(new Rectangle(237, 24, 43, 64), new Vector2()),
                new Frame(new Rectangle(287, 24, 56, 64), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.Punch, punch);

            List<Frame> hardpunch = new List<Frame>()
            {
                new Frame(new Rectangle(420, 28, 35, 64), new Vector2()),
                new Frame(new Rectangle(456, 33, 46, 64), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.HardPunch, hardpunch);

            List<Frame> kick = new List<Frame>()
            {
                new Frame(new Rectangle(583, 21, 40, 64), new Vector2()),
                new Frame(new Rectangle(625, 21, 56, 64), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.Kick, kick);

            List<Frame> walk = new List<Frame>()
            {
                new Frame(new Rectangle(1, 126, 37, 68), new Vector2()),
                new Frame(new Rectangle(38, 125, 30, 69), new Vector2()),
                new Frame(new Rectangle(71, 126, 37, 68), new Vector2()),
                new Frame(new Rectangle(109, 125, 30, 69), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.Forward, walk);

            List<Frame> jump = new List<Frame>()
            {
                new Frame(new Rectangle(1, 233, 32, 68), new Vector2()),
                new Frame(new Rectangle(37, 234, 39, 61), new Vector2()),
                new Frame(new Rectangle(79, 234, 51, 47), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.Jump, jump);

            List<Frame> jumppunch = new List<Frame>()
            {
                new Frame(new Rectangle(7, 234, 51, 47), new Vector2()),
                new Frame(new Rectangle(63, 239, 48, 38), new Vector2()),
                new Frame(new Rectangle(112, 230, 66, 48), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.JumpPunch, jumppunch);

            List<Frame> jumpkick = new List<Frame>()
            {
                new Frame(new Rectangle(221, 226, 40, 64), new Vector2()),
                new Frame(new Rectangle(265, 230, 60, 44), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.JumpKick, jumpkick);

            List<Frame> flipkick = new List<Frame>()
            {
                new Frame(new Rectangle(336, 23, 46, 43), new Vector2()),
                new Frame(new Rectangle(383, 229, 37, 52), new Vector2()),
                new Frame(new Rectangle(422, 238, 60, 43), new Vector2()),
                new Frame(new Rectangle(482, 226, 56, 55), new Vector2()),
                new Frame(new Rectangle(274, 150, 60, 44), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.FlipKick, flipkick);

            List<Frame> PsychoThingy = new List<Frame>()
            {
                new Frame(new Rectangle(233, 461, 132, 48), new Vector2()),
                new Frame(new Rectangle(368, 464, 130, 28), new Vector2()),
               // new Frame(new Rectangle(503, 466, 64, 27), new Vector2()),
            };
            animation5.Add(MBisonEnums.MBisonFrames.PsychoThingy, PsychoThingy);
        }
        public void Update(GameTime gtime, KeyboardState ks)
        {
            frames = animation5[currentframestate5];

            if (currentframestate5 == MBisonEnums.MBisonFrames.Punch)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate5 = MBisonEnums.MBisonFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.K))
            {
                currentframestate5 = MBisonEnums.MBisonFrames.Punch;
            }
            ////////////////////////////////////////////////////////////////////
            if (currentframestate5 == MBisonEnums.MBisonFrames.HardPunch)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate5 = MBisonEnums.MBisonFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.O))
            {
                currentframestate5 = MBisonEnums.MBisonFrames.HardPunch;
            }
            ////////////////////////////////////////////////////////////////////
            if (currentframestate5 == MBisonEnums.MBisonFrames.Kick)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate5 = MBisonEnums.MBisonFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.U))
            {
                currentframestate5 = MBisonEnums.MBisonFrames.Kick;
            }
            ////////////////////////////////////////////////////////////////////
            if (currentframestate5 == MBisonEnums.MBisonFrames.JumpPunch)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate5 = MBisonEnums.MBisonFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.P))
            {
                currentframestate5 = MBisonEnums.MBisonFrames.JumpPunch;
            }
            ////////////////////////////////////////////////////////////////////
            if (currentframestate5 == MBisonEnums.MBisonFrames.JumpKick)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate5 = MBisonEnums.MBisonFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Y))
            {
                currentframestate5 = MBisonEnums.MBisonFrames.JumpKick;
            }
            ////////////////////////////////////////////////////////////////////
            if (currentframestate5 == MBisonEnums.MBisonFrames.FlipKick)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate5 = MBisonEnums.MBisonFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.D9))
            {
                currentframestate5 = MBisonEnums.MBisonFrames.FlipKick;
                position.X += speed.X;
            }
            ////////////////////////////////////////////////////////////////////
            if (currentframestate5 == MBisonEnums.MBisonFrames.PsychoThingy)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate5 = MBisonEnums.MBisonFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.D8))
            {
                currentframestate5 = MBisonEnums.MBisonFrames.PsychoThingy;
                position.X += speed.X * 2;
            }

            base.Update(gtime);
        }

    }
}
