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
    Pipe pipeOne;
    Pipe pipeTwo;
    Pipe pipeThree;

    Pipe[] pipes;

    int amountOfPipes = 6;
    int pipeSpacing = 150;

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


        pipes = new Pipe[amountOfPipes];

        // i starts at 0, loop thru until i 
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i] = new Pipe(300 + ( pipeSpacing * i));
        }
    }



    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(skyColor);

        player.UpdatePosition();
        player.Render();
        //pipeOne.Render();
        //pipeTwo.Render();
        //pipeThree.Render();

        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].UpdatePosition();
            pipes[i].Render();

        }

        //collision
        Vector2 playerPosition1;
        Vector2 pipePosition2;
        Vector2 playerSize1;
        Vector2 pipeSize2;

       // if (playerPosition < pipePosition + pipeSize2 && playerPosition > pipePosition) 

        //pipeOne.UpdatePosition();
        
        
        //pipeTwo.UpdatePosition();
        //pipeThree.UpdatePosition();




    }
}
