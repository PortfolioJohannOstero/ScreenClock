namespace Screen_Clock.Forms
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.lb_list = new System.Windows.Forms.ListBox();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.rtb_helpContent = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_contactInfo = new System.Windows.Forms.Label();
            this.cb_languages = new System.Windows.Forms.ComboBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.gb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_list
            // 
            this.lb_list.FormattingEnabled = true;
            this.lb_list.Items.AddRange(new object[] {
            "The Basics",
            "More Advanced",
            "Display Type",
            "Display Deadline",
            "Advanced Options",
            "Preset Settings",
            "Analog Clock Layout Customization"});
            this.lb_list.Location = new System.Drawing.Point(12, 12);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(226, 641);
            this.lb_list.TabIndex = 0;
            this.lb_list.SelectedIndexChanged += new System.EventHandler(this.lb_list_SelectedIndexChanged);
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.rtb_helpContent);
            this.gb_info.Location = new System.Drawing.Point(244, 90);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(434, 563);
            this.gb_info.TabIndex = 1;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Description -";
            // 
            // rtb_helpContent
            // 
            this.rtb_helpContent.Location = new System.Drawing.Point(9, 19);
            this.rtb_helpContent.Name = "rtb_helpContent";
            this.rtb_helpContent.ReadOnly = true;
            this.rtb_helpContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_helpContent.Size = new System.Drawing.Size(419, 538);
            this.rtb_helpContent.TabIndex = 1;
            this.rtb_helpContent.TabStop = false;
            this.rtb_helpContent.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(666, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_contactInfo
            // 
            this.lbl_contactInfo.AutoSize = true;
            this.lbl_contactInfo.Location = new System.Drawing.Point(250, 12);
            this.lbl_contactInfo.Name = "lbl_contactInfo";
            this.lbl_contactInfo.Size = new System.Drawing.Size(344, 65);
            this.lbl_contactInfo.TabIndex = 3;
            this.lbl_contactInfo.Text = resources.GetString("lbl_contactInfo.Text");
            // 
            // cb_languages
            // 
            this.cb_languages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_languages.FormattingEnabled = true;
            this.cb_languages.Location = new System.Drawing.Point(600, 9);
            this.cb_languages.Name = "cb_languages";
            this.cb_languages.Size = new System.Drawing.Size(78, 21);
            this.cb_languages.TabIndex = 4;
            this.cb_languages.SelectedIndexChanged += new System.EventHandler(this.cb_languages_SelectedIndexChanged);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(581, 77);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(97, 13);
            this.lbl_error.TabIndex = 5;
            this.lbl_error.Text = "*Missing Language";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 692);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.cb_languages);
            this.Controls.Add(this.lbl_contactInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.lb_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.Text = "Help";
            this.TopMost = true;
            this.gb_info.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_list;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_helpContent;
        private System.Windows.Forms.Label lbl_contactInfo;
        private System.Windows.Forms.ComboBox cb_languages;
        private System.Windows.Forms.Label lbl_error;
    }
}