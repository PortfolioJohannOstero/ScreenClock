/*
 * Serialize Source:
 * http://www.codeproject.com/Articles/1789/Object-Serialization-using-C
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

// Used for serializing code (in our case, into binary)
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Screen_Clock.Data_Config
{
    [Serializable()]
    public class Preset : ISerializable
    {
        /*
         * 
         * - Presets - Parameters:
         * 1. Number of Monitors
         * 2. Size Type 
         *      a. X Location
         *      b. Y Location
         *      c. Width
         *      d. Height
         * 3. Clock Type
         * 4. Name
         * 5. Digital Colours (labels and backgrounds)
         * 6. Analog Layout (The layout for the analog clock)
         * 7. Display Seconds
         * 
         */

        int mMonitorNum;
        int mSizeType;
        int mLocation_x;
        int mLocation_y;
        int mSize;
        int mClockType;
        string mName;
        ColourScheme mDigitalColours;
        AnalogLayout mAnalogLayout;
        bool mDisplaySeconds;

        /* ------------------------ Constructor ------------------------ */
        public Preset(int monitorNum, int sizeType, int loc_x, int loc_y, int size, int clockType, string name, AnalogLayout layout, ColourScheme digitalColours, bool displaySeconds)
        {
            mMonitorNum = monitorNum;

            mSizeType = sizeType;
            mLocation_x = loc_x;
            mLocation_y = loc_y;
            mSize = size;
            
            mClockType = clockType;
            
            mName = name;

            mAnalogLayout = layout;

            mDigitalColours = digitalColours;

            mDisplaySeconds = displaySeconds;
        }

        public Preset()
        {
            mMonitorNum = 1;
            mSizeType = (int)SIZETYPE.CUSTOMSIZE;
            mLocation_x = 0;
            mLocation_y = 0;
            mSize = 300;
            mClockType = (int)CLOCKTYPE.E24hour;
            mName = "Undefined - Default";

            mAnalogLayout = new AnalogLayout(new AnalogClock.AnalogClock());
            mDigitalColours = new ColourScheme();

            mDisplaySeconds = false;
        }


        /* ----------------------- Serialization ------------------------ */
              /* Saving and Loading data (Serialize and Deserialize) */

        // Load (special constructor) :
        public Preset(SerializationInfo info, StreamingContext ctxt)
        {
            mMonitorNum = (int)info.GetValue("monitorNum", typeof(int));
            mSizeType = (int)info.GetValue("sizeType", typeof(int));
            mLocation_x = (int)info.GetValue("loc_x", typeof(int));
            mLocation_y = (int)info.GetValue("loc_y", typeof(int));
            mSize = (int)info.GetValue("size", typeof(int));
            mClockType = (int)info.GetValue("clockType", typeof(int));
            mName = (string)info.GetValue("name", typeof(string));
            mAnalogLayout = (AnalogLayout)info.GetValue("analog", typeof(AnalogLayout));
            mDigitalColours = (ColourScheme)info.GetValue("colourScheme", typeof(ColourScheme));
            mDisplaySeconds = (bool)info.GetValue("displaySeconds", typeof(bool));
        }

        // Save:
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("monitorNum", mMonitorNum);
            info.AddValue("sizeType", mSizeType);
            info.AddValue("loc_x", mLocation_x);
            info.AddValue("loc_y", mLocation_y);
            info.AddValue("size", mSize);
            info.AddValue("clockType", mClockType);
            info.AddValue("name", mName);
            info.AddValue("analog", mAnalogLayout);
            info.AddValue("colourScheme", mDigitalColours);
            info.AddValue("displaySeconds", mDisplaySeconds);
        }


        /* ------------------------ Accessors (+ one Setter) ------------------------ */
        public int MonitorNum
        {
            get { return mMonitorNum; }
        }
        public int SizeType
        {
            get { return mSizeType; }
        }
        public int LocationX
        {
            get { return mLocation_x; }
        }
        public int LocationY
        {
            get { return mLocation_y; }
        }
        public int Size
        {
            get { return mSize; }
        }
        public int ClockType
        {
            get { return mClockType; }
            set { mClockType = value; }
        }
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public AnalogLayout AnalogClockLayout
        {
            get { return mAnalogLayout; }
        }
        public ColourScheme DigitalColours
        {
            get { return mDigitalColours; }
        }
        public bool DisplaySeconds
        {
            get { return mDisplaySeconds; }
        }

    }
}
