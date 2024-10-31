// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Color skyColor = new Color(0x42, 0xbf, 0xe8);
        Color pipeColor = new Color(0xf7, 0x76, 0x22);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Flappy ");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(skyColor);

            //Draw pipes
            Draw.FillColor = pipeColor;
            //bottom pipe
            Draw.Rectangle(300, 350, 50, 350);
            //top pipe
            Draw.Rectangle(300, 0, 50, 250);
        }
    }
}
