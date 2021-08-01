using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlayDrawing
{
    class PointMarker : Square
    {
        public PointMarker(Point location) : base(location, new Size(10, 10)) { }
    }
}
