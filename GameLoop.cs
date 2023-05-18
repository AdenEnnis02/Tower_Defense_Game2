
using Raylib_cs;
using System.Numerics;

namespace TowerDefense
{
    public class GameLoop
    {
        private static Color _cursorColor = Color.BLUE;

        public static void Main()
        {
            const int screenWidth = 800;
            const int screenHeight = 450;

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

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}