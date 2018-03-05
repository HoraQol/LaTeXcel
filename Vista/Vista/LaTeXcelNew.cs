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
    public partial class LaTeXcelNew : Form
    {
        private string rutaArchivo;
        public LaTeXcelNew(string ruta)
        {
            InitializeComponent();
            txtStart.Text = ruta;
            rutaArchivo = ruta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (FileOpenerNew.ShowDialog() == DialogResult.OK)
            {
                txtStart.Text = FileOpenerNew.FileName;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (FileSaveNew.ShowDialog() == DialogResult.OK)
            {
                txtEnd.Text = FileSaveNew.FileName;
            }
        }
    }
}
