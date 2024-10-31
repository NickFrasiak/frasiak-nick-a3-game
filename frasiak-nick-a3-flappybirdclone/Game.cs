// Include code libraries you need below (use the namespace).
using System;
using System.Data;
using System.Numerics;

// The namespace your code is in.
namespace Game10003;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{

    Player player;

    Pipes pipeOne;

    Color skyColor = new Color(0x42, 0xbf, 0xe8);
    

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Flappy ");
        Window.SetSize(800, 600);
        player = new Player();
        pipeOne = new Pipes();
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(skyColor); 

        player.UpdatePosition();
        player.Render();
        pipeOne.Render();

    }
}
