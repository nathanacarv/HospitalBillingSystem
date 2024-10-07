using Newtonsoft.Json;
using System.IO;
using System.Net;


namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMedCharges_Click(object sender, EventArgs e)
        {

        }

        //closes the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //validates user input
        private bool ValidateInput()
        {
            //validates number of days
            if (!double.TryParse(textBoxDaysInHosp.Text, out double days) || days < 0)
            {
                MessageBox.Show("ERROR: Enter a valid number of days.");
                return false;
            }
            //validates charged amount
            if (!double.TryParse(textBoxMedCharges.Text, out double medCharges) || medCharges < 0)
            {
                MessageBox.Show("ERROR: Enter a valid amount for medication charges.");
                return false;
            }
            //validates charged amount
            if (!double.TryParse(textBoxSurgicalCharges.Text, out double surgCharges) || surgCharges < 0)
            {
                MessageBox.Show("ERROR: Enter a valid amount for surgical charges.");
                return false;
            }
            //validates charged amount
            if (!double.TryParse(textBoxLabFees.Text, out double labFees) || labFees < 0)
            {
                MessageBox.Show("ERROR: Enter a valid amount for lab fees.");
                return false;
            }
            //validates charged amount
            if (!double.TryParse(textBoxPhysRehabCharges.Text, out double rehabCharges) || rehabCharges < 0)
            {
                MessageBox.Show("ERROR: Enter a valid amount for physical rehab charges.");
                return false;
            }

            return true;
        }


        //calculates and displays total charges
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                CalcStayCharges();
                CalcMiscCharges();

                lblTotalDisplay.Text = "$" + CalcTotalCharges();
            }
        }
        private double CalcStayCharges()
        {
            //stay cost per day
            const double DAILY_STAY_RATE = 350.00;

            //holds number of days in hospital inputted
            double daysInHosp = Convert.ToDouble(textBoxDaysInHosp.Text);
            //Calculates the total charges for hospital stay
            double totalDaysInHospCharge = daysInHosp * DAILY_STAY_RATE;


            return totalDaysInHospCharge;
        }
        private double CalcMiscCharges()
        {
            //holds medication charges
            double medCharges = Convert.ToDouble(textBoxMedCharges.Text);

            //holds surgical charges
            double surgicalCharges = Convert.ToDouble(textBoxSurgicalCharges.Text);

            //holds lab fees cost
            double labFees = Convert.ToDouble(textBoxLabFees.Text);

            //holds physical rehab charges
            double physicalRehabCharges = Convert.ToDouble(textBoxPhysRehabCharges.Text);
            //holds the total of misc charges
            double totalMiscCharges = medCharges + surgicalCharges + labFees + physicalRehabCharges;

            return totalMiscCharges;
        }
        private String CalcTotalCharges()
        {
            double totalChargesFinal = CalcStayCharges() + CalcMiscCharges();
            return totalChargesFinal.ToString("N2");

        }

        private void lblP_RehabChargesInput_Click(object sender, EventArgs e)
        {

        }

        private void lblDaysInHospInput_Click(object sender, EventArgs e)
        {

        }

        private void lblMedChargesInput_Click(object sender, EventArgs e)
        {

        }

        private void lblSurgicalChargesInput_Click(object sender, EventArgs e)
        {

        }

        private void lblLabFeesInput_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDisplay_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSurgicalCharges_TextChanged(object sender, EventArgs e)
        {

        }

        //OPEN WEATHER MAP API:

        //Get forecast button
        private async void btnGetForecastAPI_Click(object sender, EventArgs e)
        {
            string city = textBoxCityName.Text; //gets user input
            string state = textBoxState.Text;

            (double lat, double lon) = await GetCoordinates(city, state); //get coordinates from city

            if(lat != 0 && lon != 0)
            {
                string weatherData = await GetWeatherData(lat, lon);
                if (weatherData != null)
                {
                    dynamic weatherJson = JsonConvert.DeserializeObject(weatherData);
                    
                    //get weather details
                    string description = weatherJson.weather[0].description;
                    double temperature = weatherJson.main.temp;

                    // call the method to create and display the weather html file
                    CreateWeatherHtmlFile(city, state, description, temperature);
                }

            }
        }

        //OpenWeatherMap API call method
        private async Task<string>GetWeatherData(double lat, double lon)
        {
            string openWeatherApiKey = "ebb8b715f514d52cf9e49ccdddf19f29";

            //API URL
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={openWeatherApiKey}&units=imperial"; // Using imperial units for Fahrenheit

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
            }catch(HttpRequestException e)
            {
                MessageBox.Show($"Request error: {e.Message}");
                return null;
            }

        }

        //Geocoding API call method
        private async Task<(double lat, double lon)> GetCoordinates(string city, string state)
        {
            string openWeatherApiKey = "ebb8b715f514d52cf9e49ccdddf19f29";
            string query = string.IsNullOrWhiteSpace(state) ? city : $"{city},{state}";
            string url = $"http://api.openweathermap.org/geo/1.0/direct?q={query}&limit=1&appid={openWeatherApiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var geocodeJson = JsonConvert.DeserializeObject<List<GeocodeResponse>>(responseBody);

                    if(geocodeJson != null && geocodeJson.Count > 0)
                    {
                        double lat = geocodeJson[0].lat;
                        double lon = geocodeJson[0].lon;
                        return (lat, lon);
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Coordinates for the entered city not found.");
                        return (0, 0);
                    }

                }
                else
                {
                    MessageBox.Show("ERROR: Unable to get coordinates.");
                    return (0, 0);
                }
            }
        }

        private void CreateWeatherHtmlFile(string city, string state, string description, double temperature)
        {
            // path to html file
            string templatePath = Path.Combine(Application.StartupPath, "CurrentWeather.html");

            // read html template
            string htmlContent = File.ReadAllText(templatePath);

            // replace placeholders with actual data
            htmlContent = htmlContent.Replace("{city}", city)
                                     .Replace("{state}", state)
                                     .Replace("{description}", description)
                                     .Replace("{temperature}", temperature.ToString("N2"));

            // path to the final html file that will be opened
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CurrentWeather.html");


            // write the modified content to the new file
            File.WriteAllText(filePath, htmlContent);

            // open the html file in the default browser
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }




    }
}
