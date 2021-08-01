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
    public partial class ControlsForm : Form
    {
        private OverlayForm overlayForm;
        public delegate void ClickHandledCallback(Point location);

        public ControlsForm(OverlayForm overlayForm)
        {
            this.overlayForm = overlayForm;
            InitializeComponent();
        }

        private void ControlsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            overlayForm.Close();
        }

        private void GetAndHandleClick(ClickHandledCallback callback)
        {
            ClickHandlerForm clickHandlerForm = new ClickHandlerForm(this, callback);
            clickHandlerForm.Show();
        }

        private void drawPointButton_Click(object sender, EventArgs e)
        {
            GetAndHandleClick((Point location) =>
            {
                locationTestLabel.Text = location.ToString();
                overlayForm.AddPointMarker(location);
            });
        }

        private void drawParabolaButton_Click(object sender, EventArgs e)
        {
            GetAndHandleClick((Point p1) =>
            {
                Console.WriteLine(p1);
                locationTestLabel.Text = p1.ToString();
                overlayForm.AddPointMarker(p1);

                GetAndHandleClick((Point p2) =>
                {
                    Console.WriteLine(p2);
                    locationTestLabel.Text = p2.ToString();
                    overlayForm.AddPointMarker(p2);

                    GetAndHandleClick((Point p3) =>
                    {
                        Console.WriteLine(p3);
                        locationTestLabel.Text = p2.ToString();
                        overlayForm.AddPointMarker(p2);

                        overlayForm.AddParabola(p1, p2, p3);
                    });
                });
            });
        }
        private void polyButton_Click(object sender, EventArgs e)
        {

        }

        private void renderButton_Click(object sender, EventArgs e)
        {
            overlayForm.RenderDrawings();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            overlayForm.ClearDrawings();
        }


    }
}
