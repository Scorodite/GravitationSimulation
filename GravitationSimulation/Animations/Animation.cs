using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GravitationSimulation.Animations
{
    /// <summary>
    /// Animation base class
    /// </summary>
    public abstract class Animation
    {
        public abstract int FrameCount { get; }
        public abstract int CurrentFrame { get; set; }
        public abstract float Speed { get; set; }

        public abstract void DrawNextFrame(float delta, Graphics graphics, Point location, float scale);

        public abstract void DrawCurrentFrame(Graphics graphics, Point location, float scale);
    }
}
