using Raylib_cs;
using System.Threading;
using System.Numerics;
class Monster
{
    int hp;
    float speed;
    bool hit = false;
    int value;
    Color color;
    public Rectangle box;
    private Vector2[] path;
    private int currentPathIndex;
    private Vector2 position;

    public Monster(Vector2[] path, Color color, int hp, int value, float speed)
    {
        this.path = path;
        currentPathIndex = 0;
        position = path[currentPathIndex];
        this.hp = hp;
        this.value = value;
        this.color = color;
        this.speed = speed;
    }

    public void Draw()
    {
        Raylib.DrawRectangle((int)position.X, (int)position.Y, 50, 50, color);
    }
    public void Move()
    {
        if (Vector2.Distance(position, path[currentPathIndex]) < speed)
        {
            currentPathIndex = (currentPathIndex + 1) % path.Length;
        }

        Vector2 direction = Vector2.Normalize(path[currentPathIndex] - position);
        position += direction * speed;
    }


    // public int damageMonster()
    // {
    //     if (Monster.hit == true)

    //         Monster.hp -= Tower.damage;
    //         /* 
    //         come back and change this later when the tower damage
    //         variable is created.
    //         */
    //         Monster.hit == false;
    //         return Monster.hp;
    // }
}
