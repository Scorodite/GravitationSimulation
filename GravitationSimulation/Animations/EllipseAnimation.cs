using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GravitationSimulation.Animations
{
    public class EllipseAnimation : Animation
    {
        public override int FrameCount => 1;
        public override int CurrentFrame { get => 0; set { } }
        public override float Speed { get => 0; set { } }

        public Size Size { get; set; }
        public Color Color { get; set; }

        public EllipseAnimation(Size size, Color color)
        {
            Size = size;
            Color = color;
        }

        public override void DrawCurrentFrame(Graphics graphics, Point location, float scale)
        {
            graphics.FillEllipse(
                new SolidBrush(Color),
                location.X - Size.Width / 2,
                location.Y - Size.Height / 2,
                Size.Width * scale,
                Size.Height * scale
            );
        }

        public override void DrawNextFrame(float delta, Graphics graphics, Point location, float scale)
        {
            DrawCurrentFrame(graphics, location, scale);
        }
    }
}
