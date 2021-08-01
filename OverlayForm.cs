using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverlayDrawing
{
    public partial class OverlayForm : Form
    {
        private List<Drawing> drawings;

        public OverlayForm()
        {
            InitializeComponent();

            drawings = new List<Drawing>();

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;

            this.FormBorderStyle = FormBorderStyle.None;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
        }

        public void AddPointMarker(Point location)
        {
            this.drawings.Add(new PointMarker(location));
            RenderDrawings();
        }

        public void AddParabola(Point loc1, Point loc2, Point loc3)
        {
            this.drawings.Add(new Parabola(loc1, loc2, loc3, this.Size));
            ClearPointMarkers();
            RenderDrawings();
        }

        public void ClearPointMarkers()
        {
            this.drawings.RemoveAll(drawing => drawing is PointMarker);
        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {
            LaunchControlsForm();
        }

        private void LaunchControlsForm()
        {
            ControlsForm cf = new ControlsForm(this);

            Screen targetScreen = Screen.AllScreens.FirstOrDefault(s => s != Screen.PrimaryScreen) ?? Screen.PrimaryScreen;

            cf.Location = targetScreen.WorkingArea.Location;
            cf.Show();
        }

        public void RenderDrawings()
        {
            Graphics g = CreateGraphics();
            g.Clear(this.BackColor);

            foreach (Drawing drawing in drawings)
            {
                drawing.Draw(g);
            }
        }

        public void ClearDrawings()
        {
            this.drawings.Clear();
            RenderDrawings();
        }
    }
}
