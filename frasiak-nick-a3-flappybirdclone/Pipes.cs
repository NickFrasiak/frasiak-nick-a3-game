using System;
using System.Numerics;

namespace Game10003;

public class Pipe
{
    Color pipeColor = new Color(0x91, 0x86, 0xc2);

    //collision arrays
    public float Xposition;

    public Vector2 pipeGap = new Vector2(0,0);

    //                 top: x, y, bottom: x, y
    float[] typ1position = { 0, 50, 350, 50 };
    float[] typ2position = { 0, 50, 300, 50 };
    float[] typ3position = { 0, 50, 400, 50 };
    float[] typ1size = { 250, 350 };
    float[] typ2size = { 200, 300 };
    float[] typ3size = { 300, 400 };

    int pipeType = 0;

    public Pipe(float pipePosition)
    {
        //randomly place pipes
        Xposition = pipePosition;
        pipeGap.X = pipePosition;
        pipeType = Random.Integer(0, 3);
    }

    public void Render()
    {
        //Draw pipes
        Draw.FillColor = pipeColor;
        if (pipeType == 0)
        {
            //top pipe
            Draw.Rectangle(Xposition, 0, 50, 250);
            pipeGap.Y = 250;

            //bottom pipe
            Draw.Rectangle(Xposition, 350, 50, 350);
        }

        else if (pipeType == 1)
        {
            //top pipe
            Draw.Rectangle(Xposition, 0, 50, 200);
            pipeGap.Y = 200;

            //bottom pipe
            Draw.Rectangle(Xposition, 300, 50, 300);
        }

        else if (pipeType == 2)
        {
            //top pipe
            Draw.Rectangle(Xposition, 0, 50, 300);
            pipeGap.Y = 300;

            //bottom pipe
            Draw.Rectangle(Xposition, 400, 50, 400);
        }
    }

    public void UpdatePosition()
    {
        //move pipes / move speed of pipes
        float moveSpeed = 3f;

        Xposition -= moveSpeed;

        pipeGap.X = Xposition;

        if (Xposition <= -50)
        {
            Xposition = 850;
            pipeType = Random.Integer(0, 3);
        }
    }
}





