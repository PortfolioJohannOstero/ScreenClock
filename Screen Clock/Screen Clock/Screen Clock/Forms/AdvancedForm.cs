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
    public partial class AdvancedForm : Form
    {
        /* Default properties */
        int maxRadioSelection = 0; // gets assigned a value in "populateDefaultClockType"
        RadioButton[] RadioSizeButtons;

        // Default Display Type holder
        int defaultDispType = 0;
        public int DefaultDisplayType
        {
            get { return defaultDispType; }
            set
            {
                if (defaultDispType >= (int)CLOCKTYPE.ESize || defaultDispType < 0)
                    defaultDispType = 0;
                else
                    defaultDispType = value;
            }
        }

        // Custom Size Holder
        const int minCustomSize = 150;
        int customSize = minCustomSize;   // minimum
        public int CustomSize
        {
            get { return customSize; }
            set 
            {
                if (customSize < minCustomSize)
                    customSize = minCustomSize;
                else
                    customSize = value;
            }
        }

        // Size Type Holder
        int sizeType = 0;
        public int SizeType
        {
            get { return sizeType; }
            set
            {
                sizeType = value;
            }
        }

        // Preset
        Data_Config.Preset preset;

        // analogLayout Form - preallocate
        AnalogLayoutForm analogLayoutForm;
        Data_Config.AnalogLayout analogLayout;
        Data_Config.AnalogLayout analogHolder;

        public Data_Config.AnalogLayout AnalogClockLayout
        {
            get { return analogLayout; }
        }

        public bool analogChangesApplied = false;

        // Colour Scheme ---------------
        Data_Config.ColourScheme digitalColour = new Data_Config.ColourScheme();
        public Data_Config.ColourScheme DigitalColours
        {
            get { return digitalColour; }
        }

        // Display Seconds -------------
        bool displaySeconds;
        public bool DisplaySeconds
        {
            get { return displaySeconds; }
        }

        public AdvancedForm(Data_Config.AnalogLayout layout, int currDefaultDisplayType, Data_Config.Preset currPreset)
        {
            analogLayout = layout;
            defaultDispType = currDefaultDisplayType;
            preset = currPreset;
            

            InitializeComponent();

            Microsoft.Win32.SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);

            // Collects all the radio buttons in the Size tab
            RadioSizeButtons = advTab.TabPages[(int)TAB.SIZE].Controls.OfType<RadioButton>().ToArray();

            label_currentScreenSize.Text = ": " + preset.Size;

            lbl_applyAnalogChanges.Hide();
        }

        // !check
        public void setAdvancedDefaults()
        {
            // Default
            cb_defaultClockType.SelectedIndex = DefaultDisplayType;
            cb_defaultDeadlineMin.Value = Data_Config.SavedConfigs.getDefaultMinDeadline();
            cDisplaySeconds.Checked = preset.DisplaySeconds;

            // Colours
            pb_bgColourPicker.BackColor = preset.DigitalColours.BackgroundColour;
            pb_clockColourPicker.BackColor = preset.DigitalColours.ClockLabelColour;
            pb_deadlineColourPicker.BackColor = preset.DigitalColours.DeadlineLabelColour;
            pb_deadlineClosingColourPicker.BackColor = preset.DigitalColours.MinutesUntilColour;
            pb_deadlineOvertimeColourPicker.BackColor = preset.DigitalColours.OvertimeColour;

            // Size
                // Size Type
            int st = preset.SizeType;
            for (int i = 0; i < RadioSizeButtons.Length; i++)
            {
                if (i == st)
                    RadioSizeButtons[i].Checked = true;
                else
                    RadioSizeButtons[i].Checked = false;
            }
                // Custom Size - Slider
            int sizeValue = preset.Size;
            if (sizeValue < tb_screenSize.Minimum)
                sizeValue = tb_screenSize.Minimum;
            else if (sizeValue > tb_screenSize.Maximum)
                sizeValue = tb_screenSize.Maximum;
            
            tb_screenSize.Value = sizeValue;

            // Monitor
            setMonitorComboBoxDefault();

        }

        // is separate, because of the change of the primary monitor can change place
        private void setMonitorComboBoxDefault()
        {
            if (!Data_Config.Monitor.isOnlyOneMonitor())
            {
                cb_monitorSelection.Enabled = true;

                if(cb_monitorSelection.Items.Count == 1)
                    cb_monitorSelection.SelectedIndex = 0;
                else
                    cb_monitorSelection.SelectedIndex = Data_Config.Monitor.MonitorIndex;

                label_singleMonitorWarning.Hide();
            }
            else
            {
                cb_monitorSelection.Enabled = false;
                label_singleMonitorWarning.Show();
            }
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

        /* ----------------- TAB POPULATIONS --------------- */
        public void populateDefaultClockType(string[] comboBoxItem)
        {
            // Display all the radioNames in the comboBox
            maxRadioSelection = comboBoxItem.Length;
            for (int i = 0; i < maxRadioSelection; i++)
                cb_defaultClockType.Items.Add(comboBoxItem[i]);
        }
        public void populateSizeTab()
        {
            tb_screenSize.Maximum = Screen.AllScreens[0].Bounds.Width;
            tb_screenSize.Minimum = 150; // test
        }

        public void populateMonitorTab()
        {
            Screen[] monitors = Data_Config.Monitor.AllButPrimaryMonitor();
            Screen primeMonitor = Data_Config.Monitor.PrimaryMonitor;

            for (int i = 0; i < monitors.Length; i++)
                cb_monitorSelection.Items.Add(monitors[i].DeviceName);

            label_currPrimaryMon.Text = primeMonitor.DeviceName;
        }

        public void updateCurrentDeadlineTime(string currDeadline)
        {
            label_deadlineCurrentTime.Text = currDeadline;
        }

        /* ------------------- EVENTS --------------------- */
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void applyBtn_Click(object sender, EventArgs e)
        {
            // Default tab:
                // Default Clock Type
            if (cb_defaultClockType.SelectedIndex != DefaultDisplayType)
                DefaultDisplayType = cb_defaultClockType.SelectedIndex;

                // Default minute time
            if (cb_defaultDeadlineMin.Value != Data_Config.SavedConfigs.getDefaultMinDeadline())
                Data_Config.SavedConfigs.setDefaultMinDeadline((int)cb_defaultDeadlineMin.Value);
               
                // Default Display Seconds
                displaySeconds = cDisplaySeconds.Checked;

            // Colour Tab:
                // Background Colour
            if (pb_bgColourPicker.BackColor != preset.DigitalColours.BackgroundColour)
                digitalColour.BackgroundColour = pb_bgColourPicker.BackColor;
                // Clock Colour
            if (pb_clockColourPicker.BackColor != preset.DigitalColours.ClockLabelColour)
                digitalColour.ClockLabelColour = pb_clockColourPicker.BackColor;
                // Deadline Colour
            if (pb_deadlineColourPicker.BackColor != preset.DigitalColours.DeadlineLabelColour)
                digitalColour.DeadlineLabelColour = pb_deadlineColourPicker.BackColor;
                // Deadline Closing Colour
            if (pb_deadlineClosingColourPicker.BackColor != preset.DigitalColours.MinutesUntilColour)
                digitalColour.MinutesUntilColour = pb_deadlineClosingColourPicker.BackColor;
                // Deadline Overtime Colour
            if (pb_deadlineOvertimeColourPicker.BackColor != preset.DigitalColours.OvertimeColour)
                digitalColour.OvertimeColour = pb_deadlineOvertimeColourPicker.BackColor;

            // Monitor Tab:
            if (cb_monitorSelection.SelectedIndex != Data_Config.Monitor.MonitorIndex)
                Data_Config.Monitor.MonitorIndex = cb_monitorSelection.SelectedIndex;

            // Size Tab
                // Size Type
            int numOfRadioBtn = RadioSizeButtons.Length;
            int sc = preset.SizeType;

            for (int i = 0; i < numOfRadioBtn; i++)
            {
                if (RadioSizeButtons[i].Checked)
                {
                    SizeType = i;
                    break;
                }
            }

            // Custom Size
            if (tb_screenSize.Value != CustomSize)
                CustomSize = tb_screenSize.Value;

            if (isAnalogLayoutApplied())
            {
                analogLayout = analogHolder;
                analogHolder = null;
            }
            else
                analogLayout = new Data_Config.AnalogLayout(new AnalogClock.AnalogClock());

            Data_Config.SavedConfigs.saveData();
        }

        // Setting Color Events:
        private void pb_bgColourPicker_Click(object sender, EventArgs e)
        {
            pb_bgColourPicker.BackColor = collectColour(pb_bgColourPicker.BackColor);
        }
        private void pb_clockColourPicker_Click(object sender, EventArgs e)
        {
            pb_clockColourPicker.BackColor = collectColour(pb_clockColourPicker.BackColor);
        }
        private void pb_deadlineColourPicker_Click(object sender, EventArgs e)
        {
            pb_deadlineColourPicker.BackColor = collectColour(pb_deadlineColourPicker.BackColor);
        }
        private void pb_deadlineClosingColourPicker_Click(object sender, EventArgs e)
        {
            pb_deadlineClosingColourPicker.BackColor = collectColour(pb_deadlineClosingColourPicker.BackColor);
        }
        private void pb_deadlineOvertimeColourPicker_Click(object sender, EventArgs e)
        {
            pb_deadlineOvertimeColourPicker.BackColor = collectColour(pb_deadlineOvertimeColourPicker.BackColor);
        }

        private void rCustomSize_CheckedChanged(object sender, EventArgs e)
        {
            tb_screenSize.Enabled = rCustomSize.Checked;
        }

        private void tb_screenSize_Scroll(object sender, EventArgs e)
        {
            label_currentScreenSize.Text = ": " + tb_screenSize.Value;
        }

        // Monitor Change event
        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            cb_monitorSelection.Items.Clear();
            populateMonitorTab();
            setMonitorComboBoxDefault();
        }


            // Analog Button events handling:
        private void btn_analogLayoutForm_Click(object sender, EventArgs e)
        {
            if (analogLayoutForm == null)
            {
                analogLayoutForm = new AnalogLayoutForm(analogLayout, preset.DigitalColours.MinutesUntilColour, preset.DigitalColours.OvertimeColour);
                analogLayoutForm.Show();

                analogLayoutForm.btn_apply.Click += new EventHandler(analogLayout_apply);
                analogLayoutForm.FormClosing += new FormClosingEventHandler(analogLayoutForm_closing);
            }
        }

        private void analogLayout_apply(object sender, EventArgs e)
        {
            if (!isAnalogLayoutApplied())
                lbl_applyAnalogChanges.Show();

            analogHolder = analogLayoutForm.CreatedAnalogLayout;
            analogLayoutForm.Close();
        }

        private void analogLayoutForm_closing(object sender, FormClosingEventArgs e)
        {
            analogLayoutForm.btn_apply.Click -= new EventHandler(analogLayout_apply);
            analogLayoutForm.FormClosing -= new FormClosingEventHandler(analogLayoutForm_closing);

            analogLayoutForm = null;
        }

        public bool isAnalogLayoutApplied()
        {
            return lbl_applyAnalogChanges.Visible;
        }

        public void resetAnalogLayoutAppliance()
        {
            lbl_applyAnalogChanges.Visible = false;
        }
    }
}
