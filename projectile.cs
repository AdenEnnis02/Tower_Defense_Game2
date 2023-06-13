using Raylib_cs;
using System.Numerics;

public class Projectile
{
    public float speed = 100f; // Speed of projectile.
    public float radius = 5f; // Collision radius.
    float radiusSq; // Radius squared; optimization.
    Vector2 position; // Projectile position.
    Vector2 direction; // Direction to the target.

       public Projectile(Vector2 startPosition, Vector2 targetPosition)
    {
        position = startPosition;
        direction = Vector2.Normalize(targetPosition - startPosition);
        radiusSq = radius * radius;
    }

    public void Update()
    {
        // Move the projectile towards the target.
        position += direction * speed * Raylib.GetFrameTime();

        // Destroy the projectile if it is close to the target.
        if (Vector2.DistanceSquared(position, direction) < radiusSq)
        {
            // Write your own code to spawn an explosion / splat effect.
            // Write your own code to deal damage to the target.
        }
    }

    public void Draw()
    {
        Raylib.DrawCircleV(position, radius, Color.PINK);
    }
}

// class Program
// {
//     static void Main()
//     {
//         const int screenWidth = 800;
//         const int screenHeight = 450;

//         Raylib.InitWindow(screenWidth, screenHeight, "Projectile Example");

//         // Create a projectile
//         Projectile projectile = new Projectile(new Vector2(100, 100), new Vector2(500, 300));

//         Raylib.SetTargetFPS(60);

//         while (!Raylib.WindowShouldClose())
//         {
//             // Update
//             projectile.Update();

//             // Draw
//             Raylib.BeginDrawing();
//             Raylib.ClearBackground(Color.WHITE);
//             projectile.Draw();
//             Raylib.EndDrawing();
//         }

//         Raylib.CloseWindow();
//     }
// }


