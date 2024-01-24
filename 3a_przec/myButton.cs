using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3a_przec
{
    internal class myButton : Button
    {
        private Label lAtomowa = new Label() { Text = "1" };
        private Label pMasa = new Label() {Text="1.0000"};
        private Label pNazwa = new Label() { Text = "Wodór" };
        public string Symbol
        {
            get => base.Text; 
            set => base.Text = value.ToUpper(); 
        }

        public Font lAtomFont
        {
            get => lAtomowa.Font;
            set => lAtomowa.Font = value;
        }
        public string Nazwa
        {
            get => pNazwa.Text;
            set => pNazwa.Text = value;
        }
        public string Masa
        {
            get => pMasa.Text;
            set => pMasa.Text = value;
        }
        public int LAtom
        {
            set => lAtomowa.Text = value.ToString();
            get => lAtomowa.Text != "" ? int.Parse(lAtomowa.Text) : 0;
        }


        public myButton() : base() 
        {
            lAtomowa.Left = 3;
            lAtomowa.Top = 3;
            lAtomowa.BackColor = Color.Transparent;

            this.Controls.Add(lAtomowa);
            this.Controls.Add(pMasa);
            this.Controls.Add(pNazwa);

            pMasa.BackColor = Color.Transparent;
            pNazwa.BackColor = Color.Transparent;
            pNazwa.TextAlign = ContentAlignment.MiddleCenter;
            //pNazwa.AutoSize = true;
            pNazwa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pMasa.AutoSize = true;
            lAtomowa.Font = new Font("Arial", 6, FontStyle.Bold);
            pMasa.Font = lAtomowa.Font;
            this.Font = new Font("Arial", 15, FontStyle.Bold);
            pNazwa.Font = new Font("Arial", 8, FontStyle.Regular);
            Resize += resize;
        }



        public void resize(object sender, EventArgs e)
        {
            this.Height = this.Width;    
            base.Size = new Size(this.Width, this.Height);
            pNazwa.Top = (this.Width / 2) + 5;
            pNazwa.Width = this.Width;
            pMasa.Top = this.Width - 12;
            pMasa.Left = this.Width - pMasa.Width-3;
        }
    }
}
