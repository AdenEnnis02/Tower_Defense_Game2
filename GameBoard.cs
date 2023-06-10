using Raylib_cs;
using System;

public class GameBoard
{
    private const int CellSize = 50;
    private const int BoardSize = 18;
    private Color[,] boardColors = new Color[BoardSize, BoardSize];
    private bool[,] redSquares = new bool[BoardSize, BoardSize];

    public GameBoard()
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

                redSquares[row, col] = false;
            }
        }

        // Mark specific squares as red
        redSquares[3, 0] = true;
        redSquares[3, 1] = true;
        redSquares[3, 2] = true;
        redSquares[3, 3] = true;
        redSquares[3, 4] = true;
        redSquares[4, 4] = true;
        redSquares[5, 4] = true;
        redSquares[6, 4] = true;
        redSquares[7, 4] = true;
        redSquares[7, 5] = true;
        redSquares[7, 6] = true;
        redSquares[7, 7] = true;
        redSquares[7, 8] = true;
        redSquares[7, 9] = true;
        redSquares[6, 9] = true;
        redSquares[5, 9] = true;
        redSquares[4, 9] = true;
        redSquares[3, 9] = true;
        redSquares[3, 9] = true;
        redSquares[3, 10] = true;
        redSquares[3, 11] = true;
        redSquares[3, 12] = true;
        redSquares[3, 13] = true;
        redSquares[3, 14] = true;
        redSquares[4, 14] = true;
        redSquares[5, 14] = true;
        redSquares[6, 14] = true;
        redSquares[7, 14] = true;
        redSquares[8, 14] = true;
        redSquares[9, 14] = true;
        redSquares[10, 14] = true;
        redSquares[11, 14] = true;
        redSquares[12, 14] = true;
        redSquares[12, 13] = true;
        redSquares[12, 12] = true;
        redSquares[12, 11] = true;
        redSquares[12, 10] = true;
        redSquares[12, 9] = true;
        redSquares[12, 8] = true;
        redSquares[12, 7] = true;
        redSquares[12, 6] = true;
        redSquares[12, 5] = true;
        redSquares[12, 4] = true;
        redSquares[12, 3] = true;
        redSquares[13, 3] = true;
        redSquares[14, 3] = true;
        redSquares[15, 3] = true;
        redSquares[15, 4] = true;
        redSquares[15, 5] = true;
        redSquares[15, 6] = true;
        redSquares[15, 7] = true;
        redSquares[15, 8] = true;
        redSquares[15, 9] = true;
        redSquares[15, 10] = true;
        redSquares[15, 11] = true;
        redSquares[15, 12] = true;
        redSquares[15, 13] = true;
        redSquares[15, 14] = true;
        redSquares[15, 15] = true;
        redSquares[15, 16] = true;
        redSquares[15, 17] = true;
 
    }

    
    public void Draw()
    {
        for (int row = 0; row < BoardSize; row++)
        {
            for (int col = 0; col < BoardSize; col++)
            {
                Rectangle rect = new Rectangle(col * CellSize, row * CellSize, CellSize, CellSize);

                if (redSquares[row, col])
                {
                    Raylib.DrawRectangleRec(rect, Color.RED);
                }
                else
                {
                    Raylib.DrawRectangleRec(rect, boardColors[row, col]);
                }
            }
        }
    }
}