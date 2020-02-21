using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (divider1.Top > 550)
            {
                divider1.Top = 0;
            }
            else
            {
                divider1.Top += 1;
            }

            if (divider2.Top > 550)
            {
                divider2.Top = 0;
            }
            else
            {
                divider2.Top += 1;
            }




            if (divider3.Top > 550)
            {
                divider3.Top = 0;
            }
            else
            {
                divider3.Top += 1;
            }

            if (divider4.Top > 550)
            {
                divider4.Top = 0;
            }
            else
            {
                divider4.Top += 1;
            }
        }
    }
}
