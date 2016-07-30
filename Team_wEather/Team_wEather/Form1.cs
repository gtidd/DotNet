using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;


namespace Team_wEather
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            lbl_warn.Visible = false;
            bool isDigitPresent = false;
            if (!(isDigitPresent = comboBox1.Text.Any(c => char.IsDigit(c))))
            {
                
           string APIKey = "0122e9b39c4cbdb091984948bd3e4673";
           string szTemp = "0";//default value so program does not crash
           try
           {
              string weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + comboBox1.Text + ",us" + "&mode=xml&appid=" + APIKey;
              var xml = await new WebClient().DownloadStringTaskAsync(new Uri(weburl));
              XmlDocument doc = new XmlDocument();
              doc.LoadXml(xml);
              szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;


           }
           catch (Exception ex)
           {
               MessageBox.Show("Your request was not able to be processed.\n"
                               +"Please check your input and try again");
           }

           
           double celcious = double.Parse(szTemp) - 273.15;

           lblTemp_output.Text = celcious.ToString("##0") + " " + string.Format("\u00B0") + (" Celcius");//converts output to string temp format

           double fahrenheit = (((double.Parse(szTemp)) - 273.15) * 9 / 5) + 32;// F = C * 9/5 + 32
           lbl_tempFaren_Output.Text = fahrenheit.ToString("##0") + " " + string.Format("\u00B0") + (" Fahrenheit");//converts output to string temp format
           
            }
            else
            {
                lbl_warn.Visible = true;
            }
            
        }

      }

   

      

       
    }


