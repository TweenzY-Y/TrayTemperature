using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using Microsoft.Win32;
using TrayTemperature.Properties;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;

namespace TrayTemperature
{
    public partial class TrayTemperature : Form
    {
        
        //Web scraping
        HtmlWeb htmlReader = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument htmlDoc;


        //Variables
        string temperature;

        //Registry key for "Run on startup" feature
        RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public TrayTemperature()
        {
            InitializeComponent();
        }


        private void TrayTemperature_Load(object sender, EventArgs e)
        {

            // Loads user's settings
            LoadUserSettings();
            SetStartup();

            
            // Checks if user has an assigned location
            if (String.IsNullOrEmpty(Settings.Default.userLocation))
            {
                GetUserLocation();
            }

            GetTemperatureFrom(Settings.Default.userLocation);
            ShowInTray(temperature);

        }
        
       // Gets user's location
        private void GetUserLocation()
        {
            const string locationURL = "https://mylocation.org/";

            htmlDoc = htmlReader.Load(locationURL);

            Settings.Default.userLocation = htmlDoc.DocumentNode.SelectNodes("//tr //td")[11].InnerText;
            Settings.Default.Save();
        }

        // Gets temperature from users location
        private void GetTemperatureFrom(string userLocation)
        {
            string temperatureURL = $"https://www.msn.com/en-us/weather/forecast/in-{userLocation}?&weadegreetype=C";
            string testTemperature;
            byte attempt = 0;
            
            htmlDoc = htmlReader.Load(temperatureURL);

            while (attempt <= 1)
            {
                try
                {
                    testTemperature = htmlDoc.DocumentNode.QuerySelector("a.summaryTemperatureCompact-E1_1.summaryTemperatureHover-E1_1").InnerText.Replace("°C", "");
                    temperature = testTemperature;
                    break;
                }
                catch (NullReferenceException)
                {
                    attempt++;
                    Task.Delay(1854);
                }
            }

        }

        // Display temperature as an icon
        private void ShowInTray(string temperature)
        {
            
            Brush brush = new SolidBrush(Settings.Default.userColor);

            // Makes 16x16 graphic area to draw an icon
            Bitmap bitmap = new Bitmap(16, 16);
            Graphics graphics = Graphics.FromImage(bitmap);

            // Positions string in the center of the area
            Rectangle rect1 = new Rectangle(0, 1, 16, 16);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

           // Sets font for the icon
            Font iconFont = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            
            // Draws temperature
            graphics.DrawString(temperature, iconFont , brush, rect1, stringFormat);

            // Displays the icon in tray
            Icon icon = Icon.FromHandle(bitmap.GetHicon());
            tray.Icon = icon;
        }

        // Exits application on click
        private void trayMenuStripExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Resets user's location
        private void trayMenuStripResetLocationItem_Click(object sender, EventArgs e)
        {
            GetUserLocation();
            GetTemperatureFrom(Settings.Default.userLocation);
            ShowInTray(temperature);
        }

       // Changes icon display color
        private void trayMenuStripChangeDisplayColorItem_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.userColor = ColorTranslator.FromHtml(trayMenuStripRgbValue.Text);
                ShowInTray(temperature);
                Settings.Default.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid color format");
                trayMenuStripRgbValue.Text = $"{Settings.Default.userColor.R},{Settings.Default.userColor.G},{Settings.Default.userColor.B}";
            }
        }

        // Loads user's settings
        private void LoadUserSettings()
        {
            runOnStartupToolStripMenuItem.Checked = Settings.Default.runOnStartup;
            trayMenuStripRgbValue.Text = $"{Settings.Default.userColor.R},{Settings.Default.userColor.G},{Settings.Default.userColor.B}";
        }

       // Adds or removes program from startup
        private void SetStartup()
        {
            if (runOnStartupToolStripMenuItem.Checked)
            {
                key.SetValue("Tray Temperature", Application.ExecutablePath);
                Settings.Default.runOnStartup = true;
                Settings.Default.Save();
            }

            else
            {
                key.DeleteValue("Tray Temperature", false);
                Settings.Default.runOnStartup = false;
                Settings.Default.Save();
            }
        }

        private void runOnStartupToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            SetStartup();
        }
    }
}
