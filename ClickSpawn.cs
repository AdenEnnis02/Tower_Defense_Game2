using Raylib_cs;
using System.Collections.Generic;
using System;
using System.Numerics;
using System.Threading;
using Raylib_cs;
using System.Collections.Generic;
using System;

class Square
{
    public Rectangle Rectangle { get; set; }
    public Color Color { get; set; }
}

class ClickSpawn
{
    private List<Square> squares;
    private Color[] colors;
    private int colorIndex;

    private Rectangle border;

    public ClickSpawn()
    {
        squares = new List<Square>();
        colors = new Color[] { Color.BLUE, Color.RED, Color.GREEN };
        colorIndex = 0;

        // Set the border dimensions
        int borderThickness = 0; // Adjust as needed

        int leftBorderWidth = 0; // Adjust the left border width
        int rightBorderWidth = 250; // Adjust the right border width
        int topBorderHeight = 0; // Adjust the top border height
        int bottomBorderHeight = 0; // Adjust the bottom border height

        int innerWidth = Raylib.GetScreenWidth() - leftBorderWidth - rightBorderWidth;
        int innerHeight = Raylib.GetScreenHeight() - topBorderHeight - bottomBorderHeight;

        border = new Rectangle(leftBorderWidth, topBorderHeight, innerWidth, innerHeight);
    }

    public void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
            colorIndex = 0;
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
            colorIndex = 1;
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
            colorIndex = 2;

        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
        {
            Vector2 mousePos = Raylib.GetMousePosition();

            // Check if the mouse position is within the border
            if (Raylib.CheckCollisionPointRec(mousePos, border))
            {
                Square square = new Square
                {
                    Rectangle = new Rectangle(mousePos.X - 25, mousePos.Y - 25, 50, 50),
                    Color = colors[colorIndex]
                };
                squares.Add(square);
            }
        }
    }

    public void Draw()
    {
        // Draw the border
        //Raylib.DrawRectangleLinesEx(border, 5, Color.BLACK); Uncomment to see border

        foreach (Square square in squares)
        {
            Raylib.DrawRectangleRec(square.Rectangle, square.Color);
        }
    }
}
