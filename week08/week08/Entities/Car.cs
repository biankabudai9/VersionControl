using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08.Abstractions;

namespace week08.Entities
{
    public class Car : Toy
    {
        protected override void DrawImage(Graphics graphics)
        {
            Image imageFile = Image.FromFile("irf/car.png");
            graphics.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));

        }
    }
}
