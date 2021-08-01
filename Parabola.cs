﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlayDrawing
{
    class Parabola : Polynomial
    {
        public Parabola(Point p1, Point p2, Point p3, Size overlaySize) : base(new Point[] { p1, p2, p3 }, overlaySize) {}
    }
}
