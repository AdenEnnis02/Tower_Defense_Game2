using Raylib_cs;
using System.Threading;
    public class Monster
    {
        int hp;
        int movementSpeed;
        bool hit = false;
        int value;
        Color color;

        public Monster (Color color, int hp, int value)
        {
            this.hp = hp;
            this.value = value;
            this.color = color;
    
        }

        public void draw()
        {
            Rectangle box = new Rectangle(0, 150, 50, 50);
            Raylib.DrawRectangleRec(box, color);
            Thread.Sleep(1000);
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
