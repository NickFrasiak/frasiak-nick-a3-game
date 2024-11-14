using System;
using System.Numerics;

namespace Game10003;

public class Player
{
    public Vector2 position;
    Vector2 velocity;
    public float size;
    Color color;
    Vector2 forceOfGravity = new Vector2(0, 10);
    int terminalVelocity = 250;
    int jumpHeight = 200;

    //draw player
    public Player()
    {
        position = new Vector2(100, 300);
        size = 35;
        velocity = new Vector2();
        color = Color.Yellow;
    }

    
    public void UpdatePosition()
    {
        //update velocity by gravity
        if (velocity.Y <= terminalVelocity)
        {
            velocity += forceOfGravity;
        }
        else
        {
            velocity.Y = terminalVelocity;
        }
        //apply gravity
        position += velocity * Time.DeltaTime;

        // If spacebar is pressed, set vel y to 0 then add jump height
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
        {
            velocity.Y -= velocity.Y + jumpHeight;
        }
    }

    //render player
        public void Render()
    {
        Draw.FillColor = color;
        Draw.Square(position, size);
    }

    
}
