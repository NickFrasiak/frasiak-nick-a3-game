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
    Pipes pipeTwo;
    Pipes pipeThree;

    Color skyColor = new Color(0x42, 0xbf, 0xe8);
    Color playerColor = new Color(0x68, 0x4d, 0x7f);


    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Flappy ");
        Window.SetSize(800, 600);
        player = new Player();
        pipeOne = new Pipes(300, 0);
        pipeTwo = new Pipes(450, 1);
        pipeThree = new Pipes(600, 2);
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
        pipeTwo.Render();
        pipeThree.Render();


        //collision
        Vector2 playerPosition1;
        Vector2 pipePosition2;
        Vector2 playerSize1;
        Vector2 pipeSize2;

        pipeOne.UpdatePosition();
        pipeTwo.UpdatePosition();
        pipeThree.UpdatePosition();




    }
}
