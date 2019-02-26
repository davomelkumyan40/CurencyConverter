using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;
using Rate_General.RatesFolder;

namespace Rate_General
{
    public partial class General : Form
    {

        //constructor
        public General()
        {
            // default winForms function
            InitializeComponent();
            //

            FileInfo info = new FileInfo(@"file.json");
            if (info.Exists)
                generalRate = GetRatesFromFile();
            else
            {
                generalRate = GetRatesWeb();
                JsonSaveToFile();
            }
        }

        private Dictionary<string, decimal> oldRates = null;
        private Rate generalRate;
        private Point lastLocation;
        private bool mouseDown;
        private bool isClicked = false;
        private string jsonString = string.Empty;
        private decimal finalRateValuel = 0;

        //drop and pick up functions
        private void generalPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void generalPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void generalPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static int Xminus(int x)
        {
            if (x > 60)
                x -= 5;

            return x;
        }

        //Animation of panel
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x = 60, y = 11;
            if (!isClicked)
            {
                buttonsPanel.Enabled = true;
                menubar.BringToFront();
                while (menubar.Width < 228)
                {
                    if (general_label.Location.X < 225)
                    {
                        x += 5;
                        general_label.Location = new Point(x, y);
                    }

                    Thread.Sleep(2);
                    general_label.Location = new Point(x, y);
                    menubar.Width += 4;
                    menubar.Refresh();
                }
                isClicked = true;
            }
            else
            {
                x = 225;
                while (menubar.Width > 62)
                {
                    menubar.Refresh();
                    if (general_label.Location.X > 67)
                    {
                        x -= 4;
                        general_label.Location = new Point(x, y);
                    }
                    menubar.Width -= 4;

                    exchangePanel.Refresh();
                }
                isClicked = false;
                menubar.Width += 4;
                general_label.Location = new Point(67, y);
                exchangePanel.BringToFront();
                buttonsPanel.Enabled = false;
            }
        }
        //

        //checking if Auto checked or not 
        private void check_Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Auto.CheckState == CheckState.Checked)
                autoChecker.Enabled = true;
            else
                autoChecker.Enabled = false;
        }
        //

        //Geting rates from web API services and returning type is Rate
        private Rate GetRatesWeb()
        {
            using (HttpClient client = new HttpClient())
            {
                string key = ConfigurationSettings.AppSettings.Get(0);
                if (!string.IsNullOrEmpty(key))
                {
                    string json = client.GetStringAsync("http://data.fixer.io/api/latest?access_key=" + key + "&symbols=AMD,RUB,USD").Result;
                    return JsonConvert.DeserializeObject<Rate>(json);
                }
                else
                    return null;
            }
        }
        //

        private Rate GetRatesFromFile()
        {
            using (FileStream jsonFile = new FileStream("file.json", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(jsonFile))
                {
                    jsonString = reader.ReadLine();
                }
                if (!string.IsNullOrEmpty(jsonString))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<Rate>(jsonString);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                        return new Rate
                        {
                            success = false,
                            rates = null
                        };
                }
                else
                    return new Rate
                    {
                        success = false,
                        rates = null
                    };
            }
        }

        private void JsonSaveToFile()
        {
            string json = JsonConvert.SerializeObject(generalRate);
            using (FileStream stream = new FileStream("file.json", FileMode.OpenOrCreate))
            using (StreamWriter writer = new StreamWriter(stream))
                writer.Write(json);

        }

        private void convert_money_Click(object sender, EventArgs e)
        {
            if (generalRate == null)
            {
                generalRate = GetRatesWeb();
                JsonSaveToFile();
                AppendText(rateConsole, $"[{DateTime.Now}]", Color.White);
                AppendText(rateConsole, $"[Saved...\r\n]", Color.White);
            }

            if (string.IsNullOrEmpty(change_money.Text) || string.IsNullOrEmpty(change_money2.Text) || change_money2.Text == "Money" || change_money.Text == "Money")
                MessageBox.Show("Not all fields are filled.");
            else
                money_result.Text = GeneralConverter().ToString();
            AppendText(rateConsole, $"[Converted]\r\n", Color.White);
        }

        private decimal GeneralConverter()
        {
            switch (change_money2.Items.IndexOf(change_money2.SelectedItem))
            {
                case (int)Curency.AMD:
                    if (decimal.TryParse(money.Text, out decimal value))
                    {
                        return value * generalRate.rates["AMD"];
                    }
                    break;
                case (int)Curency.RUB:
                    if (decimal.TryParse(money.Text, out decimal value1))
                    {
                        return value1 * generalRate.rates["RUB"];
                    }
                    break;
                case (int)Curency.USD:
                    if (decimal.TryParse(money.Text, out decimal value2))
                    {
                        return value2 * generalRate.rates["USD"];
                    }
                    break;
                case (int)Curency.EUR:
                    if (decimal.TryParse(money.Text, out decimal value3))
                    {
                        return value3 * generalRate.rates["EUR"];
                    }
                    break;
            }
            return 0;
        }

        //
        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //Colored String Writing
        private void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private void DrawResults()
        {
            string downArrow = "▼";
            string upArrow = "▲";
            string RightArrow = "⇨";
            if (oldRates != null)
            {
                decimal[] prevRates = new decimal[3];
                prevRates[0] = oldRates["AMD"];
                prevRates[1] = oldRates["RUB"];
                prevRates[2] = oldRates["USD"];

                decimal[] nowRates = new decimal[3];
                nowRates[0] = generalRate.rates["AMD"];
                nowRates[1] = generalRate.rates["RUB"];
                nowRates[2] = generalRate.rates["USD"];

                List<string> nameRates = new List<string>(3);

                AppendText(rateConsole, $"\n\r[{DateTime.Now}]\n\r", Color.White);

                foreach (var item in generalRate.rates.Keys)
                {
                    nameRates.Add(item);
                }
                for (int i = 0; i < 3; i++)
                {
                    if (prevRates[i] > nowRates[i])
                    {
                        AppendText(rateConsole, downArrow, Color.Red);
                        AppendText(rateConsole, $"  {nameRates[i]}: {prevRates[i]} {RightArrow} {nowRates[i]} \r\n", Color.White);
                    }
                    if (prevRates[i] < nowRates[i])
                    {
                        AppendText(rateConsole, upArrow, Color.Green);
                        AppendText(rateConsole, $"  {nameRates[i]}: {prevRates[i]} {RightArrow} {nowRates[i]} \r\n", Color.White);
                    }
                }
            }
            else
                rateConsole.Text += "All Up To Date \r\n";
        }

        private void RefreshRate()
        {
            oldRates = generalRate.rates;
            generalRate = GetRatesWeb();
            JsonSaveToFile();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (generalRate.date.Day != DateTime.Now.Day || generalRate.date.Year != DateTime.Now.Year || generalRate.date.Month != DateTime.Now.Month)
            {
                RefreshRate();
                DrawResults();
            }
            else
                rateConsole.Text += "All Up To Date \r\n";
        }

        private void refreshAuto_Tick(object sender, EventArgs e)
        {
            autoChecker.Interval = 600000;
            if (generalRate.date.Day != DateTime.Now.Day)
            {
                RefreshRate();
                DrawResults();
            }
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(0, 70, 167);
        }

        private void user_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(0, 70, 167);
        }

        private void user_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(25, 31, 40);
        }

        private void menubar_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(25, 31, 40);
        }

        private void menubar_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(0, 70, 167);
        }
    }
}
