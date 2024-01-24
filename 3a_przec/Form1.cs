using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3a_przec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myButton btt = new myButton();
            btt.Width = 80;
            btt.Symbol = "H";
            btt.LAtom = 1;
            btt.Nazwa = "Wodór";
            btt.Masa = "1.0078";



            panel.Controls.Add(btt, 1, 1);

         /*
            myLabel my = new myLabel();
            my.Text = "ala ma kota";

            this.Controls.Add(my);
        */
        }
    }
}
