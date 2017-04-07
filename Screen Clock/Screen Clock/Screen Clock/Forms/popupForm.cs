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
    public partial class popupForm : Form
    {
        string presetTitle;

        public string PresetTitle
        {
            get { return presetTitle; }
        }


        public popupForm()
        {
            InitializeComponent();
        }

        // Events
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            presetTitle = tb_name.Text;
            this.Close();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
                btn_create.Enabled = false;
            else
                btn_create.Enabled = true;
        }
    }
}
