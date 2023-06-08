using System;
using Raylib_cs;
using System.Numerics;

public class GameLoop
{
    public static void Main()
    {
        const int screenWidth = 1150;
        const int screenHeight = 900;
        const int health = 100;
        const int money = 100;

        int mouseX = Raylib.GetMouseX();
        int mouseY = Raylib.GetMouseY();
        Vector2 mousePosition = Raylib.GetMousePosition();

        Raylib.InitWindow(screenWidth, screenHeight, "Tower Defense");
        Raylib.SetTargetFPS(60);

        // Make instances of other classes here
        Mouse mouseController = new Mouse();
        GameBoard gameBoard = new GameBoard();
        MakeSquares MS = new MakeSquares();
        SideBar SB = new SideBar();
        TrailFollow TF = new TrailFollow();
        Collision collisionChecker = new Collision();

        // Box variables
        Rectangle box = new Rectangle(0, 150, 50, 50);
        Vector2[] path = new Vector2[]
        {
            new Vector2(0, 150),  // Starting point
            new Vector2(200, 150),
            new Vector2(200, 350),
            new Vector2(450, 350),
            new Vector2(450, 150),
            new Vector2(700, 150),
            new Vector2(700, 600),
            new Vector2(150, 600),
            new Vector2(150, 750),
            new Vector2(900, 750),
        };
        int currentPathIndex = 0;
        Vector2 target = path[currentPathIndex];
        float speed = 2.5f;

        bool startButtonClicked = false;
        Rectangle startButton = new Rectangle(990, 840, 100, 50);

        while (!Raylib.WindowShouldClose())
        {
            // Update
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

            // Add functions from other classes here
            mouseController.Update();
            TF.Move();

            // Draw
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            gameBoard.Draw();
            SB.DrawTowerOptions();
            mouseController.DrawCursor();

            // Draw box
            Raylib.DrawRectangleRec(box, Color.GOLD);

            // Draw HUD
            Raylib.DrawText($"{health}", 990, 50, 30, Color.BLUE);
            Raylib.DrawText($"{money}", 990, 100, 30, Color.BLUE);
            Raylib.DrawRectangleRec(startButton, Color.GREEN);
            Raylib.DrawText("Start", (int)startButton.x + 20, (int)startButton.y + 10, 20, Color.BLACK);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
