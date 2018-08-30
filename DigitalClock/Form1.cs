using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
	public partial class Clock : Form
	{
		Timer timer = new Timer();
		public Clock()
		{
			InitializeComponent();
		}

		private void Clock_Load(object sender, EventArgs e)
		{
			timer.Interval = 1000;

			timer.Tick += new EventHandler(this.timer_Tick);

			timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			int hh = DateTime.Now.Hour;
			int mm = DateTime.Now.Minute;
			int ss = DateTime.Now.Second;

			string time = "";

			if(hh < 10)
			{
				time += "0" + hh;
			}
			else
			{
				time += hh;
			}

			time += ":";

			if (mm < 10)
			{
				time += "0" + mm;
			}
			else
			{
				time += mm;
			}

			time += ":";

			if (ss < 10)
			{
				time += "0" + ss;
			}
			else
			{
				time += ss;
			}

			label1.Text = time;
		}
	}
}
