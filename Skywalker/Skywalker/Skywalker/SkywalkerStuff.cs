using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skywalker
{
    public class SkywalkerStuff : MovingAnimation
    {
        Dictionary<SkywalkerEnums.SkyFrames, List<Frame>> animation;
        SkywalkerEnums.SkyFrames currentFrameState;
        SkywalkerEnums.SkyFrames SkywalkerStates;

        public SkywalkerStuff (Texture2D image, Vector2 position, Vector2 speed, Color color, List<Frame> frames)
            : base (image, position, speed, color, frames)
        {
            List<Frame> RunRight = new List<Frame>()
            {
                new Frame(new Rectangle(202, 40, 18, 32), new Vector2()),
                new Frame(new Rectangle(242, 40, 20, 31), new Vector2()),
                new Frame(new Rectangle(285, 40, 12, 32), new Vector2()),
                new Frame(new Rectangle(324, 40, 14, 32), new Vector2()),
                new Frame(new Rectangle(361, 41, 21, 30), new Vector2()),
                new Frame(new Rectangle(202, 80, 19, 32), new Vector2()),
                new Frame(new Rectangle(244, 80, 14, 31), new Vector2()),
                new Frame(new Rectangle(284, 80, 15, 31), new Vector2()),
                new Frame(new Rectangle(321, 81, 20, 30), new Vector2()),
            };
            animation = new Dictionary<SkywalkerEnums.SkyFrames, List<Frame>>();
            animation.Add(SkywalkerEnums.SkyFrames.RunRight, RunRight);

            List<Frame> RunLeft = new List<Frame>()
            {
                new Frame(new Rectangle(162, 40, 18, 32), new Vector2()),
                new Frame(new Rectangle(121, 40, 19, 31), new Vector2()),
                new Frame(new Rectangle(85, 40, 12, 32), new Vector2()),
                new Frame(new Rectangle(44, 40, 14, 32), new Vector2()),
                new Frame(new Rectangle(0, 41, 21, 30), new Vector2()),
                new Frame(new Rectangle(161, 80, 19, 32), new Vector2()),
                new Frame(new Rectangle(124, 80, 14, 31), new Vector2()),
                new Frame(new Rectangle(83, 80, 15, 31), new Vector2()),
                new Frame(new Rectangle(41, 81, 20, 30), new Vector2()),
            };
            animation.Add(SkywalkerEnums.SkyFrames.RunLeft, RunLeft);

            List<Frame> DownSlice = new List<Frame>()
            {
                new Frame(new Rectangle(204, 274, 15, 43), new Vector2()),
                new Frame(new Rectangle(242, 274, 19, 44), new Vector2()),
                new Frame(new Rectangle(276, 275, 30, 41), new Vector2()),
                new Frame(new Rectangle(312, 277, 38, 38), new Vector2()),
                new Frame(new Rectangle(235, 320, 33, 32), new Vector2()),
                new Frame(new Rectangle(194, 320, 35, 32), new Vector2()),
            };
            animation.Add(SkywalkerEnums.SkyFrames.DownSlice, DownSlice);

            List<Frame> UpSlice = new List<Frame>()
            {
                new Frame(new Rectangle(202, 240, 18, 31), new Vector2()),
                new Frame(new Rectangle(235, 241, 32, 30), new Vector2()),
                new Frame(new Rectangle(275, 241, 32, 30), new Vector2()),
                new Frame(new Rectangle(312, 277, 38, 38), new Vector2()),
                new Frame(new Rectangle(276, 275, 30, 41), new Vector2()),
                new Frame(new Rectangle(242, 274, 19, 44), new Vector2()),
                new Frame(new Rectangle(204, 274, 15, 43), new Vector2()),
            };
            animation.Add(SkywalkerEnums.SkyFrames.UpSlice, UpSlice);

            List<Frame> Starting = new List<Frame>()
            {
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
                new Frame(new Rectangle(), new Vector2()),
                //new Frame(new Rectangle())
            };



        }

/*
Idle
321, 196, 21, 39
Idle Left
40, 196, 21, 39
Starting
204, 200, 15, 32
243, 200, 17, 32
282, 198, 18, 35
321, 186, 21, 39
Upward Slice
202, 240, 18, 31
235, 241, 32, 30
275, 241, 32, 30
312, 277, 38, 38
276, 275, 30, 41
242, 274, 19, 44
204, 274, 15, 43
Downward Slice
204, 274, 15, 43
242, 274, 19, 44
276, 275, 30, 41
312, 277, 38, 38
235, 320, 33, 32
194, 320, 35, 32
Block
204, 274, 15, 43
Run Right
202, 40, 18, 32
242, 40, 20, 31
285, 40, 12, 32
324, 40, 14, 32
361, 41, 21, 30
202, 80, 19, 32
244, 80, 14, 31
284, 80, 15, 31
321, 81, 20, 30
Run Left
162, 40, 18, 32
121, 40, 19, 31
85, 40, 12, 32
44, 40, 14, 32
0, 41, 21, 30
161, 80, 19, 32
124, 80, 14, 31
83, 80, 15, 31
41, 81, 20, 30
*/
    }
}
