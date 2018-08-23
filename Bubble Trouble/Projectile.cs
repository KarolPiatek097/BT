using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Bubble_Trouble
{
    public class Projectile
    {
        public static int quantity = 0;
        public Vector2f speed = new Vector2f(0,-20);
        public RectangleShape projectile = new RectangleShape();
        public int angle;


        public Projectile(int _x,int _y)
        {
            projectile.Size = new Vector2f(3, 15);
            projectile.FillColor = new Color(Color.White);
            projectile.Position = new Vector2f(_x+MyGlobals.size, MyGlobals.height - 100 - MyGlobals.size*2);
            speed += new Vector2f(0, _y);

            Random r = new Random(DateTime.Now.Millisecond);
            angle = r.Next(-2,  2);
        }

        public void move()
        {
            projectile.Position += new Vector2f(angle,0);
            projectile.Position += speed;
        }


    }
}
