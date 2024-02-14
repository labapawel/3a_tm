using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3a_przec
{
    public partial class Form1 : Form
    {
        private string url = @"https://raw.githubusercontent.com/Bowserinator/Periodic-Table-JSON/master/PeriodicTableJSON.json";
        public Form1()
        {
            InitializeComponent();
            using(var wc = new WebClient())
            {
                string jsonstring = wc.DownloadString(url);
                ListaTM tm = JsonConvert.DeserializeObject<ListaTM>(jsonstring);
                foreach (Element el in tm.elements) { 
                    myButton b = new myButton();
                    b.Nazwa = el.name;
                    b.Width = 80;
                    b.LAtom = el.number;
                    b.Masa = el.atomic_mass.ToString();
                    b.Symbol = el.symbol;
                    panel.Controls.Add(b, el.xpos, el.ypos);
                } 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myButton btt = new myButton();
            btt.Width = 80;
            btt.Symbol = "H";
            btt.LAtom = 1;
            btt.Nazwa = "Wodór";
            btt.Masa = "1.0078";



            //panel.Controls.Add(btt, 1, 1);

         /*
            myLabel my = new myLabel();
            my.Text = "ala ma kota";

            this.Controls.Add(my);
        */
        }
    }
}
