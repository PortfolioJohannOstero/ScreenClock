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
    partial class PresetSettingsForm : Form
    {
        Data_Config.PresetList mPresetList;
        bool indexSelected = false;
        popupForm popup;

        int x;
        int y;
        int sizeType;
        int customSize;
        int clockType;
        string presetTitle;
        AnalogLayout analogLayout;
        ColourScheme digitalColours;
        bool displaySeconds;

        HelpForm helpForm;

        public PresetSettingsForm(PresetList presets, int xLocation, int yLocation, int typeOfSize, int size, int radioIndex, AnalogLayout layout, ColourScheme clockColours, bool seconds)
        {
            InitializeComponent();

            mPresetList = presets;
            populatePresetView();

            
            x = xLocation;
            y = yLocation;
            sizeType = typeOfSize;
            customSize = size;

            clockType = radioIndex;

            analogLayout = layout;

            digitalColours = clockColours;

            displaySeconds = seconds;
        }

        private void populatePresetView()
        {
            lv_presetListView.Columns.Clear();
            lv_presetListView.Columns.Add("Saved Presets");
            lv_presetListView.Columns[0].Width = lv_presetListView.Width - 4;

            for (int i = 0; i < mPresetList.Size(); i++)
            {
                lv_presetListView.Items.Add(mPresetList[i].Name);

                // If the number of monitors required is not equal to how many there currently are
                if (mPresetList[i].MonitorNum != Monitor.AllMonitors.Length)
                    lv_presetListView.Items[i].BackColor = Color.PaleVioletRed;
            }

            lv_presetListView.Items[0].BackColor = Color.LimeGreen;
        }

        public PresetList getPresetList()
        {
            return mPresetList;
        }


        /* ------------------- EVENTS ---------------- */
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getListViewIndex()
        {
            /*
             * http://social.msdn.microsoft.com/Forums/en-US/1f466a28-7db2-42f8-aeb5-3d604bd390c8/getting-the-text-from-the-selected-listview-item
             */

            if (lv_presetListView.SelectedItems.Count > 0)
                return lv_presetListView.SelectedItems[0].Index;

            return 0;
        }

        private void lv_presetListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexSelected = true;

            // Display information on right side
            int i = getListViewIndex();

            if (mPresetList[i].MonitorNum != Monitor.AllMonitors.Length)
            {
                label_numOfMon.ForeColor = Color.White;
                label_numOfMon.BackColor = Color.Red;
            }
            else
            {
                label_numOfMon.ForeColor = Color.Black;
                label_numOfMon.BackColor = Color.Transparent;
            }
            label_numOfMon.Text = mPresetList[i].MonitorNum.ToString();     // monitor

            if (mPresetList[i].SizeType == (int)SIZETYPE.FULLSCREEN)        // size type
                label_sizeType.Text = "Full Screen";
            else
                label_sizeType.Text = "Custom Size";

            label_location.Text = "x: " + mPresetList[i].LocationX + "\ny: " + mPresetList[i].LocationY;    // location

            label_windowSize.Text = mPresetList[i].Size.ToString();     //form size

            switch (mPresetList[i].ClockType)
            {
                case (int)CLOCKTYPE.E12hour:
                    label_clockType.Text = "am/pm";
                    break;
                case (int)CLOCKTYPE.E24hour:
                    label_clockType.Text = "24h";
                    break;
                case (int)CLOCKTYPE.EAnalog:
                    label_clockType.Text = "Analog";
                    break;
            }

            pb_bgColour.BackColor = mPresetList[i].DigitalColours.BackgroundColour;
            pb_clockColour.BackColor = mPresetList[i].DigitalColours.ClockLabelColour;
            pb_deadlineColour.BackColor = mPresetList[i].DigitalColours.DeadlineLabelColour;
            pb_minUntilColour.BackColor = mPresetList[i].DigitalColours.MinutesUntilColour;
            pb_overtimeColour.BackColor = mPresetList[i].DigitalColours.OvertimeColour;

            label_displaySeconds.Text = mPresetList[i].DisplaySeconds.ToString();

            btn_edit.Enabled = getListViewIndex() != 0;
        }

        // Buttons
        private void btn_up_Click(object sender, EventArgs e)
        {
            if (indexSelected && mPresetList.Size() > 2)
            {
                int i = getListViewIndex();

                if (i - 1 > 0)
                {
                    Preset temp = mPresetList[i - 1];
                    mPresetList[i - 1] = mPresetList[i];
                    mPresetList[i] = temp;


                    lv_presetListView.Items.Clear();
                    populatePresetView();
                }
            }
            indexSelected = false;
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (indexSelected && mPresetList.Size() > 2)
            {
                int i = getListViewIndex();

                if (i + 1 < mPresetList.Size() && i != 0)
                {
                    Preset temp = mPresetList[i + 1];
                    mPresetList[i + 1] = mPresetList[i];
                    mPresetList[i] = temp;


                    lv_presetListView.Items.Clear();
                    populatePresetView();
                }

            }
            
            indexSelected = false;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (indexSelected)
            {
                int i = getListViewIndex();

                if (i != 0)
                {
                    DialogResult dr = MessageBox.Show("Are you sure that you wish to delete: " + mPresetList[i].Name + "?", "Remove Preset", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        mPresetList.removePresetAtIndex(i);
                        lv_presetListView.Clear();
                        populatePresetView();
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (popup == null)
            {
                popup = new popupForm();
                popup.Text = "Create New Preset";
                popup.btn_create.Click += new EventHandler(popup_presetCreate);
                popup.FormClosing += new FormClosingEventHandler(popupCreate_closed);

                popup.Location = this.Location;
                popup.Show();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (popup == null)
            {
                popup = new popupForm();
                popup.Text = "Edit Preset Name";
                popup.btn_create.Text = "Rename";
                popup.tb_name.Text = mPresetList[getListViewIndex()].Name;
                popup.btn_create.Click += new EventHandler(popup_presetEdit);
                popup.FormClosing += new FormClosingEventHandler(popupEdit_closed);

                popup.Location = this.Location;
                popup.Show();
            }
        }

        private void popup_presetCreate(object sender, EventArgs e)
        {

            mPresetList.addPreset(Data_Config.Monitor.AllMonitors.Length,
                                  sizeType,
                                  x, y,
                                  customSize,
                                  clockType,
                                  presetTitle,
                                  analogLayout,
                                  digitalColours,
                                  displaySeconds);

            lv_presetListView.Clear();
            populatePresetView();
        }
        private void popup_presetEdit(object sender, EventArgs e)
        {
            mPresetList[getListViewIndex()].Name = presetTitle;
            lv_presetListView.Clear();
            populatePresetView();
        }

        private void popupCreate_closed(object sender, EventArgs e)
        {
            presetTitle = popup.PresetTitle;
            popup.btn_create.Click -= new EventHandler(popup_presetCreate);
            popup.FormClosing -= new FormClosingEventHandler(popupCreate_closed);
            popup = null;
        }
        private void popupEdit_closed(object sender, EventArgs e)
        {
            presetTitle = popup.PresetTitle;
            popup.btn_create.Click -= new EventHandler(popup_presetEdit);
            popup.FormClosing -= new FormClosingEventHandler(popupEdit_closed);
            popup = null;
        }

        // Help button
        private void help_btn_presetSettings_Click(object sender, EventArgs e)
        {
            createHelpForm((int)constE.eHelpIndexes.PresetSettings);
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
