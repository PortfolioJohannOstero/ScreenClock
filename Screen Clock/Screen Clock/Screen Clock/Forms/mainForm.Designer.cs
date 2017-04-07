namespace Screen_Clock.Forms
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.gb_displayType = new System.Windows.Forms.GroupBox();
            this.rDispType_analog = new System.Windows.Forms.RadioButton();
            this.help_btn_dispType = new System.Windows.Forms.Button();
            this.rDispType_12ampm = new System.Windows.Forms.RadioButton();
            this.rDispType_24h = new System.Windows.Forms.RadioButton();
            this.gb_displayDeadline = new System.Windows.Forms.GroupBox();
            this.help_btn_dispDeadline = new System.Windows.Forms.Button();
            this.cCountOvertime = new System.Windows.Forms.CheckBox();
            this.minUpDown = new System.Windows.Forms.NumericUpDown();
            this.label_minutesLeft = new System.Windows.Forms.Label();
            this.cChangeColourDeadline = new System.Windows.Forms.CheckBox();
            this.label_ampm = new System.Windows.Forms.Label();
            this.deadlineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_deadline = new System.Windows.Forms.Label();
            this.cDispDeadline = new System.Windows.Forms.CheckBox();
            this.advanced_btn = new System.Windows.Forms.Button();
            this.clock_btn = new System.Windows.Forms.Button();
            this.cb_presetSelection = new System.Windows.Forms.ComboBox();
            this.btn_presetAdd = new System.Windows.Forms.Button();
            this.btn_presetRemove = new System.Windows.Forms.Button();
            this.btn_presetSettings = new System.Windows.Forms.Button();
            this.cb_alwaysOnTopBtn = new System.Windows.Forms.CheckBox();
            this.help_btn_advancedOptions = new System.Windows.Forms.Button();
            this.gb_displayType.SuspendLayout();
            this.gb_displayDeadline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_displayType
            // 
            this.gb_displayType.Controls.Add(this.rDispType_analog);
            this.gb_displayType.Controls.Add(this.help_btn_dispType);
            this.gb_displayType.Controls.Add(this.rDispType_12ampm);
            this.gb_displayType.Controls.Add(this.rDispType_24h);
            this.gb_displayType.Location = new System.Drawing.Point(12, 12);
            this.gb_displayType.Name = "gb_displayType";
            this.gb_displayType.Size = new System.Drawing.Size(140, 101);
            this.gb_displayType.TabIndex = 0;
            this.gb_displayType.TabStop = false;
            this.gb_displayType.Text = "Display Type";
            // 
            // rDispType_analog
            // 
            this.rDispType_analog.AutoSize = true;
            this.rDispType_analog.Location = new System.Drawing.Point(6, 65);
            this.rDispType_analog.Name = "rDispType_analog";
            this.rDispType_analog.Size = new System.Drawing.Size(58, 17);
            this.rDispType_analog.TabIndex = 2;
            this.rDispType_analog.TabStop = true;
            this.rDispType_analog.Text = "Analog";
            this.rDispType_analog.UseVisualStyleBackColor = true;
            this.rDispType_analog.CheckedChanged += new System.EventHandler(this.rDispType_analog_CheckedChanged);
            // 
            // help_btn_dispType
            // 
            this.help_btn_dispType.Location = new System.Drawing.Point(118, 76);
            this.help_btn_dispType.Name = "help_btn_dispType";
            this.help_btn_dispType.Size = new System.Drawing.Size(22, 25);
            this.help_btn_dispType.TabIndex = 3;
            this.help_btn_dispType.Text = "?";
            this.help_btn_dispType.UseVisualStyleBackColor = true;
            this.help_btn_dispType.Click += new System.EventHandler(this.help_btn_dispType_Click);
            // 
            // rDispType_12ampm
            // 
            this.rDispType_12ampm.AutoSize = true;
            this.rDispType_12ampm.Location = new System.Drawing.Point(6, 42);
            this.rDispType_12ampm.Name = "rDispType_12ampm";
            this.rDispType_12ampm.Size = new System.Drawing.Size(68, 17);
            this.rDispType_12ampm.TabIndex = 1;
            this.rDispType_12ampm.TabStop = true;
            this.rDispType_12ampm.Text = "AM / PM";
            this.rDispType_12ampm.UseVisualStyleBackColor = true;
            this.rDispType_12ampm.CheckedChanged += new System.EventHandler(this.rDispType_12ampm_CheckedChanged);
            // 
            // rDispType_24h
            // 
            this.rDispType_24h.AutoSize = true;
            this.rDispType_24h.Location = new System.Drawing.Point(6, 19);
            this.rDispType_24h.Name = "rDispType_24h";
            this.rDispType_24h.Size = new System.Drawing.Size(93, 17);
            this.rDispType_24h.TabIndex = 0;
            this.rDispType_24h.TabStop = true;
            this.rDispType_24h.Text = "24h (standard)";
            this.rDispType_24h.UseVisualStyleBackColor = true;
            this.rDispType_24h.CheckedChanged += new System.EventHandler(this.rDispType_24h_CheckedChanged);
            // 
            // gb_displayDeadline
            // 
            this.gb_displayDeadline.Controls.Add(this.help_btn_dispDeadline);
            this.gb_displayDeadline.Controls.Add(this.cCountOvertime);
            this.gb_displayDeadline.Controls.Add(this.minUpDown);
            this.gb_displayDeadline.Controls.Add(this.label_minutesLeft);
            this.gb_displayDeadline.Controls.Add(this.cChangeColourDeadline);
            this.gb_displayDeadline.Controls.Add(this.label_ampm);
            this.gb_displayDeadline.Controls.Add(this.deadlineTimePicker);
            this.gb_displayDeadline.Controls.Add(this.label_deadline);
            this.gb_displayDeadline.Controls.Add(this.cDispDeadline);
            this.gb_displayDeadline.Location = new System.Drawing.Point(158, 12);
            this.gb_displayDeadline.Name = "gb_displayDeadline";
            this.gb_displayDeadline.Size = new System.Drawing.Size(166, 139);
            this.gb_displayDeadline.TabIndex = 1;
            this.gb_displayDeadline.TabStop = false;
            this.gb_displayDeadline.Text = "Display Deadline";
            // 
            // help_btn_dispDeadline
            // 
            this.help_btn_dispDeadline.Location = new System.Drawing.Point(144, 114);
            this.help_btn_dispDeadline.Name = "help_btn_dispDeadline";
            this.help_btn_dispDeadline.Size = new System.Drawing.Size(22, 25);
            this.help_btn_dispDeadline.TabIndex = 4;
            this.help_btn_dispDeadline.Text = "?";
            this.help_btn_dispDeadline.UseVisualStyleBackColor = true;
            this.help_btn_dispDeadline.Click += new System.EventHandler(this.help_btn_dispDeadline_Click);
            // 
            // cCountOvertime
            // 
            this.cCountOvertime.AutoSize = true;
            this.cCountOvertime.Location = new System.Drawing.Point(6, 114);
            this.cCountOvertime.Name = "cCountOvertime";
            this.cCountOvertime.Size = new System.Drawing.Size(115, 17);
            this.cCountOvertime.TabIndex = 7;
            this.cCountOvertime.Text = "Count the overtime";
            this.cCountOvertime.UseVisualStyleBackColor = true;
            this.cCountOvertime.CheckedChanged += new System.EventHandler(this.cCountOvertime_CheckedChanged);
            // 
            // minUpDown
            // 
            this.minUpDown.Enabled = false;
            this.minUpDown.Location = new System.Drawing.Point(92, 85);
            this.minUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minUpDown.Name = "minUpDown";
            this.minUpDown.Size = new System.Drawing.Size(41, 20);
            this.minUpDown.TabIndex = 6;
            this.minUpDown.ValueChanged += new System.EventHandler(this.minUpDown_ValueChanged);
            // 
            // label_minutesLeft
            // 
            this.label_minutesLeft.AutoSize = true;
            this.label_minutesLeft.Location = new System.Drawing.Point(23, 88);
            this.label_minutesLeft.Name = "label_minutesLeft";
            this.label_minutesLeft.Size = new System.Drawing.Size(63, 13);
            this.label_minutesLeft.TabIndex = 5;
            this.label_minutesLeft.Text = "minutes left:";
            // 
            // cChangeColourDeadline
            // 
            this.cChangeColourDeadline.AutoSize = true;
            this.cChangeColourDeadline.Location = new System.Drawing.Point(6, 68);
            this.cChangeColourDeadline.Name = "cChangeColourDeadline";
            this.cChangeColourDeadline.Size = new System.Drawing.Size(96, 17);
            this.cChangeColourDeadline.TabIndex = 4;
            this.cChangeColourDeadline.Text = "Change Colour";
            this.cChangeColourDeadline.UseVisualStyleBackColor = true;
            this.cChangeColourDeadline.CheckedChanged += new System.EventHandler(this.cChangeColourDeadline_CheckedChanged);
            // 
            // label_ampm
            // 
            this.label_ampm.AutoSize = true;
            this.label_ampm.Location = new System.Drawing.Point(139, 42);
            this.label_ampm.Name = "label_ampm";
            this.label_ampm.Size = new System.Drawing.Size(21, 13);
            this.label_ampm.TabIndex = 3;
            this.label_ampm.Text = "pm";
            // 
            // deadlineTimePicker
            // 
            this.deadlineTimePicker.CustomFormat = "HH:mm";
            this.deadlineTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deadlineTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deadlineTimePicker.Location = new System.Drawing.Point(64, 39);
            this.deadlineTimePicker.Name = "deadlineTimePicker";
            this.deadlineTimePicker.ShowUpDown = true;
            this.deadlineTimePicker.Size = new System.Drawing.Size(69, 20);
            this.deadlineTimePicker.TabIndex = 2;
            this.deadlineTimePicker.ValueChanged += new System.EventHandler(this.deadlineTimePicker_ValueChanged);
            // 
            // label_deadline
            // 
            this.label_deadline.AutoSize = true;
            this.label_deadline.Location = new System.Drawing.Point(6, 42);
            this.label_deadline.Name = "label_deadline";
            this.label_deadline.Size = new System.Drawing.Size(52, 13);
            this.label_deadline.TabIndex = 1;
            this.label_deadline.Text = "Deadline:";
            // 
            // cDispDeadline
            // 
            this.cDispDeadline.AutoSize = true;
            this.cDispDeadline.Location = new System.Drawing.Point(6, 19);
            this.cDispDeadline.Name = "cDispDeadline";
            this.cDispDeadline.Size = new System.Drawing.Size(105, 17);
            this.cDispDeadline.TabIndex = 0;
            this.cDispDeadline.Text = "Display Deadline";
            this.cDispDeadline.UseVisualStyleBackColor = true;
            this.cDispDeadline.CheckedChanged += new System.EventHandler(this.cDispDeadline_CheckedChanged);
            // 
            // advanced_btn
            // 
            this.advanced_btn.Location = new System.Drawing.Point(12, 119);
            this.advanced_btn.Name = "advanced_btn";
            this.advanced_btn.Size = new System.Drawing.Size(140, 32);
            this.advanced_btn.TabIndex = 2;
            this.advanced_btn.Text = "Advanced Options";
            this.advanced_btn.UseVisualStyleBackColor = true;
            this.advanced_btn.Click += new System.EventHandler(this.advanced_btn_Click);
            // 
            // clock_btn
            // 
            this.clock_btn.BackColor = System.Drawing.Color.Orange;
            this.clock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clock_btn.Location = new System.Drawing.Point(12, 157);
            this.clock_btn.Name = "clock_btn";
            this.clock_btn.Size = new System.Drawing.Size(312, 163);
            this.clock_btn.TabIndex = 4;
            this.clock_btn.Text = "Show Clock";
            this.clock_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.clock_btn.UseVisualStyleBackColor = false;
            this.clock_btn.Click += new System.EventHandler(this.clock_btn_Click);
            // 
            // cb_presetSelection
            // 
            this.cb_presetSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_presetSelection.FormattingEnabled = true;
            this.cb_presetSelection.Location = new System.Drawing.Point(41, 326);
            this.cb_presetSelection.Name = "cb_presetSelection";
            this.cb_presetSelection.Size = new System.Drawing.Size(238, 21);
            this.cb_presetSelection.TabIndex = 5;
            this.cb_presetSelection.SelectedIndexChanged += new System.EventHandler(this.cb_presetSelection_SelectedIndexChanged);
            // 
            // btn_presetAdd
            // 
            this.btn_presetAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_presetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_presetAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_presetAdd.Location = new System.Drawing.Point(285, 325);
            this.btn_presetAdd.Name = "btn_presetAdd";
            this.btn_presetAdd.Size = new System.Drawing.Size(18, 22);
            this.btn_presetAdd.TabIndex = 6;
            this.btn_presetAdd.Text = "+";
            this.btn_presetAdd.UseVisualStyleBackColor = false;
            this.btn_presetAdd.Click += new System.EventHandler(this.btn_presetAdd_Click);
            // 
            // btn_presetRemove
            // 
            this.btn_presetRemove.BackColor = System.Drawing.Color.LightCoral;
            this.btn_presetRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_presetRemove.Location = new System.Drawing.Point(302, 325);
            this.btn_presetRemove.Name = "btn_presetRemove";
            this.btn_presetRemove.Size = new System.Drawing.Size(18, 22);
            this.btn_presetRemove.TabIndex = 7;
            this.btn_presetRemove.Text = "-";
            this.btn_presetRemove.UseVisualStyleBackColor = false;
            this.btn_presetRemove.Click += new System.EventHandler(this.btn_presetRemove_Click);
            // 
            // btn_presetSettings
            // 
            this.btn_presetSettings.BackgroundImage = global::Screen_Clock.Properties.Resources.gear;
            this.btn_presetSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_presetSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_presetSettings.Location = new System.Drawing.Point(12, 325);
            this.btn_presetSettings.Name = "btn_presetSettings";
            this.btn_presetSettings.Size = new System.Drawing.Size(23, 22);
            this.btn_presetSettings.TabIndex = 8;
            this.btn_presetSettings.UseVisualStyleBackColor = false;
            this.btn_presetSettings.Click += new System.EventHandler(this.btn_presetSettings_Click);
            // 
            // cb_alwaysOnTopBtn
            // 
            this.cb_alwaysOnTopBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_alwaysOnTopBtn.AutoSize = true;
            this.cb_alwaysOnTopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cb_alwaysOnTopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_alwaysOnTopBtn.Location = new System.Drawing.Point(24, 166);
            this.cb_alwaysOnTopBtn.Name = "cb_alwaysOnTopBtn";
            this.cb_alwaysOnTopBtn.Size = new System.Drawing.Size(87, 23);
            this.cb_alwaysOnTopBtn.TabIndex = 4;
            this.cb_alwaysOnTopBtn.Text = "Always on Top";
            this.cb_alwaysOnTopBtn.UseVisualStyleBackColor = false;
            this.cb_alwaysOnTopBtn.CheckedChanged += new System.EventHandler(this.cb_alwaysOnTopBtn_CheckedChanged);
            // 
            // help_btn_advancedOptions
            // 
            this.help_btn_advancedOptions.Location = new System.Drawing.Point(130, 119);
            this.help_btn_advancedOptions.Name = "help_btn_advancedOptions";
            this.help_btn_advancedOptions.Size = new System.Drawing.Size(22, 25);
            this.help_btn_advancedOptions.TabIndex = 4;
            this.help_btn_advancedOptions.Text = "?";
            this.help_btn_advancedOptions.UseVisualStyleBackColor = true;
            this.help_btn_advancedOptions.Click += new System.EventHandler(this.help_btn_advancedOptions_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 361);
            this.Controls.Add(this.help_btn_advancedOptions);
            this.Controls.Add(this.cb_alwaysOnTopBtn);
            this.Controls.Add(this.btn_presetSettings);
            this.Controls.Add(this.btn_presetRemove);
            this.Controls.Add(this.btn_presetAdd);
            this.Controls.Add(this.cb_presetSelection);
            this.Controls.Add(this.clock_btn);
            this.Controls.Add(this.advanced_btn);
            this.Controls.Add(this.gb_displayDeadline);
            this.Controls.Add(this.gb_displayType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Screen Clock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.gb_displayType.ResumeLayout(false);
            this.gb_displayType.PerformLayout();
            this.gb_displayDeadline.ResumeLayout(false);
            this.gb_displayDeadline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_displayType;
        private System.Windows.Forms.RadioButton rDispType_analog;
        private System.Windows.Forms.RadioButton rDispType_12ampm;
        private System.Windows.Forms.RadioButton rDispType_24h;
        private System.Windows.Forms.GroupBox gb_displayDeadline;
        private System.Windows.Forms.DateTimePicker deadlineTimePicker;
        private System.Windows.Forms.Label label_deadline;
        private System.Windows.Forms.CheckBox cDispDeadline;
        private System.Windows.Forms.Label label_minutesLeft;
        private System.Windows.Forms.CheckBox cChangeColourDeadline;
        private System.Windows.Forms.Label label_ampm;
        private System.Windows.Forms.NumericUpDown minUpDown;
        private System.Windows.Forms.CheckBox cCountOvertime;
        private System.Windows.Forms.Button advanced_btn;
        private System.Windows.Forms.Button help_btn_dispType;
        private System.Windows.Forms.Button clock_btn;
        private System.Windows.Forms.Button help_btn_dispDeadline;
        private System.Windows.Forms.ComboBox cb_presetSelection;
        private System.Windows.Forms.Button btn_presetAdd;
        private System.Windows.Forms.Button btn_presetRemove;
        private System.Windows.Forms.Button btn_presetSettings;
        private System.Windows.Forms.CheckBox cb_alwaysOnTopBtn;
        private System.Windows.Forms.Button help_btn_advancedOptions;
    }
}

