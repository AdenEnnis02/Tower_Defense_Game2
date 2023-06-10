using Raylib_cs;
using System;
using System.Numerics;

public class TrailFollow
{
    public void Move()
    {

        // Box variables
        Rectangle box = new Rectangle(100, 100, 25, 25);
        Vector2[] path = new Vector2[]
        {
                new Vector2(100, 100),  // Starting point
                new Vector2(400, 100),
                new Vector2(400, 300),
                new Vector2(100, 300),
                new Vector2(100, 100)   // Back to the starting point
        };
        int currentPathIndex = 0;
        Vector2 target = path[currentPathIndex];
        float speed = 1.5f;

        bool startButtonClicked = false;
        Rectangle startButton = new Rectangle(900, 800, 250, 100);


        if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), startButton) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
        {
            startButtonClicked = true;
        }
        if (startButtonClicked)
        {
            if (Vector2.Distance(new Vector2(box.x, box.y), target) < 1.0f)
            {
                currentPathIndex = (currentPathIndex + 1) % path.Length;
                target = path[currentPathIndex];
            }

            // Move the box towards the target
            Vector2 direction = Vector2.Normalize(target - new Vector2(box.x, box.y));
            box.x += direction.X * speed;
            box.y += direction.Y * speed;
        }
    }
}