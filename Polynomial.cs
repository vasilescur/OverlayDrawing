using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlayDrawing
{
    abstract class Polynomial : Drawing
    {
        protected Point[] points;
        protected Size overlaySize;

        public Polynomial(Point[] points, Size overlaySize)
        {
            this.points = points;
            this.overlaySize = overlaySize;
        }

        protected double LagrangeInterpolation(double x)
        {
            double result = 0;
            for (int i = 0; i < points.Length; i++)
            {
                double term = points[i].Y;
                for (int j = 0; j < points.Length; j++)
                {
                    if (j != i)
                    {
                        term *= (x - points[j].X) / (points[i].X - points[j].X);
                    }
                }

                result += term;
            }
            return result;
        }

        public override void Draw(Graphics g)
        {
            Point origin = new Point(1, 1);
            double xStep = 1.0;
            int numX = (int)Math.Floor(overlaySize.Width / xStep);

            List<Point> curvePoints = new List<Point>();
            for (int i = 0; i < numX; i++)
            {
                double x = i * xStep;
                double y = LagrangeInterpolation(x);
                curvePoints.Add(new Point((int)Math.Floor(x), (int)Math.Floor(y)));
            }

            Pen pen = new Pen(Color.Black, 2.0f);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawLine(pen, origin, curvePoints[0]);
            for (int i = 1; i < numX - 1; i++)
            {
                g.DrawLine(pen, curvePoints[i], curvePoints[i + 1]);
            }
        }
    }
}
