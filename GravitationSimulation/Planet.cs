using System;
using System.Drawing;
using GravitationSimulation.Animations;

namespace GravitationSimulation
{
    /// <summary>
    /// Class that represents planet
    /// </summary>
    public class Planet
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Mass { get; set; }
        /// <summary>
        /// If planet is static, it does not change it's position in space
        /// </summary>
        public bool Static { get; set; }
        public Animation Animation { get; set; }

        public Vector Acceleration { get; set; }

        public Planet() { }

        public Planet(float x, float y, float mass, Color color)
        {
            X = x;
            Y = y;
            Mass = mass;
            int size = (int)(Math.Max(2, mass / 2));
            Animation = new EllipseAnimation(new Size(size, size), color);
        }

        public Planet(float x, float y, float mass, Animation anim)
        {
            X = x;
            Y = y;
            Mass = mass;
            Animation = anim;
        }

        /// <summary>
        /// Gets PlanetState with Planet parameters
        /// </summary>
        /// <returns></returns>
        public PlanetState GetState()
        {
            return new PlanetState()
            {
                X = X,
                Y = Y,
                Mass = Mass,
                Acceleration = Acceleration,

                Owner = this,
            };
        }

        /// <summary>
        /// Moves planet coordinates according to acceleration
        /// </summary>
        public void Move()
        {
            if (!Static)
            {
                X += (float)Acceleration.X;
                Y += (float)Acceleration.Y;
            }
        }

        /// <summary>
        /// Draws the planet in bitmap using Graphics
        /// </summary>
        /// <param name="delta">Time from previous draw</param>
        /// <param name="graphics">Graphics object</param>
        /// <param name="screen">Actual screen size</param>
        /// <param name="camera">Camera position</param>
        /// <param name="cameraScale">Camera scale</param>
        /// <param name="drawHitbox">If true, draws hitbox around frame</param>
        /// <returns>If planet was drawn</returns>
        public bool Draw(float delta, Graphics graphics, Size screen, Point camera, float cameraScale, bool drawHitbox)
        {
            Point position = PosRelativeToCamera(screen, camera, cameraScale);

            if (position.X < screen.Width * 2 &&
                position.X > -screen.Width && 
                position.Y < screen.Height * 2 &&
                position.Y > -screen.Height )
            {
                Animation.DrawNextFrame(
                    delta,
                    graphics,
                    position,
                    cameraScale
                );
                if (drawHitbox && Animation is BitmapAnimation anim)
                {
                    Bitmap currFrame = anim.Source.Frames[anim.CurrentFrame];
                    float width = currFrame.Width * cameraScale;
                    float height = currFrame.Width * cameraScale;
                    graphics.DrawRectangle(Pens.Red,
                        position.X - width / 2,
                        position.Y - height / 2,
                        width,
                        height
                    );
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets position of texture relative to the camera
        /// </summary>
        /// <param name="screen">Actual screen size</param>
        /// <param name="camera">Camera position</param>
        /// <param name="cameraScale">Camera scale</param>
        /// <returns>Position of texture</returns>
        public Point PosRelativeToCamera(Size screen, Point camera, float cameraScale)
        {
            return new(
                       (int)((X - camera.X) * cameraScale + screen.Width / 2),
                       (int)((Y - camera.Y) * cameraScale + screen.Height / 2)
                   );
        }

        /// <summary>
        /// Class that stores fixed information about planet
        /// </summary>
        public struct PlanetState
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Mass { get; set; }
            public Vector Acceleration { get; set; }

            public Planet Owner { get; set; }

            /// <summary>
            /// Applies properties from state to planet object
            /// </summary>
            public void ApplyState()
            {
                Owner.X = X;
                Owner.Y = Y;
                Owner.Mass = Mass;
                Owner.Acceleration = Acceleration;
            }
        }
    }
}
