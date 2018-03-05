using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class LaTeXcelMain : Form
    {
        private LaTeXcelNew frmNew;
        public LaTeXcelMain()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void conversiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LaTeXcelFileOpener.ShowDialog() == DialogResult.OK)
            {
                string dir = LaTeXcelFileOpener.FileName;
                frmNew = new LaTeXcelNew(dir);
                frmNew.ShowDialog();
            }
        }
    }
}
