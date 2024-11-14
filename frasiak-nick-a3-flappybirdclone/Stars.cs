using System;
using System.Numerics;

namespace Game10003;

public class Stars
{
    public void DrawStars()
    {

        float[] xstarCoords = [5,10,30,50];
        float[] ystarCoords = [];
        float starRadius = 2;



        Draw.FillColor = Color.White;
        for (int i = 0; i < xstarCoords.Length; i++)
        {
            Draw.Circle(xstarCoords[i], ystarCoords[i], starRadius);
        }

        int count = 55;
        xstarCoords = new float[count];
        ystarCoords = new float[count];
        for (int i = 0; i < count; i++)
        {
            xstarCoords[i] = Random.Integer(10, 390);
            ystarCoords[i] = Random.Integer(10, 250);
        }
    }
}