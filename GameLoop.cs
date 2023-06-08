
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

        //Make instances of other classes here
        Mouse mouseController = new Mouse();
        GameBoard gameBoard = new GameBoard();
        MakeSquares MS = new MakeSquares();
        SideBar SB = new SideBar();
        TrailFollow TF = new TrailFollow();
        Collision collisionChecker = new Collision();


        while (!Raylib.WindowShouldClose())
        {
            mouseController.Update();
            TF.Move();
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            //Add functions from other classes here.
            gameBoard.Draw();

            SB.DrawToweroptions();
            mouseController.DrawCursor();
            TF.Draw();

            Raylib.DrawText($"{health}", 990, 50, 30, Color.BLUE);
            Raylib.DrawText($"{money}", 990, 100, 30, Color.BLUE);
            Raylib.DrawText("Play", 990, 840, 30, Color.BLUE);

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}



