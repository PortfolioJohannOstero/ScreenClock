using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AnalogClockTest
{
	/// <summary>
	/// Summary description for Analogclock.
	/// </summary>
	public class Analogclock : System.Windows.Forms.Form
	{
		private AnalogClock.AnalogClock analogClock1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Analogclock()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.analogClock1 = new AnalogClock.AnalogClock();
			this.SuspendLayout();
			// 
			// analogClock1
			// 
			this.analogClock1.DrawHourHand = true;
			this.analogClock1.DrawHourHandShadow = true;
			this.analogClock1.DrawMinuteHand = true;
			this.analogClock1.DrawMinuteHandShadow = true;
			this.analogClock1.DrawSecondHand = true;
			this.analogClock1.DropShadowColor = System.Drawing.Color.Black;
			this.analogClock1.DropShadowOffset = new System.Drawing.Point(0, 0);
			this.analogClock1.FaceColorHigh = System.Drawing.Color.RoyalBlue;
			this.analogClock1.FaceColorLow = System.Drawing.Color.SkyBlue;
			this.analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.analogClock1.FaceImage = null;
			this.analogClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.analogClock1.HourHandColor = System.Drawing.Color.Gainsboro;
			this.analogClock1.HourHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock1.Location = new System.Drawing.Point(0, 0);
			this.analogClock1.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
			this.analogClock1.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
			this.analogClock1.Name = "analogClock1";
			this.analogClock1.NumeralColor = System.Drawing.Color.WhiteSmoke;
			this.analogClock1.RimColorHigh = System.Drawing.Color.RoyalBlue;
			this.analogClock1.RimColorLow = System.Drawing.Color.SkyBlue;
			this.analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.analogClock1.SecondHandColor = System.Drawing.Color.Tomato;
			this.analogClock1.SecondHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
			this.analogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
			this.analogClock1.Size = new System.Drawing.Size(232, 232);
			this.analogClock1.TabIndex = 0;
			this.analogClock1.Time = new System.DateTime(((long)(0)));
			// 
			// Analogclock
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(232, 237);
			this.Controls.Add(this.analogClock1);
			this.Name = "Analogclock";
			this.Text = "Analogclock";
			this.Load += new System.EventHandler(this.Analogclock_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Analogclock_Load(object sender, System.EventArgs e)
		{
			this.analogClock1.Time = new DateTime(1999, 9, 1, 5, 6, 47);

		}
	}
}
