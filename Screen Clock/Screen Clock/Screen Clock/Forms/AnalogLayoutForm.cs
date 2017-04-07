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
    public partial class AnalogLayoutForm : Form
    {
        System.Drawing.Drawing2D.LinearGradientMode[] listOfGradients = {
                                                                            System.Drawing.Drawing2D.LinearGradientMode.Horizontal,
                                                                            System.Drawing.Drawing2D.LinearGradientMode.Vertical,
                                                                            System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal,
                                                                            System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
                                                                        };

        bool startClock = false;
        Data_Config.AnalogLayout storedLayout;
        Color deadline_minUntilColour;
        Color deadline_overtime;

        TimeSpan deadlineTime;
        bool deadlineSetupisChanged = false;
        float minUntilValue;

        HelpForm helpForm;

        public AnalogLayoutForm(Data_Config.AnalogLayout layout, Color minUntil, Color overtime)
        {
            InitializeComponent();

            storedLayout = (layout != null) ? layout : new Data_Config.AnalogLayout(new AnalogClock.AnalogClock());

            deadline_minUntilColour = minUntil;
            deadline_overtime = overtime;

            settingDefaults();
            applyToDispClock();
            appliedChanges(false);

            deadlineTime = new TimeSpan(deadlineTimePicker.Value.Hour, deadlineTimePicker.Value.Minute, 0);
            analog_dispClock.DeadlineHourTime = deadlineTime.Hours;
            analog_dispClock.DeadlineMinuteTime = deadlineTime.Minutes;

            tAnalogDisplayClockTick.Start();
        }


        /* ----------------- Form Population ---------------*/
        public void settingDefaults()
        {
            // populate combo boxes
            populateGradientLists();

            // Drop Shadow Colour:
            btn_applyDropShadowColour.BackColor = storedLayout.DropShadowColor;
            cb_drawDropShadow.Checked = storedLayout.DrawDropShadow;
            
            // Face Colour
            btn_applyFaceColour_high.BackColor = storedLayout.FaceColour_High;
            btn_applyFaceColour_low.BackColor = storedLayout.FaceColour_Low;
            cb_applyFaceGradientMode.SelectedIndex = getCurrentIndex(cb_applyFaceGradientMode, storedLayout.FaceGradient.ToString());

    
            // Rim Colour
            btn_applyRimColour_high.BackColor = storedLayout.RimColour_High;
            btn_applyRimColour_low.BackColor = storedLayout.RimColour_Low;
            cb_applyRimGradientMode.SelectedIndex = getCurrentIndex(cb_applyRimGradientMode, storedLayout.RimGradient.ToString());


            // Font Colour
            btn_applyFontColour.BackColor = storedLayout.FontColour;

            // Hour - Minute - Second' Hand Colours
            btn_applyHourHandColour.BackColor = storedLayout.HourHandColour;
            btn_applyMinuteHandColour.BackColor = storedLayout.MinuteHandColour;
            btn_applySecondHandColour.BackColor = storedLayout.SecondHandColour;

            // Seconds Behavior
            switch (storedLayout.SecondTickStyle)
            {
                case AnalogClock.eTickStyle.Normal:
                    r_applyNormalTick.Checked = true;
                    r_applySmoothTick.Checked = false;
                    break;
                case AnalogClock.eTickStyle.Smooth:
                    r_applyNormalTick.Checked = false;
                    r_applySmoothTick.Checked = true;
                    break;
            }

            analog_dispClock.SecondHandTickStyle = storedLayout.SecondTickStyle;
            
            // Deadline colours
            btn_applyDeadlineColour.BackColor = storedLayout.DeadlineHandColour;

            // Draw
                // Hands
            cb_drawHourHand.Checked = storedLayout.DrawHourHand;
            cb_drawMinuteHand.Checked = storedLayout.DrawMinuteHand;
            cb_drawSecondHand.Checked = storedLayout.DrawSecondHand;

                // Shadows
            cb_drawHourDropShadow.Checked = storedLayout.DrawHourDropShadow;
            cb_drawMinuteDropShadow.Checked = storedLayout.DrawMinuteDropShadow;
            cb_drawSecondDropShadow.Checked = storedLayout.DrawSecondDropShadow;
            cb_drawDeadlineDropShadow.Checked = storedLayout.DrawDeadlineDropShadow;

            btn_applyHourDropShadowColour.BackColor = storedLayout.HourDropShadowColour;
            btn_applyMinuteDropShadowColour.BackColor = storedLayout.MinuteDropShadowColour;
            btn_applySecondDropShadowColour.BackColor = storedLayout.SecondDropShadowColour;
            btn_applyDeadlineDropShadowColour.BackColor = storedLayout.DeadlineDropShadowColour;
        }

        private void applyToDispClock()
        {
            analog_dispClock.DropShadowColor = storedLayout.DropShadowColor;
            analog_dispClock.DrawDropShadow = storedLayout.DrawDropShadow;

            // Face Colour
            analog_dispClock.FaceColorHigh = storedLayout.FaceColour_High;
            analog_dispClock.FaceColorLow = storedLayout.FaceColour_Low;
            analog_dispClock.FaceGradientMode = storedLayout.FaceGradient;


            // Rim Colour
            analog_dispClock.RimColorHigh = storedLayout.RimColour_High;
            analog_dispClock.RimColorLow = storedLayout.RimColour_Low;
            analog_dispClock.RimGradientMode = storedLayout.RimGradient;


            // Font Colour
            analog_dispClock.NumeralColor = storedLayout.FontColour;

            // Hour - Minute - Second' Hand Colours
            analog_dispClock.HourHandColor = storedLayout.HourHandColour;
            analog_dispClock.MinuteHandColor = storedLayout.MinuteHandColour;
            analog_dispClock.SecondHandColor = storedLayout.SecondHandColour;

            // Seconds Behavior
            analog_dispClock.SecondHandTickStyle = storedLayout.SecondTickStyle;

            // Deadline colours
            analog_dispClock.DeadlineHandColour = storedLayout.DeadlineHandColour;

            // Draw
                // Hands
            analog_dispClock.DrawHourHand = storedLayout.DrawHourHand;
            analog_dispClock.DrawMinuteHand = storedLayout.DrawMinuteHand;
            analog_dispClock.DrawSecondHand = storedLayout.DrawSecondHand;

            // Shadows
            analog_dispClock.DrawHourHandShadow = storedLayout.DrawHourDropShadow;
            analog_dispClock.DrawMinuteHandShadow = storedLayout.DrawMinuteDropShadow;
            analog_dispClock.DrawSecondHandShadow = storedLayout.DrawSecondDropShadow;
            analog_dispClock.DrawDeadlineHandShadow = storedLayout.DrawDeadlineDropShadow;

            analog_dispClock.HourHandDropShadowColor = storedLayout.HourDropShadowColour;
            analog_dispClock.MinuteHandDropShadowColor = storedLayout.MinuteDropShadowColour;
            analog_dispClock.SecondHandDropShadowColor = storedLayout.SecondDropShadowColour;
            analog_dispClock.DeadlineHandDropShadowColor = storedLayout.DeadlineDropShadowColour;
        }

        private void resetToDefaultLayout()
        {
            Data_Config.AnalogLayout canvas = new Data_Config.AnalogLayout(new AnalogClock.AnalogClock());

            storedLayout = canvas;

            btn_apply.Enabled = true;
        }
        private void populateGradientLists()
        {
            for (int i = 0; i < listOfGradients.Length; i++)
            {
                cb_applyFaceGradientMode.Items.Add(listOfGradients[i].ToString());
                cb_applyRimGradientMode.Items.Add(listOfGradients[i].ToString());
            }
        }

        private int getCurrentIndex(ComboBox listHolder, string value)
        {
            int i = 0;
            while (listHolder.Items[i].ToString() != value)
            {
                i++;
            }

            return i;
        }


        private void appliedChanges(bool change)
        {
            if (change)
                btn_apply.Enabled = true;
            else
                btn_apply.Enabled = false;
        }

        public Color collectColour(Color primaryColour)
        {
            ColorDialog colourSelector = new ColorDialog();
            colourSelector.AllowFullOpen = true;
            colourSelector.AnyColor = true;

            colourSelector.Color = primaryColour;

            colourSelector.ShowDialog();

            return colourSelector.Color;
        }


        /* --------------------- Accessors ------------------- */
        public Data_Config.AnalogLayout CreatedAnalogLayout
        {
            get { return storedLayout; }
        }

        /* ----------------------- EVENTS ------------------- */

        // Close event
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Settings Events


        // ---------- Drop Shadow Colour
        private void btn_applyDropShadowColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.DropShadowColor = collectColour(btn_applyDropShadowColour.BackColor);
            btn_applyDropShadowColour.BackColor = analog_dispClock.DropShadowColor;
            appliedChanges(true);
        }

        private void cb_drawDropShadow_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawDropShadow = cb_drawDropShadow.Checked;
            appliedChanges(true);
        }

        // -------------- Face Colour
        private void btn_applyFaceColour_high_Click(object sender, EventArgs e)
        {
            analog_dispClock.FaceColorHigh = collectColour(btn_applyFaceColour_high.BackColor);
            btn_applyFaceColour_high.BackColor = analog_dispClock.FaceColorHigh;
            appliedChanges(true);
        }

        private void btn_applyFaceColour_low_Click(object sender, EventArgs e)
        {
            analog_dispClock.FaceColorLow = collectColour(btn_applyFaceColour_low.BackColor);
            btn_applyFaceColour_low.BackColor = analog_dispClock.FaceColorLow;
            appliedChanges(true);
        }

        private void cb_applyFaceGradientMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            analog_dispClock.FaceGradientMode = listOfGradients[cb_applyFaceGradientMode.SelectedIndex];
            appliedChanges(true);
        }

        // ------------- Rim Colour
        private void btn_applyRimColour_high_Click(object sender, EventArgs e)
        {
            analog_dispClock.RimColorHigh = collectColour(btn_applyRimColour_high.BackColor);
            btn_applyRimColour_high.BackColor = analog_dispClock.RimColorHigh;
            appliedChanges(true);
        }

        private void btn_applyRimColour_low_Click(object sender, EventArgs e)
        {
            analog_dispClock.RimColorLow = collectColour(btn_applyRimColour_low.BackColor);
            btn_applyRimColour_low.BackColor = analog_dispClock.RimColorLow;
            appliedChanges(true);
        }

        private void cb_applyRimGradientMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            analog_dispClock.RimGradientMode = listOfGradients[cb_applyRimGradientMode.SelectedIndex];
            appliedChanges(true);
        }

        // ------------ Font Colour
        private void btn_applyFontColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.NumeralColor = collectColour(btn_applyFontColour.BackColor);
            btn_applyFontColour.BackColor = analog_dispClock.NumeralColor;

            appliedChanges(true);
        }

        // ---------------- Hour - Minute - Second' Hand Colours
        private void btn_applyHourHandColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.HourHandColor = collectColour(btn_applyHourHandColour.BackColor);
            btn_applyHourHandColour.BackColor = analog_dispClock.HourHandColor;

            appliedChanges(true);
        }

        private void btn_applyMinuteHandColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.MinuteHandColor = collectColour(btn_applyMinuteHandColour.BackColor);
            btn_applyMinuteHandColour.BackColor = analog_dispClock.MinuteHandColor;

            appliedChanges(true);
        }

        private void btn_applySecondHandColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.SecondHandColor = collectColour(btn_applySecondHandColour.BackColor);
            btn_applySecondHandColour.BackColor = analog_dispClock.SecondHandColor;

            appliedChanges(true);
        }


        // --------------- Seconds Behavior
        private void r_applyNormalTick_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.SecondHandTickStyle = AnalogClock.eTickStyle.Normal;
            appliedChanges(true);
        }

        private void r_applySmoothTick_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.SecondHandTickStyle = AnalogClock.eTickStyle.Smooth;
            appliedChanges(true);
        }

        // --------------------- Deadline Colours
        private void btn_applyDeadlineColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.DeadlineHandColour = collectColour(btn_applyDeadlineColour.BackColor);
            btn_applyDeadlineColour.BackColor = analog_dispClock.DeadlineHandColour;

            appliedChanges(true);
        }

        // -------------- Draw
            // Hands
        private void cb_drawHourHand_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawHourHand = cb_drawHourHand.Checked;
            appliedChanges(true);
        }

        private void cb_drawMinuteHand_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawMinuteHand = cb_drawMinuteHand.Checked;
            appliedChanges(true);
        }

        private void cb_drawSecondHand_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawSecondHand = cb_drawSecondHand.Checked;
            appliedChanges(true);
        }

            // Shadows
        private void cb_drawHourDropShadow_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawHourHandShadow = cb_drawHourDropShadow.Checked;
            appliedChanges(true);
        }

        private void cb_drawMinuteDropShadow_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawMinuteHandShadow = cb_drawMinuteDropShadow.Checked;
            appliedChanges(true);
        }

        private void cb_drawSecondDropShadow_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawSecondHandShadow = cb_drawSecondDropShadow.Checked;
            appliedChanges(true);
        }

        private void cb_drawDeadlineDropShadow_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawDeadlineHandShadow = cb_drawDeadlineDropShadow.Checked;
            appliedChanges(true);
        }

            // Shadow Colours
        private void btn_applyHourDropShadowColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.HourHandDropShadowColor = collectColour(btn_applyHourDropShadowColour.BackColor);
            btn_applyHourDropShadowColour.BackColor = analog_dispClock.HourHandDropShadowColor;
            appliedChanges(true);
        }

        private void btn_applyMinuteDropShadowColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.MinuteHandDropShadowColor = collectColour(btn_applyMinuteDropShadowColour.BackColor);
            btn_applyMinuteDropShadowColour.BackColor = analog_dispClock.MinuteHandDropShadowColor;
            appliedChanges(true);
        }

        private void btn_applySecondDropShadowColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.SecondHandDropShadowColor = collectColour(btn_applySecondDropShadowColour.BackColor);
            btn_applySecondDropShadowColour.BackColor = analog_dispClock.SecondHandDropShadowColor;
            appliedChanges(true);
        }

        private void btn_applyDeadlineDropShadowColour_Click(object sender, EventArgs e)
        {
            analog_dispClock.DeadlineHandDropShadowColor = collectColour(btn_applyDeadlineDropShadowColour.BackColor);
            btn_applyDeadlineDropShadowColour.BackColor = analog_dispClock.DeadlineHandDropShadowColor;
            appliedChanges(true);
        } 

        #endregion

        private void cDispDeadline_CheckedChanged(object sender, EventArgs e)
        {
            analog_dispClock.DrawDeadlineHand = cDispDeadline.Checked;

            deadlineTimePicker.Enabled = cDispDeadline.Checked;
            cChangeColourDeadline.Enabled = cDispDeadline.Checked;
            cCountOvertime.Enabled = cDispDeadline.Checked;
        }

        // Timer (Show the clock in action)
        private void tAnalogDisplayClockTick_Tick(object sender, EventArgs e)
        {
            analog_dispClock.Time = DateTime.Now;

            if(cDispDeadline.Checked)
            {
                float deadline = deadlineTime.Hours + (deadlineTime.Minutes / 60f);
                float current = DateTime.Now.Hour + (DateTime.Now.Minute / 60f);

                float minUntil = (minUntilValue / 60f);

                if (cChangeColourDeadline.Checked && ((current >= deadline - minUntil) && current < deadline))
                {
                        deadlineSetupisChanged = true;
                        analog_dispClock.DeadlineHandColour = deadline_minUntilColour;
                }
                else if (cCountOvertime.Checked && deadline < current)
                {
                    deadlineSetupisChanged = true;
                    analog_dispClock.DeadlineHandColour = deadline_overtime;
                }
                else
                    resetDeadlineColour();
            }
        }

        private void resetDeadlineColour()
        {
            if (deadlineSetupisChanged)
            {
                analog_dispClock.DeadlineHandColour = storedLayout.DeadlineHandColour;
                deadlineSetupisChanged = false;
            }
        }

        // Play and stop clock
        private void btn_playPauseClock_Click(object sender, EventArgs e)
        {
            if (startClock)
            {
                btn_playPauseClock.BackgroundImage = Screen_Clock.Properties.Resources.Pause_Button1;
                tAnalogDisplayClockTick.Start();
            }
            else
            {
                btn_playPauseClock.BackgroundImage = Screen_Clock.Properties.Resources.Play_Button1;
                tAnalogDisplayClockTick.Stop();
            }


            startClock = !startClock;
        }
        
        // Apply Button
        private void btn_apply_Click(object sender, EventArgs e)
        {
            storedLayout = new Data_Config.AnalogLayout(analog_dispClock);
        }


        // Reset Command
        private void btn_resetToDefault_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure that you wish to reset to the default layout?", "Reset to Default Layout", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                resetToDefaultLayout();
                settingDefaults(); 
                applyToDispClock();
            }
        }

        private void deadlineTimePicker_ValueChanged(object sender, EventArgs e)
        {
            analog_dispClock.DeadlineHourTime = deadlineTimePicker.Value.Hour;
            analog_dispClock.DeadlineMinuteTime = deadlineTimePicker.Value.Minute;

            deadlineTime = new TimeSpan(deadlineTimePicker.Value.Hour, deadlineTimePicker.Value.Minute, 0);
        }


        // Deadline properties
        private void cChangeColourDeadline_CheckedChanged(object sender, EventArgs e)
        {
            minUpDown.Enabled = cChangeColourDeadline.Checked;
        }

        private void minUpDown_ValueChanged(object sender, EventArgs e)
        {
            minUntilValue = (float)minUpDown.Value;
        }

        // Help Form
        private void help_btn_analogLayoutCustomization_Click(object sender, EventArgs e)
        {
            createHelpForm((int)constE.eHelpIndexes.AnalogLayoutCustomization);
        }

        private void createHelpForm(int listIndex)
        {
            if (helpForm == null)
            {
                helpForm = new HelpForm(listIndex);
                helpForm.Show();
                helpForm.FormClosing += new FormClosingEventHandler(helpForm_closing);
            }
        }

        private void helpForm_closing(object sender, FormClosingEventArgs e)
        {
            helpForm.FormClosing -= new FormClosingEventHandler(helpForm_closing);
            helpForm = null;
        }
        

    }
}
