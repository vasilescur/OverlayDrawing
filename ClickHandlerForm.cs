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
    public partial class ClickHandlerForm : Form
    {
        private ControlsForm controlsForm;
        private ControlsForm.ClickHandledCallback callback;

        public ClickHandlerForm(ControlsForm controlsForm, ControlsForm.ClickHandledCallback callback)
        {
            this.controlsForm = controlsForm;
            this.callback = callback;

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void ClickHandlerForm_MouseClick(object sender, MouseEventArgs e)
        {
            callback(e.Location);
            this.Close();
        }
    }
}
