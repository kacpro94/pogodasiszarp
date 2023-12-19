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
            getWeather();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
           
        private void label1_Click(object sender, EventArgs e)
        {

        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=" + textBox1.Text + "&appid=" + API);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);


                    LabTemp1.Text = "Temperatura: " + (Info.main.temp - 273.15).ToString() + " stopni celcjusza";
                    labelMiasto.ForeColor = Color.Black;
                    labelMiasto.Text = textBox1.Text;
                    labelWiatr.Text = "Wiatr: " + Info.wind.speed.ToString() + "m/s";
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
    }
}
