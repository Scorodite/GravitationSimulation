using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GravitationSimulation.Animations
{
    public class BitmapAnimation : Animation
    {
        public override int FrameCount => Source.Count;
        public override int CurrentFrame { get; set; }
        public override float Speed { get; set; }

        public BitmapFrames Source { get; set; }

        private float CurrentFrameFloat { get; set; }

        public BitmapAnimation(BitmapFrames source)
        {
            Source = source;
            Speed = 15;
        }

        public override void DrawCurrentFrame(Graphics graphics, Point location, float scale)
        {
            Bitmap frame = Source.Frames[CurrentFrame];
            float width = frame.Width * scale;
            float height = frame.Height * scale;
            graphics.DrawImage(
                frame,
                location.X - width / 2,
                location.Y - width / 2,
                width,
                height
            );
        }

        public override void DrawNextFrame(float delta, Graphics graphics, Point location, float scale)
        {
            CurrentFrameFloat += Speed * delta;
            if (CurrentFrameFloat >= FrameCount)
            {
                CurrentFrameFloat = 0;
            }
            else if (CurrentFrameFloat < 0)
            {
                CurrentFrameFloat = FrameCount - 1;
            }
            CurrentFrame = (int)CurrentFrameFloat;

            DrawCurrentFrame(graphics, location, scale);
        }
    }
}
