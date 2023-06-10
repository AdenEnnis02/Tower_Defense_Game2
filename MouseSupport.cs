using System;
using Raylib_cs;
using System.Numerics;

public class Mouse
{
    private Color _cursorColor = Color.BLUE;

    public void Update()
    {
        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
        {
            // Change the cursor's color
            _cursorColor = new Color(
                Raylib.GetRandomValue(0, 255),
                Raylib.GetRandomValue(0, 255),
                Raylib.GetRandomValue(0, 255),
                255);
        }
    }

    public void DrawCursor()
    {
        Raylib.DrawCircleV(Raylib.GetMousePosition(), 10, _cursorColor);
    }
}