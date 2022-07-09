using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GravitationSimulation
{
    /// <summary>
    /// Class that stores animations from the "Planets" directiory
    /// </summary>
    static class LoadedAnimations
    {
        public static SortedDictionary<string, Animations.BitmapFrames> Animations { get; } = new();
        public static int Count => Animations.Count;

        public static void Load()
        {
            Regex frameRE = new("f([0-9]+)x([0-9]+)");
            List<string> files = Directory.GetFiles("Planets").ToList();

            for (int i = 0; i < files.Count; i++)
            {
                if (!files[i].EndsWith(".png"))
                {
                    files.RemoveAt(i);
                    i--;
                }
            }

            Task[] tasks = new Task[files.Count];

            for (int i = 0; i < files.Count; i++)
            {
                string file = files[i];
                tasks[i] = Task.Run(() =>
                {
                    string name = Path.GetFileNameWithoutExtension(file);
                    Match frameMatch = frameRE.Match(name);
                    if (!frameMatch.Success || frameMatch.Groups.Count < 3)
                    {
                        return;
                    }
                    bool isMatchX = int.TryParse(frameMatch.Groups[1].Value, out int frameCountX);
                    bool isMatchY = int.TryParse(frameMatch.Groups[2].Value, out int frameCountY);
                    if (!isMatchX || !isMatchY)
                    {
                        return;
                    }
                    Image image = Image.FromFile(file);
                    Animations.Add(name[..name.IndexOf('.')], new(image, frameCountX, frameCountY));
                    image.Dispose();
                });
            }

            Task.WaitAll(tasks);
        }
    }
}
