
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saiyuki_VS_Skywalker
{
    public class SaiyukiStuff : MovingAnimation
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
        public SaiyukiStuff(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Frame> frames)
            : base (image, position, speed, color, frames)
        {
            List<Frame> IdleGuard = new List<Frame>()
            {
                new Frame(new Rectangle(9, 32, 23, 32), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.IdleGuard, IdleGuard);
            List<Frame> StandAttack = new List<Frame>()
            {
                new Frame(new Rectangle(49, 33, 31, 31), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.StandAttack, StandAttack);
            List<Frame> UpGuard = new List<Frame>()
            {
                new Frame(new Rectangle(96, 32, 24, 32), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.UpGuard, UpGuard);
            List<Frame> Jump = new List<Frame>()
            {
                new Frame(new Rectangle(136, 40, 24, 24), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.Jump, Jump);
            List<Frame> Hurt = new List<Frame>()
            {
                new Frame(new Rectangle(224, 34, 24, 30), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.Hurt, Hurt);
            List<Frame> UpAttack = new List<Frame>()
            {
                new Frame(new Rectangle(9, 75, 19, 45), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.UpAttack, UpAttack);
            List<Frame> DownAttack = new List<Frame>()
            {
                new Frame(new Rectangle(80, 95, 20, 35), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.DownAttack, DownAttack);
            List<Frame> Running = new List<Frame>()
            {
                new Frame(new Rectangle(138, 88, 22, 32), new Vector2()),
                new Frame(new Rectangle(170, 89, 21, 31), new Vector2()),
                new Frame(new Rectangle(201, 89, 23, 31), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.Running, Running);
            List<Frame> RunningAttack = new List<Frame>()
            {
                new Frame(new Rectangle(256, 89, 32, 31), new Vector2()),
                new Frame(new Rectangle(296, 89, 32, 31), new Vector2()),
                new Frame(new Rectangle(336, 89, 32, 31), new Vector2()),
            };
            animation2.Add(SaiyukiEnums.SaiyukiFrames.RunningAttack, RunningAttack);
        }
        
        public void Update(GameTime gtime, KeyboardState ks)
        {
            frames = animation2[currentframestate2];


        }
    }
}

