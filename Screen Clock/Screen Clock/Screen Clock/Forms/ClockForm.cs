using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Clock.Forms
{
    public partial class ClockForm : Form
    {
        public static bool settingsChanged;
        private bool formIsHidden = true;

        // Colour buffer
        private Data_Config.ColourScheme digitalColour = new Data_Config.ColourScheme();

        // ClockType Properties
        private string timeFormat = "HH";
        private string ampm = "";
        private string seconds = "ss";
        private bool displaySeconds = false;

        // Deadline properties
        private bool displayDeadline = false;
        private bool changeDeadlineColour = false;
        private bool enableDeadlineOvertime = false;
        private DateTime deadlineValue;
        private string deadline_ampm = "";
        private int deadlineMinUntilValue;
        private Color baseDeadlineColour = Color.DarkGreen;

        // Monitor properties
        private int sizeType = 0;
        private int customSize = 0;
        private bool monitorIsChanged = false;
        private bool runOnce = true;

        // The ClockForm overlay (so that it is possible to drag the form around)
        ClockForm_overlay dragOverlayForm;

        public ClockForm()
        {
            InitializeComponent();

            dragOverlayForm = new ClockForm_overlay(this, false);
            dragOverlayForm.LocationChanged += overlayForm_LocationChanged;

            // Escape key event handling
            this.KeyPress += new KeyPressEventHandler(escapeKeyPressed);
            analogClock1.KeyPress += escapeKeyPressed;

            updateBaseDigitalColours();
            resizeForm();

            setClockType();
            stdFontResize();

            this.StartPosition = FormStartPosition.Manual;
            
            timer_clockTimer.Enabled = true;
        }

        // Default setups
        public void setClockType()
        {

            if (mainForm.clockTypeState[(int)CLOCKTYPE.E24hour])
            {
                if ((!clockLabel.Visible || !deadlineLabel.Visible))
                {
                    clockLabel.Show();
                    deadlineLabel.Show();
                }

                if (analogClock1.Visible)
                    analogClock1.Hide();


                timeFormat = "HH";
                ampm = "";
                deadline_ampm = "";
            }
            else if (mainForm.clockTypeState[(int)CLOCKTYPE.E12hour])
            {
                if ((!clockLabel.Visible || !deadlineLabel.Visible))
                {
                    clockLabel.Show();
                    deadlineLabel.Show();
                }

                if (analogClock1.Visible)
                    analogClock1.Hide();

                timeFormat = "hh";
                ampm = (DateTime.Now.Hour < 12) ? "am" : "pm";
                deadline_ampm = (deadlineValue.Hour < 12) ? "am" : "pm";
            }
            else if (mainForm.clockTypeState[(int)CLOCKTYPE.EAnalog])
            {
                if ((clockLabel.Visible || deadlineLabel.Visible))
                {
                    clockLabel.Hide();
                    deadlineLabel.Hide();
                }

                if(!analogClock1.Visible)
                    analogClock1.Show();
            }
        }


        // Screen and value updates
        public void resizeForm()
        {
            if (sizeType == (int)SIZETYPE.FULLSCREEN && !Data_Config.Monitor.isOnlyOneMonitor())
            {
                Data_Config.Monitor.IsFullScreen = true;

                this.WindowState = FormWindowState.Normal;
                this.Location = Screen.AllScreens[Data_Config.Monitor.MonitorIndex].WorkingArea.Location;
                this.WindowState = FormWindowState.Maximized;

                // TEMPORARY SOLUTION
                if (runOnce)
                {
                    this.Size = Screen.AllScreens[Data_Config.Monitor.MonitorIndex].Bounds.Size;
                    runOnce = false;
                }
            }
            else if (sizeType == (int)SIZETYPE.CUSTOMSIZE)
            {
                this.WindowState = FormWindowState.Normal;

                Data_Config.Monitor.IsFullScreen = false;
                this.SetBounds(this.Location.X, this.Location.Y, customSize, (int)(customSize / 1.5));

                this.Width = customSize;
                this.Height = (int)(customSize / 1.5);
            }
        }
        public void updateBaseDigitalColours()
        {
            this.BackColor = digitalColour.BackgroundColour;
            clockLabel.ForeColor = digitalColour.ClockLabelColour;
            deadlineLabel.ForeColor = digitalColour.DeadlineLabelColour;
        }
        private void resizeFont(Label label, int reductionSize, int yOffset, int xOffset)
        {
            int totalSize = ((this.Width+this.Height) / (label.Text.Length+3)) / reductionSize;

            label.AutoSize = true;

            label.Font = new Font(label.Font.FontFamily, totalSize+1);

            label.Left = (this.Width - label.Width)/2 + xOffset;
            label.Top = (this.Height - label.Height)/2 + yOffset;
        }

        private void resizeAnalogClock()
        {
            int size = this.Size.Height;

            analogClock1.Size = new Size(size, size);

            analogClock1.Left = (this.Size.Width - analogClock1.Width) / 2;
            analogClock1.Top = (this.Size.Height - analogClock1.Height) / 2;
        }

        public void stdFontResize()
        {

            if (!mainForm.clockTypeState[(int)CLOCKTYPE.EAnalog])
            {
                int deadlineYOffset = 0;
                if (displaySeconds)
                    deadlineYOffset = deadlineLabel.Height;
                else
                    deadlineYOffset = deadlineLabel.Height + deadlineLabel.Height / 6;

                resizeFont(deadlineLabel, 2, deadlineYOffset, 0);
                resizeFont(clockLabel, 1, 0, 0);
            }
            else
                resizeAnalogClock();
        }

        // Main form deadline checks
        public void setDisplayDeadlineState(bool state) { displayDeadline = state; }
        public void setChangeDeadlineColourState(bool state) { changeDeadlineColour = state; }
        public void setEnableDeadlineOvertimeState(bool state) { enableDeadlineOvertime = state; }
        public void setDeadlineValue(DateTime time) { deadlineValue = time; }

        public void setMinUntilValue(int time)
        {
            deadlineMinUntilValue = time;
        }

        public void setLocation(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        public void setCustomSize(int newSize)
        {
            customSize = newSize;
        }

        public void setSizeType(int newType)
        {
            sizeType = newType;
        }

        public void setColourScheme(Data_Config.ColourScheme cs)
        {
            digitalColour = cs;
            updateBaseDigitalColours();
        }

        public void setSecondState(bool state) 
        {
            seconds = (state) ? ":ss" : "";
            analogClock1.DrawSecondHand = state;
            analogClock1.DrawSecondHandShadow = state;

            displaySeconds = state;
        }

        // Sets the monitor status
        public void monitorSetupIsChanged()
        {
            monitorIsChanged = true;
        }

        public void applyNewAnalogLayout(Data_Config.AnalogLayout layout)
        {
            if(layout != null) {
                analogClock1.DropShadowColor = layout.DropShadowColor;
                analogClock1.DrawDropShadow = layout.DrawDropShadow;

                analogClock1.FaceColorHigh = layout.FaceColour_High;
                analogClock1.FaceColorLow = layout.FaceColour_Low;
                analogClock1.FaceGradientMode = layout.FaceGradient;

                analogClock1.RimColorHigh = layout.RimColour_High;
                analogClock1.RimColorLow = layout.RimColour_Low;
                analogClock1.RimGradientMode = layout.RimGradient;

                analogClock1.NumeralColor = layout.FontColour;

                analogClock1.HourHandColor = layout.HourHandColour;
                analogClock1.MinuteHandColor = layout.MinuteHandColour;
                analogClock1.SecondHandColor = layout.SecondHandColour;

                analogClock1.SecondHandTickStyle = layout.SecondTickStyle;

                analogClock1.DeadlineHandColour = layout.DeadlineHandColour;

                analogClock1.DrawHourHand = layout.DrawHourHand;
                analogClock1.DrawMinuteHand = layout.DrawMinuteHand;
                analogClock1.DrawSecondHand = layout.DrawSecondHand;

                analogClock1.DrawHourHandShadow = layout.DrawHourDropShadow;
                analogClock1.DrawMinuteHandShadow = layout.DrawMinuteDropShadow;
                analogClock1.DrawSecondHandShadow = layout.DrawSecondDropShadow;
                analogClock1.DrawDeadlineHandShadow = layout.DrawDeadlineDropShadow;

                analogClock1.HourHandDropShadowColor = layout.HourDropShadowColour;
                analogClock1.MinuteHandDropShadowColor = layout.MinuteDropShadowColour;
                analogClock1.SecondHandDropShadowColor = layout.SecondDropShadowColour;
                analogClock1.DeadlineHandDropShadowColor = layout.DeadlineDropShadowColour;


                baseDeadlineColour = layout.DeadlineHandColour;
            }
        }

        public void applyPreset(Data_Config.Preset newPreset)
        {
            sizeType = newPreset.SizeType;
            customSize = newPreset.Size;

            //applyNewAnalogLayout(newPreset.AnalogClockLayout);
            //setColourScheme(newPreset.DigitalColours);

            resizeForm();
        }

        // -------------------------------- Timer ---------------------------
        private void timer_clockTimer_Tick(object sender, EventArgs e)
        {
            #region Clock Display
            if (!mainForm.clockTypeState[(int)CLOCKTYPE.EAnalog])
            {
                clockLabel.Text = DateTime.Now.ToString(timeFormat + ":mm" + seconds) + ampm;   // Display The time
                deadlineLabel.Text = deadlineValue.ToString(timeFormat + ":mm") + deadline_ampm;  // Display the deadline timer
            }
            else
            {
                analogClock1.Time = DateTime.Now;

                analogClock1.DeadlineHourTime = deadlineValue.Hour;
                analogClock1.DeadlineMinuteTime = deadlineValue.Minute;
            }
            #endregion

            setClockType(); // Checks to see what clock type to display
            stdFontResize();

            /* -------------------------- Display Deadline ------------------------- */
            
            if (displayDeadline)
            {
                if (!mainForm.clockTypeState[(int)CLOCKTYPE.EAnalog])
                {
                    deadlineLabel.Show();
                    analogClock1.DrawDeadlineHand = false;
                }
                    
                else
                    analogClock1.DrawDeadlineHand = true;
                    

                float deadline = deadlineValue.Hour + (deadlineValue.Minute / 60f);
                float current = DateTime.Now.Hour + (DateTime.Now.Minute / 60f);

                float minUntil = (deadlineMinUntilValue / 60f);


                // Deadline Colouring
                #region Deadline Minutes until
                if (changeDeadlineColour && ((current >= deadline - minUntil) && current < deadline))
                    if (analogClock1.DrawDeadlineHand)
                        analogClock1.DeadlineHandColour = digitalColour.MinutesUntilColour;
                    else
                        deadlineLabel.ForeColor = digitalColour.MinutesUntilColour;
                #endregion
                #region Deadline Overtime Colour
                else if (enableDeadlineOvertime && deadline < current)
                    if (analogClock1.DrawDeadlineHand)
                        analogClock1.DeadlineHandColour = digitalColour.OvertimeColour;
                    else
                        deadlineLabel.ForeColor = digitalColour.OvertimeColour;
                #endregion
                #region - If Nothing macthes the previous
                else
                    if (analogClock1.DrawDeadlineHand)
                        analogClock1.DeadlineHandColour = digitalColour.DeadlineLabelColour;
                    else
                        deadlineLabel.ForeColor = digitalColour.DeadlineLabelColour;
                #endregion
            }
            else
            {
                if (!mainForm.clockTypeState[(int)CLOCKTYPE.EAnalog])
                    deadlineLabel.Hide();
                else
                    analogClock1.DrawDeadlineHand = false;
            }

            // Manages what monitor to display the clock on (in case of primary monitor change)
            if (monitorIsChanged)
            {
                monitorIsChanged = false;
                resizeForm();
            }

            if (Data_Config.Monitor.isOnlyOneMonitor() && sizeType != (int)SIZETYPE.CUSTOMSIZE)
            {
                this.Hide();
                formIsHidden = true;
            }
            else
                formIsHidden = false;
        }


        // Overlay form drag events
        private void overlayForm_LocationChanged(object sender, EventArgs e)
        {
            setLocation(dragOverlayForm.Location.X, dragOverlayForm.Location.Y);
        }


        private void escapeKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Hide();
        }

    }
}
