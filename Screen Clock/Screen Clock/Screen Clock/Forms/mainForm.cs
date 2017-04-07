using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Screen_Clock.Data_Config;

namespace Screen_Clock.Forms
{

    public partial class mainForm : Form
    {
        // Allocate the ClockForm
        ClockForm clockForm;
        private bool clockToggled = false;

        // Advanced Settings - multiple form init restricted
        public static bool allowCreationOfAdvForm = true;

        public static bool[] clockTypeState = new bool[(int)CLOCKTYPE.ESize];
        public static int deadlineMinUntilValue = 0;

        // Radio button control
        RadioButton[] radioList;
        string deadlineTimeFormat = "HH";
        int radioIndex = 0;

        // Preset List Allocation
        Data_Config.PresetList presetList;
        int presetIndex = 0;

        // popup form allocation
        popupForm popup;
        string presetTitle;

        AnalogLayout storedAnalogLayout;

        // stored Adv option values
        int customSize = 0;
        int sizeType = 0;
        ColourScheme digitalColours;
        bool displaySeconds;

        // Preallocated forms
        AdvancedForm advForm;
        PresetSettingsForm presetForm;
        HelpForm helpForm;

        
        private string[] getAllRadioNames()
        {
            
            string[] radioName = new string[radioList.Length];

            for (int i = 0; i < radioList.Length; i++)
                radioName[i] = radioList[i].Text;

            return radioName;
        }
        
        private void assignGlobalRadioState(int index)
        {
            deadlineTimeFormat = "";
            for (int i = 0; i < radioList.Length; i++)
                clockTypeState[i] = (i == index) ? true : false;

            switch (index)
            {
                case (int)CLOCKTYPE.E24hour:
                case (int)CLOCKTYPE.EAnalog:
                    deadlineTimeFormat = "HH";
                    break;
                case (int)CLOCKTYPE.E12hour:
                    deadlineTimeFormat = "hh";
                    break;
            }
            deadlineTimeFormat += ":mm";

            radioIndex = index;
        }
        
        public mainForm()
        {
            InitializeComponent();
            Data_Config.SavedConfigs.updateConfigs();

            Microsoft.Win32.SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
            Data_Config.Monitor.update();


            // Preset Management
            presetList = new Data_Config.PresetList("presetData.bplist");
            presetList.readFromFile();

            presetIndex = SavedConfigs.getPresetIndex(presetList.Size());

                // sets the default preset
            setDefaultPreset();

            btn_presetRemove.Enabled = false;


            // Collects the number of radio buttons ( for layout purposes and for collecting data for the ClockForm )
            radioList = gb_displayType.Controls.OfType<RadioButton>().ToArray();

            // Sets up the Default layout of the mainForm
            setFormDefaults();

            // Initiate the clock form
            clockForm = new ClockForm();
            clockForm.setSecondState(presetList[presetIndex].DisplaySeconds);
            clockForm.setDeadlineValue(deadlineTimePicker.Value);
            clockForm.setMinUntilValue((int)minUpDown.Value);
            deadlineMinUntilValue = Data_Config.SavedConfigs.getDefaultMinDeadline();
            clockForm.applyPreset(presetList[presetIndex]);

            cb_presetSelection.SelectedIndex = presetIndex;

            cb_alwaysOnTopBtn.Checked = SavedConfigs.getDefaultTopStatus();
            setAlwaysOnTopButtonColour(cb_alwaysOnTopBtn.Checked);
            
        }

        /* -------------- Layout setup -------------- */    
        private void setFormDefaults()
        {
            setDefaultRadioButton();
            setDeadlineMinutes();
            assignGlobalRadioState(presetList[presetIndex].ClockType);

            setPresetListDefaults();

            label_ampm.Hide();
        }
        
        private void setDefaultRadioButton()
        {
            for (int i = 0; i < radioList.Length; i++)
            {
                if (i == presetList[presetIndex].ClockType)
                    radioList[i].Checked = true;
                else
                    radioList[i].Checked = false;
            }
        }
        
        private void setRadioButton(int index)
        {
            switch (index)
            {
                case (int)CLOCKTYPE.E24hour:
                    rDispType_24h.Checked = true;
                    rDispType_12ampm.Checked = false;
                    rDispType_analog.Checked = false;
                    break;
                case (int)CLOCKTYPE.E12hour:
                    rDispType_24h.Checked = false;
                    rDispType_12ampm.Checked = true;
                    rDispType_analog.Checked = false;
                    break;
                default:
                    rDispType_24h.Checked = false;
                    rDispType_12ampm.Checked = false;
                    rDispType_analog.Checked = true;
                    break;
            }
        }
        
        private void setDeadlineMinutes()
        {
            minUpDown.Value = Data_Config.SavedConfigs.getDefaultMinDeadline();
        }
        
        private string getCurrentAmPmState()
        {
            return (deadlineTimePicker.Value.Hour < 12) ? "am" : "pm";
        }
        
        private void assignDeadlineTimeFormat()
        {
            deadlineTimePicker.CustomFormat = deadlineTimeFormat;
        }
        
        private void setPresetListDefaults()
        {
            cb_presetSelection.Items.Clear();
            cb_presetSelection.SelectedIndex = -1;

            for (int i = 0; i < presetList.Size(); i++)
            {
                string name = "";
                if (presetList[i].MonitorNum < Monitor.AllMonitors.Length)
                    name += "//Monitor < 1: ";
                else if (presetList[i].MonitorNum > Monitor.AllMonitors.Length)
                    name += "//Monitor > 1: ";

                name += presetList[i].Name;

                cb_presetSelection.Items.Add(name);
            }
        }
        
        private void setDefaultPreset()
        {
            Preset defaultPreset;
            if (Monitor.isOnlyOneMonitor())
                defaultPreset = new Preset(1, (int)SIZETYPE.CUSTOMSIZE, 0, 0, 300, (int)CLOCKTYPE.E24hour, "Default - One Monitor", new AnalogLayout(new AnalogClock.AnalogClock()), new ColourScheme(), false);
            else
                defaultPreset = new Preset(Data_Config.Monitor.AllMonitors.Length, (int)SIZETYPE.FULLSCREEN, 0, 0, 0, (int)CLOCKTYPE.E24hour, "Default - Multiple Monitors", new AnalogLayout(new AnalogClock.AnalogClock()), new ColourScheme(), false);

            presetList[0] = defaultPreset;
            customSize = defaultPreset.Size;
            sizeType = defaultPreset.SizeType;
            digitalColours = defaultPreset.DigitalColours;
            displaySeconds = defaultPreset.DisplaySeconds;
        }

        /* --------------- EVENTS ---------------- */
        #region Advanced Form   
        private void advanced_btn_Click(object sender, EventArgs e)
        {
            if (advForm == null)
            {
                advForm = new AdvancedForm(storedAnalogLayout, presetList[0].ClockType, presetList[presetIndex]);
                advForm.TopMost = true;

                // Populate the settings
                advForm.populateDefaultClockType(getAllRadioNames());
                advForm.updateCurrentDeadlineTime(deadlineTimePicker.Value.ToString(deadlineTimePicker.CustomFormat));
                advForm.populateMonitorTab();
                advForm.populateSizeTab();
                // Sets the defaults
                advForm.setAdvancedDefaults();
                advForm.Show();

                advForm.applyBtn.Click += new EventHandler(advancedOptions_applied);
                advForm.FormClosing += new FormClosingEventHandler(advancedForm_formClosing);
            }
        }

            // Triggers if the apply button is hit  
        private void advancedOptions_applied(object sender, EventArgs e)
        {
            //  Sets the default preset clock type
            presetList[0].ClockType = advForm.DefaultDisplayType;
            presetList.saveToFile();

            // Store values
            customSize = advForm.CustomSize;
            sizeType = advForm.SizeType;
            displaySeconds = advForm.DisplaySeconds;

            // Main Form settings
            setDefaultRadioButton();
            setDeadlineMinutes();

            digitalColours = (advForm.DigitalColours != null) ? advForm.DigitalColours : new ColourScheme();

            if (advForm.isAnalogLayoutApplied())
            {
                if (advForm.AnalogClockLayout != null)
                    storedAnalogLayout = advForm.AnalogClockLayout;
                else
                    storedAnalogLayout = new AnalogLayout(new AnalogClock.AnalogClock());
            }

            // Clock form settings
            clockForm.setSizeType(sizeType);
            clockForm.setCustomSize(customSize);
            clockForm.setColourScheme(digitalColours);
            clockForm.setSecondState(displaySeconds);
            clockForm.resizeForm();

            if(storedAnalogLayout != null)
                clockForm.applyNewAnalogLayout(storedAnalogLayout);

            advForm.resetAnalogLayoutAppliance();
        }
        
        private void advancedForm_formClosing(object sender, FormClosingEventArgs e)
        {
            advForm.applyBtn.Click -= new EventHandler(advancedOptions_applied);
            advForm.FormClosing -= new FormClosingEventHandler(advancedForm_formClosing);

            advForm = null;
        }
        #endregion
        // Clock events
        private void clock_btn_Click(object sender, EventArgs e)
        {
            if (!(Data_Config.Monitor.isOnlyOneMonitor()) || sizeType == (int)SIZETYPE.CUSTOMSIZE)
            {
                clockToggled = !clockToggled;

                if (clockToggled)
                {
                    clock_btn.BackColor = Color.Red;
                    clock_btn.Text = "Stop Clock";
                    clockForm.Show();
                }
                else
                {
                    clock_btn.BackColor = Color.Orange;
                    clock_btn.Text = "Show Clock";
                    clockForm.Hide();
                }
            }
            else
            {
                clock_btn.BackColor = Color.Gray;
                clock_btn.Text = "No external monitor was found! \n please plug one in or set the size to Custom Size";
                clockToggled = false;
            }
        }

            // Radio button management  
        private void rDispType_24h_CheckedChanged(object sender, EventArgs e)
        {
            assignGlobalRadioState((int)CLOCKTYPE.E24hour);
            assignDeadlineTimeFormat();
            label_ampm.Hide();
        }
        private void rDispType_12ampm_CheckedChanged(object sender, EventArgs e)
        {
            assignGlobalRadioState((int)CLOCKTYPE.E12hour);

            label_ampm.Text = getCurrentAmPmState();
            assignDeadlineTimeFormat();
            label_ampm.Show();
        }
        private void rDispType_analog_CheckedChanged(object sender, EventArgs e)
        {
            assignGlobalRadioState((int)CLOCKTYPE.EAnalog);
            assignDeadlineTimeFormat();
            label_ampm.Hide();
        }


            // Deadline Checks  
        private void cChangeColourDeadline_CheckedChanged(object sender, EventArgs e)
        {
            minUpDown.Enabled = cChangeColourDeadline.Checked;
            clockForm.setChangeDeadlineColourState(cChangeColourDeadline.Checked);
        }
        private void cCountOvertime_CheckedChanged(object sender, EventArgs e)
        {
            clockForm.setEnableDeadlineOvertimeState(cCountOvertime.Checked);
        }
        private void cDispDeadline_CheckedChanged(object sender, EventArgs e)
        {
            clockForm.setDisplayDeadlineState(cDispDeadline.Checked);
        }

        private void deadlineTimePicker_ValueChanged(object sender, EventArgs e)
        {
            label_ampm.Text = getCurrentAmPmState();
            clockForm.setDeadlineValue(deadlineTimePicker.Value);
        }

        private void minUpDown_ValueChanged(object sender, EventArgs e)
        {
            deadlineMinUntilValue = (int)minUpDown.Value;

            if (clockForm != null)
                clockForm.setMinUntilValue(deadlineMinUntilValue);
        }


            // Monitor Change event 
        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            Monitor.update();
            
            setDefaultPreset();
            setPresetListDefaults();

            clockForm.monitorSetupIsChanged();

            cb_presetSelection.SelectedIndex = 0;

        }

            // Preset Events    
        private void btn_presetAdd_Click(object sender, EventArgs e)
        {
            if (popup == null)
            {
                popup = new popupForm();
                popup.Text = "Create New Preset";
                popup.btn_create.Click += new EventHandler(popup_presetCreate);
                popup.FormClosing += new FormClosingEventHandler(popup_closed);

                popup.Location = this.Location;
                popup.Show();
            }
        }

        private void popup_presetCreate(object sender, EventArgs e)
        {
            presetList.addPreset(Data_Config.Monitor.AllMonitors.Length, 
                                 sizeType,
                                 clockForm.Location.X, clockForm.Location.Y,
                                 customSize, 
                                 radioIndex,
                                 presetTitle,
                                 storedAnalogLayout,
                                 digitalColours,
                                 displaySeconds);

            setPresetListDefaults();
            cb_presetSelection.SelectedIndex = cb_presetSelection.Items.Count-1;
        }

        private void popup_closed(object sender, EventArgs e)
        {
            presetTitle = popup.PresetTitle;
            resetPopupForm();
        }

        private void resetPopupForm() 
        {
            popup.btn_create.Click -= new EventHandler(popup_presetCreate);
            popup.FormClosing -= new FormClosingEventHandler(popup_closed);
            popup = null;
        }

        private void btn_presetRemove_Click(object sender, EventArgs e)
        {
                // First make sure that the selected index isn't the Default one and that there is more than one in the combobox
            if (cb_presetSelection.SelectedIndex != 0 && presetList.Size() != 1)
            {
                // YES NO Dialog box to determined if it will be deleted or not
                DialogResult dr = MessageBox.Show("Are you sure that you wish to delete: " + presetList[cb_presetSelection.SelectedIndex].Name + "?", "Remove Preset", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    int temp = cb_presetSelection.SelectedIndex > 0 ? cb_presetSelection.SelectedIndex - 1 : 0;

                    presetList.removePresetAtIndex(cb_presetSelection.SelectedIndex);
                    setPresetListDefaults();
                    cb_presetSelection.SelectedIndex = temp;
                }
            }
            
        }

        private void btn_presetSettings_Click(object sender, EventArgs e)
        {
            if (presetForm == null)
            {
                presetForm = new PresetSettingsForm(presetList, clockForm.Location.X, clockForm.Location.Y, sizeType, customSize, radioIndex, storedAnalogLayout, digitalColours, displaySeconds);
                presetForm.FormClosing += new FormClosingEventHandler(presetForm_closed);
                presetForm.Show();
            }
        }

        private void presetForm_closed(object sender, EventArgs e)
        {
            presetList = presetForm.getPresetList();
            presetForm.FormClosing -= new FormClosingEventHandler(presetForm_closed);
            presetForm = null;

            setPresetListDefaults();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            presetList.saveToFile();

            SavedConfigs.saveData();
        }

        private void cb_presetSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_presetRemove.Enabled = true;

            presetIndex = cb_presetSelection.SelectedIndex;
            clockForm.applyPreset(presetList[presetIndex]);     // Size type, customSize

            sizeType = presetList[presetIndex].SizeType;
            customSize = presetList[presetIndex].Size;

            clockForm.setSecondState(presetList[presetIndex].DisplaySeconds);
            clockForm.setLocation(presetList[presetIndex].LocationX, presetList[presetIndex].LocationY);    // Location


            assignGlobalRadioState(presetList[presetIndex].ClockType);    // clock type

            clockForm.monitorSetupIsChanged();

            clockForm.applyNewAnalogLayout(presetList[presetIndex].AnalogClockLayout);
            storedAnalogLayout = presetList[presetIndex].AnalogClockLayout;

            setRadioButton(presetList[presetIndex].ClockType);

            clockForm.setColourScheme(presetList[presetIndex].DigitalColours);
            digitalColours = presetList[presetIndex].DigitalColours;

            Data_Config.SavedConfigs.setPresetIndex(presetIndex, presetList.Size()-1);
            Data_Config.SavedConfigs.saveData();
        }


        // Help Form
        private void help_btn_dispType_Click(object sender, EventArgs e)
        {
            createHelpForm((int)constE.eHelpIndexes.DisplayType);
        }

        private void help_btn_dispDeadline_Click(object sender, EventArgs e)
        {
            createHelpForm((int)constE.eHelpIndexes.DisplayDeadline);
        }

        private void help_btn_advancedOptions_Click(object sender, EventArgs e)
        {
            createHelpForm((int)constE.eHelpIndexes.AdvancedOptions);
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

        private void cb_alwaysOnTopBtn_CheckedChanged(object sender, EventArgs e)
        {
            setAlwaysOnTopButtonColour(cb_alwaysOnTopBtn.Checked);


            clockForm.TopMost = cb_alwaysOnTopBtn.Checked;

            SavedConfigs.setDefaulTopStatus(cb_alwaysOnTopBtn.Checked);
        }

        private void setAlwaysOnTopButtonColour(bool state)
        {
            cb_alwaysOnTopBtn.BackColor = (cb_alwaysOnTopBtn.Checked) ? Color.Gray : Color.DarkGray;
        }

        
    }
}
