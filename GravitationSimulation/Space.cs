using System;
using System.Collections;
using System.Collections.Generic;

namespace GravitationSimulation
{
    /// <summary>
    /// Class that stores planets
    /// </summary>
    public class Space : IList<Planet>
    {
        private List<Planet> Planets { get; }
        public float Gravity { get; set; }

        public Space()
        { 
            Planets = new();
            Gravity = 10F;
        }

        #region IList implementation
        public Planet this[int index] { get => Planets[index]; set => Planets[index] = value; }

        public int Count => Planets.Count;

        public bool IsReadOnly => false;

        public void Add(Planet item)
        {
            Planets.Add(item);
        }

        public void Clear()
        {
            Planets.Clear();
        }

        public bool Contains(Planet item)
        {
            return Planets.Contains(item);
        }

        public void CopyTo(Planet[] array, int arrayIndex)
        {
            Planets.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Planet> GetEnumerator()
        {
            return Planets.GetEnumerator();
        }

        public int IndexOf(Planet item)
        {
            return Planets.IndexOf(item);
        }

        public void Insert(int index, Planet item)
        {
            Planets.Insert(index, item);
        }

        public bool Remove(Planet item)
        {
            return Planets.Remove(item);
        }

        public void RemoveAt(int index)
        {
            Planets.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Planets.GetEnumerator();
        }
        #endregion

        /// <summary>
        /// Updates all planets in the space
        /// </summary>
        public void Update()
        {
            List<Planet.PlanetState> states = Planets.ConvertAll((p) => p.GetState());

            // Applying gravitation forces to planets
            for (int i = 0; i < states.Count; i++)
            {
                Planet.PlanetState state1 = states[i];
                if (state1.Owner.Static) continue;

                for (int j = 0; j < states.Count; j++)
                {
                    if (i == j) continue;
                    Planet.PlanetState state2 = states[j];
                    float relativeX = state1.X - state2.X;
                    float relativeY = state1.Y - state2.Y;
                    float distance = (float)Math.Sqrt(Math.Pow(relativeX, 2) + Math.Pow(relativeY, 2));
                    float force = state2.Mass / (float)Math.Pow(distance, 2) * Gravity;
                    Angle angle = Angle.PosToAngle(0, 0, relativeX, relativeY);

                    if (force < 0)
                    {
                        angle += Math.PI;
                        force = -force;
                    }

                    state1.Acceleration &= new Vector(angle, force);
                }

                states[i] = state1;
            }

            states.ForEach((s) => { s.ApplyState(); s.Owner.Move(); });
        }

        /// <summary>
        /// Moves all planets with an offset
        /// </summary>
        /// <param name="x">Offset x</param>
        /// <param name="y">Offset y</param>
        public void Move(float x, float y)
        {
            foreach (Planet planet in this)
            {
                planet.X += x;
                planet.Y += y;
            }
        }

        /// <summary>
        /// Applies force to all planets
        /// </summary>
        /// <param name="force">Force</param>
        public void ApplyForce(Vector force)
        {
            foreach (Planet planet in this)
            {
                planet.Acceleration &= force;
            }
        }
    }
}
