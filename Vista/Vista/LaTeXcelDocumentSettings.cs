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
    public partial class LaTeXcelDocumentSettings : Form
    {
        public LaTeXcelDocumentSettings()
        {
            InitializeComponent();
            DomainUpDown.DomainUpDownItemCollection col = domLetra.Items;
            col.Add("8pt.");
            col.Add("9pt.");
            col.Add("10pt.");
            col.Add("11pt.");
            col.Add("12pt.");
            domLetra.SelectedIndex = 2;
        }

        private void btnCustomCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
