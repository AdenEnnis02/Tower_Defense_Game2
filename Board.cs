using Raylib_cs;
using System;

public class Board
{
    private const int CellSize = 50;
    private const int BoardSize = 8;
    private Color[,] boardColors = new Color[BoardSize, BoardSize];

    public Board()
    {
        // Initialize the board colors
        for (int row = 0; row < BoardSize; row++)
        {
            for (int col = 0; col < BoardSize; col++)
            {
                if ((row + col) % 2 == 0)
                {
                    boardColors[row, col] = Color.WHITE;
                }
                else
                {
                    boardColors[row, col] = Color.BLACK;
                }
            }
        }
    }

    public void Draw()
    {
        for (int row = 0; row < BoardSize; row++)
        {
            for (int col = 0; col < BoardSize; col++)
            {
                Rectangle rect = new Rectangle(col * CellSize, row * CellSize, CellSize, CellSize);
                Raylib.DrawRectangleRec(rect, boardColors[row, col]);
            }
        }
    }
}

public class Program
{
    static void Main()
    {
        const int screenWidth = 400;
        const int screenHeight = 400;

        Raylib.InitWindow(screenWidth, screenHeight, "Game Board");

        Board gameBoard = new Board();

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            gameBoard.Draw();

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
