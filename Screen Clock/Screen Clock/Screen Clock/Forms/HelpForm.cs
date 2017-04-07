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
    public partial class HelpForm : Form
    {
        public static int listID = 0;
        
        private string root = "Help";
        private System.IO.DirectoryInfo[] languages;
        private int languageID = 0;

        private string presetTitle = "Description - ";


        public HelpForm(int test)
        {
            listID = test;
            InitializeComponent();

            chooseLanguage();
            populateLanguageBox();
            loadHelpFile(listID);
            setStartupListValue();
        }

        private void chooseLanguage()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(root);
            languages = dir.GetDirectories();
        }

        private void populateLanguageBox()
        {
            lbl_error.Visible = languages.Length < 1;
            if (languages.Length < 1)
                return;

            for(int i = 0; i < languages.Length; i++) 
            {
                cb_languages.Items.Add(languages[i].Name);
                cb_languages.SelectedIndex = 0;
            }
        }

        private void loadHelpFile(int index)
        {
            try
            {
                rtb_helpContent.LoadFile("Help/" + languages[languageID].Name + "/" + index.ToString() + ".rtf");
            }
            catch(Exception e)
            {
                rtb_helpContent.ForeColor = Color.Red;
                rtb_helpContent.Text = e.Message;
            }
        }

        // Sets the initial start value of the list (based on where the help button was clicked)
        private void setStartupListValue()
        {
            if (listID < 0)
                listID = 0;
            else if (listID > lb_list.Items.Count)
                listID = lb_list.Items.Count - 1;

            lb_list.SelectedIndex = listID;
        }

        // -------------- EVENTS ----------------

            // Close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


            // List controller
        private void lb_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change the title of the group box
            gb_info.Text = presetTitle + lb_list.Items[lb_list.SelectedIndex];

            loadHelpFile(lb_list.SelectedIndex);
        }

        private void cb_languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            languageID = cb_languages.SelectedIndex;
            loadHelpFile(lb_list.SelectedIndex);
        }
    }
}
