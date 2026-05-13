using System;
using Figgle;

namespace CybersecurityAwarenessBotGUI
{
    public class AsciiArt
    {
        public static void Show()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Cybersecurity Bot"));
        }
    }
}