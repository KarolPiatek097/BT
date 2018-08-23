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


    class Player
    {
        const int width = 1920;
        const int height = 1080;
        public CircleShape player = new CircleShape();
        public List<Projectile> projectile_list = new List<Projectile>();
        public int x;
        public int y;
        public int size;

        public Player(int _x, int _size)
        {
            
            size = _size;
            x = _x;
            y = height - 100 - size*2;

            player.Position = new Vector2f(x, y);
            player.FillColor = new Color(255, 0, 0);
            player.Radius = _size;
        }

        public void setPosition(int _x)
        {

            if (_x>100 && _x<MyGlobals.width-100-MyGlobals.size*2)
            x = _x;

        }

        public void updatePosition()
        {
            player.Position = new Vector2f(x, y);
        }

        public void fire()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int ticks = r.Next(-15, 15);
            Random r2 = new Random(DateTime.Now.Millisecond);
            int ticks2 = r.Next(-3, 3);


            Projectile.quantity += 1;
            projectile_list.Add(new Projectile(x+ticks,ticks2));
        }



        public void projectileColision()
        {
            for (int i=0;i<Projectile.quantity;i++)
            {
                if (projectile_list[i].projectile.Position.Y <= 100 || projectile_list[i].projectile.Position.X <= 100 || projectile_list[i].projectile.Position.X >= MyGlobals.width-100)
                {
                    Projectile.quantity -= 1;
                    projectile_list.Remove(projectile_list[i]);
                }
            }
        }




    }
}
