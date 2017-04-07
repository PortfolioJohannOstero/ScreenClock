using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


/*
 * Explanation:
 * http://stackoverflow.com/questions/4503210/draw-semi-transparent-overlay-image-all-over-the-windows-form-having-some-contro
 * 
 */


namespace Screen_Clock.Forms
{
    public partial class ClockForm_overlay : Form
    {
        private bool visible = false;
        public static bool hidden = false;

        // The dragging properties
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public ClockForm_overlay(Form tocover, bool startOutVisible)
        {
            visible = startOutVisible;

            this.BackColor = Color.Black;
            this.Opacity = 0.1;    // ---- The Visibility (increase for testing purposes) -! cannot be zero or it will break the dragging mechanics
            this.FormBorderStyle = FormBorderStyle.None;
            
            this.ControlBox = false;
            this.ShowInTaskbar = false;
            
            this.StartPosition = FormStartPosition.Manual;
            this.AutoScaleMode = AutoScaleMode.None;
            
            this.Location = tocover.PointToScreen(Point.Empty);
            this.ClientSize = tocover.ClientSize;

            tocover.VisibleChanged += Cover_VisibleChanged;
            tocover.ClientSizeChanged += Cover_ClientSizeChanged;
            tocover.LocationChanged += Cover_LocationChanged;

            this.MouseDown += mouseDown_drag;
            this.MouseUp += mouseUp_drag;
            this.MouseMove += mouseMove_drag;

            this.Show(tocover);
            this.Hide();
            tocover.Focus();

            InitializeComponent();
        }

        private void Cover_ClientSizeChanged(object sender, EventArgs e)
        {
            this.ClientSize = this.Owner.ClientSize;
            this.Location = this.Owner.Location;
        }

        private void Cover_LocationChanged(object sender, EventArgs e)
        {
            this.Location = this.Owner.Location;
        }

        private void Cover_VisibleChanged(object sender, EventArgs e)
        {
            visible = !visible; // toggle

            if (visible)
                this.Show();
            else
                this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Owner.ClientSizeChanged -= Cover_ClientSizeChanged;
            this.Owner.LocationChanged -= Cover_LocationChanged;
            this.Owner.VisibleChanged -= Cover_VisibleChanged;

            base.OnFormClosing(e);
        }

        protected override void OnActivated(EventArgs e)
        {
            this.BeginInvoke(new Action(() => this.Owner.Activate()));
            base.OnActivated(e);
        }


        // The Dragging events
        private void mouseDown_drag(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void mouseUp_drag(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void mouseMove_drag(object sender, MouseEventArgs e)
        {
            if (dragging && !Data_Config.Monitor.IsFullScreen)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
    }
}
