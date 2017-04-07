namespace Screen_Clock.Forms
{
    partial class AnalogLayoutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalogLayoutForm));
            this.gb_Settings = new System.Windows.Forms.GroupBox();
            this.help_btn_analogLayoutCustomization = new System.Windows.Forms.Button();
            this.btn_applyDeadlineDropShadowColour = new System.Windows.Forms.Button();
            this.cb_drawDeadlineDropShadow = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_applyHourDropShadowColour = new System.Windows.Forms.Button();
            this.btn_applyMinuteDropShadowColour = new System.Windows.Forms.Button();
            this.btn_applySecondDropShadowColour = new System.Windows.Forms.Button();
            this.cb_drawSecondDropShadow = new System.Windows.Forms.CheckBox();
            this.cb_drawMinuteDropShadow = new System.Windows.Forms.CheckBox();
            this.cb_drawHourDropShadow = new System.Windows.Forms.CheckBox();
            this.cb_drawSecondHand = new System.Windows.Forms.CheckBox();
            this.cb_drawMinuteHand = new System.Windows.Forms.CheckBox();
            this.cb_drawHourHand = new System.Windows.Forms.CheckBox();
            this.lbl_draw_shadows = new System.Windows.Forms.Label();
            this.lbl_draw_hands = new System.Windows.Forms.Label();
            this.lbl_draw = new System.Windows.Forms.Label();
            this.lbl_normal = new System.Windows.Forms.Label();
            this.btn_applyDeadlineColour = new System.Windows.Forms.Button();
            this.lbl_deadlineColours = new System.Windows.Forms.Label();
            this.r_applySmoothTick = new System.Windows.Forms.RadioButton();
            this.r_applyNormalTick = new System.Windows.Forms.RadioButton();
            this.lbl_secondsBehavior = new System.Windows.Forms.Label();
            this.btn_applySecondHandColour = new System.Windows.Forms.Button();
            this.btn_applyMinuteHandColour = new System.Windows.Forms.Button();
            this.btn_applyHourHandColour = new System.Windows.Forms.Button();
            this.lbl_handColours = new System.Windows.Forms.Label();
            this.cb_drawDropShadow = new System.Windows.Forms.CheckBox();
            this.btn_applyFontColour = new System.Windows.Forms.Button();
            this.lbl_fontColour = new System.Windows.Forms.Label();
            this.cb_applyRimGradientMode = new System.Windows.Forms.ComboBox();
            this.btn_applyRimColour_low = new System.Windows.Forms.Button();
            this.btn_applyRimColour_high = new System.Windows.Forms.Button();
            this.lbl_rimColour = new System.Windows.Forms.Label();
            this.cb_applyFaceGradientMode = new System.Windows.Forms.ComboBox();
            this.btn_applyFaceColour_low = new System.Windows.Forms.Button();
            this.btn_applyFaceColour_high = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_applyDropShadowColour = new System.Windows.Forms.Button();
            this.lbl_dropShadow = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.gb_displayDeadline = new System.Windows.Forms.GroupBox();
            this.cCountOvertime = new System.Windows.Forms.CheckBox();
            this.minUpDown = new System.Windows.Forms.NumericUpDown();
            this.label_minutesLeft = new System.Windows.Forms.Label();
            this.cChangeColourDeadline = new System.Windows.Forms.CheckBox();
            this.deadlineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_deadline = new System.Windows.Forms.Label();
            this.cDispDeadline = new System.Windows.Forms.CheckBox();
            this.tAnalogDisplayClockTick = new System.Windows.Forms.Timer(this.components);
            this.analog_dispClock = new AnalogClock.AnalogClock();
            this.btn_playPauseClock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_resetToDefault = new System.Windows.Forms.Button();
            this.gb_Settings.SuspendLayout();
            this.gb_displayDeadline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Settings
            // 
            this.gb_Settings.Controls.Add(this.help_btn_analogLayoutCustomization);
            this.gb_Settings.Controls.Add(this.btn_applyDeadlineDropShadowColour);
            this.gb_Settings.Controls.Add(this.cb_drawDeadlineDropShadow);
            this.gb_Settings.Controls.Add(this.label2);
            this.gb_Settings.Controls.Add(this.btn_applyHourDropShadowColour);
            this.gb_Settings.Controls.Add(this.btn_applyMinuteDropShadowColour);
            this.gb_Settings.Controls.Add(this.btn_applySecondDropShadowColour);
            this.gb_Settings.Controls.Add(this.cb_drawSecondDropShadow);
            this.gb_Settings.Controls.Add(this.cb_drawMinuteDropShadow);
            this.gb_Settings.Controls.Add(this.cb_drawHourDropShadow);
            this.gb_Settings.Controls.Add(this.cb_drawSecondHand);
            this.gb_Settings.Controls.Add(this.cb_drawMinuteHand);
            this.gb_Settings.Controls.Add(this.cb_drawHourHand);
            this.gb_Settings.Controls.Add(this.lbl_draw_shadows);
            this.gb_Settings.Controls.Add(this.lbl_draw_hands);
            this.gb_Settings.Controls.Add(this.lbl_draw);
            this.gb_Settings.Controls.Add(this.lbl_normal);
            this.gb_Settings.Controls.Add(this.btn_applyDeadlineColour);
            this.gb_Settings.Controls.Add(this.lbl_deadlineColours);
            this.gb_Settings.Controls.Add(this.r_applySmoothTick);
            this.gb_Settings.Controls.Add(this.r_applyNormalTick);
            this.gb_Settings.Controls.Add(this.lbl_secondsBehavior);
            this.gb_Settings.Controls.Add(this.btn_applySecondHandColour);
            this.gb_Settings.Controls.Add(this.btn_applyMinuteHandColour);
            this.gb_Settings.Controls.Add(this.btn_applyHourHandColour);
            this.gb_Settings.Controls.Add(this.lbl_handColours);
            this.gb_Settings.Controls.Add(this.cb_drawDropShadow);
            this.gb_Settings.Controls.Add(this.btn_applyFontColour);
            this.gb_Settings.Controls.Add(this.lbl_fontColour);
            this.gb_Settings.Controls.Add(this.cb_applyRimGradientMode);
            this.gb_Settings.Controls.Add(this.btn_applyRimColour_low);
            this.gb_Settings.Controls.Add(this.btn_applyRimColour_high);
            this.gb_Settings.Controls.Add(this.lbl_rimColour);
            this.gb_Settings.Controls.Add(this.cb_applyFaceGradientMode);
            this.gb_Settings.Controls.Add(this.btn_applyFaceColour_low);
            this.gb_Settings.Controls.Add(this.btn_applyFaceColour_high);
            this.gb_Settings.Controls.Add(this.label1);
            this.gb_Settings.Controls.Add(this.btn_applyDropShadowColour);
            this.gb_Settings.Controls.Add(this.lbl_dropShadow);
            this.gb_Settings.Location = new System.Drawing.Point(13, 13);
            this.gb_Settings.Name = "gb_Settings";
            this.gb_Settings.Size = new System.Drawing.Size(212, 462);
            this.gb_Settings.TabIndex = 0;
            this.gb_Settings.TabStop = false;
            this.gb_Settings.Text = "Settings";
            // 
            // help_btn_analogLayoutCustomization
            // 
            this.help_btn_analogLayoutCustomization.Location = new System.Drawing.Point(190, 7);
            this.help_btn_analogLayoutCustomization.Name = "help_btn_analogLayoutCustomization";
            this.help_btn_analogLayoutCustomization.Size = new System.Drawing.Size(22, 25);
            this.help_btn_analogLayoutCustomization.TabIndex = 60;
            this.help_btn_analogLayoutCustomization.Text = "?";
            this.help_btn_analogLayoutCustomization.UseVisualStyleBackColor = true;
            this.help_btn_analogLayoutCustomization.Click += new System.EventHandler(this.help_btn_analogLayoutCustomization_Click);
            // 
            // btn_applyDeadlineDropShadowColour
            // 
            this.btn_applyDeadlineDropShadowColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyDeadlineDropShadowColour.Location = new System.Drawing.Point(152, 438);
            this.btn_applyDeadlineDropShadowColour.Name = "btn_applyDeadlineDropShadowColour";
            this.btn_applyDeadlineDropShadowColour.Size = new System.Drawing.Size(54, 17);
            this.btn_applyDeadlineDropShadowColour.TabIndex = 52;
            this.btn_applyDeadlineDropShadowColour.UseVisualStyleBackColor = true;
            this.btn_applyDeadlineDropShadowColour.Click += new System.EventHandler(this.btn_applyDeadlineDropShadowColour_Click);
            // 
            // cb_drawDeadlineDropShadow
            // 
            this.cb_drawDeadlineDropShadow.AutoSize = true;
            this.cb_drawDeadlineDropShadow.Location = new System.Drawing.Point(83, 439);
            this.cb_drawDeadlineDropShadow.Name = "cb_drawDeadlineDropShadow";
            this.cb_drawDeadlineDropShadow.Size = new System.Drawing.Size(68, 17);
            this.cb_drawDeadlineDropShadow.TabIndex = 51;
            this.cb_drawDeadlineDropShadow.Text = "Deadline";
            this.cb_drawDeadlineDropShadow.UseVisualStyleBackColor = true;
            this.cb_drawDeadlineDropShadow.CheckedChanged += new System.EventHandler(this.cb_drawDeadlineDropShadow_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "Shadow\r\nColours:";
            // 
            // btn_applyHourDropShadowColour
            // 
            this.btn_applyHourDropShadowColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyHourDropShadowColour.Location = new System.Drawing.Point(152, 371);
            this.btn_applyHourDropShadowColour.Name = "btn_applyHourDropShadowColour";
            this.btn_applyHourDropShadowColour.Size = new System.Drawing.Size(54, 17);
            this.btn_applyHourDropShadowColour.TabIndex = 49;
            this.btn_applyHourDropShadowColour.UseVisualStyleBackColor = true;
            this.btn_applyHourDropShadowColour.Click += new System.EventHandler(this.btn_applyHourDropShadowColour_Click);
            // 
            // btn_applyMinuteDropShadowColour
            // 
            this.btn_applyMinuteDropShadowColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyMinuteDropShadowColour.Location = new System.Drawing.Point(152, 394);
            this.btn_applyMinuteDropShadowColour.Name = "btn_applyMinuteDropShadowColour";
            this.btn_applyMinuteDropShadowColour.Size = new System.Drawing.Size(54, 17);
            this.btn_applyMinuteDropShadowColour.TabIndex = 48;
            this.btn_applyMinuteDropShadowColour.UseVisualStyleBackColor = true;
            this.btn_applyMinuteDropShadowColour.Click += new System.EventHandler(this.btn_applyMinuteDropShadowColour_Click);
            // 
            // btn_applySecondDropShadowColour
            // 
            this.btn_applySecondDropShadowColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applySecondDropShadowColour.Location = new System.Drawing.Point(152, 415);
            this.btn_applySecondDropShadowColour.Name = "btn_applySecondDropShadowColour";
            this.btn_applySecondDropShadowColour.Size = new System.Drawing.Size(54, 17);
            this.btn_applySecondDropShadowColour.TabIndex = 47;
            this.btn_applySecondDropShadowColour.UseVisualStyleBackColor = true;
            this.btn_applySecondDropShadowColour.Click += new System.EventHandler(this.btn_applySecondDropShadowColour_Click);
            // 
            // cb_drawSecondDropShadow
            // 
            this.cb_drawSecondDropShadow.AutoSize = true;
            this.cb_drawSecondDropShadow.Location = new System.Drawing.Point(83, 416);
            this.cb_drawSecondDropShadow.Name = "cb_drawSecondDropShadow";
            this.cb_drawSecondDropShadow.Size = new System.Drawing.Size(63, 17);
            this.cb_drawSecondDropShadow.TabIndex = 46;
            this.cb_drawSecondDropShadow.Text = "Second";
            this.cb_drawSecondDropShadow.UseVisualStyleBackColor = true;
            this.cb_drawSecondDropShadow.CheckedChanged += new System.EventHandler(this.cb_drawSecondDropShadow_CheckedChanged);
            // 
            // cb_drawMinuteDropShadow
            // 
            this.cb_drawMinuteDropShadow.AutoSize = true;
            this.cb_drawMinuteDropShadow.Location = new System.Drawing.Point(83, 394);
            this.cb_drawMinuteDropShadow.Name = "cb_drawMinuteDropShadow";
            this.cb_drawMinuteDropShadow.Size = new System.Drawing.Size(58, 17);
            this.cb_drawMinuteDropShadow.TabIndex = 45;
            this.cb_drawMinuteDropShadow.Text = "Minute";
            this.cb_drawMinuteDropShadow.UseVisualStyleBackColor = true;
            this.cb_drawMinuteDropShadow.CheckedChanged += new System.EventHandler(this.cb_drawMinuteDropShadow_CheckedChanged);
            // 
            // cb_drawHourDropShadow
            // 
            this.cb_drawHourDropShadow.AutoSize = true;
            this.cb_drawHourDropShadow.Location = new System.Drawing.Point(83, 371);
            this.cb_drawHourDropShadow.Name = "cb_drawHourDropShadow";
            this.cb_drawHourDropShadow.Size = new System.Drawing.Size(49, 17);
            this.cb_drawHourDropShadow.TabIndex = 44;
            this.cb_drawHourDropShadow.Text = "Hour";
            this.cb_drawHourDropShadow.UseVisualStyleBackColor = true;
            this.cb_drawHourDropShadow.CheckedChanged += new System.EventHandler(this.cb_drawHourDropShadow_CheckedChanged);
            // 
            // cb_drawSecondHand
            // 
            this.cb_drawSecondHand.AutoSize = true;
            this.cb_drawSecondHand.Location = new System.Drawing.Point(9, 416);
            this.cb_drawSecondHand.Name = "cb_drawSecondHand";
            this.cb_drawSecondHand.Size = new System.Drawing.Size(63, 17);
            this.cb_drawSecondHand.TabIndex = 43;
            this.cb_drawSecondHand.Text = "Second";
            this.cb_drawSecondHand.UseVisualStyleBackColor = true;
            this.cb_drawSecondHand.CheckedChanged += new System.EventHandler(this.cb_drawSecondHand_CheckedChanged);
            // 
            // cb_drawMinuteHand
            // 
            this.cb_drawMinuteHand.AutoSize = true;
            this.cb_drawMinuteHand.Location = new System.Drawing.Point(9, 394);
            this.cb_drawMinuteHand.Name = "cb_drawMinuteHand";
            this.cb_drawMinuteHand.Size = new System.Drawing.Size(58, 17);
            this.cb_drawMinuteHand.TabIndex = 42;
            this.cb_drawMinuteHand.Text = "Minute";
            this.cb_drawMinuteHand.UseVisualStyleBackColor = true;
            this.cb_drawMinuteHand.CheckedChanged += new System.EventHandler(this.cb_drawMinuteHand_CheckedChanged);
            // 
            // cb_drawHourHand
            // 
            this.cb_drawHourHand.AutoSize = true;
            this.cb_drawHourHand.Location = new System.Drawing.Point(9, 371);
            this.cb_drawHourHand.Name = "cb_drawHourHand";
            this.cb_drawHourHand.Size = new System.Drawing.Size(49, 17);
            this.cb_drawHourHand.TabIndex = 41;
            this.cb_drawHourHand.Text = "Hour";
            this.cb_drawHourHand.UseVisualStyleBackColor = true;
            this.cb_drawHourHand.CheckedChanged += new System.EventHandler(this.cb_drawHourHand_CheckedChanged);
            // 
            // lbl_draw_shadows
            // 
            this.lbl_draw_shadows.AutoSize = true;
            this.lbl_draw_shadows.Location = new System.Drawing.Point(80, 355);
            this.lbl_draw_shadows.Name = "lbl_draw_shadows";
            this.lbl_draw_shadows.Size = new System.Drawing.Size(54, 13);
            this.lbl_draw_shadows.TabIndex = 40;
            this.lbl_draw_shadows.Text = "Shadows:";
            // 
            // lbl_draw_hands
            // 
            this.lbl_draw_hands.AutoSize = true;
            this.lbl_draw_hands.Location = new System.Drawing.Point(6, 355);
            this.lbl_draw_hands.Name = "lbl_draw_hands";
            this.lbl_draw_hands.Size = new System.Drawing.Size(41, 13);
            this.lbl_draw_hands.TabIndex = 38;
            this.lbl_draw_hands.Text = "Hands:";
            // 
            // lbl_draw
            // 
            this.lbl_draw.AutoSize = true;
            this.lbl_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_draw.Location = new System.Drawing.Point(6, 337);
            this.lbl_draw.Name = "lbl_draw";
            this.lbl_draw.Size = new System.Drawing.Size(35, 13);
            this.lbl_draw.TabIndex = 36;
            this.lbl_draw.Text = "Draw:";
            // 
            // lbl_normal
            // 
            this.lbl_normal.AutoSize = true;
            this.lbl_normal.Location = new System.Drawing.Point(37, 310);
            this.lbl_normal.Name = "lbl_normal";
            this.lbl_normal.Size = new System.Drawing.Size(40, 13);
            this.lbl_normal.TabIndex = 30;
            this.lbl_normal.Text = "Normal";
            // 
            // btn_applyDeadlineColour
            // 
            this.btn_applyDeadlineColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyDeadlineColour.Location = new System.Drawing.Point(9, 305);
            this.btn_applyDeadlineColour.Name = "btn_applyDeadlineColour";
            this.btn_applyDeadlineColour.Size = new System.Drawing.Size(25, 23);
            this.btn_applyDeadlineColour.TabIndex = 28;
            this.btn_applyDeadlineColour.UseVisualStyleBackColor = true;
            this.btn_applyDeadlineColour.Click += new System.EventHandler(this.btn_applyDeadlineColour_Click);
            // 
            // lbl_deadlineColours
            // 
            this.lbl_deadlineColours.AutoSize = true;
            this.lbl_deadlineColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deadlineColours.Location = new System.Drawing.Point(6, 289);
            this.lbl_deadlineColours.Name = "lbl_deadlineColours";
            this.lbl_deadlineColours.Size = new System.Drawing.Size(125, 13);
            this.lbl_deadlineColours.TabIndex = 27;
            this.lbl_deadlineColours.Text = "Deadline Hand(s) Colour:";
            // 
            // r_applySmoothTick
            // 
            this.r_applySmoothTick.AutoSize = true;
            this.r_applySmoothTick.Location = new System.Drawing.Point(121, 244);
            this.r_applySmoothTick.Name = "r_applySmoothTick";
            this.r_applySmoothTick.Size = new System.Drawing.Size(85, 17);
            this.r_applySmoothTick.TabIndex = 26;
            this.r_applySmoothTick.TabStop = true;
            this.r_applySmoothTick.Text = "Smooth Tick";
            this.r_applySmoothTick.UseVisualStyleBackColor = true;
            this.r_applySmoothTick.CheckedChanged += new System.EventHandler(this.r_applySmoothTick_CheckedChanged);
            // 
            // r_applyNormalTick
            // 
            this.r_applyNormalTick.AutoSize = true;
            this.r_applyNormalTick.Location = new System.Drawing.Point(9, 244);
            this.r_applyNormalTick.Name = "r_applyNormalTick";
            this.r_applyNormalTick.Size = new System.Drawing.Size(82, 17);
            this.r_applyNormalTick.TabIndex = 25;
            this.r_applyNormalTick.TabStop = true;
            this.r_applyNormalTick.Text = "Normal Tick";
            this.r_applyNormalTick.UseVisualStyleBackColor = true;
            this.r_applyNormalTick.CheckedChanged += new System.EventHandler(this.r_applyNormalTick_CheckedChanged);
            // 
            // lbl_secondsBehavior
            // 
            this.lbl_secondsBehavior.AutoSize = true;
            this.lbl_secondsBehavior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secondsBehavior.Location = new System.Drawing.Point(6, 226);
            this.lbl_secondsBehavior.Name = "lbl_secondsBehavior";
            this.lbl_secondsBehavior.Size = new System.Drawing.Size(92, 13);
            this.lbl_secondsBehavior.TabIndex = 23;
            this.lbl_secondsBehavior.Text = "Second Behavior:";
            // 
            // btn_applySecondHandColour
            // 
            this.btn_applySecondHandColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applySecondHandColour.Location = new System.Drawing.Point(71, 200);
            this.btn_applySecondHandColour.Name = "btn_applySecondHandColour";
            this.btn_applySecondHandColour.Size = new System.Drawing.Size(25, 23);
            this.btn_applySecondHandColour.TabIndex = 22;
            this.btn_applySecondHandColour.UseVisualStyleBackColor = true;
            this.btn_applySecondHandColour.Click += new System.EventHandler(this.btn_applySecondHandColour_Click);
            // 
            // btn_applyMinuteHandColour
            // 
            this.btn_applyMinuteHandColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyMinuteHandColour.Location = new System.Drawing.Point(40, 200);
            this.btn_applyMinuteHandColour.Name = "btn_applyMinuteHandColour";
            this.btn_applyMinuteHandColour.Size = new System.Drawing.Size(25, 23);
            this.btn_applyMinuteHandColour.TabIndex = 21;
            this.btn_applyMinuteHandColour.UseVisualStyleBackColor = true;
            this.btn_applyMinuteHandColour.Click += new System.EventHandler(this.btn_applyMinuteHandColour_Click);
            // 
            // btn_applyHourHandColour
            // 
            this.btn_applyHourHandColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyHourHandColour.Location = new System.Drawing.Point(9, 200);
            this.btn_applyHourHandColour.Name = "btn_applyHourHandColour";
            this.btn_applyHourHandColour.Size = new System.Drawing.Size(25, 23);
            this.btn_applyHourHandColour.TabIndex = 20;
            this.btn_applyHourHandColour.UseVisualStyleBackColor = true;
            this.btn_applyHourHandColour.Click += new System.EventHandler(this.btn_applyHourHandColour_Click);
            // 
            // lbl_handColours
            // 
            this.lbl_handColours.AutoSize = true;
            this.lbl_handColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_handColours.Location = new System.Drawing.Point(6, 184);
            this.lbl_handColours.Name = "lbl_handColours";
            this.lbl_handColours.Size = new System.Drawing.Size(186, 13);
            this.lbl_handColours.TabIndex = 19;
            this.lbl_handColours.Text = "\'Hour - Minute - Second\' Hand Colour:";
            // 
            // cb_drawDropShadow
            // 
            this.cb_drawDropShadow.AutoSize = true;
            this.cb_drawDropShadow.Location = new System.Drawing.Point(40, 36);
            this.cb_drawDropShadow.Name = "cb_drawDropShadow";
            this.cb_drawDropShadow.Size = new System.Drawing.Size(125, 17);
            this.cb_drawDropShadow.TabIndex = 18;
            this.cb_drawDropShadow.Text = "Draw Drop Shadow?";
            this.cb_drawDropShadow.UseVisualStyleBackColor = true;
            this.cb_drawDropShadow.CheckedChanged += new System.EventHandler(this.cb_drawDropShadow_CheckedChanged);
            // 
            // btn_applyFontColour
            // 
            this.btn_applyFontColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyFontColour.Location = new System.Drawing.Point(9, 158);
            this.btn_applyFontColour.Name = "btn_applyFontColour";
            this.btn_applyFontColour.Size = new System.Drawing.Size(25, 23);
            this.btn_applyFontColour.TabIndex = 17;
            this.btn_applyFontColour.UseVisualStyleBackColor = true;
            this.btn_applyFontColour.Click += new System.EventHandler(this.btn_applyFontColour_Click);
            // 
            // lbl_fontColour
            // 
            this.lbl_fontColour.AutoSize = true;
            this.lbl_fontColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fontColour.Location = new System.Drawing.Point(6, 142);
            this.lbl_fontColour.Name = "lbl_fontColour";
            this.lbl_fontColour.Size = new System.Drawing.Size(64, 13);
            this.lbl_fontColour.TabIndex = 16;
            this.lbl_fontColour.Text = "Font Colour:";
            // 
            // cb_applyRimGradientMode
            // 
            this.cb_applyRimGradientMode.FormattingEnabled = true;
            this.cb_applyRimGradientMode.Location = new System.Drawing.Point(71, 118);
            this.cb_applyRimGradientMode.Name = "cb_applyRimGradientMode";
            this.cb_applyRimGradientMode.Size = new System.Drawing.Size(135, 21);
            this.cb_applyRimGradientMode.TabIndex = 15;
            this.cb_applyRimGradientMode.SelectedIndexChanged += new System.EventHandler(this.cb_applyRimGradientMode_SelectedIndexChanged);
            // 
            // btn_applyRimColour_low
            // 
            this.btn_applyRimColour_low.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyRimColour_low.Location = new System.Drawing.Point(40, 116);
            this.btn_applyRimColour_low.Name = "btn_applyRimColour_low";
            this.btn_applyRimColour_low.Size = new System.Drawing.Size(25, 23);
            this.btn_applyRimColour_low.TabIndex = 14;
            this.btn_applyRimColour_low.UseVisualStyleBackColor = true;
            this.btn_applyRimColour_low.Click += new System.EventHandler(this.btn_applyRimColour_low_Click);
            // 
            // btn_applyRimColour_high
            // 
            this.btn_applyRimColour_high.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyRimColour_high.Location = new System.Drawing.Point(9, 116);
            this.btn_applyRimColour_high.Name = "btn_applyRimColour_high";
            this.btn_applyRimColour_high.Size = new System.Drawing.Size(25, 23);
            this.btn_applyRimColour_high.TabIndex = 13;
            this.btn_applyRimColour_high.UseVisualStyleBackColor = true;
            this.btn_applyRimColour_high.Click += new System.EventHandler(this.btn_applyRimColour_high_Click);
            // 
            // lbl_rimColour
            // 
            this.lbl_rimColour.AutoSize = true;
            this.lbl_rimColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rimColour.Location = new System.Drawing.Point(6, 100);
            this.lbl_rimColour.Name = "lbl_rimColour";
            this.lbl_rimColour.Size = new System.Drawing.Size(61, 13);
            this.lbl_rimColour.TabIndex = 12;
            this.lbl_rimColour.Text = "Rim Colour:";
            // 
            // cb_applyFaceGradientMode
            // 
            this.cb_applyFaceGradientMode.FormattingEnabled = true;
            this.cb_applyFaceGradientMode.Location = new System.Drawing.Point(71, 76);
            this.cb_applyFaceGradientMode.Name = "cb_applyFaceGradientMode";
            this.cb_applyFaceGradientMode.Size = new System.Drawing.Size(135, 21);
            this.cb_applyFaceGradientMode.TabIndex = 11;
            this.cb_applyFaceGradientMode.SelectedIndexChanged += new System.EventHandler(this.cb_applyFaceGradientMode_SelectedIndexChanged);
            // 
            // btn_applyFaceColour_low
            // 
            this.btn_applyFaceColour_low.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyFaceColour_low.Location = new System.Drawing.Point(40, 74);
            this.btn_applyFaceColour_low.Name = "btn_applyFaceColour_low";
            this.btn_applyFaceColour_low.Size = new System.Drawing.Size(25, 23);
            this.btn_applyFaceColour_low.TabIndex = 10;
            this.btn_applyFaceColour_low.UseVisualStyleBackColor = true;
            this.btn_applyFaceColour_low.Click += new System.EventHandler(this.btn_applyFaceColour_low_Click);
            // 
            // btn_applyFaceColour_high
            // 
            this.btn_applyFaceColour_high.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyFaceColour_high.Location = new System.Drawing.Point(9, 74);
            this.btn_applyFaceColour_high.Name = "btn_applyFaceColour_high";
            this.btn_applyFaceColour_high.Size = new System.Drawing.Size(25, 23);
            this.btn_applyFaceColour_high.TabIndex = 9;
            this.btn_applyFaceColour_high.UseVisualStyleBackColor = true;
            this.btn_applyFaceColour_high.Click += new System.EventHandler(this.btn_applyFaceColour_high_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Face Colour:";
            // 
            // btn_applyDropShadowColour
            // 
            this.btn_applyDropShadowColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_applyDropShadowColour.Location = new System.Drawing.Point(9, 32);
            this.btn_applyDropShadowColour.Name = "btn_applyDropShadowColour";
            this.btn_applyDropShadowColour.Size = new System.Drawing.Size(25, 23);
            this.btn_applyDropShadowColour.TabIndex = 7;
            this.btn_applyDropShadowColour.UseVisualStyleBackColor = true;
            this.btn_applyDropShadowColour.Click += new System.EventHandler(this.btn_applyDropShadowColour_Click);
            // 
            // lbl_dropShadow
            // 
            this.lbl_dropShadow.AutoSize = true;
            this.lbl_dropShadow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dropShadow.Location = new System.Drawing.Point(6, 16);
            this.lbl_dropShadow.Name = "lbl_dropShadow";
            this.lbl_dropShadow.Size = new System.Drawing.Size(108, 13);
            this.lbl_dropShadow.TabIndex = 6;
            this.lbl_dropShadow.Text = "Drop Shadow Colour:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(231, 451);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(211, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Enabled = false;
            this.btn_apply.Location = new System.Drawing.Point(231, 422);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(211, 23);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // gb_displayDeadline
            // 
            this.gb_displayDeadline.Controls.Add(this.cCountOvertime);
            this.gb_displayDeadline.Controls.Add(this.minUpDown);
            this.gb_displayDeadline.Controls.Add(this.label_minutesLeft);
            this.gb_displayDeadline.Controls.Add(this.cChangeColourDeadline);
            this.gb_displayDeadline.Controls.Add(this.deadlineTimePicker);
            this.gb_displayDeadline.Controls.Add(this.label_deadline);
            this.gb_displayDeadline.Controls.Add(this.cDispDeadline);
            this.gb_displayDeadline.Location = new System.Drawing.Point(259, 266);
            this.gb_displayDeadline.Name = "gb_displayDeadline";
            this.gb_displayDeadline.Size = new System.Drawing.Size(166, 139);
            this.gb_displayDeadline.TabIndex = 56;
            this.gb_displayDeadline.TabStop = false;
            this.gb_displayDeadline.Text = "Display Deadline";
            // 
            // cCountOvertime
            // 
            this.cCountOvertime.AutoSize = true;
            this.cCountOvertime.Enabled = false;
            this.cCountOvertime.Location = new System.Drawing.Point(6, 114);
            this.cCountOvertime.Name = "cCountOvertime";
            this.cCountOvertime.Size = new System.Drawing.Size(102, 17);
            this.cCountOvertime.TabIndex = 7;
            this.cCountOvertime.Text = "Notice Overtime";
            this.cCountOvertime.UseVisualStyleBackColor = true;
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
            this.cChangeColourDeadline.Enabled = false;
            this.cChangeColourDeadline.Location = new System.Drawing.Point(6, 68);
            this.cChangeColourDeadline.Name = "cChangeColourDeadline";
            this.cChangeColourDeadline.Size = new System.Drawing.Size(96, 17);
            this.cChangeColourDeadline.TabIndex = 4;
            this.cChangeColourDeadline.Text = "Change Colour";
            this.cChangeColourDeadline.UseVisualStyleBackColor = true;
            this.cChangeColourDeadline.CheckedChanged += new System.EventHandler(this.cChangeColourDeadline_CheckedChanged);
            // 
            // deadlineTimePicker
            // 
            this.deadlineTimePicker.CustomFormat = "HH:mm";
            this.deadlineTimePicker.Enabled = false;
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
            // tAnalogDisplayClockTick
            // 
            this.tAnalogDisplayClockTick.Tick += new System.EventHandler(this.tAnalogDisplayClockTick_Tick);
            // 
            // analog_dispClock
            // 
            this.analog_dispClock.BackColor = System.Drawing.Color.Transparent;
            this.analog_dispClock.DeadlineHandColour = System.Drawing.Color.DarkGreen;
            this.analog_dispClock.DeadlineHandDropShadowColor = System.Drawing.Color.Gray;
            this.analog_dispClock.DeadlineHourTime = 0;
            this.analog_dispClock.DeadlineMinuteTime = 0;
            this.analog_dispClock.DrawDeadlineHand = false;
            this.analog_dispClock.DrawDeadlineHandShadow = true;
            this.analog_dispClock.DrawHourHand = true;
            this.analog_dispClock.DrawHourHandShadow = true;
            this.analog_dispClock.DrawMinuteHand = true;
            this.analog_dispClock.DrawMinuteHandShadow = true;
            this.analog_dispClock.DrawSecondHand = true;
            this.analog_dispClock.DropShadowColor = System.Drawing.Color.Black;
            this.analog_dispClock.DropShadowOffset = new System.Drawing.Point(0, 0);
            this.analog_dispClock.FaceColorHigh = System.Drawing.Color.White;
            this.analog_dispClock.FaceColorLow = System.Drawing.Color.LightGray;
            this.analog_dispClock.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.analog_dispClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analog_dispClock.HourHandColor = System.Drawing.Color.Gainsboro;
            this.analog_dispClock.HourHandDropShadowColor = System.Drawing.Color.Gray;
            this.analog_dispClock.Location = new System.Drawing.Point(232, 49);
            this.analog_dispClock.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
            this.analog_dispClock.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
            this.analog_dispClock.MinuteHandTickStyle = AnalogClock.eTickStyle.Normal;
            this.analog_dispClock.Name = "analog_dispClock";
            this.analog_dispClock.NumeralColor = System.Drawing.Color.Black;
            this.analog_dispClock.RimColorHigh = System.Drawing.Color.DarkGray;
            this.analog_dispClock.RimColorLow = System.Drawing.Color.Gray;
            this.analog_dispClock.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.analog_dispClock.SecondHandColor = System.Drawing.Color.Tomato;
            this.analog_dispClock.SecondHandDropShadowColor = System.Drawing.Color.Gray;
            this.analog_dispClock.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.analog_dispClock.SecondHandTickStyle = AnalogClock.eTickStyle.Normal;
            this.analog_dispClock.Size = new System.Drawing.Size(211, 211);
            this.analog_dispClock.TabIndex = 3;
            this.analog_dispClock.Time = new System.DateTime(((long)(0)));
            // 
            // btn_playPauseClock
            // 
            this.btn_playPauseClock.BackgroundImage = global::Screen_Clock.Properties.Resources.Pause_Button1;
            this.btn_playPauseClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_playPauseClock.FlatAppearance.BorderSize = 0;
            this.btn_playPauseClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playPauseClock.Location = new System.Drawing.Point(412, 228);
            this.btn_playPauseClock.Name = "btn_playPauseClock";
            this.btn_playPauseClock.Size = new System.Drawing.Size(25, 24);
            this.btn_playPauseClock.TabIndex = 57;
            this.btn_playPauseClock.UseVisualStyleBackColor = true;
            this.btn_playPauseClock.Click += new System.EventHandler(this.btn_playPauseClock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(81, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Note: You can save your clock layout, by making a preset";
            // 
            // btn_resetToDefault
            // 
            this.btn_resetToDefault.Location = new System.Drawing.Point(232, 20);
            this.btn_resetToDefault.Name = "btn_resetToDefault";
            this.btn_resetToDefault.Size = new System.Drawing.Size(211, 23);
            this.btn_resetToDefault.TabIndex = 59;
            this.btn_resetToDefault.Text = "Reset to Default Layout";
            this.btn_resetToDefault.UseVisualStyleBackColor = true;
            this.btn_resetToDefault.Click += new System.EventHandler(this.btn_resetToDefault_Click);
            // 
            // AnalogLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 495);
            this.Controls.Add(this.btn_resetToDefault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_playPauseClock);
            this.Controls.Add(this.gb_displayDeadline);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.analog_dispClock);
            this.Controls.Add(this.gb_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnalogLayoutForm";
            this.ShowInTaskbar = false;
            this.Text = "Analog Clock Layout Customization";
            this.TopMost = true;
            this.gb_Settings.ResumeLayout(false);
            this.gb_Settings.PerformLayout();
            this.gb_displayDeadline.ResumeLayout(false);
            this.gb_displayDeadline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Settings;
        private AnalogClock.AnalogClock analog_dispClock;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.ComboBox cb_applyRimGradientMode;
        private System.Windows.Forms.Button btn_applyRimColour_low;
        private System.Windows.Forms.Button btn_applyRimColour_high;
        private System.Windows.Forms.Label lbl_rimColour;
        private System.Windows.Forms.ComboBox cb_applyFaceGradientMode;
        private System.Windows.Forms.Button btn_applyFaceColour_low;
        private System.Windows.Forms.Button btn_applyFaceColour_high;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_applyDropShadowColour;
        private System.Windows.Forms.Label lbl_dropShadow;
        private System.Windows.Forms.Button btn_applyFontColour;
        private System.Windows.Forms.Label lbl_fontColour;
        private System.Windows.Forms.CheckBox cb_drawDropShadow;
        private System.Windows.Forms.Label lbl_normal;
        private System.Windows.Forms.Button btn_applyDeadlineColour;
        private System.Windows.Forms.Label lbl_deadlineColours;
        private System.Windows.Forms.RadioButton r_applySmoothTick;
        private System.Windows.Forms.RadioButton r_applyNormalTick;
        private System.Windows.Forms.Label lbl_secondsBehavior;
        private System.Windows.Forms.Button btn_applySecondHandColour;
        private System.Windows.Forms.Button btn_applyMinuteHandColour;
        private System.Windows.Forms.Button btn_applyHourHandColour;
        private System.Windows.Forms.Label lbl_handColours;
        private System.Windows.Forms.Label lbl_draw_shadows;
        private System.Windows.Forms.Label lbl_draw_hands;
        private System.Windows.Forms.Label lbl_draw;
        private System.Windows.Forms.CheckBox cb_drawSecondHand;
        private System.Windows.Forms.CheckBox cb_drawMinuteHand;
        private System.Windows.Forms.CheckBox cb_drawHourHand;
        private System.Windows.Forms.Button btn_applyHourDropShadowColour;
        private System.Windows.Forms.Button btn_applyMinuteDropShadowColour;
        private System.Windows.Forms.Button btn_applySecondDropShadowColour;
        private System.Windows.Forms.CheckBox cb_drawSecondDropShadow;
        private System.Windows.Forms.CheckBox cb_drawMinuteDropShadow;
        private System.Windows.Forms.CheckBox cb_drawHourDropShadow;
        private System.Windows.Forms.GroupBox gb_displayDeadline;
        private System.Windows.Forms.CheckBox cCountOvertime;
        private System.Windows.Forms.NumericUpDown minUpDown;
        private System.Windows.Forms.Label label_minutesLeft;
        private System.Windows.Forms.CheckBox cChangeColourDeadline;
        private System.Windows.Forms.DateTimePicker deadlineTimePicker;
        private System.Windows.Forms.Label label_deadline;
        private System.Windows.Forms.CheckBox cDispDeadline;
        private System.Windows.Forms.Timer tAnalogDisplayClockTick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_applyDeadlineDropShadowColour;
        private System.Windows.Forms.CheckBox cb_drawDeadlineDropShadow;
        private System.Windows.Forms.Button btn_playPauseClock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_resetToDefault;
        private System.Windows.Forms.Button help_btn_analogLayoutCustomization;
    }
}