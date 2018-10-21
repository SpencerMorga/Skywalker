
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

        Vector2 initialvelocity;
        Vector2 velocity;
        public Vector2 Velocity { get { return velocity; } }
        bool isJumping = false;
        float gravity = 0.05f;
        bool Pastfloor
        {
            get { return position.Y + frames[currentframeIndex].frame.Height > Game1.Viewport3.Height; }
        }
        private Vector2 Bottomright(int width, int height)
        {
            return new Vector2(width, 0);
        }
        public Chun_LiStuff(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Frame> frames)
            : base(image, position, speed, color, frames)
        {
            initialvelocity = speed;

            List<Frame> stand = new List<Frame>()
            {
                new Frame(new Rectangle(959, 43, 31, 50), new Vector2()),
                new Frame(new Rectangle(959, 43, 31, 50), new Vector2()),
                new Frame(new Rectangle(927, 43, 31, 50), new Vector2()),
                new Frame(new Rectangle(927, 43, 31, 50), new Vector2()),
                new Frame(new Rectangle(895, 42, 31, 52), new Vector2()),
                new Frame(new Rectangle(895, 42, 31, 52), new Vector2()),
            };
            animation3 = new Dictionary<Chun_LiEnums.ChunLiFrames, List<Frame>>();
            animation3.Add(Chun_LiEnums.ChunLiFrames.Stand, stand);

            List<Frame> punch = new List<Frame>()
            {
              //  new Frame(new Rectangle(827, 43, 31, 56), new Vector2()),
                new Frame(new Rectangle(827, 43, 31, 56), Bottomright(31, 56)),
                new Frame(new Rectangle(781, 36, 43, 57), Bottomright(43, 57)),
                new Frame(new Rectangle(781, 36, 43, 57), Bottomright(43, 57)),
                new Frame(new Rectangle(749, 36, 32, 56), Bottomright(32, 56)),
                new Frame(new Rectangle(749, 36, 32, 56), Bottomright(32, 56)),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.Punch, punch);

            List<Frame> punch2 = new List<Frame>()
            {
                new Frame(new Rectangle(553, 41, 38, 49), Bottomright(38, 49)),
                new Frame(new Rectangle(553, 41, 38, 49), Bottomright(38, 49)),
                new Frame(new Rectangle(493, 40, 58, 48), Bottomright(58, 48)),
                new Frame(new Rectangle(493, 40, 58, 48), Bottomright(58, 48)),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.Punch2, punch2);

            List<Frame> kick = new List<Frame>()
            {
                new Frame(new Rectangle(154, 32, 30, 56), new Vector2()),
                new Frame(new Rectangle(154, 32, 30, 56), new Vector2()),
                new Frame(new Rectangle(98, 32, 52, 56), new Vector2()),
                new Frame(new Rectangle(98, 32, 52, 56), new Vector2()),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.Kick, kick);

            List<Frame> crouchkick = new List<Frame>()
            {
                new Frame(new Rectangle(63, 141, 42, 40), new Vector2()),
                new Frame(new Rectangle(63, 141, 42, 40), new Vector2()),
                new Frame(new Rectangle(0, 138, 61, 43), new Vector2()),
                new Frame(new Rectangle(0, 138, 61, 43), new Vector2()),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.CrouchKick, crouchkick);

            List<Frame> jumpkick = new List<Frame>()
            {
                new Frame(new Rectangle(179, 219, 51, 38), new Vector2()),
                new Frame(new Rectangle(179, 219, 51, 38), new Vector2()),
                new Frame(new Rectangle(179, 219, 51, 38), new Vector2()),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.JumpKick, jumpkick);

            List<Frame> walkforward = new List<Frame>()
            {
                new Frame(new Rectangle(772, 131, 28, 49), new Vector2()),
                new Frame(new Rectangle(772, 131, 28, 49), new Vector2()),
                new Frame(new Rectangle(746, 129, 24, 51), new Vector2()),
                new Frame(new Rectangle(746, 129, 24, 51), new Vector2()),
                new Frame(new Rectangle(717, 129, 27, 51), new Vector2()),
                new Frame(new Rectangle(717, 129, 27, 51), new Vector2()),
                new Frame(new Rectangle(687, 131, 28, 49), new Vector2()),
                new Frame(new Rectangle(687, 131, 28, 49), new Vector2()),
                new Frame(new Rectangle(659, 130, 26, 51), new Vector2()),
                new Frame(new Rectangle(659, 130, 26, 51), new Vector2()),
                new Frame(new Rectangle(633, 130, 24, 51), new Vector2()),
                new Frame(new Rectangle(633, 130, 24, 51), new Vector2()),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.WalkForward, walkforward);

            List<Frame> walkbackward = new List<Frame>()
            {
                new Frame(new Rectangle(960, 133, 30, 47), new Vector2()),
                new Frame(new Rectangle(960, 133, 30, 47), new Vector2()),
                new Frame(new Rectangle(933, 132, 26, 48), new Vector2()),
                new Frame(new Rectangle(933, 132, 26, 48), new Vector2()),
                new Frame(new Rectangle(903, 132, 28, 48), new Vector2()),
                new Frame(new Rectangle(903, 132, 28, 48), new Vector2()),
                new Frame(new Rectangle(870, 133, 32, 47), new Vector2()),
                new Frame(new Rectangle(870, 133, 32, 47), new Vector2()),
                new Frame(new Rectangle(842, 132, 28, 48), new Vector2()),
                new Frame(new Rectangle(842, 132, 28, 48), new Vector2()),
                new Frame(new Rectangle(812, 132, 26, 48), new Vector2()),
                new Frame(new Rectangle(812, 132, 26, 48), new Vector2()),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.WalkBackward, walkforward);

            List<Frame> spinkick = new List<Frame>()
            {
                 //new Frame(new Rectangle(389, 442, 23, 72), new Vector2()),
                 new Frame(new Rectangle(389, 442, 23, 72), new Vector2()),
                 //new Frame(new Rectangle(347, 442, 39, 72), new Vector2()),
                 new Frame(new Rectangle(347, 442, 39, 72), new Vector2()),
                 //new Frame(new Rectangle(296, 442, 49, 72), new Vector2()),
                 new Frame(new Rectangle(296, 442, 49, 72), new Vector2()),
                 //new Frame(new Rectangle(252, 442, 42, 72), new Vector2()),
                 new Frame(new Rectangle(252, 442, 42, 72), new Vector2()),
                 //new Frame(new Rectangle(195, 442, 26, 72), new Vector2()),
                 new Frame(new Rectangle(195, 442, 26, 72), new Vector2()),
                 //new Frame(new Rectangle(159, 442, 30, 72), new Vector2()),
                 new Frame(new Rectangle(159, 442, 30, 72), new Vector2()),
                 new Frame(new Rectangle(92, 442, 58, 72), new Vector2()),
                 new Frame(new Rectangle(92, 442, 58, 72), new Vector2()),
                 new Frame(new Rectangle(32, 442, 58, 72), new Vector2()),
                 new Frame(new Rectangle(32, 442, 58, 72), new Vector2()),

                 new Frame(new Rectangle(159, 442, 30, 72), new Vector2()),
                 new Frame(new Rectangle(195, 442, 26, 72), new Vector2()),
                 new Frame(new Rectangle(252, 442, 42, 72), new Vector2()),
                 new Frame(new Rectangle(296, 442, 42, 72), new Vector2()),
                 new Frame(new Rectangle(347, 442, 39, 72), new Vector2()),
                 new Frame(new Rectangle(389, 442, 23, 72), new Vector2()),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.SpinKick, spinkick);

            List<Frame> jump = new List<Frame>()
            {
                new Frame(new Rectangle(969, 217, 21, 64), new Vector2()),
                 new Frame(new Rectangle(969, 217, 21, 64), new Vector2()),
                new Frame(new Rectangle(969, 217, 21, 64), new Vector2()),
                new Frame(new Rectangle(945, 217, 23, 56), new Vector2()),
                new Frame(new Rectangle(945, 217, 23, 56), new Vector2()),
                new Frame(new Rectangle(945, 217, 23, 56), new Vector2()),
                new Frame(new Rectangle(920, 217, 24, 43), new Vector2()),
                new Frame(new Rectangle(920, 217, 24, 43), new Vector2()),
                new Frame(new Rectangle(920, 217, 24, 43), new Vector2()),
                new Frame(new Rectangle(894, 217, 23, 56), new Vector2()),
                new Frame(new Rectangle(894, 217, 23, 56), new Vector2()),
                new Frame(new Rectangle(894, 217, 23, 56), new Vector2()),
                new Frame(new Rectangle(871, 217, 21, 64), new Vector2()),
                new Frame(new Rectangle(871, 217, 21, 64), new Vector2()),
                new Frame(new Rectangle(871, 217, 21, 64), new Vector2()),
                //new Frame(new Rectangle(222, 442, 24, 72), new Vector2()),
                //new Frame(new Rectangle(222, 442, 24, 72), new Vector2()),
            };
            animation3.Add(Chun_LiEnums.ChunLiFrames.Jump, jump);

        }
        public void Update(GameTime gtime, KeyboardState ks)
        {
            frames = animation3[currentframestate3];
            /*
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.Punch)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            
            if (ks.IsKeyDown(Keys.Up))
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.Punch;
            }
            */
            ////////////////////////////////////////////////////////////////
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.Punch2)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Down))
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.Punch2;
            }
            ////////////////////////////////////////////////////////////////
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.Kick)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.M))
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.Kick;
            }
            ////////////////////////////////////////////////////////////////
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.WalkForward)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Left))
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.WalkForward;
                position.X -= speed.X * 3;
            }
            ////////////////////////////////////////////////////////////////
            /*
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.CrouchKick)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.N))
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.CrouchKick;
            }
            */
            ////////////////////////////////////////////////////////////////
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.JumpKick)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.B))
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.JumpKick;
            }
            ////////////////////////////////////////////////////////////////
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.WalkBackward)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Right))
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.WalkBackward;
                position.X += speed.X * 3;
            }
            ////////////////////////////////////////////////////////////////
            if (isJumping)
            {
                velocity.Y -= gravity;
                position.Y -= velocity.Y;
                if (Pastfloor)
                {
                    isJumping = false;
                }

            }
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.Jump)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.Up) && !isJumping)
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.Jump;
                velocity = initialvelocity;
                isJumping = true;
            }
            ////////////////////////////////////////////////////////////////
            if (currentframestate3 == Chun_LiEnums.ChunLiFrames.SpinKick)
            {
                if (currentframeIndex + 1 >= frames.Count)
                {
                    currentframestate3 = Chun_LiEnums.ChunLiFrames.Stand;
                }
            }
            if (ks.IsKeyDown(Keys.N))
            {
                currentframestate3 = Chun_LiEnums.ChunLiFrames.SpinKick;
                position.X -= speed.X;

            }
            base.Update(gtime);
        }
    }
}
