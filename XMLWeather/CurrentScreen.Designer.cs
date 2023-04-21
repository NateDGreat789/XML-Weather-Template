namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.precipitationLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.feelsLikeOutput = new System.Windows.Forms.Label();
            this.precipitationOutput = new System.Windows.Forms.Label();
            this.conditionOutput = new System.Windows.Forms.Label();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.cityButton = new System.Windows.Forms.Button();
            this.windOutput = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.MistyRose;
            this.maxOutput.Location = new System.Drawing.Point(213, 169);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(69, 35);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.Aqua;
            this.minOutput.Location = new System.Drawing.Point(211, 213);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(71, 39);
            this.minOutput.TabIndex = 30;
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(20, 137);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(203, 149);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precipitationLabel
            // 
            this.precipitationLabel.BackColor = System.Drawing.Color.Transparent;
            this.precipitationLabel.ForeColor = System.Drawing.Color.Black;
            this.precipitationLabel.Location = new System.Drawing.Point(4, 354);
            this.precipitationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitationLabel.Name = "precipitationLabel";
            this.precipitationLabel.Size = new System.Drawing.Size(164, 16);
            this.precipitationLabel.TabIndex = 26;
            this.precipitationLabel.Text = "Chance of Precipitation:";
            this.precipitationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Silver;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.Black;
            this.todayLabel.Location = new System.Drawing.Point(22, 18);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(131, 34);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Stratford, CA";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Silver;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(179, 18);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(131, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.ForeColor = System.Drawing.Color.Black;
            this.humidityLabel.Location = new System.Drawing.Point(4, 389);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(164, 16);
            this.humidityLabel.TabIndex = 43;
            this.humidityLabel.Text = "Humidity:";
            this.humidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.ForeColor = System.Drawing.Color.Black;
            this.conditionLabel.Location = new System.Drawing.Point(4, 303);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(164, 50);
            this.conditionLabel.TabIndex = 44;
            this.conditionLabel.Text = "Conditions:";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.Black;
            this.feelsLikeLabel.Location = new System.Drawing.Point(30, 271);
            this.feelsLikeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(121, 25);
            this.feelsLikeLabel.TabIndex = 45;
            this.feelsLikeLabel.Text = "Feels like";
            this.feelsLikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feelsLikeOutput
            // 
            this.feelsLikeOutput.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeOutput.ForeColor = System.Drawing.Color.Black;
            this.feelsLikeOutput.Location = new System.Drawing.Point(135, 271);
            this.feelsLikeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feelsLikeOutput.Name = "feelsLikeOutput";
            this.feelsLikeOutput.Size = new System.Drawing.Size(39, 25);
            this.feelsLikeOutput.TabIndex = 46;
            this.feelsLikeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precipitationOutput
            // 
            this.precipitationOutput.BackColor = System.Drawing.Color.Transparent;
            this.precipitationOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationOutput.ForeColor = System.Drawing.Color.Black;
            this.precipitationOutput.Location = new System.Drawing.Point(169, 344);
            this.precipitationOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitationOutput.Name = "precipitationOutput";
            this.precipitationOutput.Size = new System.Drawing.Size(164, 34);
            this.precipitationOutput.TabIndex = 47;
            this.precipitationOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conditionOutput
            // 
            this.conditionOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput.ForeColor = System.Drawing.Color.Black;
            this.conditionOutput.Location = new System.Drawing.Point(169, 309);
            this.conditionOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionOutput.Name = "conditionOutput";
            this.conditionOutput.Size = new System.Drawing.Size(164, 35);
            this.conditionOutput.TabIndex = 48;
            this.conditionOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // humidityOutput
            // 
            this.humidityOutput.BackColor = System.Drawing.Color.Transparent;
            this.humidityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityOutput.ForeColor = System.Drawing.Color.Black;
            this.humidityOutput.Location = new System.Drawing.Point(169, 378);
            this.humidityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(160, 34);
            this.humidityOutput.TabIndex = 49;
            this.humidityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.Black;
            this.cityLabel.Location = new System.Drawing.Point(21, 74);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(60, 28);
            this.cityLabel.TabIndex = 50;
            this.cityLabel.Text = "City";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(103, 74);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(130, 22);
            this.cityInput.TabIndex = 51;
            // 
            // countryLabel
            // 
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.Color.Black;
            this.countryLabel.Location = new System.Drawing.Point(21, 102);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(147, 51);
            this.countryLabel.TabIndex = 52;
            this.countryLabel.Text = "Country \r\n(CA, US etc.)";
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(103, 102);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(130, 22);
            this.countryInput.TabIndex = 53;
            // 
            // cityButton
            // 
            this.cityButton.BackColor = System.Drawing.Color.White;
            this.cityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityButton.Location = new System.Drawing.Point(240, 72);
            this.cityButton.Name = "cityButton";
            this.cityButton.Size = new System.Drawing.Size(76, 57);
            this.cityButton.TabIndex = 54;
            this.cityButton.Text = "Search";
            this.cityButton.UseVisualStyleBackColor = false;
            this.cityButton.Click += new System.EventHandler(this.cityButton_Click);
            // 
            // windOutput
            // 
            this.windOutput.BackColor = System.Drawing.Color.Transparent;
            this.windOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windOutput.ForeColor = System.Drawing.Color.Black;
            this.windOutput.Location = new System.Drawing.Point(169, 412);
            this.windOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windOutput.Name = "windOutput";
            this.windOutput.Size = new System.Drawing.Size(160, 56);
            this.windOutput.TabIndex = 56;
            this.windOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.ForeColor = System.Drawing.Color.Black;
            this.windLabel.Location = new System.Drawing.Point(4, 425);
            this.windLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(164, 35);
            this.windLabel.TabIndex = 55;
            this.windLabel.Text = "Wind Direction:\r\nWind Speed:";
            this.windLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.windOutput);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.cityButton);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.conditionOutput);
            this.Controls.Add(this.precipitationOutput);
            this.Controls.Add(this.feelsLikeOutput);
            this.Controls.Add(this.feelsLikeLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.precipitationLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(333, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label precipitationLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label feelsLikeOutput;
        private System.Windows.Forms.Label precipitationOutput;
        private System.Windows.Forms.Label conditionOutput;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.Button cityButton;
        private System.Windows.Forms.Label windOutput;
        private System.Windows.Forms.Label windLabel;
    }
}
