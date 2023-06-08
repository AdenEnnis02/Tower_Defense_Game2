using Raylib_cs;
using System;

public class TrailFollow
{
    private Rectangle box;
    private float speed;
    private bool isMoving;

    public TrailFollow()
    {
        box = new Rectangle(100, 100, 50, 50);
        speed = 5.0f;
        isMoving = false;
    }

    public void Move()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            isMoving = true;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
        {
            isMoving = false;
        }
        if (isMoving)
        {
            box.x += speed;

            // Check if the box has reached the right edge
            if (box.x + box.width > Raylib.GetScreenWidth())
            {
                // Reset the box position to the left side
                box.x = -box.width;
            }
        }
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(box, Color.RED);
    }
}
