using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string API = "7afd963d06f249702e1994777cc5a0ed";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            getWeather();
            getForecast();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
           
        private void label1_Click(object sender, EventArgs e)
        {

        }
        double lat;
        double lon;

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=" + textBox1.Text + "&appid=" + API);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);


                    LabTemp1.Text = "Temperatura: " + (Math.Round(Info.main.temp - 273.15).ToString()) + " stopni celcjusza";
                    labelMiasto.ForeColor = Color.Black;
                    labelMiasto.Text = textBox1.Text;
                    labelWiatr.Text = "Wiatr: " + Info.wind.speed.ToString() + "m/s";
                    lon = Info.coord.lon;
                    lat = Info.coord.lat;

                }
                catch (Exception ex)
                {

                    labelMiasto.Text = "Wprowadzono niepoprawne miasto";
                    labelMiasto.ForeColor = Color.Red;
                    LabTemp1.Text = null;
                    labelWiatr.Text = null;
                }
                
            }

        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970,1,1,0,0,0,0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }

        /*void getWeather16()
        {
            using (WebClient web = new WebClient())
            {

            }
        }*/

        private void LabTemp1_Click(object sender, EventArgs e)
        {

        }

        private void tekst_Click(object sender, EventArgs e)
        {

        }
        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                try { 
                    string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&exclude=current,minutely,hourly,alerts&appid={1}", textBox1.Text, API);
                    var json = web.DownloadString(url);
                    WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);
                for(int i =0;i<30;i++)
                {
                    FUc FUC = new FUc();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.list[i].weather[0].icon + ".png";
                    FUC.labelMainWeather.Text = ForecastInfo.list[i].weather[0].main;
                    FUC.labWeatherDescription.Text = ForecastInfo.list[i].weather[0].description;
                    FUC.labelDT.Text = convertDateTime(ForecastInfo.list[i].dt).DayOfWeek.ToString() +" "+ convertDateTime(ForecastInfo.list[i].dt).TimeOfDay.ToString();
                    FUC.labelTemp.Text = Math.Round(ForecastInfo.list[i].main.temp - 273.15).ToString() + "°C";
                    flp.Controls.Add(FUC);

                }
               }
                catch (Exception ex)
                {

                    labelMiasto.Text = "Wprowadzono niepoprawne miasto";
                    labelMiasto.ForeColor = Color.Red;
                    LabTemp1.Text = null;
                    labelWiatr.Text = null;
                }



            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
