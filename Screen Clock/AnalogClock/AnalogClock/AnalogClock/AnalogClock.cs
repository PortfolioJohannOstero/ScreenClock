using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;


/*
 * 
 *      ANALOG CLOCK 
 *      CUSTOM CONTROLLER
 * 
 *      http://www.codeproject.com/Articles/10627/Yet-Another-Analog-Clock
 *      
 *      Modified: Jóhann Østerø
 * 
 * 
 */

namespace AnalogClock
{
    /* <summary> Defines the ticking "style" (Only applies to the second and minute hands of the analog clock) </summary> */
    public enum eTickStyle
    {
        /* <summary> Smooth ticking style. For example if used with second hand it will be updated every millisecond. </summary> */
        Smooth, 
        
        /* <summary> Normal ticking style. For example if used with second hand it will be updated every second only. </summary> */
        Normal
    }


    // Main class:
    public partial class AnalogClock: UserControl
    {
        /* ............... Data members .............. */
        #region Data Members

            // Draw Variables (bool)
        private bool drawnumerals = true;
        private bool drawRim = true;
        private bool drawDropShadow = true;
        private bool drawSecondHandShadow = true;
        private bool drawMinuteHandShadow = true;
        private bool drawDeadlineHandShadow = true;
        private bool drawHourHandShadow = true;
        private bool drawSecondHand = true;
        private bool drawMinuteHand = true;
        private bool drawHourHand = true;
        private bool drawDeadlineHand = false;

            // Default dropShadow
        private Color dropShadowColor = Color.Black;

        private Color secondHandDropShadowColor = Color.Gray;
        private Color hourHandDropShadowColor = Color.Gray;
        private Color minuteHandDropShadowColor = Color.Gray;
        private Color deadlineHandDropShadowColor = Color.Gray;

            // graphics
        private Color faceColor1 = Color.White;
        private Color faceColor2 = Color.LightGray;
        private Color rimColor1 = Color.Gray;
        private Color rimColor2 = Color.DarkGray;
        private Color numeralColor = Color.Black;
        private Color secondHandColor = Color.Tomato;

        private LinearGradientBrush gb;
        private SmoothingMode smoothingMode = SmoothingMode.AntiAlias;
        private TextRenderingHint textRenderingHint = TextRenderingHint.AntiAlias;
        private LineCap secLineEndCap = LineCap.Round;
        private LinearGradientMode faceGradientMode = LinearGradientMode.ForwardDiagonal;
        private LinearGradientMode rimGradientMode = LinearGradientMode.BackwardDiagonal;
        private DateTime time;

        private Color hourHandColor = Color.Gainsboro;
        private Color minHandColor = Color.WhiteSmoke;
        private Color deadlineHandColor = Color.DarkGreen;

            // Holders
        private float radius;
        private float midx;
        private float midy;
        private float y;
        private float x;
        private float fontsize;
        private Font textFont;
        private int min;
        private int hour;
        private double sec;

        float minuteAngle;
        double secondAngle;
        double hourAngle;
        double deadline_minuteAngle;
        double deadline_hourAngle;

        private int deadline_minValue;
        private int deadline_hourValue;

        private Point dropShadowOffset;

            // default eTickStyle
        private eTickStyle secondHandTickStyle = eTickStyle.Normal;
        private eTickStyle minHandTickStyle = eTickStyle.Normal;

        #endregion

        #region Properties

        /// <summary>
        /// Defines the second hand tick style.
        /// </summary>
        [
        Category("Clock"),
        Description("Defines the second hand tick style."),

        ]
        public eTickStyle SecondHandTickStyle
        {
            get { return secondHandTickStyle; }
            set { this.secondHandTickStyle = value; }
        }

        /// <summary>
        /// Defines the minute hand tick style.
        /// </summary>
        [
        Category("Clock"),
        Description("Defines the minute hand tick style."),

        ]
        public eTickStyle MinuteHandTickStyle
        {
            get { return minHandTickStyle; }
            set { minHandTickStyle = value; }
        }

        /// <summary>
        /// Determines whether the Numerals are drawn on the clock face.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the Numerals are drawn on the clock face."),
        DefaultValue(true),
        ]
        public bool DrawNumerals
        {
            get { return drawnumerals; }
            set { drawnumerals = value; Invalidate(); }

        }

        /// <summary>
        /// Sets or gets the rendering quality of the clock.
        /// </summary>
        /// <remarks>This property does not effect the numeral text rendering quality. To set the numeral text rendering quality use the <see cref="TextRenderingHint"/> Property</remarks>
        [
        Category("Clock"),
        Description("Sets or gets the rendering quality of the clock."),
        DefaultValue(SmoothingMode.AntiAlias),
        ]
        public SmoothingMode SmoothingMode
        {
            get { return smoothingMode; }
            set { this.smoothingMode = value; Invalidate(); }
        }

        /// <summary>
        /// Sets or gets the text rendering mode used for the clock numerals.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the text rendering mode used for the clock numerals."),
        DefaultValue(TextRenderingHint.AntiAlias),
        ]
        public TextRenderingHint TextRenderingHint
        {
            get { return this.textRenderingHint; }
            set { this.textRenderingHint = value; Invalidate(); }

        }

        /// <summary>
        /// Determines whether the clock Rim is drawn or not.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the clock Rim is drawn or not."),
        DefaultValue(true),
        ]
        public bool DrawRim
        {
            get { return this.drawRim; }
            set { this.drawRim = value; Invalidate(); }
        }

        /// <summary>
        /// Determines whether drop shadow for the clock is drawn or not.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether drop shadow for the clock is drawn or not."),
        DefaultValue(true),
        ]
        public bool DrawDropShadow
        {
            get { return this.drawDropShadow; }
            set { drawDropShadow = value; Invalidate(); }
        }

        /// <summary>
        /// Sets or gets the color of the Drop Shadow.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the color of the Drop Shadow."),

        ]
        public Color DropShadowColor
        {
            get { return this.dropShadowColor; }
            set { this.dropShadowColor = value; Invalidate(); }
        }


        /// <summary>
        /// Sets or gets the color of the second hand drop Shadow.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the color of the second hand drop Shadow."),

        ]
        public Color SecondHandDropShadowColor
        {
            get { return this.secondHandDropShadowColor; }
            set { this.secondHandDropShadowColor = value; Invalidate(); }
        }


        /// <summary>
        /// Sets or gets the color of the Minute hand drop Shadow.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the color of the Minute hand drop Shadow."),

        ]
        public Color MinuteHandDropShadowColor
        {
            get { return this.minuteHandDropShadowColor; }
            set { this.minuteHandDropShadowColor = value; Invalidate(); }
        }

        /// <summary>
        /// Sets or gets the color of the hour hand drop Shadow.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the color of the hour hand drop Shadow."),

        ]
        public Color HourHandDropShadowColor
        {
            get { return this.hourHandDropShadowColor; }
            set { this.hourHandDropShadowColor = value; Invalidate(); }
        }

        [
        Category("Clock"),
        Description("Sets or gets the color of the deadline hand(s) drop Shadow."),

        ]
        public Color DeadlineHandDropShadowColor
        {
            get { return this.deadlineHandDropShadowColor; }
            set { this.deadlineHandDropShadowColor = value; Invalidate(); }
        }


        /// <summary>
        /// Determines the first color of the clock face gradient.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the first color of the clock face gradient."),

        ]
        public Color FaceColorHigh
        {
            get { return this.faceColor1; }
            set { this.faceColor1 = value; Invalidate(); }
        }

        /// <summary>
        /// Determines the second color of the clock face gradient.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the second color of the clock face gradient."),
        DefaultValue(typeof(Color), "Black")
        ]
        public Color FaceColorLow
        {
            get { return this.faceColor2; }
            set { this.faceColor2 = value; Invalidate(); }
        }


        /// <summary>
        /// Determines whether the second hand casts a drop shadow for added realism.  
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the second hand casts a drop shadow for added realism."),
        DefaultValue(true)
        ]
        public bool DrawSecondHandShadow
        {
            get { return this.drawSecondHandShadow; }
            set { this.drawSecondHandShadow = value; Invalidate(); }
        }


        /// <summary>
        /// Determines whether the hour hand casts a drop shadow for added realism.  
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the hour hand casts a drop shadow for added realism."),
        ]
        public bool DrawHourHandShadow
        {
            get { return this.drawHourHandShadow; }
            set { this.drawHourHandShadow = value; Invalidate(); }
        }

        /// <summary>
        /// Determines whether the minute hand casts a drop shadow for added realism.  
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the minute hand casts a drop shadow for added realism."),
        ]
        public bool DrawMinuteHandShadow
        {
            get { return this.drawMinuteHandShadow; }
            set { this.drawMinuteHandShadow = value; Invalidate(); }
        }

        [
        Category("Clock"),
        Description("Determines whether the deadline hand casts a drop shadow for added realism."),
        ]
        public bool DrawDeadlineHandShadow
        {
            get { return this.drawDeadlineHandShadow; }
            set { this.drawDeadlineHandShadow = value; Invalidate(); }
        }

        /// <summary>
        /// Determines the first color of the rim gradient.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the first color of the rim gradient."),
        ]
        public Color RimColorHigh
        {
            get { return this.rimColor1; }
            set { this.rimColor1 = value; Invalidate(); }
        }

        /// <summary>
        /// Determines the second color of the rim face gradient.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the second color of the rim face gradient."),
        ]
        public Color RimColorLow
        {
            get { return this.rimColor2; }
            set { this.rimColor2 = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the direction of the Rim gradient.
        /// </summary>
        //TODO:replace this by degree
        [
        Category("Clock"),
        Description("Gets or sets the direction of the Rim gradient."),
        ]
        public LinearGradientMode RimGradientMode
        {
            get { return this.faceGradientMode; }
            set { this.faceGradientMode = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the direction of the Clock Face gradient.
        /// </summary>
        //TODO:replace this by degree
        [
        Category("Clock"),
        Description("Gets or sets the direction of the Clock Face gradient."),
        ]
        public LinearGradientMode FaceGradientMode
        {
            get { return this.rimGradientMode; }
            set { this.rimGradientMode = value; Invalidate(); }
        }

        /// <summary>
        /// Determines the Seconds hand end line shape.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the shape of second hand."),
        ]
        public LineCap SecondHandEndCap
        {
            get { return this.secLineEndCap; }
            set { this.secLineEndCap = value; Invalidate(); }
        }

        /// <summary>
        /// The System.DateTime structure which is used to display time.
        /// </summary>
        /// <example>
        /// <code>
        /// AnalogClock clock = new AnalogClock();
        /// clock.Time = DateTime.Now;
        /// </code>
        /// </example>
        /// <remarks>The clock face is updated every time the value of this property is changed.</remarks>
        [
        Category("Clock"),
        Description("The DateTime structure which the clock uses to display time."),
        Browsable(false)
        ]
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; this.Invalidate(); }
        }

        [
        Category("Clock"),
        Description("The Deadline Hour time that is used to display where the deadline hour hand is suppose to be."),
        ]
        public int DeadlineHourTime
        {
            get { return this.deadline_hourValue; }
            set { this.deadline_hourValue = value; this.Invalidate(); }
        }

        [
        Category("Clock"),
        Description("The Deadline Minute time that is used to display where the deadline minute hand is suppose to be."),
        ]
        public int DeadlineMinuteTime
        {
            get { return this.deadline_minValue; }
            set { this.deadline_minValue = value; this.Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the Seconds Hand.
        /// </summary>
        [
        Category("Clock"),
        Description("Gets or sets the color of the Seconds Hand."),
        ]
        public Color SecondHandColor
        {
            get { return this.secondHandColor; }
            set { this.secondHandColor = value; Invalidate(); }
        }

        /// <summary>
        /// Sets or gets the color of the clock Numerals.
        /// </summary>
        /// <remarks>To change the numeral font use the <see cref=" Font "/> Property </remarks>
        [
        Category("Clock"),
        Description("Sets or gets the color of the clock Numerals."),
        ]
        public Color NumeralColor
        {
            get { return this.numeralColor; }
            set { this.numeralColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the Hour Hand.
        /// </summary>
        [
        Category("Clock"),
        Description("Gets or sets the color of the Hour Hand."),
        ]
        public Color HourHandColor
        {
            get { return this.hourHandColor; }
            set { this.hourHandColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the Minute Hand.
        /// </summary>
        [
        Category("Clock"),
        Description("Gets or sets the color of the Minute Hand."),
        ]
        public Color MinuteHandColor
        {
            get { return this.minHandColor; }
            set { this.minHandColor = value; Invalidate(); }
        }


        /// <summary>
        /// Determines whether the second Hand is shown. 
        /// </summary>
        /// 
        [
        Category("Clock"),
        Description("Determines whether the second Hand is shown."),
        ]
        public bool DrawSecondHand
        {
            get { return drawSecondHand; }
            set { this.drawSecondHand = value; Invalidate(); }
        }


        /// <summary>
        /// Determines whether the minute hand is shown. 
        /// </summary>
        /// 
        [
        Category("Clock"),
        Description("Determines whether the minute hand is shown."),
        ]
        public bool DrawMinuteHand
        {
            get { return drawMinuteHand; }
            set { this.drawMinuteHand = value; Invalidate(); }
        }

        /// <summary>
        /// Determines whether the hour Hand is shown. 
        /// </summary>
        /// 
        [
        Category("Clock"),
        Description("Determines whether the hour Hand is shown."),
        ]
        public bool DrawHourHand
        {
            get { return drawHourHand; }
            set { this.drawHourHand = value; Invalidate(); }
        }

        [
        Category("Clock"),
        Description("Determines whether the deadline Hands are shown."),
        ]
        public bool DrawDeadlineHand
        {
            get { return drawDeadlineHand; }
            set { this.drawDeadlineHand = value; Invalidate(); }
        }

        [
        Category("Clock"),
        Description("Sets the Deadline Hand Colour"),
        ]
        public Color DeadlineHandColour
        {
            get { return deadlineHandColor; }
            set { this.deadlineHandColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the drop shadow offset.
        /// </summary>
        /// 
        [
        Category("Clock"),
        Description("Gets or sets the drop shadow offset."),
        ]
        public Point DropShadowOffset
        {
            get { return dropShadowOffset; }
            set { this.dropShadowOffset = value; Invalidate(); }
        }





        #endregion

        /* ----------- Constructor -----------*/
        public AnalogClock()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }



        /* ----------- private accessors ------- */
        private float GetX(float deg)
        { return (float)(radius * Math.Cos((Math.PI / 180) * deg)); }

        private float GetY(float deg)
        { return (float)(radius * Math.Sin((Math.PI / 180) * deg)); }


        /* -------------------- event handlers --------------- */
        private void AnalogClock_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            DrawClock(e.Graphics);
        }

        private void AnalogClock_Resize(object sender, System.EventArgs e)
        {
            this.Width = this.Height;
            this.Width = this.Width;

            this.Invalidate();
        }

        /* -------------- Draw Method ------------ */
        private void DrawClock(Graphics e)
        {
            Graphics grfx = e;
            grfx.SmoothingMode = smoothingMode;
            grfx.TextRenderingHint = textRenderingHint;
            grfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            midx = this.ClientSize.Width / 2;
            midy = this.ClientSize.Height / 2;


            x = this.ClientSize.Width;
            y = this.ClientSize.Height;

            SolidBrush stringBrush = new SolidBrush(this.numeralColor);
            Pen pen = new Pen(stringBrush, 2);

            /*
             * 
             * Rectangle:
             *  - Parameters:
             * x Position
             * y Position
             * width
             * height
             * 
             */

            // V    Its so that we don't calculate the same values multiple times
            float proc4     = calcSize(4);
            float proc8     = calcSize(8);
            float proc12    = calcSize(12);
            float proc24    = calcSize(24);
            float proc16    = calcSize(16);
            float proc36    = calcSize(36);
            

            //Define rectangles inside which we will draw circles.
            Rectangle rect = new Rectangle((int)proc8, (int)proc8, (int)(x - proc16), (int)(y - proc16));
            Rectangle rectrim = new Rectangle((int)proc12, (int)proc12, (int)(x - proc24), (int)(y - proc24));

            Rectangle rectinner = new Rectangle((int)proc24, (int)proc24, (int)(x - proc36), (int)(y - proc36));
            Rectangle rectdropshadow = new Rectangle((int)proc4, (int)proc4, (int)(x - proc8), (int)(y - proc8));

            //Rectangle rect = new Rectangle(0 + 10, 0 + 10, (int)x - 20, (int)y - 20);
            //Rectangle rectrim = new Rectangle(0 + 20, 0 + 20, (int)x - 40, (int)y - 40);

            //Rectangle rectinner = new Rectangle(0 + 40, 0 + 40, (int)x - 80, (int)y - 80);
            //Rectangle rectdropshadow = new Rectangle(0 + 10, 0 + 10, (int)x - 17, (int)y - 17);


            radius = rectinner.Width / 2;

            fontsize = (radius / 5);
            textFont = this.Font;


            //Drop Shadow
            gb = new LinearGradientBrush(rect, Color.Transparent, dropShadowColor, LinearGradientMode.BackwardDiagonal);
            rectdropshadow.Offset(dropShadowOffset);
            if (this.drawDropShadow)
                grfx.FillEllipse(gb, rectdropshadow);


            //Face
            gb = new LinearGradientBrush(rect, rimColor1, rimColor2, faceGradientMode);
            if (this.drawRim)
                grfx.FillEllipse(gb, rect);




            //Rim
            gb = new LinearGradientBrush(rect, faceColor1, faceColor2, rimGradientMode);
            grfx.FillEllipse(gb, rectrim);



            //			Triangular region
            //			pen.Width =2;
            //			grfx.DrawRectangle(pen, rect);
            //			grfx.DrawRectangle(pen, rectinner);
            //			grfx.DrawRectangle(pen, rectrim);
            //			grfx.DrawRectangle(pen, rectdropshadow);
            //			
            //			grfx.DrawRectangle(pen, rect);
            //			grfx.DrawEllipse(pen, rect);
            //			grfx.DrawEllipse(pen, rectinner);
            //			grfx.DrawEllipse(pen, rectrim);
            //			grfx.DrawEllipse(pen, rectdropshadow);
            //			


            //Center Point
            //grfx.DrawEllipse(pen, midx, midy ,2 ,2);

            //Define the midpoint of the control as the center
            grfx.TranslateTransform(midx, midy);



            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;


            //Draw Numerals on the Face 
            int deg = 360 / 12;
            if (drawnumerals)
            {
                textFont = new Font(textFont.FontFamily, fontsize);
                for (int i = 1; i <= 12; i++)
                {
                    grfx.DrawString(i.ToString(), textFont, stringBrush, -1 * GetX(i * deg + 90), -1 * GetY(i * deg + 90), format);
                }

            }
            format.Dispose();



            hour = time.Hour;
            min = time.Minute;
            Point centre = new Point(0, 0);

            // Draw Deadline Hand(s)
            if (drawDeadlineHand)
            {
                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.RoundAnchor;
                pen.Width = (int)radius / 14;

                pen.Color = Color.Gray;


                // ---------------------- hours
                deadline_hourAngle = 2.0 * Math.PI * (deadline_hourValue + deadline_minValue / 60.0) / 12.0;

                centre.X = centre.Y = 1;
                Point deadlineHandShadow_hour = new Point((int)((radius * Math.Sin(deadline_hourAngle) / 1.5) + 2), (int)((-(radius) * Math.Cos(deadline_hourAngle) / 1.5) + 2));

                if (this.drawDeadlineHandShadow)
                {
                    pen.Color = deadlineHandDropShadowColor;
                    grfx.DrawLine(pen, centre, deadlineHandShadow_hour);
                }

                centre.X = centre.Y = 0;
                pen.Color = deadlineHandColor;
                Point deadlineHand_hour = new Point((int)(radius * Math.Sin(deadline_hourAngle) / 1.5), (int)(-(radius) * Math.Cos(deadline_hourAngle) / 1.5));
                grfx.DrawLine(pen, centre, deadlineHand_hour);

                // ----------------- minutes
                deadline_minuteAngle = (float)(2.0 * Math.PI * (deadline_minValue / 60.0));

                centre.Offset(2, 2);
                Point deadlineHandShadow_minute = new Point((int)(radius * Math.Sin(deadline_minuteAngle)), (int)(-(radius) * Math.Cos(deadline_minuteAngle) + 2));

                if (this.drawDeadlineHandShadow)
                {
                    pen.Color = deadlineHandDropShadowColor;
                    grfx.DrawLine(pen, centre, deadlineHandShadow_minute);
                }

                centre.X = centre.Y = 0;
                pen.Color = deadlineHandColor;
                Point deadlineHand_minute = new Point((int)(radius * Math.Sin(deadline_minuteAngle)), (int)(-(radius) * Math.Cos(deadline_minuteAngle)));
                grfx.DrawLine(pen, centre, deadlineHand_minute);
            }


            //Draw Minute hand
            if (drawMinuteHand)
            {

                if (minHandTickStyle == eTickStyle.Smooth)
                    minuteAngle = (float)(2.0 * Math.PI * (min + sec / 60.0) / 60.0);
                else
                    minuteAngle = (float)(2.0 * Math.PI * (min / 60.0));

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.RoundAnchor;
                pen.Width = (int)radius / 14;

                centre.Offset(2, 2);
                pen.Color = Color.Gray;
                Point minHandShadow = new Point((int)(radius * Math.Sin(minuteAngle)), (int)(-(radius) * Math.Cos(minuteAngle) + 2));


                if (this.drawMinuteHandShadow)
                {
                    pen.Color = minuteHandDropShadowColor;
                    grfx.DrawLine(pen, centre, minHandShadow);
                }

                centre.X = centre.Y = 0;
                pen.Color = minHandColor;
                Point minHand = new Point((int)(radius * Math.Sin(minuteAngle)), (int)(-(radius) * Math.Cos(minuteAngle)));
                grfx.DrawLine(pen, centre, minHand);
            }

            //--End Minute Hand


            // Draw Hour Hand
            if (drawHourHand)
            {
                hourAngle = 2.0 * Math.PI * (hour + min / 60.0) / 12.0;


                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.RoundAnchor;
                pen.Width = (int)radius / 14;

                centre.X = centre.Y = 1;
                pen.Color = Color.Gray;
                Point hourHandShadow = new Point((int)((radius * Math.Sin(hourAngle) / 1.5) + 2), (int)((-(radius) * Math.Cos(hourAngle) / 1.5) + 2));

                if (this.drawHourHandShadow)
                {
                    pen.Color = hourHandDropShadowColor;
                    grfx.DrawLine(pen, centre, hourHandShadow);
                }

                centre.X = centre.Y = 0;
                pen.Color = hourHandColor;
                Point hourHand = new Point((int)(radius * Math.Sin(hourAngle) / 1.5), (int)(-(radius) * Math.Cos(hourAngle) / 1.5));
                grfx.DrawLine(pen, centre, hourHand);
            }
            //---End Hour Hand


            if (secondHandTickStyle == eTickStyle.Smooth)
                sec = time.Second + (time.Millisecond * 0.001);
            else
                sec = time.Second;


            //Draw Sec Hand
            if (drawSecondHand)
            {
                int width = (int)radius / 25;
                pen.Width = width;
                pen.EndCap = secLineEndCap;
                pen.StartCap = LineCap.RoundAnchor;
                secondAngle = 2.0 * Math.PI * sec / 60.0;




                //Draw Second Hand Drop Shadow
                pen.Color = Color.DimGray;
                centre.X = 1;
                centre.Y = 1;

                Point secHand = new Point((int)(radius * Math.Sin(secondAngle)), (int)(-(radius) * Math.Cos(secondAngle)));
                Point secHandshadow = new Point((int)(radius * Math.Sin(secondAngle)), (int)(-(radius) * Math.Cos(secondAngle) + 2));



                if (drawSecondHandShadow)
                {
                    pen.Color = secondHandDropShadowColor;
                    grfx.DrawLine(pen, centre, secHandshadow);

                }

                centre.X = centre.Y = 0;
                pen.Color = secondHandColor;
                grfx.DrawLine(pen, centre, secHand);
            }

            pen.Dispose();
        }

        /* -------------- Calculate Dimension sizes ----------------- */
        private float calcSize(float size)
        {
            return (size / 100) * this.Size.Width;
        }

        private float calcHeight(float size)
        {
            return (size / 100) * this.Size.Height;
        }
    }
}
