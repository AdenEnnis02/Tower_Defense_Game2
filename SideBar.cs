using Raylib_cs;
using System.Numerics;

public class SideBar //This is the bar on the side of the screen where the user buy towers
{
    private Tower draggedTower;
    private bool isDragging;
    bool buyBlue = false;

    List<Tower> towers = new List<Tower>();

    public void DrawTowerOptions()
    {

        Vector2 mousePosition = Raylib.GetMousePosition();
        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
        {
            // Check if the mouse is inside the blue square
            if (Raylib.CheckCollisionPointRec(mousePosition, new Rectangle(950, 200, 50, 50)))
            {
                // Create a new tower at the mouse position
                draggedTower = new Tower(mousePosition);
                isDragging = true;
            }
        }
            if (isDragging)
        {
            draggedTower.tposition = mousePosition;

            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
            {
                // Place the tower on the game board
                PlaceTower();
            }
        }
    
    
        Rectangle blueSquare = new Rectangle(950, 200, 50, 50);   // horizontal position, vertical , width, length
        Rectangle yellowSquare = new Rectangle(1050, 200, 50, 50);
        Rectangle orangeSquare = new Rectangle(950, 300, 50, 50);
        Rectangle purpleSquare = new Rectangle(1050, 300, 50, 50);
        Rectangle greenSquare = new Rectangle(900, 800, 250, 100);
        Rectangle healthSquare = new Rectangle(950, 50, 25, 25);
        Rectangle moneySquare = new Rectangle(950, 100, 25, 25);

        //
        Raylib.DrawRectangleRec(blueSquare, Color.BLUE);
        Raylib.DrawRectangleRec(yellowSquare, Color.YELLOW);
        Raylib.DrawRectangleRec(orangeSquare, Color.ORANGE);
        Raylib.DrawRectangleRec(purpleSquare, Color.PURPLE);
        Raylib.DrawRectangleRec(greenSquare, Color.GREEN);  //Play
        Raylib.DrawRectangleRec(healthSquare, Color.RED);  //Health
        Raylib.DrawRectangleRec(moneySquare, Color.GOLD);  //Money



        // Check for collision between the mouse cursor and the other object
        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
        {
            if (buyBlue == false)
            {
                if (Raylib.CheckCollisionPointRec(mousePosition, blueSquare))
                {
                    buyBlue = true;
                }
            }
        }
        //If you have bought the blue square then it attaches to your mouse
        // if (buyBlue == true)
        // {
        //     Rectangle oneBlueSquare = new Rectangle(Raylib.GetMouseX(), Raylib.GetMouseY(), 50, 50);
        //     Raylib.DrawRectangleRec(oneBlueSquare, Color.GOLD);
        //     if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
        //     {
        //         buyBlue = false;
        //         Tower tower = new Tower(Raylib.GetMouseX(), Raylib.GetMouseY());
        //     }
        // }


        //hover over tower options
        if (Raylib.CheckCollisionPointRec(mousePosition, blueSquare))
        {
            Raylib.DrawText("Price: 100", 950, 750, 20, Color.GREEN);
        }
        if (Raylib.CheckCollisionPointRec(mousePosition, yellowSquare))
        {
            Raylib.DrawText("Price: 200", 950, 750, 20, Color.GREEN);
        }
        if (Raylib.CheckCollisionPointRec(mousePosition, orangeSquare))
        {
            Raylib.DrawText("Price: 300", 950, 750, 20, Color.GREEN);
        }
        if (Raylib.CheckCollisionPointRec(mousePosition, purpleSquare))
        {
            Raylib.DrawText("Price: 400", 950, 750, 20, Color.GREEN);
        }
    }
       public void DrawTowers()
    {
        if (isDragging)
        {
            draggedTower.Draw();
        }
    }

    private void PlaceTower()
    {
        // Check if the tower can be placed at the current position (e.g., no collision with other objects)
        bool canPlaceTower = true; // Add your own logic to check for placement conditions

        if (canPlaceTower)
        {
            // Add the tower to the game board
            // For now, we simply add it to a list of towers
            // You can modify this to fit your game logic
            // For example, you might have a dedicated game board class
            // where you store towers and handle collisions.
            AllTowers.Towers.Add(draggedTower);
        }

        // Reset dragging state
        draggedTower = null;
        isDragging = false;
    }
}


