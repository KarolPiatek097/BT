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
    class Program
    {


        static void Main(string[] args)
        {
            

            var window = new RenderWindow(new VideoMode(MyGlobals.width, MyGlobals.height), "Bubble Trouble", Styles.Default);
            window.SetFramerateLimit(60);
            Player player = new Player(100, MyGlobals.size);
            Box box = new Box();

            window.Closed += (s, a) => window.Close();
            window.MouseMoved += (s, a) => player.setPosition(a.X);



            while(window.IsOpen)
            {
                window.DispatchEvents();

                player.fire();
                player.updatePosition();
                
                window.Clear();
                player.projectileColision();
                draw();
                window.Display();
            }


            void draw()
            {

                foreach (var element in player.projectile_list)
                {
                    window.Draw(element.projectile);
                    element.move();
                }
                window.Draw(box.box);
                window.Draw(box.upperPanel);
                window.Draw(player.player);
            }

        }
    }
}
