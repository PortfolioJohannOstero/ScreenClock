namespace Screen_Clock.Forms
{
    partial class AdvancedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.tab_monitor = new System.Windows.Forms.TabPage();
            this.label_singleMonitorWarning = new System.Windows.Forms.Label();
            this.label_monitorWarning = new System.Windows.Forms.Label();
            this.label_currPrimaryMon = new System.Windows.Forms.Label();
            this.label_currPrimaryMonDescription = new System.Windows.Forms.Label();
            this.cb_monitorSelection = new System.Windows.Forms.ComboBox();
            this.label_monitor = new System.Windows.Forms.Label();
            this.tab_Clocksize = new System.Windows.Forms.TabPage();
            this.label_currentScreenSize = new System.Windows.Forms.Label();
            this.label_sizeDescription = new System.Windows.Forms.Label();
            this.tb_screenSize = new System.Windows.Forms.TrackBar();
            this.rCustomSize = new System.Windows.Forms.RadioButton();
            this.rFullScreen = new System.Windows.Forms.RadioButton();
            this.tab_colour = new System.Windows.Forms.TabPage();
            this.btn_analogLayoutForm = new System.Windows.Forms.Button();
            this.label_deadlineOvertime = new System.Windows.Forms.Label();
            this.label_deadlineClosing = new System.Windows.Forms.Label();
            this.label_deadlineColour = new System.Windows.Forms.Label();
            this.label_clockColour = new System.Windows.Forms.Label();
            this.label_backgroundColour = new System.Windows.Forms.Label();
            this.pb_deadlineOvertimeColourPicker = new System.Windows.Forms.PictureBox();
            this.pb_deadlineClosingColourPicker = new System.Windows.Forms.PictureBox();
            this.pb_deadlineColourPicker = new System.Windows.Forms.PictureBox();
            this.pb_clockColourPicker = new System.Windows.Forms.PictureBox();
            this.pb_bgColourPicker = new System.Windows.Forms.PictureBox();
            this.tab_default = new System.Windows.Forms.TabPage();
            this.cDisplaySeconds = new System.Windows.Forms.CheckBox();
            this.label_deadlineCurrentTime = new System.Windows.Forms.Label();
            this.label_deadline = new System.Windows.Forms.Label();
            this.cb_defaultDeadlineMin = new System.Windows.Forms.NumericUpDown();
            this.label_deadlineMinTime = new System.Windows.Forms.Label();
            this.label_advDefaultType = new System.Windows.Forms.Label();
            this.cb_defaultClockType = new System.Windows.Forms.ComboBox();
            this.advTab = new System.Windows.Forms.TabControl();
            this.lbl_applyAnalogChanges = new System.Windows.Forms.Label();
            this.tab_monitor.SuspendLayout();
            this.tab_Clocksize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_screenSize)).BeginInit();
            this.tab_colour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deadlineOvertimeColourPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deadlineClosingColourPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deadlineColourPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clockColourPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bgColourPicker)).BeginInit();
            this.tab_default.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_defaultDeadlineMin)).BeginInit();
            this.advTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 230);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(197, 230);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 1;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // tab_monitor
            // 
            this.tab_monitor.Controls.Add(this.label_singleMonitorWarning);
            this.tab_monitor.Controls.Add(this.label_monitorWarning);
            this.tab_monitor.Controls.Add(this.label_currPrimaryMon);
            this.tab_monitor.Controls.Add(this.label_currPrimaryMonDescription);
            this.tab_monitor.Controls.Add(this.cb_monitorSelection);
            this.tab_monitor.Controls.Add(this.label_monitor);
            this.tab_monitor.Location = new System.Drawing.Point(4, 22);
            this.tab_monitor.Name = "tab_monitor";
            this.tab_monitor.Size = new System.Drawing.Size(252, 190);
            this.tab_monitor.TabIndex = 2;
            this.tab_monitor.Text = "Monitor";
            this.tab_monitor.UseVisualStyleBackColor = true;
            // 
            // label_singleMonitorWarning
            // 
            this.label_singleMonitorWarning.AutoSize = true;
            this.label_singleMonitorWarning.BackColor = System.Drawing.SystemColors.Control;
            this.label_singleMonitorWarning.ForeColor = System.Drawing.Color.Red;
            this.label_singleMonitorWarning.Location = new System.Drawing.Point(7, 38);
            this.label_singleMonitorWarning.Name = "label_singleMonitorWarning";
            this.label_singleMonitorWarning.Size = new System.Drawing.Size(153, 13);
            this.label_singleMonitorWarning.TabIndex = 5;
            this.label_singleMonitorWarning.Text = "No external monitor was found!";
            // 
            // label_monitorWarning
            // 
            this.label_monitorWarning.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_monitorWarning.ForeColor = System.Drawing.Color.Black;
            this.label_monitorWarning.Location = new System.Drawing.Point(3, 58);
            this.label_monitorWarning.Name = "label_monitorWarning";
            this.label_monitorWarning.Size = new System.Drawing.Size(246, 32);
            this.label_monitorWarning.TabIndex = 4;
            this.label_monitorWarning.Text = "Note: If the primary monitor is changed, it might take up to 1 second for this ta" +
    "b to update";
            // 
            // label_currPrimaryMon
            // 
            this.label_currPrimaryMon.AutoSize = true;
            this.label_currPrimaryMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_currPrimaryMon.Location = new System.Drawing.Point(94, 167);
            this.label_currPrimaryMon.Name = "label_currPrimaryMon";
            this.label_currPrimaryMon.Size = new System.Drawing.Size(60, 15);
            this.label_currPrimaryMon.TabIndex = 3;
            this.label_currPrimaryMon.Text = "MONITOR";
            // 
            // label_currPrimaryMonDescription
            // 
            this.label_currPrimaryMonDescription.AutoSize = true;
            this.label_currPrimaryMonDescription.Location = new System.Drawing.Point(3, 167);
            this.label_currPrimaryMonDescription.Name = "label_currPrimaryMonDescription";
            this.label_currPrimaryMonDescription.Size = new System.Drawing.Size(85, 13);
            this.label_currPrimaryMonDescription.TabIndex = 2;
            this.label_currPrimaryMonDescription.Text = "Primary Monitor: ";
            // 
            // cb_monitorSelection
            // 
            this.cb_monitorSelection.FormattingEnabled = true;
            this.cb_monitorSelection.Location = new System.Drawing.Point(3, 34);
            this.cb_monitorSelection.Name = "cb_monitorSelection";
            this.cb_monitorSelection.Size = new System.Drawing.Size(246, 21);
            this.cb_monitorSelection.TabIndex = 1;
            // 
            // label_monitor
            // 
            this.label_monitor.AutoSize = true;
            this.label_monitor.Location = new System.Drawing.Point(3, 18);
            this.label_monitor.Name = "label_monitor";
            this.label_monitor.Size = new System.Drawing.Size(172, 13);
            this.label_monitor.TabIndex = 0;
            this.label_monitor.Text = "Default monitor to display clock on:";
            // 
            // tab_Clocksize
            // 
            this.tab_Clocksize.Controls.Add(this.label_currentScreenSize);
            this.tab_Clocksize.Controls.Add(this.label_sizeDescription);
            this.tab_Clocksize.Controls.Add(this.tb_screenSize);
            this.tab_Clocksize.Controls.Add(this.rCustomSize);
            this.tab_Clocksize.Controls.Add(this.rFullScreen);
            this.tab_Clocksize.Location = new System.Drawing.Point(4, 22);
            this.tab_Clocksize.Name = "tab_Clocksize";
            this.tab_Clocksize.Size = new System.Drawing.Size(252, 190);
            this.tab_Clocksize.TabIndex = 3;
            this.tab_Clocksize.Text = "Size";
            this.tab_Clocksize.UseVisualStyleBackColor = true;
            // 
            // label_currentScreenSize
            // 
            this.label_currentScreenSize.AutoSize = true;
            this.label_currentScreenSize.Location = new System.Drawing.Point(102, 38);
            this.label_currentScreenSize.Name = "label_currentScreenSize";
            this.label_currentScreenSize.Size = new System.Drawing.Size(10, 13);
            this.label_currentScreenSize.TabIndex = 4;
            this.label_currentScreenSize.Text = ":";
            // 
            // label_sizeDescription
            // 
            this.label_sizeDescription.Location = new System.Drawing.Point(3, 98);
            this.label_sizeDescription.Name = "label_sizeDescription";
            this.label_sizeDescription.Size = new System.Drawing.Size(246, 92);
            this.label_sizeDescription.TabIndex = 3;
            this.label_sizeDescription.Text = "1. Full Screen:\r\nFills the entire secondary monitor, and cannot be displayed with" +
    "out it\r\n\r\n2. Lets you set the size yourself, which allows you to drag it around " +
    "and have it on the primary monitor\r\n";
            // 
            // tb_screenSize
            // 
            this.tb_screenSize.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_screenSize.Enabled = false;
            this.tb_screenSize.LargeChange = 1;
            this.tb_screenSize.Location = new System.Drawing.Point(3, 59);
            this.tb_screenSize.Name = "tb_screenSize";
            this.tb_screenSize.Size = new System.Drawing.Size(246, 45);
            this.tb_screenSize.TabIndex = 2;
            this.tb_screenSize.Scroll += new System.EventHandler(this.tb_screenSize_Scroll);
            // 
            // rCustomSize
            // 
            this.rCustomSize.AutoSize = true;
            this.rCustomSize.Location = new System.Drawing.Point(13, 36);
            this.rCustomSize.Name = "rCustomSize";
            this.rCustomSize.Size = new System.Drawing.Size(83, 17);
            this.rCustomSize.TabIndex = 1;
            this.rCustomSize.TabStop = true;
            this.rCustomSize.Text = "Custom Size";
            this.rCustomSize.UseVisualStyleBackColor = true;
            this.rCustomSize.CheckedChanged += new System.EventHandler(this.rCustomSize_CheckedChanged);
            // 
            // rFullScreen
            // 
            this.rFullScreen.AutoSize = true;
            this.rFullScreen.Location = new System.Drawing.Point(13, 13);
            this.rFullScreen.Name = "rFullScreen";
            this.rFullScreen.Size = new System.Drawing.Size(78, 17);
            this.rFullScreen.TabIndex = 0;
            this.rFullScreen.TabStop = true;
            this.rFullScreen.Text = "Full Screen";
            this.rFullScreen.UseVisualStyleBackColor = true;
            // 
            // tab_colour
            // 
            this.tab_colour.Controls.Add(this.btn_analogLayoutForm);
            this.tab_colour.Controls.Add(this.label_deadlineOvertime);
            this.tab_colour.Controls.Add(this.label_deadlineClosing);
            this.tab_colour.Controls.Add(this.label_deadlineColour);
            this.tab_colour.Controls.Add(this.label_clockColour);
            this.tab_colour.Controls.Add(this.label_backgroundColour);
            this.tab_colour.Controls.Add(this.pb_deadlineOvertimeColourPicker);
            this.tab_colour.Controls.Add(this.pb_deadlineClosingColourPicker);
            this.tab_colour.Controls.Add(this.pb_deadlineColourPicker);
            this.tab_colour.Controls.Add(this.pb_clockColourPicker);
            this.tab_colour.Controls.Add(this.pb_bgColourPicker);
            this.tab_colour.Location = new System.Drawing.Point(4, 22);
            this.tab_colour.Name = "tab_colour";
            this.tab_colour.Padding = new System.Windows.Forms.Padding(3);
            this.tab_colour.Size = new System.Drawing.Size(252, 190);
            this.tab_colour.TabIndex = 1;
            this.tab_colour.Text = "Colours";
            this.tab_colour.UseVisualStyleBackColor = true;
            // 
            // btn_analogLayoutForm
            // 
            this.btn_analogLayoutForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_analogLayoutForm.Location = new System.Drawing.Point(136, 162);
            this.btn_analogLayoutForm.Name = "btn_analogLayoutForm";
            this.btn_analogLayoutForm.Size = new System.Drawing.Size(110, 22);
            this.btn_analogLayoutForm.TabIndex = 10;
            this.btn_analogLayoutForm.Text = "Analog layout...";
            this.btn_analogLayoutForm.UseVisualStyleBackColor = true;
            this.btn_analogLayoutForm.Click += new System.EventHandler(this.btn_analogLayoutForm_Click);
            // 
            // label_deadlineOvertime
            // 
            this.label_deadlineOvertime.AutoSize = true;
            this.label_deadlineOvertime.Location = new System.Drawing.Point(35, 109);
            this.label_deadlineOvertime.Name = "label_deadlineOvertime";
            this.label_deadlineOvertime.Size = new System.Drawing.Size(100, 13);
            this.label_deadlineOvertime.TabIndex = 8;
            this.label_deadlineOvertime.Text = "Deadline - Overtime";
            // 
            // label_deadlineClosing
            // 
            this.label_deadlineClosing.AutoSize = true;
            this.label_deadlineClosing.Location = new System.Drawing.Point(35, 85);
            this.label_deadlineClosing.Name = "label_deadlineClosing";
            this.label_deadlineClosing.Size = new System.Drawing.Size(171, 13);
            this.label_deadlineClosing.TabIndex = 6;
            this.label_deadlineClosing.Text = "Deadline - Close to deadline colour";
            // 
            // label_deadlineColour
            // 
            this.label_deadlineColour.AutoSize = true;
            this.label_deadlineColour.Location = new System.Drawing.Point(35, 61);
            this.label_deadlineColour.Name = "label_deadlineColour";
            this.label_deadlineColour.Size = new System.Drawing.Size(101, 13);
            this.label_deadlineColour.TabIndex = 4;
            this.label_deadlineColour.Text = "Deadline text colour";
            // 
            // label_clockColour
            // 
            this.label_clockColour.AutoSize = true;
            this.label_clockColour.Location = new System.Drawing.Point(35, 37);
            this.label_clockColour.Name = "label_clockColour";
            this.label_clockColour.Size = new System.Drawing.Size(86, 13);
            this.label_clockColour.TabIndex = 2;
            this.label_clockColour.Text = "Clock text colour";
            // 
            // label_backgroundColour
            // 
            this.label_backgroundColour.AutoSize = true;
            this.label_backgroundColour.Location = new System.Drawing.Point(35, 13);
            this.label_backgroundColour.Name = "label_backgroundColour";
            this.label_backgroundColour.Size = new System.Drawing.Size(171, 13);
            this.label_backgroundColour.TabIndex = 0;
            this.label_backgroundColour.Text = "Clock Display - Background Colour";
            // 
            // pb_deadlineOvertimeColourPicker
            // 
            this.pb_deadlineOvertimeColourPicker.BackColor = System.Drawing.Color.Lime;
            this.pb_deadlineOvertimeColourPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_deadlineOvertimeColourPicker.Location = new System.Drawing.Point(11, 107);
            this.pb_deadlineOvertimeColourPicker.Name = "pb_deadlineOvertimeColourPicker";
            this.pb_deadlineOvertimeColourPicker.Size = new System.Drawing.Size(19, 18);
            this.pb_deadlineOvertimeColourPicker.TabIndex = 9;
            this.pb_deadlineOvertimeColourPicker.TabStop = false;
            this.pb_deadlineOvertimeColourPicker.Click += new System.EventHandler(this.pb_deadlineOvertimeColourPicker_Click);
            // 
            // pb_deadlineClosingColourPicker
            // 
            this.pb_deadlineClosingColourPicker.BackColor = System.Drawing.Color.Red;
            this.pb_deadlineClosingColourPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_deadlineClosingColourPicker.Location = new System.Drawing.Point(11, 83);
            this.pb_deadlineClosingColourPicker.Name = "pb_deadlineClosingColourPicker";
            this.pb_deadlineClosingColourPicker.Size = new System.Drawing.Size(19, 18);
            this.pb_deadlineClosingColourPicker.TabIndex = 7;
            this.pb_deadlineClosingColourPicker.TabStop = false;
            this.pb_deadlineClosingColourPicker.Click += new System.EventHandler(this.pb_deadlineClosingColourPicker_Click);
            // 
            // pb_deadlineColourPicker
            // 
            this.pb_deadlineColourPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_deadlineColourPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_deadlineColourPicker.Location = new System.Drawing.Point(11, 59);
            this.pb_deadlineColourPicker.Name = "pb_deadlineColourPicker";
            this.pb_deadlineColourPicker.Size = new System.Drawing.Size(19, 18);
            this.pb_deadlineColourPicker.TabIndex = 5;
            this.pb_deadlineColourPicker.TabStop = false;
            this.pb_deadlineColourPicker.Click += new System.EventHandler(this.pb_deadlineColourPicker_Click);
            // 
            // pb_clockColourPicker
            // 
            this.pb_clockColourPicker.BackColor = System.Drawing.Color.White;
            this.pb_clockColourPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_clockColourPicker.Location = new System.Drawing.Point(11, 35);
            this.pb_clockColourPicker.Name = "pb_clockColourPicker";
            this.pb_clockColourPicker.Size = new System.Drawing.Size(19, 18);
            this.pb_clockColourPicker.TabIndex = 3;
            this.pb_clockColourPicker.TabStop = false;
            this.pb_clockColourPicker.Click += new System.EventHandler(this.pb_clockColourPicker_Click);
            // 
            // pb_bgColourPicker
            // 
            this.pb_bgColourPicker.BackColor = System.Drawing.Color.Black;
            this.pb_bgColourPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_bgColourPicker.Location = new System.Drawing.Point(11, 11);
            this.pb_bgColourPicker.Name = "pb_bgColourPicker";
            this.pb_bgColourPicker.Size = new System.Drawing.Size(19, 18);
            this.pb_bgColourPicker.TabIndex = 1;
            this.pb_bgColourPicker.TabStop = false;
            this.pb_bgColourPicker.Click += new System.EventHandler(this.pb_bgColourPicker_Click);
            // 
            // tab_default
            // 
            this.tab_default.Controls.Add(this.cDisplaySeconds);
            this.tab_default.Controls.Add(this.label_deadlineCurrentTime);
            this.tab_default.Controls.Add(this.label_deadline);
            this.tab_default.Controls.Add(this.cb_defaultDeadlineMin);
            this.tab_default.Controls.Add(this.label_deadlineMinTime);
            this.tab_default.Controls.Add(this.label_advDefaultType);
            this.tab_default.Controls.Add(this.cb_defaultClockType);
            this.tab_default.Location = new System.Drawing.Point(4, 22);
            this.tab_default.Name = "tab_default";
            this.tab_default.Padding = new System.Windows.Forms.Padding(3);
            this.tab_default.Size = new System.Drawing.Size(252, 190);
            this.tab_default.TabIndex = 0;
            this.tab_default.Text = "Default";
            this.tab_default.UseVisualStyleBackColor = true;
            // 
            // cDisplaySeconds
            // 
            this.cDisplaySeconds.AutoSize = true;
            this.cDisplaySeconds.Checked = true;
            this.cDisplaySeconds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cDisplaySeconds.Location = new System.Drawing.Point(9, 167);
            this.cDisplaySeconds.Name = "cDisplaySeconds";
            this.cDisplaySeconds.Size = new System.Drawing.Size(143, 17);
            this.cDisplaySeconds.TabIndex = 6;
            this.cDisplaySeconds.Text = "Display Digital Seconds?";
            this.cDisplaySeconds.UseVisualStyleBackColor = true;
            // 
            // label_deadlineCurrentTime
            // 
            this.label_deadlineCurrentTime.AutoSize = true;
            this.label_deadlineCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_deadlineCurrentTime.Location = new System.Drawing.Point(112, 84);
            this.label_deadlineCurrentTime.Name = "label_deadlineCurrentTime";
            this.label_deadlineCurrentTime.Size = new System.Drawing.Size(36, 15);
            this.label_deadlineCurrentTime.TabIndex = 5;
            this.label_deadlineCurrentTime.Text = "00:00";
            // 
            // label_deadline
            // 
            this.label_deadline.AutoSize = true;
            this.label_deadline.Location = new System.Drawing.Point(54, 84);
            this.label_deadline.Name = "label_deadline";
            this.label_deadline.Size = new System.Drawing.Size(52, 13);
            this.label_deadline.TabIndex = 4;
            this.label_deadline.Text = "Deadline:";
            // 
            // cb_defaultDeadlineMin
            // 
            this.cb_defaultDeadlineMin.Location = new System.Drawing.Point(9, 82);
            this.cb_defaultDeadlineMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.cb_defaultDeadlineMin.Name = "cb_defaultDeadlineMin";
            this.cb_defaultDeadlineMin.Size = new System.Drawing.Size(39, 20);
            this.cb_defaultDeadlineMin.TabIndex = 3;
            // 
            // label_deadlineMinTime
            // 
            this.label_deadlineMinTime.AutoSize = true;
            this.label_deadlineMinTime.Location = new System.Drawing.Point(6, 66);
            this.label_deadlineMinTime.Name = "label_deadlineMinTime";
            this.label_deadlineMinTime.Size = new System.Drawing.Size(228, 13);
            this.label_deadlineMinTime.TabIndex = 2;
            this.label_deadlineMinTime.Text = "Default minutes until colour change (deadline) :";
            // 
            // label_advDefaultType
            // 
            this.label_advDefaultType.AutoSize = true;
            this.label_advDefaultType.Location = new System.Drawing.Point(6, 16);
            this.label_advDefaultType.Name = "label_advDefaultType";
            this.label_advDefaultType.Size = new System.Drawing.Size(101, 13);
            this.label_advDefaultType.TabIndex = 1;
            this.label_advDefaultType.Text = "Default Clock Type:";
            // 
            // cb_defaultClockType
            // 
            this.cb_defaultClockType.FormattingEnabled = true;
            this.cb_defaultClockType.Location = new System.Drawing.Point(9, 32);
            this.cb_defaultClockType.Name = "cb_defaultClockType";
            this.cb_defaultClockType.Size = new System.Drawing.Size(121, 21);
            this.cb_defaultClockType.TabIndex = 0;
            // 
            // advTab
            // 
            this.advTab.Controls.Add(this.tab_default);
            this.advTab.Controls.Add(this.tab_colour);
            this.advTab.Controls.Add(this.tab_Clocksize);
            this.advTab.Controls.Add(this.tab_monitor);
            this.advTab.Location = new System.Drawing.Point(12, 12);
            this.advTab.Name = "advTab";
            this.advTab.SelectedIndex = 0;
            this.advTab.Size = new System.Drawing.Size(260, 216);
            this.advTab.TabIndex = 0;
            // 
            // lbl_applyAnalogChanges
            // 
            this.lbl_applyAnalogChanges.AutoSize = true;
            this.lbl_applyAnalogChanges.ForeColor = System.Drawing.Color.Red;
            this.lbl_applyAnalogChanges.Location = new System.Drawing.Point(110, 235);
            this.lbl_applyAnalogChanges.Name = "lbl_applyAnalogChanges";
            this.lbl_applyAnalogChanges.Size = new System.Drawing.Size(81, 13);
            this.lbl_applyAnalogChanges.TabIndex = 2;
            this.lbl_applyAnalogChanges.Text = "Apply Analog ->";
            // 
            // AdvancedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.lbl_applyAnalogChanges);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.advTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdvancedForm";
            this.Text = "Advanced Options";
            this.tab_monitor.ResumeLayout(false);
            this.tab_monitor.PerformLayout();
            this.tab_Clocksize.ResumeLayout(false);
            this.tab_Clocksize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_screenSize)).EndInit();
            this.tab_colour.ResumeLayout(false);
            this.tab_colour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deadlineOvertimeColourPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deadlineClosingColourPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deadlineColourPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clockColourPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bgColourPicker)).EndInit();
            this.tab_default.ResumeLayout(false);
            this.tab_default.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_defaultDeadlineMin)).EndInit();
            this.advTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        public System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.TabPage tab_monitor;
        private System.Windows.Forms.Label label_currPrimaryMon;
        private System.Windows.Forms.Label label_currPrimaryMonDescription;
        private System.Windows.Forms.ComboBox cb_monitorSelection;
        private System.Windows.Forms.Label label_monitor;
        private System.Windows.Forms.TabPage tab_Clocksize;
        private System.Windows.Forms.TabPage tab_colour;
        private System.Windows.Forms.PictureBox pb_deadlineOvertimeColourPicker;
        private System.Windows.Forms.Label label_deadlineOvertime;
        private System.Windows.Forms.PictureBox pb_deadlineClosingColourPicker;
        private System.Windows.Forms.Label label_deadlineClosing;
        private System.Windows.Forms.PictureBox pb_deadlineColourPicker;
        private System.Windows.Forms.Label label_deadlineColour;
        private System.Windows.Forms.PictureBox pb_clockColourPicker;
        private System.Windows.Forms.Label label_clockColour;
        private System.Windows.Forms.PictureBox pb_bgColourPicker;
        private System.Windows.Forms.Label label_backgroundColour;
        private System.Windows.Forms.TabPage tab_default;
        private System.Windows.Forms.CheckBox cDisplaySeconds;
        private System.Windows.Forms.Label label_deadlineCurrentTime;
        private System.Windows.Forms.Label label_deadline;
        private System.Windows.Forms.NumericUpDown cb_defaultDeadlineMin;
        private System.Windows.Forms.Label label_deadlineMinTime;
        private System.Windows.Forms.Label label_advDefaultType;
        private System.Windows.Forms.ComboBox cb_defaultClockType;
        private System.Windows.Forms.TabControl advTab;
        private System.Windows.Forms.TrackBar tb_screenSize;
        private System.Windows.Forms.RadioButton rCustomSize;
        private System.Windows.Forms.RadioButton rFullScreen;
        private System.Windows.Forms.Label label_sizeDescription;
        private System.Windows.Forms.Label label_currentScreenSize;
        private System.Windows.Forms.Label label_monitorWarning;
        private System.Windows.Forms.Label label_singleMonitorWarning;
        private System.Windows.Forms.Button btn_analogLayoutForm;
        private System.Windows.Forms.Label lbl_applyAnalogChanges;
    }
}