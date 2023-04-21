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
        public static string city = "Stratford";
        public static string country = "CA";

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
            double humidity = Convert.ToDouble(Form1.days[0].humidity);
            double speed = Convert.ToDouble(Form1.days[0].windSpeed);


            int weather = Convert.ToInt32(Form1.days[0].condum);

            string direction = Form1.days[0].windDirection;
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

            todayLabel.Text = $"{city}, {country}";
            currentOutput.Text = $"{current}°C";
            minOutput.Text = $"{min}°C";
            maxOutput.Text = $"{max}°C";
            feelsLikeOutput.Text = $"{feels}°C";
            precipitationOutput.Text = $"{preProb}%";
            conditionOutput.Text = $"{condition}";
            humidityOutput.Text = $"{humidity}%";
            windOutput.Text = $"{direction}\n{speed} m/s";
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
                cityLabel.ForeColor = Color.White;
                countryLabel.ForeColor = Color.White;
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
                windLabel.ForeColor = Color.White;
                windOutput.ForeColor = Color.White;
            }
            else
            {
                cityLabel.ForeColor = Color.Black;
                countryLabel.ForeColor = Color.Black;
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
                windLabel.ForeColor = Color.Black;
                windOutput.ForeColor = Color.Black;
            }
        }

        private void cityButton_Click(object sender, EventArgs e)
        {
            try
            {
                city = cityInput.Text;
                country = countryInput.Text;

                Form1.ExtractForecast(city, country);
                Form1.ExtractCurrent(city, country);
                DisplayCurrent();
            }
            catch
            {
                cityInput.Text = "ERROR: city not found";
                cityInput.Text = "ERROR: city not found";
            }
        }
    }
}
