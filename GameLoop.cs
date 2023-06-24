using System;
using Raylib_cs;
using System.Numerics;
using System.Threading;
public class GameLoop
{
    public static void Main()
    {
        const int screenWidth = 1150;
        const int screenHeight = 900;
        float health = 100;
        float money = 100;

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
        Tower tower = new Tower(100, 100);


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
        //Lists for monsters & variables
        List<Monster> monsters = new List<Monster>();
        List<Monster> monstersToRemove = new List<Monster>();

        bool startButtonClicked = false;
        Rectangle startButton = new Rectangle(990, 840, 100, 50);

        while (!Raylib.WindowShouldClose())
        {
            // Update
            if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), startButton) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {
                startButtonClicked = true;
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

            // Draw HUD
            Raylib.DrawText($"{health}", 990, 50, 30, Color.BLUE);
            Raylib.DrawText($"{money}", 990, 100, 30, Color.BLUE);
            Raylib.DrawRectangleRec(startButton, Color.GREEN);
            Raylib.DrawText("Start", (int)startButton.x + 20, (int)startButton.y + 10, 20, Color.BLACK);

            if (startButtonClicked)
            {
                // creates 20 monsters with a 1 second interval inbetween creation
                if (monsters.Count < 20 && Raylib.GetTime() % 1.0f < Raylib.GetFrameTime())
                {
                    monsters.Add(new Monster(path, Color.GREEN, 100, 50, 2.5f, 10));
                }
            }

            if (monsters.Count >= 20)
            {
            // Stop creating monsters
            startButtonClicked = false;
            }
        
            foreach (Monster monster in monsters)
            {
                monster.Draw();
                monster.Move();

                if (monster.CheckEnd(monsters))
                {
                    monstersToRemove.Add(monster);
                    health -= monster.dmg;
                    Console.WriteLine(health);
                }
            }
            foreach (Monster monsterToRemove in monstersToRemove)
            {
                monsters.Remove(monsterToRemove);
            }

            monstersToRemove.Clear();
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
