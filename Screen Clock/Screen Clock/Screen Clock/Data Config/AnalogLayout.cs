using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Screen_Clock.Data_Config
{
    [Serializable()]
    public class AnalogLayout
    {
        #region Data Members

        /* Data Members */
            // Drop Shadow Color
        Color dropShadowColor;
        bool drawDropShadow;

            // Face Colour
        Color faceColourHigh;
        Color faceColourLow;
        System.Drawing.Drawing2D.LinearGradientMode faceGradient;

            // Rim Colour
        Color rimColourHigh;
        Color rimColourLow;
        System.Drawing.Drawing2D.LinearGradientMode rimGradient;

            //Font Colour
        Color fontColour;

            // Hour Minute Second Hand Colour
        Color hourHand;
        Color minuteHand;
        Color secondHand;

            // Second Behavior
        AnalogClock.eTickStyle secondTickStyle;

            // Deadline Hand Colour
        Color deadlineHand;

            // draw
        bool drawHourHand;
        bool drawMinuteHand;
        bool drawSecondHand;

        bool drawHourShadow;
        bool drawMinuteShadow;
        bool drawSecondShadow;
        bool drawDeadlineShadow;

        Color hourShadow;
        Color minuteShadow;
        Color secondShadow;
        Color deadlineShadow;

        #endregion

        public AnalogLayout(AnalogClock.AnalogClock analogLayout)
        {
            dropShadowColor= analogLayout.DropShadowColor;
            drawDropShadow = analogLayout.DrawDropShadow;
            
            faceColourHigh = analogLayout.FaceColorHigh;
            faceColourLow = analogLayout.FaceColorLow;
            faceGradient = analogLayout.FaceGradientMode;

            rimColourHigh = analogLayout.RimColorHigh;
            rimColourLow = analogLayout.RimColorLow;
            rimGradient = analogLayout.RimGradientMode;

            fontColour = analogLayout.NumeralColor;

            hourHand = analogLayout.HourHandColor;
            minuteHand = analogLayout.MinuteHandColor;
            secondHand = analogLayout.SecondHandColor;

            secondTickStyle = analogLayout.SecondHandTickStyle;        // enum

            deadlineHand = analogLayout.DeadlineHandColour;

            drawHourHand = analogLayout.DrawHourHand;
            drawMinuteHand = analogLayout.DrawMinuteHand;
            drawSecondHand = analogLayout.DrawSecondHand;

            drawHourShadow = analogLayout.DrawHourHandShadow;
            drawMinuteShadow = analogLayout.DrawMinuteHandShadow;
            drawSecondShadow = analogLayout.DrawSecondHandShadow;
            drawDeadlineShadow = analogLayout.DrawDeadlineHandShadow;

            hourShadow = analogLayout.HourHandDropShadowColor;
            minuteShadow = analogLayout.MinuteHandDropShadowColor;
            secondShadow = analogLayout.SecondHandDropShadowColor;
            deadlineShadow = analogLayout.DeadlineHandDropShadowColor;
        }


        #region Accessors
        /* ---------Accessors ---------- */
        public Color DropShadowColor
        {
            get { return dropShadowColor; }
        }

        public bool DrawDropShadow
        {
            get { return drawDropShadow; }
        }

        public Color FaceColour_High
        {
            get { return faceColourHigh; }
        }

        public Color FaceColour_Low
        {
            get { return faceColourLow; }
        }

        public System.Drawing.Drawing2D.LinearGradientMode FaceGradient
        {
            get { return faceGradient; }
        }

        public Color RimColour_High
        {
            get { return rimColourHigh; }
        }

        public Color RimColour_Low
        {
            get { return rimColourLow; }
        }

        public System.Drawing.Drawing2D.LinearGradientMode RimGradient
        {
            get { return rimGradient; }
        }

        public Color FontColour
        {
            get { return fontColour; }
        }

        public Color HourHandColour
        {
            get { return hourHand; }
        }

        public Color MinuteHandColour
        {
            get { return minuteHand; }
        }

        public Color SecondHandColour
        {
            get { return secondHand; }
        }

        public AnalogClock.eTickStyle SecondTickStyle
        {
            get { return secondTickStyle; }
        }

        public Color DeadlineHandColour
        {
            get { return deadlineHand; }
        }

        public bool DrawHourHand
        {
            get { return drawHourHand; }
        }

        public bool DrawMinuteHand
        {
            get { return drawMinuteHand; }
        }

        public bool DrawSecondHand
        {
            get { return drawSecondHand; }
        }

        public bool DrawHourDropShadow
        {
            get { return drawHourShadow; }
        }

        public bool DrawMinuteDropShadow
        {
            get { return drawMinuteShadow; }
        }

        public bool DrawSecondDropShadow
        {
            get { return drawSecondShadow; }
        }

        public bool DrawDeadlineDropShadow
        {
            get { return drawDeadlineShadow; }
        }

        public Color HourDropShadowColour
        {
            get { return hourShadow; }
        }

        public Color MinuteDropShadowColour
        {
            get { return minuteShadow; }
        }

        public Color SecondDropShadowColour
        {
            get { return secondShadow; }
        }

        public Color DeadlineDropShadowColour
        {
            get { return deadlineShadow; }
        }



        #endregion
    }
}
