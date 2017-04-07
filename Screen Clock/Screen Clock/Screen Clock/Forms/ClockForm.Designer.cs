namespace Screen_Clock.Forms
{
    partial class ClockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            this.clockLabel = new System.Windows.Forms.Label();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.timer_clockTimer = new System.Windows.Forms.Timer(this.components);
            this.analogClock1 = new AnalogClock.AnalogClock();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.ForeColor = System.Drawing.Color.White;
            this.clockLabel.Location = new System.Drawing.Point(112, 95);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(49, 13);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "00:00:00";
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.ForeColor = System.Drawing.Color.White;
            this.deadlineLabel.Location = new System.Drawing.Point(112, 108);
            this.deadlineLabel.Margin = new System.Windows.Forms.Padding(0);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(49, 13);
            this.deadlineLabel.TabIndex = 1;
            this.deadlineLabel.Text = "00:00:00";
            // 
            // timer_clockTimer
            // 
            this.timer_clockTimer.Tick += new System.EventHandler(this.timer_clockTimer_Tick);
            // 
            // analogClock1
            // 
            this.analogClock1.BackColor = System.Drawing.Color.Transparent;
            this.analogClock1.DeadlineHourTime = 0;
            this.analogClock1.DeadlineMinuteTime = 0;
            this.analogClock1.DrawDeadlineHand = false;
            this.analogClock1.DrawHourHand = true;
            this.analogClock1.DrawHourHandShadow = true;
            this.analogClock1.DrawMinuteHand = true;
            this.analogClock1.DrawMinuteHandShadow = true;
            this.analogClock1.DrawSecondHand = true;
            this.analogClock1.DropShadowColor = System.Drawing.Color.Black;
            this.analogClock1.DropShadowOffset = new System.Drawing.Point(0, 0);
            this.analogClock1.FaceColorHigh = System.Drawing.Color.White;
            this.analogClock1.FaceColorLow = System.Drawing.Color.LightGray;
            this.analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.analogClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogClock1.HourHandColor = System.Drawing.Color.Gainsboro;
            this.analogClock1.HourHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.Location = new System.Drawing.Point(30, 12);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock1.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.MinuteHandTickStyle = AnalogClock.eTickStyle.Normal;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.NumeralColor = System.Drawing.Color.Black;
            this.analogClock1.RimColorHigh = System.Drawing.Color.DarkGray;
            this.analogClock1.RimColorLow = System.Drawing.Color.Gray;
            this.analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.analogClock1.SecondHandColor = System.Drawing.Color.Tomato;
            this.analogClock1.SecondHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.analogClock1.SecondHandTickStyle = AnalogClock.eTickStyle.Normal;
            this.analogClock1.Size = new System.Drawing.Size(232, 232);
            this.analogClock1.TabIndex = 2;
            this.analogClock1.Time = new System.DateTime(((long)(0)));
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.analogClock1);
            this.Controls.Add(this.deadlineLabel);
            this.Controls.Add(this.clockLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClockForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ClockForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.Timer timer_clockTimer;
        private AnalogClock.AnalogClock analogClock1;
    }
}