using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class LaTeXcelScreen : Form
    {
        public LaTeXcelScreen()
        {
            InitializeComponent();
            timerScreen.Enabled = true;
            timerScreen.Interval = 3000;
        }

        private void timerScreen_Tick(object sender, EventArgs e)
        {
            timerScreen.Stop();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
