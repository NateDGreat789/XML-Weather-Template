using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        List <int> weathers = new List <int> ();

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            dateLabel1.Text = Form1.days[1].date;

            for (int i = 1; i < Form1.days.Count; i++)
            {
                weathers.Add(Convert.ToInt32(Form1.days[i].condum));
            }

            dateLabel1.Text = Form1.days[0].date;
            dateLabel2.Text = Form1.days[1].date;
            dateLabel3.Text = Form1.days[2].date;
            dateLabel4.Text = Form1.days[3].date;
            dateLabel5.Text = Form1.days[4].date;
            dateLabel6.Text = Form1.days[5].date;

            minLabel1.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0)}";
            minLabel2.Text = $"{Math.Round(Convert.ToDouble(Form1.days[1].tempLow), 0)}";
            minLabel3.Text = $"{Math.Round(Convert.ToDouble(Form1.days[2].tempLow), 0)}";
            minLabel4.Text = $"{Math.Round(Convert.ToDouble(Form1.days[3].tempLow), 0)}";
            minLabel5.Text = $"{Math.Round(Convert.ToDouble(Form1.days[4].tempLow), 0)}";
            minLabel6.Text = $"{Math.Round(Convert.ToDouble(Form1.days[5].tempLow), 0)}";

            maxLabel1.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0)}";
            maxLabel2.Text = $"{Math.Round(Convert.ToDouble(Form1.days[1].tempHigh), 0)}";
            maxLabel3.Text = $"{Math.Round(Convert.ToDouble(Form1.days[2].tempHigh), 0)}";
            maxLabel4.Text = $"{Math.Round(Convert.ToDouble(Form1.days[3].tempHigh), 0)}";
            maxLabel5.Text = $"{Math.Round(Convert.ToDouble(Form1.days[4].tempHigh), 0)}";
            maxLabel6.Text = $"{Math.Round(Convert.ToDouble(Form1.days[5].tempHigh), 0)}";

            #region icons
            if (weathers[0] > 199 && weathers[0] < 600)
            {
                pictureBox1.BackgroundImage = Properties.Resources.irain;
            }
            else if (weathers[0] > 599 && weathers[0] < 700)
            {
                pictureBox1.BackgroundImage = Properties.Resources.isnow;
            }
            else if (weathers[0] == 800)
            {
                pictureBox1.BackgroundImage = Properties.Resources.isun;
            }
            else if (weathers[0] > 800 && weathers[0] < 900)
            {
                pictureBox1.BackgroundImage = Properties.Resources.icloud;
            }

            if (weathers[1] > 199 && weathers[1] < 600)
            {
                pictureBox2.BackgroundImage = Properties.Resources.irain;
            }
            else if (weathers[1] > 599 && weathers[0] < 700)
            {
                pictureBox2.BackgroundImage = Properties.Resources.isnow;
            }
            else if (weathers[1] == 800)
            {
                pictureBox2.BackgroundImage = Properties.Resources.isun;
            }
            else if (weathers[1] > 800 && weathers[0] < 900)
            {
                pictureBox2.BackgroundImage = Properties.Resources.icloud;
            }

            if (weathers[2] > 199 && weathers[2] < 600)
            {
                pictureBox3.BackgroundImage = Properties.Resources.irain;
            }
            else if (weathers[2] > 599 && weathers[0] < 700)
            {
                pictureBox3.BackgroundImage = Properties.Resources.isnow;
            }
            else if (weathers[2] == 800)
            {
                pictureBox3.BackgroundImage = Properties.Resources.isun;
            }
            else if (weathers[2] > 800 && weathers[0] < 900)
            {
                pictureBox3.BackgroundImage = Properties.Resources.icloud;
            }

            if (weathers[3] > 199 && weathers[3] < 600)
            {
                pictureBox4.BackgroundImage = Properties.Resources.irain;
            }
            else if (weathers[3] > 599 && weathers[0] < 700)
            {
                pictureBox4.BackgroundImage = Properties.Resources.isnow;
            }
            else if (weathers[3] == 800)
            {
                pictureBox4.BackgroundImage = Properties.Resources.isun;
            }
            else if (weathers[3] > 800 && weathers[0] < 900)
            {
                pictureBox4.BackgroundImage = Properties.Resources.icloud;
            }

            if (weathers[4] > 199 && weathers[4] < 600)
            {
                pictureBox5.BackgroundImage = Properties.Resources.irain;
            }
            else if (weathers[4] > 599 && weathers[0] < 700)
            {
                pictureBox5.BackgroundImage = Properties.Resources.isnow;
            }
            else if (weathers[4] == 800)
            {
                pictureBox5.BackgroundImage = Properties.Resources.isun;
            }
            else if (weathers[4] > 800 && weathers[0] < 900)
            {
                pictureBox5.BackgroundImage = Properties.Resources.icloud;
            }

            if (weathers[5] > 199 && weathers[5] < 600)
            {
                pictureBox6.BackgroundImage = Properties.Resources.irain;
            }
            else if (weathers[5] > 599 && weathers[0] < 700)
            {
                pictureBox6.BackgroundImage = Properties.Resources.isnow;
            }
            else if (weathers[5] == 800)
            {
                pictureBox6.BackgroundImage = Properties.Resources.isun;
            }
            else if (weathers[5] > 800 && weathers[0] < 900)
            {
                pictureBox6.BackgroundImage = Properties.Resources.icloud;
            }
            #endregion
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
