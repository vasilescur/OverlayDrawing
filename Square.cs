using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlayDrawing
{
    class Square : Drawing
    {
        private Point location;
        private Size size;

        public Square(Point location, Size size)
        {
            this.location = location;
            this.size = size;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            g.FillRectangle(solidBrush, new Rectangle(location, size));
            solidBrush.Dispose();
        }
    }
}
