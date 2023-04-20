using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, condum, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, preProb, visibility, feelsLike, humidity;

        public Day()
        {
            date = currentTemp = currentTime = condition = condum = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = preProb = visibility = feelsLike = humidity = "";
        }
    }
}
