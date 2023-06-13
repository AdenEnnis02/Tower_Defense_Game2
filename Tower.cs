using Raylib_cs;
using System.Numerics;

    public static class AllTowers
{
    public static List<Tower> Towers = new List<Tower>();
    public static List<Projectile> Projectiles = new List<Projectile>();
}
public class Tower 
{
    public int damage;
    private double fireSpeed;
    private int range;
    public Vector2 tposition;
    

    //WIP: Default constructor for creating a tower
    public Tower(Vector2 tposition) 
    {
        this.damage = 10;
        this.fireSpeed = 1.0;
        this.range = 100;
        this.tposition = tposition;
    }

   public void Draw()
{
    Raylib.DrawRectangle((int)tposition.X, (int)tposition.Y, 50, 50, Color.BLUE);
}

   public void FireProjectile(Vector2 targetPosition)
    {
        Projectile projectile = new Projectile(tposition, targetPosition);
        AllTowers.Projectiles.Add(projectile);
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
