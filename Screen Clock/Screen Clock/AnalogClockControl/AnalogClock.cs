using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClockControl
{
    public partial class AnalogClock : UserControl
    {
        const float PI = 3.141592654F;

        DateTime dateTime;

        float fRadius;
        float fCenterX;
        float fCenterY;
        float fCenterCircleRadius;

        float fHourLength;
        float fMinLength;
        float fSecLength;

        float fHourThickness;
        float fMinThickness;
        float fSecThickness;

        bool bDraw5MinuteTicks = true;
        bool bDraw1MinuteTicks = true;
        float fTicksThickness = 3;

        Color hrColor = Color.Black;
        Color minColor = Color.Black;
        Color secColor = Color.Red;
        Color circleColor = Color.Red;
        Color ticksColor = Color.Black;

        Color deadlineColor = Color.Gray;
        bool bDrawDeadlineHand = true;
        float fDeadlineValue_hour = 16;
        float fDeadlineValue_min = 30;

        public AnalogClock()
        {
            InitializeComponent();
        }

        // CONTROLLERS
        private void AnalogClock_Load(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            this.AnalogClock_Resize(sender, e);
        }

        private void AnalogClock_Resize(object sender, EventArgs e)
        {
            this.Width = this.Height;
            this.fRadius = this.Height / 2;
            this.fCenterX = this.ClientSize.Width / 2;
            this.fCenterY = this.ClientSize.Height / 2;
            this.fHourLength = (float)this.Height / 3 / 1.65F;
            this.fMinLength = (float)this.Height / 3 / 1.20F;
            this.fSecLength = (float)this.Height / 3 / 1.15F;
            this.fHourThickness = (float)this.Height / 100;
            this.fMinThickness = (float)this.Height / 150;
            this.fSecThickness = (float)this.Height / 200;
            this.fCenterCircleRadius = this.Height / 50;
            this.Refresh();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            this.dateTime = DateTime.Now;
            this.Refresh();
        }

        // GRAPHICAL DRAWING
        private void DrawLine(float fThickness, float fLength, Color color, float fRadians, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(color, fThickness),
            fCenterX - (float)(fLength / 12 * System.Math.Sin(fRadians)),
            fCenterY + (float)(fLength / 12 * System.Math.Cos(fRadians)),
            fCenterX + (float)(fLength * System.Math.Sin(fRadians)),
            fCenterY - (float)(fLength * System.Math.Cos(fRadians)));
        }

        private void DrawPolygon(float fThickness, float fLength, Color color, float fRadians, System.Windows.Forms.PaintEventArgs e)
        {

            PointF A = new PointF((float)(fCenterX + fThickness * 2 * System.Math.Sin(fRadians + PI / 2)),
                        (float)(fCenterY - fThickness * 2 * System.Math.Cos(fRadians + PI / 2)));
            PointF B = new PointF((float)(fCenterX + fThickness * 2 * System.Math.Sin(fRadians - PI / 2)),
                        (float)(fCenterY - fThickness * 2 * System.Math.Cos(fRadians - PI / 2)));
            PointF C = new PointF((float)(fCenterX + fLength * System.Math.Sin(fRadians)),
                        (float)(fCenterY - fLength * System.Math.Cos(fRadians)));
            PointF D = new PointF((float)(fCenterX - fThickness * 4 * System.Math.Sin(fRadians)),
                        (float)(fCenterY + fThickness * 4 * System.Math.Cos(fRadians)));
            
            
            PointF[] points = { A, D, B, C };
            e.Graphics.FillPolygon(new SolidBrush(color), points);
        }

        public void Start()
        {
            clockTimer.Enabled = true;
            this.Refresh();
        }

        public void Stop()
        {
            clockTimer.Enabled = false;
        }

        private void AnalogClock_Paint(object sender, PaintEventArgs e)
        {
            float fRadHr = (dateTime.Hour % 12 + dateTime.Minute / 60F) * 30 * PI / 180;
            float fRadMin = (dateTime.Minute) * 6 * PI / 180;
            float fRadSec = (dateTime.Second) * 6 * PI / 180;

            float fDeadHour = (fDeadlineValue_hour % 12 + fDeadlineValue_min / 60F) * 30 * PI / 180;
            float fDeadMin = (fDeadlineValue_min) * 6 * PI / 180;

            DrawPolygon(this.fHourThickness,    this.fHourLength,   hrColor,    fRadHr,     e);
            DrawPolygon(this.fMinThickness,     this.fMinLength,    minColor,   fRadMin,    e);

            DrawLine(   this.fSecThickness,     this.fSecLength,    secColor,   fRadSec,    e);
            
            //if(bDrawDeadlineHand)
            DrawLine(this.fSecThickness, this.fSecLength, deadlineColor, fDeadHour, e);
            DrawLine(this.fSecThickness, this.fSecLength, deadlineColor, fDeadMin, e);


            for (int i = 0; i < 60; i++)
            {
                if (this.bDraw5MinuteTicks == true && i % 5 == 0)
                // Draw 5 minute ticks
                {
                    e.Graphics.DrawLine(new Pen(ticksColor, fTicksThickness),
                      fCenterX +
                      (float)(this.fRadius / 1.50F * System.Math.Sin(i * 6 * PI / 180)),
                      fCenterY -
                      (float)(this.fRadius / 1.50F * System.Math.Cos(i * 6 * PI / 180)),
                      fCenterX +
                      (float)(this.fRadius / 1.65F * System.Math.Sin(i * 6 * PI / 180)),
                      fCenterY -
                      (float)(this.fRadius / 1.65F * System.Math.Cos(i * 6 * PI / 180)));
                }
                else if (this.bDraw1MinuteTicks == true) // draw 1 minute ticks
                {
                    e.Graphics.DrawLine(new Pen(ticksColor, fTicksThickness),
                      fCenterX +
                      (float)(this.fRadius / 1.50F * System.Math.Sin(i * 6 * PI / 180)),
                      fCenterY -
                      (float)(this.fRadius / 1.50F * System.Math.Cos(i * 6 * PI / 180)),
                      fCenterX +
                      (float)(this.fRadius / 1.55F * System.Math.Sin(i * 6 * PI / 180)),
                      fCenterY -
                      (float)(this.fRadius / 1.55F * System.Math.Cos(i * 6 * PI / 180)));
                }
            }

            //draw circle at center
            e.Graphics.FillEllipse(new SolidBrush(circleColor),
                       fCenterX - fCenterCircleRadius / 2,
                       fCenterY - fCenterCircleRadius / 2,
                       fCenterCircleRadius, fCenterCircleRadius);
        }


        // --------------------------- The Properties Interface ---------------------------
            // COLOURS
        [Description("Sets the colour of the Hour Hand"), Category("Appearance")]
        public Color Color_HourHand
        {
            get { return this.hrColor; }
            set { this.hrColor = value; }
        }

        [Description("Sets the colour of the Minute Hand"), Category("Appearance")]
        public Color Color_MinuteHand
        {
            get { return this.minColor; }
            set { this.minColor = value; }
        }

        [Description("Sets the colour of the Second Hand"), Category("Appearance")]
        public Color Color_SecondHand
        {
            get { return this.secColor; }
            set
            {
                this.secColor = value;
                this.circleColor = value;
            }
        }

        [Description("Sets the colour of the \"border\" (The ticks around)"), Category("Appearance")]
        public Color Color_Ticks
        {
            get { return this.ticksColor; }
            set { this.ticksColor = value; }
        }

            // DISPLAY (Booleans)
        [Description("Choose to display the one minute ticks on the \"border\""), Category("Appearance")]
        public bool DisplayOneMinuteTicks
        {
            get { return this.bDraw1MinuteTicks; }
            set { this.bDraw1MinuteTicks = value; }
        }

        [Description("Choose to display the five minute ticks on the \"border\""), Category("Appearance")]
        public bool DisplayFiveMinuteTicks
        {
            get { return this.bDraw5MinuteTicks; }
            set { this.bDraw5MinuteTicks = value; }
        }

        [Description("Display the Deadline Hand"), Category("Appearance")]
        public bool DisplayDeadlineHand
        {
            get { return this.bDrawDeadlineHand; }
            set { this.bDrawDeadlineHand = value; }
        }

            // ASSIGNED VALUES
        [Description("Sets the overall thickness of the lines"), Category("Appearance")]
        public float LineThickness
        {
            get { return this.fTicksThickness; }
            set { this.fTicksThickness = value; }
        }

        [Description("Sets the Deadline time"), Category("Appearance")]
        public float DeadlineTime
        {
            get { return this.fDeadlineValue_hour; }
            set { this.fDeadlineValue_hour = value; }
        }
    }
}
