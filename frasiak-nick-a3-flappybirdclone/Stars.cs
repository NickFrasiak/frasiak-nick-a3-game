using System;
using System.Numerics;

namespace Game10003;

public class Star
{
    float starRadius = 2;
    Vector2 position;
    Color color = Color.White; 

    public Star()
    {
        position = new Vector2(Random.Integer(0,800), Random.Integer(0, 600));
    }

    public void Render()
    {
        Draw.FillColor = color;
        Draw.Circle(position, starRadius);
    }
}

