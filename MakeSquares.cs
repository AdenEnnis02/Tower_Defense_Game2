using Raylib_cs;
using System.Numerics;

public class MakeSquares
{
    public Rectangle Bounds { get; set; }
    public Color Color { get; set; }

     public void makeSquare(float x, float y, float size, Color color)
    {
        Bounds = new Rectangle(x, y, size, size);
        Color = color;
    }
}


// The first parameter 100 represents the X-coordinate of the top-left corner of the rectangle.
// The second parameter 100 represents the Y-coordinate of the top-left corner of the rectangle.
// The third parameter 200 represents the width of the rectangle.
// The fourth parameter 150 represents the height of the rectangle.
//Then to actually draw it add this in the game loop... Raylib.DrawRectangleRec(square1, Color.RED); or Raylib.DrawRectangleRec(square2, Color.BLUE);