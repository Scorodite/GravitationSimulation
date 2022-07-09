using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GravitationSimulation.Animations;

namespace GravitationSimulation
{
    public partial class MainForm : Form
    {
        public const int CAMERA_SPEED = 10;

        public Space Space { get; }
        public bool Paused { get; set; }

        public float CameraX {
            get => CameraCenterX - SpaceBitmapBox.Width / CameraScale / 2;
            set => CameraCenterX = value + SpaceBitmapBox.Width / CameraScale / 2;
        }
        public float CameraY
        {
            get => CameraCenterY - SpaceBitmapBox.Height / CameraScale / 2;
            set => CameraCenterY = value + SpaceBitmapBox.Height / CameraScale / 2;
        }

        public float CameraCenterX { get; set; }
        public float CameraCenterY { get; set; }
        public float CameraScale { get; set; }
        /// <summary>
        /// The planet on which the camera is fixed
        /// </summary>
        public Planet CameraLock { get; set; }

        private Bitmap SpaceBitmap { get; set; }
        private Graphics Graphics { get; set; }
        private DateTime LastDrawTime { get; set; }

        private Point LastMousePoint { get; set; }
        private bool IsCameraMoving { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CameraScale = 1;

            Space = new();
            SpaceBitmap = new(SpaceBitmapBox.Width, SpaceBitmapBox.Height);
            LastDrawTime = DateTime.Now;
            Graphics = Graphics.FromImage(SpaceBitmap);
            Graphics.Clear(Color.Black);
            SpaceBitmapBox.Image = SpaceBitmap;
            foreach (string anim in LoadedAnimations.Animations.Keys)
            {
                PlanetAnimationBox.Items.Add(anim);
            }

            PlanetAnimationBox.SelectedIndex = 0;

            MainSplitContainer.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Space update timer handler
        /// </summary>
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!Paused)
            {
                Space.Update();

                foreach (ListViewItem item in PlanetList.Items)
                {
                    if (item.Tag is Planet planet)
                    {
                        item.SubItems[1].Text = ((int)planet.X).ToString();
                        item.SubItems[2].Text = ((int)planet.Y).ToString();
                        item.SubItems[4].Text = ((int)planet.Acceleration.Lenght).ToString();
                    }
                }
            }
            if (CameraLock is not null)
            {
                CameraCenterX = CameraLock.X;
                CameraCenterY = CameraLock.Y;
            }
            Draw();
        }

        /// <summary>
        /// Draws planets in SpaceBitmap
        /// </summary>
        private void Draw()
        {
            float delta = Paused ? 0 : (float)(DateTime.Now - LastDrawTime).TotalSeconds;
            LastDrawTime = DateTime.Now;
            Graphics.Clear(Color.Black);

            List<Planet> selected = new();

            foreach (ListViewItem selection in PlanetList.SelectedItems)
            {
                if (selection.Tag is Planet planet)
                {
                    selected.Add(planet);
                }
            }

            foreach (Planet planet in Space)
            {
                bool drawn = planet.Draw(
                    delta,
                    Graphics,
                    new Size(SpaceBitmapBox.Width, SpaceBitmapBox.Height),
                    new Point((int)CameraCenterX, (int)CameraCenterY),
                    CameraScale,
                    selected.Contains(planet)
                );

                if (AccelerationVectorsBox.Checked && drawn)
                {
                    Point pos = GetRelativePlanetPos(planet);

                    Graphics.DrawLine(Pens.Crimson,
                        pos,
                        new Point(pos.X + (int)(planet.Acceleration.X * 5), pos.Y + (int)(planet.Acceleration.Y * 5))
                    );
                }
            }
            
            SpaceBitmapBox.Refresh();
        }

        /// <summary>
        /// Gets planet position relative to the camera
        /// </summary>
        private Point GetRelativePlanetPos(Planet planet)
        {
            return planet.PosRelativeToCamera(
                        new Size(SpaceBitmapBox.Width, SpaceBitmapBox.Height),
                        new Point((int)CameraCenterX, (int)CameraCenterY),
                        CameraScale
                    );
        }

        /// <summary>
        /// Mouse click handler
        /// </summary>
        private void SpaceBitmapBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CreatePlanetRadio.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Planet planet = GetPlanet();

                    planet.X = e.X / CameraScale + CameraX;
                    planet.Y = e.Y / CameraScale + CameraY;

                    Space.Add(planet);

                    PlanetList.Items.Add(
                        new ListViewItem(
                            new[]
                            {
                                PlanetAnimationBox.Text,
                                ((int)planet.X).ToString(),
                                ((int)planet.Y).ToString(),
                                ((int)planet.Mass).ToString(),
                                ((int)planet.Acceleration.Lenght).ToString(),
                                planet.Static ? "Yes" : "No",
                            }
                        )
                        {
                            Tag = planet
                        }
                    );
                }
            }
        }

        /// <summary>
        /// Mouse down handler
        /// </summary>
        private void SpaceBitmapBox_MouseDown(object sender, MouseEventArgs e)
        {
            LastMousePoint = e.Location;
            IsCameraMoving = MoveCameraRadio.Checked;
        }

        /// <summary>
        /// Mouse up handler
        /// </summary>
        private void SpaceBitmapBox_MouseUp(object sender, MouseEventArgs e)
        {
            IsCameraMoving = false;
        }

        /// <summary>
        /// Mouse leave handler
        /// </summary>
        private void SpaceBitmapBox_MouseLeave(object sender, EventArgs e)
        {
            IsCameraMoving = false;
        }

        /// <summary>
        /// Mouse move handler
        /// </summary>
        private void SpaceBitmapBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveCameraRadio.Checked && IsCameraMoving)
            {
                CameraLock = null;
                if (e.Button == MouseButtons.Left)
                {
                    CameraCenterX += (LastMousePoint.X - e.X) / CameraScale;
                    CameraCenterY += (LastMousePoint.Y - e.Y) / CameraScale;
                }
            }
            LastMousePoint = e.Location;
        }

        /// <summary>
        /// Pause button click handler
        /// </summary>
        private void PauseButton_Click(object sender, EventArgs e)
        {
            Paused = !Paused;
            PauseButton.Text = Paused ? "Unpause" : "Pause";
        }

        /// <summary>
        /// Gets planet from planet constructor
        /// </summary>
        public Planet GetPlanet()
        {
            return new Planet()
            {
                Animation = new BitmapAnimation(LoadedAnimations.Animations[PlanetAnimationBox.Text]),
                Static = PlanetStaticBox.Checked,
                Mass = (float)PlanetMassBox.Value,
                Acceleration = new Vector()
                {
                    Angle = (double)PlanetAngleBox.Value * Math.PI,
                    Lenght = (double)PlanetSpeedBox.Value,
                }
            };
        }

        /// <summary>
        /// Clear button click handler
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Space.Clear();
            PlanetList.Items.Clear();
            CameraLock = null;
        }

        /// <summary>
        /// Screen size change handler
        /// </summary>
        private void SpaceBitmapBox_SizeChanged(object sender, EventArgs e)
        {
            SpaceBitmap.Dispose();
            SpaceBitmap = new(SpaceBitmapBox.Width, SpaceBitmapBox.Height);
            Graphics = Graphics.FromImage(SpaceBitmap);
            SpaceBitmapBox.Image = SpaceBitmap;
            Draw();
        }

        /// <summary>
        /// Animation box in planet constructor selection change handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlanetAnimationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanetAnimationPreviewBox.Image =
                LoadedAnimations.Animations[PlanetAnimationBox.Text].Frames[0];
        }

        /// <summary>
        /// Hotkey handler
        /// </summary>
        private void PlanetList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        while (PlanetList.SelectedItems.Count > 0)
                        {
                            if (PlanetList.SelectedItems[0].Tag is Planet planet)
                            {
                                Space.Remove(planet);
                            }
                            PlanetList.Items.Remove(PlanetList.SelectedItems[0]);
                        }
                    }
                    break;
                case Keys.S:
                    {
                        foreach (ListViewItem item in PlanetList.SelectedItems)
                        {
                            if (item.Tag is Planet planet)
                            {
                                planet.Static = !planet.Static;
                                item.SubItems[5].Text = planet.Static ? "Yes" : "No";
                            }
                        }
                    }
                    break;
                case Keys.C:
                    {
                        if (GetSelectedPlanet() is Planet planet)
                        {
                            CameraCenterX = planet.X;
                            CameraCenterY = planet.Y;
                        }
                    }
                    break;
                case Keys.X:
                    {
                        if (GetSelectedPlanet() is Planet planet)
                        {
                            CameraLock = planet;
                        }
                    }
                    break;
                case Keys.Z:
                    {
                        if (GetSelectedPlanet() is Planet center)
                        {
                            float x = center.X;
                            float y = center.Y;
                            CameraCenterX -= x;
                            CameraCenterY -= y;
                            Space.Move(-x, -y);
                        }
                    }
                    break;
                case Keys.V:
                    {
                        if (GetSelectedPlanet() is Planet center)
                        {
                            Space.ApplyForce(new Vector(
                                center.Acceleration.Angle + Math.PI,
                                center.Acceleration.Lenght
                            ));
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Gets selected planet
        /// </summary>
        private Planet GetSelectedPlanet()
        {
            if (PlanetList.SelectedItems.Count == 1
                && PlanetList.SelectedItems[0].Tag is Planet planet)
            {
                return planet;
            }
            return null;
        }

        /// <summary>
        /// Scroll handler
        /// </summary>
        private void SpaceBitmapBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int boxWidth = SpaceBitmapBox.Width;
            int boxHeight = SpaceBitmapBox.Height;

            float offsetX = (boxWidth / 2f - e.X) / boxWidth * 2;
            float offsetY = (boxHeight / 2f - e.Y) / boxHeight * 2;

            float oldWidth = boxWidth / CameraScale;
            float oldHeight = boxHeight / CameraScale;

            CameraScale = Math.Clamp(e.Delta > 0 ? CameraScale * 1.1f : CameraScale / 1.1f, 0.05f, 10);

            float newWidth = SpaceBitmapBox.Width / CameraScale;
            float newHeight = SpaceBitmapBox.Height / CameraScale;

            CameraCenterX -= (int)((oldWidth - newWidth) / 2 * offsetX);
            CameraCenterY -= (int)((oldHeight - newHeight) / 2 * offsetY);
        }
    }
}
