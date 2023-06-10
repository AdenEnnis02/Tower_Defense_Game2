
using Raylib_cs;
using System.Numerics;
using System.Threading;

namespace TowerDefense
{
    public class GameLoop
    {
<<<<<<< Updated upstream
        private static Color _cursorColor = Color.BLUE;
        
        public static void Main()
=======
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

        // Monster Variables
        Monster goblin = new Monster(Color.GREEN, 200, 50);
        List<Monster> monster_list = new List<Monster>();
        for (int monsterCount = 0; monsterCount < 20; monsterCount++)
        {
            monster_list.Add(goblin);
            goblin.draw();
        }

        // Box variables
        Rectangle box = new Rectangle(0, 150, 50, 50);
        Vector2[] path = new Vector2[]
>>>>>>> Stashed changes
        {
            const int screenWidth = 800;
            const int screenHeight = 450;
            var ogre_list = new List<GameObject>();
            var position = new Vector2(50, 0);
            
            Raylib.InitWindow(screenWidth, screenHeight, "Mouse Support");

            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
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

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Move the mouse to change the cursor's position", 10, 10, 20, Color.GRAY);
                Raylib.DrawText("Click the left mouse button to change the cursor's color", 10, 40, 20, Color.GRAY);

                Raylib.DrawCircleV(Raylib.GetMousePosition(), 15, _cursorColor);

                Monster ogre  = new Monster("Ogre", 200, 50, 100, Color.GREEN);
                ogre.position = position;
                ogre.movespeed = new Vector2(10,10);
                ogre_list.Add(ogre);

                Raylib.EndDrawing();
            }

<<<<<<< Updated upstream
            Raylib.CloseWindow();
=======
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
            // Raylib.DrawRectangleRec(box, Color.GOLD);

            // Draw HUD
            Raylib.DrawText($"{health}", 990, 50, 30, Color.BLUE);
            Raylib.DrawText($"{money}", 990, 100, 30, Color.BLUE);
            Raylib.DrawRectangleRec(startButton, Color.GREEN);
            Raylib.DrawText("Start", (int)startButton.x + 20, (int)startButton.y + 10, 20, Color.BLACK);

            Raylib.EndDrawing();
>>>>>>> Stashed changes
        }
    }
}