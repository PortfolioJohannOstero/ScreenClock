using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Screen_Clock.Data_Config
{
    [Serializable()]
    public class ColourScheme
    {
        Color mBack, mClock, mDeadline, mMinUntil, mOvertime;


        public ColourScheme(Color bgColour, Color clockColour, Color deadlineColour, Color minUntilColour, Color overtimeColour)
        {
            mBack = bgColour;
            mClock = clockColour;
            mDeadline = deadlineColour;
            mMinUntil = minUntilColour;
            mOvertime = overtimeColour;
        }

        public ColourScheme()
        {
            mBack = Color.Black;
            mClock = Color.White;
            mDeadline = Color.Gray;
            mMinUntil = Color.Red;
            mOvertime = Color.Orange;
        }

        #region Getters and setters
        public Color BackgroundColour
        {
            get { return mBack; }
            set { mBack = value; }
        }
        public Color ClockLabelColour
        {
            get { return mClock; }
            set { mClock = value; }
        }
        public Color DeadlineLabelColour
        {
            get { return mDeadline; }
            set { mDeadline = value; }
        }
        public Color MinutesUntilColour
        {
            get { return mMinUntil; }
            set { mMinUntil = value; }
        }
        public Color OvertimeColour
        {
            get { return mOvertime; }
            set { mOvertime = value; }
        }
        #endregion
    }
}
