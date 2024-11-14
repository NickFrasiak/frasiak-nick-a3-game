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
    bool isGameOver = false;

    Player player;
    Pipe[] pipes;
    Star[] stars;

    int amountOfPipes = 6;
    int pipeSpacing = 150;
    int score = 0;

    Color skyColor = new Color(0x08, 0x0D, 0x5B);
    Color playerColor = new Color(0x68, 0x4d, 0x7f);

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Flappy Square");
        Window.SetSize(800, 600);
        player = new Player();

        pipes = new Pipe[amountOfPipes];
        stars = new Star[70];

        // i starts at 0, loop thru until i 
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i] = new Pipe(300 + (pipeSpacing * i));
        }

        for (int i = 0; i < stars.Length; i++)
        {
            stars[i] = new Star();
        }
    }

    //game over screen
    void GameOver()
    {
        if (isGameOver)
        {
            Draw.FillColor = Color.Black;
            Draw.Rectangle(0, 0, 800, 600);

            Text.Color = Color.Red;
            Text.Draw("GAME OVER", 300, 300);
            Text.Draw($"SCORE: {score}", 300, 350);
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


        for (int cuurentStar = 0; cuurentStar < stars.Length; cuurentStar++)
        {
            stars[cuurentStar].Render();
        }

        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].UpdatePosition();
            pipes[i].Render();
            Vector2 pipePosition2 = new Vector2(pipes[i].Xposition, 0);

            Vector2 playerPosition1 = player.position;

            float playerSize1 = player.size;
            Vector2 pipeSize2;

            //Collision code
            float playerLeft = playerPosition1.X;
            float playerRight = playerPosition1.X + playerSize1;
            float playerTop = playerPosition1.Y;
            float playerBottom = playerPosition1.Y + playerSize1;

            float leftEdge2 = pipePosition2.X;
            float rightEdge2 = pipePosition2.X + 50;
            float topEdge2 = pipePosition2.Y;
            float bottomEdge2 = pipePosition2.Y + 600;

            float pipeGapLeft = pipes[i].pipeGap.X;
            float pipeGapRight = pipes[i].pipeGap.X + 50;
            float pipeGapTop = pipes[i].pipeGap.Y;
            float pipeGapBottom = pipes[i].pipeGap.Y + 100;

            bool doesOverlapLeft = playerLeft < rightEdge2;
            bool doesOverlapRight = playerRight > leftEdge2;
            bool doesOverlapTop = playerTop < bottomEdge2;
            bool doesOverlapBottom = playerBottom > topEdge2;

            bool doesGapLeft = playerLeft < pipeGapRight;
            bool doesGapRight = playerRight > pipeGapLeft;
            bool doesGapTop = playerTop < pipeGapBottom;
            bool doesGapBottom = playerBottom > pipeGapTop;

            bool doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;

            bool doesGapOverlap = doesGapLeft && doesGapRight && doesGapTop && doesGapBottom;

            if (doesOverlap && doesGapOverlap)
            {
                score++;
            }

            else if (doesOverlap && !doesGapOverlap)
            {
                isGameOver = true;
            }

            Text.Color = Color.White;
            Text.Draw($"Score: {score}", 25, 550);

        }
        GameOver();
    }
}
