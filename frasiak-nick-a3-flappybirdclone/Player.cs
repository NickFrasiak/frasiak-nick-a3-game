using System;
using System.Numerics;

namespace Game10003;

public class Player
{
    Vector2 position;
    Vector2 velocity;
    float radius;
    Color color;
    Vector2 forceOfGravity = new Vector2(0, 10);
    int terminalVelocity = 200;
    int jumpHeight = 150;

    public Player()
    {
        position = new Vector2(100, 300);
        radius = 25;
        velocity = new Vector2();
        color = Color.Green;
    }

    public void UpdatePosition()
    {
        if (velocity.Y <= terminalVelocity)
        {
            velocity += forceOfGravity;
        }
        else
        {
            velocity.Y = terminalVelocity;
        }
        Console.WriteLine(velocity.Y);
        position += velocity * Time.DeltaTime;

        // If spacebar is pressed, set vel y to 0 then add jump height
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
        {
            velocity.Y -= velocity.Y + jumpHeight;
        }
    }

    public void Render()
    {
        Draw.FillColor = color;
        Draw.Circle(position, radius);
    }
}
