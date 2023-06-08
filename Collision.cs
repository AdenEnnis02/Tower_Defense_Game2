
using Raylib_cs;
using System.Numerics;

public class Collision
{

bool CheckCollision(int x1, int y1, int width1, int height1, int x2, int y2, int width2, int height2)
{
    bool isCollision =
        x1 < x2 + width2 &&
        x1 + width1 > x2 &&
        y1 < y2 + height2 &&
        y1 + height1 > y2;

    return isCollision;
}


}

