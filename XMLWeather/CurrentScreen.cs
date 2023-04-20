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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            double current = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0);
            double min = Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0);
            double max = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0);
            double feels = Math.Round(Convert.ToDouble(Form1.days[0].feelsLike));
            double preProb = Convert.ToDouble(Form1.days[0].preProb) * 100;
            double speed = Convert.ToDouble(Form1.days[0].windSpeed);

            int humidity = Convert.ToInt32(Form1.days[0].humidity);
            int weather = Convert.ToInt32(Form1.days[0].condum);

            string condition = Form1.days[0].condition;

            #region background
            if (weather > 199 && weather < 600)
            {
                BackgroundImage = Properties.Resources.rain;
                TextColour("white");
            }
            else if (weather > 599 && weather < 700)
            {
                BackgroundImage = Properties.Resources.snow;
                TextColour("black");
            }
            else if (weather == 800)
            {
                BackgroundImage = Properties.Resources.sun;
                TextColour("black");
            }
            else if (weather > 800 && weather < 900)
            {
                BackgroundImage = Properties.Resources.cloudy;
                TextColour("black");
            }
            #endregion

            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = $"{current}°";
            minOutput.Text = $"{min}°";
            maxOutput.Text = $"{max}°";
            feelsLikeOutput.Text = $"{feels}°";
            precipitationOutput.Text = $"{preProb}%";
            conditionOutput.Text = $"{condition}";
            humidityOutput.Text = $"{humidity}%";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        public void TextColour(string colour)
        {
            if (colour == "white")
            {
                cityOutput.ForeColor = Color.White;
                currentOutput.ForeColor = Color.White;
                minOutput.ForeColor = Color.Aqua;
                maxOutput.ForeColor = Color.MistyRose;
                feelsLikeLabel.ForeColor = Color.White;
                feelsLikeOutput.ForeColor = Color.White;
                precipitationLabel.ForeColor = Color.White;
                precipitationOutput.ForeColor = Color.White;
                conditionLabel.ForeColor = Color.White;
                conditionOutput.ForeColor = Color.White;
                humidityLabel.ForeColor = Color.White;
                humidityOutput.ForeColor = Color.White;
            }
            else
            {
                cityOutput.ForeColor = Color.Black;
                currentOutput.ForeColor = Color.Black;
                minOutput.ForeColor = Color.MidnightBlue;
                maxOutput.ForeColor = Color.Firebrick;
                feelsLikeLabel.ForeColor = Color.Black;
                feelsLikeOutput.ForeColor = Color.Black;
                precipitationLabel.ForeColor = Color.Black;
                precipitationOutput.ForeColor = Color.Black;
                conditionLabel.ForeColor = Color.Black;
                conditionOutput.ForeColor = Color.Black;
                humidityLabel.ForeColor = Color.Black;
                humidityOutput.ForeColor = Color.Black;
            }
        }
    }
}
