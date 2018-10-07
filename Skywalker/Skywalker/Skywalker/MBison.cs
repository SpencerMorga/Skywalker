using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
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

            /*&stand
            2, 21, 46, 64
50, 22, 47, 64
100, 24, 46, 64
148, 22, 47, 64

light punch
237, 24, 43, 64
287, 24, 56, 64

hard punch
420, 28, 35, 64
456, 33, 46, 64

kick
583, 21, 40, 64
625, 21, 56, 64

walk
1, 126, 37, 68
38, 125, 30, 69
71, 126, 37, 68
109, 125, 30, 69

jump
1, 233, 32, 68
37, 234, 39, 61
79, 234, 51, 47

jump punch
7, 234, 51, 47
63, 239, 48, 38
112, 230, 66, 48

jump kick
221, 226, 40, 64
265, 230, 60, 44

flip kcccckkkkkkkkkkkk
336, 23, 46, 43
383, 229, 37, 52
422, 238, 60, 43
482, 226, 56, 55
274, 150, 60, 44

psycho thingy
68, 461, 132, 48
203, 464, 130, 28
338, 466, 64, 27

*/


        }
    }
}
