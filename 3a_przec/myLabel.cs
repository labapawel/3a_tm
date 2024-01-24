using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3a_przec
{
    internal class myLabel : Label
    {
        private string myTXT;

        public string Text
        {
            get => base.Text;
            set
            {
                base.Text = value.ToUpper();
            }
        }


    }
}
