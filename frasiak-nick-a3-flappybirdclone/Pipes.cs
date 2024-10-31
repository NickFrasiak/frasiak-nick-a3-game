using System;
using System.Numerics;

namespace Game10003;

public class Pipes
{
    Color pipeColor = new Color(0xf7, 0x76, 0x22);
    public void Render()
	{
        
        
        //Draw pipes
        Draw.FillColor = pipeColor;
        //bottom pipe

        Draw.Rectangle(300, 350, 50, 350);
        //top pipe
        Draw.Rectangle(300, 0, 50, 250);
	}
}



	

