using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GravitationSimulation.Animations
{
    /// <summary>
    /// Class that stores bitmap frames of animation
    /// </summary>
    public class BitmapFrames
    {
        public Bitmap[] Frames { get; set; }
        public int Count => Frames.Length;
        
        public BitmapFrames()
        {
            Frames = Array.Empty<Bitmap>();
        }

        public BitmapFrames(Image source, int framesX, int framesY)
        {
            int frameWidth = source.Width / framesX;
            int frameHeight = source.Height / framesY;
            Frames = new Bitmap[framesX * framesY];

            int frameIndex = 0;
            for (int y = 0; y < framesY; y++)
            {
                for (int x = 0; x < framesX; x++)
                {
                    Bitmap frame = new(frameWidth, frameHeight);
                    Graphics g = Graphics.FromImage(frame);

                    g.Clear(Color.Transparent);
                    g.DrawImage(
                        source,
                        new Rectangle(0, 0, frameWidth, frameHeight),
                        new Rectangle(frameWidth * x, frameHeight * y, frameWidth, frameHeight),
                        GraphicsUnit.Pixel
                    );
                    g.Dispose();
                    Frames[frameIndex++] = frame;
                }
            }
        }
    }
}
