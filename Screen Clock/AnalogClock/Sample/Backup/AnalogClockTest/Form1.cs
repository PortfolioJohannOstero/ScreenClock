using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AnalogClockTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private AnalogClock.AnalogClock analogClock1;
		private AnalogClock.AnalogClock analogClock2;
		private AnalogClock.AnalogClock analogClock3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private AnalogClock.AnalogClock analogClock4;
		private System.Windows.Forms.Label label4;
		private System.ComponentModel.IContainer components;

		public Form1()
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
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.analogClock1 = new AnalogClock.AnalogClock();
			this.analogClock2 = new AnalogClock.AnalogClock();
			this.analogClock3 = new AnalogClock.AnalogClock();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.analogClock4 = new AnalogClock.AnalogClock();
			this.label4 = new System.Windows.Forms.Label();
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
			this.analogClock1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.analogClock1.HourHandColor = System.Drawing.Color.Gainsboro;
			this.analogClock1.HourHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock1.Location = new System.Drawing.Point(8, 0);
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
			// analogClock2
			// 
			this.analogClock2.DrawHourHand = true;
			this.analogClock2.DrawHourHandShadow = false;
			this.analogClock2.DrawMinuteHand = true;
			this.analogClock2.DrawMinuteHandShadow = false;
			this.analogClock2.DrawNumerals = false;
			this.analogClock2.DrawSecondHand = false;
			this.analogClock2.DrawSecondHandShadow = false;
			this.analogClock2.DropShadowColor = System.Drawing.Color.Black;
			this.analogClock2.DropShadowOffset = new System.Drawing.Point(0, 0);
			this.analogClock2.FaceColorHigh = System.Drawing.Color.RoyalBlue;
			this.analogClock2.FaceColorLow = System.Drawing.Color.SkyBlue;
			this.analogClock2.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.analogClock2.FaceImage = ((System.Drawing.Image)(resources.GetObject("analogClock2.FaceImage")));
			this.analogClock2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.analogClock2.HourHandColor = System.Drawing.Color.LightGoldenrodYellow;
			this.analogClock2.HourHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock2.Location = new System.Drawing.Point(264, 0);
			this.analogClock2.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
			this.analogClock2.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock2.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
			this.analogClock2.Name = "analogClock2";
			this.analogClock2.NumeralColor = System.Drawing.Color.WhiteSmoke;
			this.analogClock2.RimColorHigh = System.Drawing.Color.MidnightBlue;
			this.analogClock2.RimColorLow = System.Drawing.Color.Gainsboro;
			this.analogClock2.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.analogClock2.SecondHandColor = System.Drawing.Color.Yellow;
			this.analogClock2.SecondHandDropShadowColor = System.Drawing.Color.Khaki;
			this.analogClock2.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
			this.analogClock2.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
			this.analogClock2.Size = new System.Drawing.Size(232, 232);
			this.analogClock2.TabIndex = 1;
			this.analogClock2.Time = new System.DateTime(((long)(0)));
			// 
			// analogClock3
			// 
			this.analogClock3.DrawHourHand = true;
			this.analogClock3.DrawHourHandShadow = true;
			this.analogClock3.DrawMinuteHand = true;
			this.analogClock3.DrawMinuteHandShadow = true;
			this.analogClock3.DrawSecondHand = true;
			this.analogClock3.DropShadowColor = System.Drawing.Color.RosyBrown;
			this.analogClock3.DropShadowOffset = new System.Drawing.Point(0, 0);
			this.analogClock3.FaceColorHigh = System.Drawing.Color.Red;
			this.analogClock3.FaceColorLow = System.Drawing.Color.Crimson;
			this.analogClock3.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.analogClock3.FaceImage = null;
			this.analogClock3.Font = new System.Drawing.Font("Siddiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.analogClock3.HourHandColor = System.Drawing.Color.Gainsboro;
			this.analogClock3.HourHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock3.Location = new System.Drawing.Point(8, 256);
			this.analogClock3.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
			this.analogClock3.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock3.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
			this.analogClock3.Name = "analogClock3";
			this.analogClock3.NumeralColor = System.Drawing.Color.WhiteSmoke;
			this.analogClock3.RimColorHigh = System.Drawing.Color.RosyBrown;
			this.analogClock3.RimColorLow = System.Drawing.Color.Black;
			this.analogClock3.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.analogClock3.SecondHandColor = System.Drawing.Color.Tomato;
			this.analogClock3.SecondHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock3.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
			this.analogClock3.SecondHandTickStyle = AnalogClock.TickStyle.Smooth;
			this.analogClock3.Size = new System.Drawing.Size(232, 232);
			this.analogClock3.TabIndex = 2;
			this.analogClock3.Time = new System.DateTime(((long)(0)));
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(104, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "UTC";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(368, 240);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "Paris";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(112, 496);
			this.label3.Name = "label3";
			this.label3.TabIndex = 5;
			this.label3.Text = "Karachi";
			// 
			// analogClock4
			// 
			this.analogClock4.DrawHourHand = true;
			this.analogClock4.DrawHourHandShadow = true;
			this.analogClock4.DrawMinuteHand = true;
			this.analogClock4.DrawMinuteHandShadow = true;
			this.analogClock4.DrawNumerals = false;
			this.analogClock4.DrawSecondHand = true;
			this.analogClock4.DropShadowColor = System.Drawing.Color.Black;
			this.analogClock4.DropShadowOffset = new System.Drawing.Point(0, 0);
			this.analogClock4.FaceColorHigh = System.Drawing.Color.DimGray;
			this.analogClock4.FaceColorLow = System.Drawing.Color.LightGray;
			this.analogClock4.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.analogClock4.FaceImage = null;
			this.analogClock4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.analogClock4.HourHandColor = System.Drawing.Color.Gainsboro;
			this.analogClock4.HourHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock4.Location = new System.Drawing.Point(264, 256);
			this.analogClock4.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
			this.analogClock4.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock4.MinuteHandTickStyle = AnalogClock.TickStyle.Smooth;
			this.analogClock4.Name = "analogClock4";
			this.analogClock4.NumeralColor = System.Drawing.Color.WhiteSmoke;
			this.analogClock4.RimColorHigh = System.Drawing.Color.DimGray;
			this.analogClock4.RimColorLow = System.Drawing.Color.LightGray;
			this.analogClock4.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.analogClock4.SecondHandColor = System.Drawing.Color.Tomato;
			this.analogClock4.SecondHandDropShadowColor = System.Drawing.Color.Gray;
			this.analogClock4.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
			this.analogClock4.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
			this.analogClock4.Size = new System.Drawing.Size(232, 232);
			this.analogClock4.TabIndex = 6;
			this.analogClock4.Time = new System.DateTime(((long)(0)));
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(344, 496);
			this.label4.Name = "label4";
			this.label4.TabIndex = 7;
			this.label4.Text = "Hong Kong";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(506, 519);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.analogClock4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.analogClock1);
			this.Controls.Add(this.analogClock2);
			this.Controls.Add(this.analogClock3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Analog Clock";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.analogClock1.Time = DateTime.UtcNow;
			this.analogClock2.Time = DateTime.UtcNow.AddHours(1);
			this.analogClock3.Time = DateTime.UtcNow.AddHours(5);
			this.analogClock4.Time = DateTime.UtcNow.AddHours(8);

		}
	}
}
