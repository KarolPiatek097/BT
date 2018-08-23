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
    public class Box
    {
        public RectangleShape box = new RectangleShape();
        public RectangleShape upperPanel = new RectangleShape();

        public Box()
        {
            box.Size = new Vector2f(MyGlobals.width - 200, MyGlobals.height - 200);
            box.Position = new Vector2f(100, 100);
            box.OutlineThickness = 2f;
            box.FillColor = new Color(Color.Transparent);

            upperPanel.Size = new Vector2f(MyGlobals.width-196, 98);
            upperPanel.Position = new Vector2f(98, 0);
            upperPanel.FillColor = new Color(Color.Black);
        }
    }
}
