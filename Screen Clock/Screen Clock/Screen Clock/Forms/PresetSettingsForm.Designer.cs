namespace Screen_Clock.Forms
{
    partial class PresetSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetSettingsForm));
            this.gb_information = new System.Windows.Forms.GroupBox();
            this.label_displaySeconds = new System.Windows.Forms.Label();
            this.desc_displaySeconds = new System.Windows.Forms.Label();
            this.pb_overtimeColour = new System.Windows.Forms.PictureBox();
            this.pb_minUntilColour = new System.Windows.Forms.PictureBox();
            this.pb_deadlineColour = new System.Windows.Forms.PictureBox();
            this.pb_clockColour = new System.Windows.Forms.PictureBox();
            this.desc_digitalColour = new System.Windows.Forms.Label();
            this.pb_bgColour = new System.Windows.Forms.PictureBox();
            this.help_btn_presetSettings = new System.Windows.Forms.Button();
            this.label_clockType = new System.Windows.Forms.Label();
            this.label_windowSize = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label_sizeType = new System.Windows.Forms.Label();
            this.label_numOfMon = new System.Windows.Forms.Label();
            this.desc_clockType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desc_location = new System.Windows.Forms.Label();
            this.desc_sizeType = new System.Windows.Forms.Label();
            this.desc_Monitor = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.lv_presetListView = new System.Windows.Forms.ListView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.gb_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_overtimeColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minUntilColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deadlineColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clockColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bgColour)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_information
            // 
            this.gb_information.Controls.Add(this.label_displaySeconds);
            this.gb_information.Controls.Add(this.desc_displaySeconds);
            this.gb_information.Controls.Add(this.pb_overtimeColour);
            this.gb_information.Controls.Add(this.pb_minUntilColour);
            this.gb_information.Controls.Add(this.pb_deadlineColour);
            this.gb_information.Controls.Add(this.pb_clockColour);
            this.gb_information.Controls.Add(this.desc_digitalColour);
            this.gb_information.Controls.Add(this.pb_bgColour);
            this.gb_information.Controls.Add(this.help_btn_presetSettings);
            this.gb_information.Controls.Add(this.label_clockType);
            this.gb_information.Controls.Add(this.label_windowSize);
            this.gb_information.Controls.Add(this.label_location);
            this.gb_information.Controls.Add(this.label_sizeType);
            this.gb_information.Controls.Add(this.label_numOfMon);
            this.gb_information.Controls.Add(this.desc_clockType);
            this.gb_information.Controls.Add(this.label1);
            this.gb_information.Controls.Add(this.desc_location);
            this.gb_information.Controls.Add(this.desc_sizeType);
            this.gb_information.Controls.Add(this.desc_Monitor);
            this.gb_information.Location = new System.Drawing.Point(265, 12);
            this.gb_information.Name = "gb_information";
            this.gb_information.Size = new System.Drawing.Size(200, 384);
            this.gb_information.TabIndex = 1;
            this.gb_information.TabStop = false;
            this.gb_information.Text = "Preset Information";
            // 
            // label_displaySeconds
            // 
            this.label_displaySeconds.AutoSize = true;
            this.label_displaySeconds.Location = new System.Drawing.Point(101, 365);
            this.label_displaySeconds.Name = "label_displaySeconds";
            this.label_displaySeconds.Size = new System.Drawing.Size(13, 13);
            this.label_displaySeconds.TabIndex = 17;
            this.label_displaySeconds.Text = "0";
            // 
            // desc_displaySeconds
            // 
            this.desc_displaySeconds.AutoSize = true;
            this.desc_displaySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_displaySeconds.Location = new System.Drawing.Point(6, 365);
            this.desc_displaySeconds.Name = "desc_displaySeconds";
            this.desc_displaySeconds.Size = new System.Drawing.Size(89, 13);
            this.desc_displaySeconds.TabIndex = 16;
            this.desc_displaySeconds.Text = "Display Seconds:";
            // 
            // pb_overtimeColour
            // 
            this.pb_overtimeColour.Location = new System.Drawing.Point(85, 321);
            this.pb_overtimeColour.Name = "pb_overtimeColour";
            this.pb_overtimeColour.Size = new System.Drawing.Size(19, 20);
            this.pb_overtimeColour.TabIndex = 15;
            this.pb_overtimeColour.TabStop = false;
            // 
            // pb_minUntilColour
            // 
            this.pb_minUntilColour.Location = new System.Drawing.Point(66, 321);
            this.pb_minUntilColour.Name = "pb_minUntilColour";
            this.pb_minUntilColour.Size = new System.Drawing.Size(19, 20);
            this.pb_minUntilColour.TabIndex = 14;
            this.pb_minUntilColour.TabStop = false;
            // 
            // pb_deadlineColour
            // 
            this.pb_deadlineColour.Location = new System.Drawing.Point(47, 321);
            this.pb_deadlineColour.Name = "pb_deadlineColour";
            this.pb_deadlineColour.Size = new System.Drawing.Size(19, 20);
            this.pb_deadlineColour.TabIndex = 13;
            this.pb_deadlineColour.TabStop = false;
            // 
            // pb_clockColour
            // 
            this.pb_clockColour.Location = new System.Drawing.Point(28, 321);
            this.pb_clockColour.Name = "pb_clockColour";
            this.pb_clockColour.Size = new System.Drawing.Size(19, 20);
            this.pb_clockColour.TabIndex = 12;
            this.pb_clockColour.TabStop = false;
            // 
            // desc_digitalColour
            // 
            this.desc_digitalColour.AutoSize = true;
            this.desc_digitalColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_digitalColour.Location = new System.Drawing.Point(6, 305);
            this.desc_digitalColour.Name = "desc_digitalColour";
            this.desc_digitalColour.Size = new System.Drawing.Size(75, 13);
            this.desc_digitalColour.TabIndex = 11;
            this.desc_digitalColour.Text = "Clock Colours:";
            // 
            // pb_bgColour
            // 
            this.pb_bgColour.Location = new System.Drawing.Point(9, 321);
            this.pb_bgColour.Name = "pb_bgColour";
            this.pb_bgColour.Size = new System.Drawing.Size(19, 20);
            this.pb_bgColour.TabIndex = 10;
            this.pb_bgColour.TabStop = false;
            // 
            // help_btn_presetSettings
            // 
            this.help_btn_presetSettings.Location = new System.Drawing.Point(178, 359);
            this.help_btn_presetSettings.Name = "help_btn_presetSettings";
            this.help_btn_presetSettings.Size = new System.Drawing.Size(22, 25);
            this.help_btn_presetSettings.TabIndex = 9;
            this.help_btn_presetSettings.Text = "?";
            this.help_btn_presetSettings.UseVisualStyleBackColor = true;
            this.help_btn_presetSettings.Click += new System.EventHandler(this.help_btn_presetSettings_Click);
            // 
            // label_clockType
            // 
            this.label_clockType.AutoSize = true;
            this.label_clockType.Location = new System.Drawing.Point(19, 274);
            this.label_clockType.Name = "label_clockType";
            this.label_clockType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_clockType.Size = new System.Drawing.Size(53, 13);
            this.label_clockType.TabIndex = 9;
            this.label_clockType.Text = "Unknown";
            // 
            // label_windowSize
            // 
            this.label_windowSize.AutoSize = true;
            this.label_windowSize.Location = new System.Drawing.Point(19, 217);
            this.label_windowSize.Name = "label_windowSize";
            this.label_windowSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_windowSize.Size = new System.Drawing.Size(53, 13);
            this.label_windowSize.TabIndex = 8;
            this.label_windowSize.Text = "Unknown";
            // 
            // label_location
            // 
            this.label_location.Location = new System.Drawing.Point(15, 147);
            this.label_location.Name = "label_location";
            this.label_location.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_location.Size = new System.Drawing.Size(179, 45);
            this.label_location.TabIndex = 7;
            this.label_location.Text = "x: 0 y: 0";
            // 
            // label_sizeType
            // 
            this.label_sizeType.AutoSize = true;
            this.label_sizeType.Location = new System.Drawing.Point(16, 98);
            this.label_sizeType.Name = "label_sizeType";
            this.label_sizeType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_sizeType.Size = new System.Drawing.Size(53, 13);
            this.label_sizeType.TabIndex = 6;
            this.label_sizeType.Text = "Unknown";
            // 
            // label_numOfMon
            // 
            this.label_numOfMon.AutoSize = true;
            this.label_numOfMon.Location = new System.Drawing.Point(15, 50);
            this.label_numOfMon.Name = "label_numOfMon";
            this.label_numOfMon.Size = new System.Drawing.Size(13, 13);
            this.label_numOfMon.TabIndex = 5;
            this.label_numOfMon.Text = "0";
            // 
            // desc_clockType
            // 
            this.desc_clockType.AutoSize = true;
            this.desc_clockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_clockType.Location = new System.Drawing.Point(6, 252);
            this.desc_clockType.Name = "desc_clockType";
            this.desc_clockType.Size = new System.Drawing.Size(67, 13);
            this.desc_clockType.TabIndex = 4;
            this.desc_clockType.Text = "Clock Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Windows Size: ";
            // 
            // desc_location
            // 
            this.desc_location.AutoSize = true;
            this.desc_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_location.Location = new System.Drawing.Point(6, 123);
            this.desc_location.Name = "desc_location";
            this.desc_location.Size = new System.Drawing.Size(54, 13);
            this.desc_location.TabIndex = 2;
            this.desc_location.Text = "Location: ";
            // 
            // desc_sizeType
            // 
            this.desc_sizeType.AutoSize = true;
            this.desc_sizeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_sizeType.Location = new System.Drawing.Point(6, 76);
            this.desc_sizeType.Name = "desc_sizeType";
            this.desc_sizeType.Size = new System.Drawing.Size(60, 13);
            this.desc_sizeType.TabIndex = 1;
            this.desc_sizeType.Text = "Size Type: ";
            // 
            // desc_Monitor
            // 
            this.desc_Monitor.AutoSize = true;
            this.desc_Monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_Monitor.Location = new System.Drawing.Point(6, 26);
            this.desc_Monitor.Name = "desc_Monitor";
            this.desc_Monitor.Size = new System.Drawing.Size(105, 13);
            this.desc_Monitor.TabIndex = 0;
            this.desc_Monitor.Text = "Number of Monitors: ";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(265, 402);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(200, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lv_presetListView
            // 
            this.lv_presetListView.GridLines = true;
            this.lv_presetListView.Location = new System.Drawing.Point(12, 12);
            this.lv_presetListView.MultiSelect = false;
            this.lv_presetListView.Name = "lv_presetListView";
            this.lv_presetListView.Size = new System.Drawing.Size(217, 413);
            this.lv_presetListView.TabIndex = 8;
            this.lv_presetListView.UseCompatibleStateImageBehavior = false;
            this.lv_presetListView.View = System.Windows.Forms.View.Details;
            this.lv_presetListView.SelectedIndexChanged += new System.EventHandler(this.lv_presetListView_SelectedIndexChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = global::Screen_Clock.Properties.Resources.editIcon;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.Enabled = false;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.Location = new System.Drawing.Point(235, 129);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(24, 24);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackgroundImage = global::Screen_Clock.Properties.Resources.removeIcon;
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.Location = new System.Drawing.Point(235, 223);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(24, 24);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::Screen_Clock.Properties.Resources.addIcon;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Location = new System.Drawing.Point(235, 99);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(24, 24);
            this.btn_add.TabIndex = 5;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_down
            // 
            this.btn_down.BackgroundImage = global::Screen_Clock.Properties.Resources.downIcon;
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_down.FlatAppearance.BorderSize = 0;
            this.btn_down.Location = new System.Drawing.Point(235, 191);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(24, 26);
            this.btn_down.TabIndex = 4;
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackgroundImage = global::Screen_Clock.Properties.Resources.upIcon;
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_up.FlatAppearance.BorderSize = 0;
            this.btn_up.Location = new System.Drawing.Point(235, 159);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(24, 26);
            this.btn_up.TabIndex = 3;
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // PresetSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 437);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lv_presetListView);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.gb_information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PresetSettingsForm";
            this.Text = "Preset Settings";
            this.gb_information.ResumeLayout(false);
            this.gb_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_overtimeColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minUntilColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deadlineColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clockColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bgColour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_information;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListView lv_presetListView;
        private System.Windows.Forms.Label desc_Monitor;
        private System.Windows.Forms.Label desc_sizeType;
        private System.Windows.Forms.Label desc_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label desc_clockType;
        private System.Windows.Forms.Label label_clockType;
        private System.Windows.Forms.Label label_windowSize;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_sizeType;
        private System.Windows.Forms.Label label_numOfMon;
        private System.Windows.Forms.Button help_btn_presetSettings;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.PictureBox pb_overtimeColour;
        private System.Windows.Forms.PictureBox pb_minUntilColour;
        private System.Windows.Forms.PictureBox pb_deadlineColour;
        private System.Windows.Forms.PictureBox pb_clockColour;
        private System.Windows.Forms.Label desc_digitalColour;
        private System.Windows.Forms.PictureBox pb_bgColour;
        private System.Windows.Forms.Label label_displaySeconds;
        private System.Windows.Forms.Label desc_displaySeconds;
    }
}