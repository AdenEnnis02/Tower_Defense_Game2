using Raylib_cs;
class Tower 
{
    public int damage;
    private double fireSpeed;
    private int range;
    
    private Position location;

    //WIP: Default constructor for creating a tower
    public Tower() 
    {
        this.damage = 10;
        this.fireSpeed = 1.0;
        this.range = 10;
        this.location = new Position(10.0,10.0);
    }

    public Tower(int x, int y)
    {
        this.damage = 10;
        this.fireSpeed = 1.0;
        this.range = 10;
        this.location = new Position((double)x,(double)y);
        Console.WriteLine("tower made.");
        draw();      
    }

    public Tower(int damage, double firespeed, int range, Position location) 
    {
      this.damage = damage;
      this.fireSpeed = fireSpeed;
      this.range = range;
      draw();
    }

    public void draw()
    {
        Rectangle oneBlueSquare1 = new Rectangle((int)location.getX(), (int)location.getY(), 50, 50);
        Raylib.DrawRectangleRec(oneBlueSquare1, Color.BLUE); 
    }
    /*
     * Needed Functionality: Fire, Detect, Draw(?)
     */

    //Fires a projectile at a monster. If that attack hits, return true. If not (monster dead), return false.
     public bool fire() 
     {
        return true;
     }

    //Checks the area up to the range of the tower. Finds the closest monster, returns true if found, false if no monsters.
     public bool detect() 
     {
        return true;
     }

     public int getDamage()
     {
        return this.damage;
     }

     public void setDamage(int damage) 
     {
        this.damage = damage;
     }

     public double getSpeed()
     {
        return this.fireSpeed;
     }

     public void setSpeed(double fireSpeed) 
     {
        this.fireSpeed = fireSpeed;
     }

     public int getRange() 
     {
        return this.range;
     }

     public void setRange(int range)
     {
        this.range = range;
     }

}
