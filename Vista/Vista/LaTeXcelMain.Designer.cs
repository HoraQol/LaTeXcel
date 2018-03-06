namespace Vista
{
    partial class LaTeXcelMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeLaTeXcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMSExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeLaTeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LaTeXcelFileOpener = new System.Windows.Forms.OpenFileDialog();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.menuStrip1);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(524, 365);
            this.mainPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "LaTeXcel Menu";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversiónToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.nuevoToolStripMenuItem.Text = "Archivo";
            // 
            // conversiónToolStripMenuItem
            // 
            this.conversiónToolStripMenuItem.Name = "conversiónToolStripMenuItem";
            this.conversiónToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.conversiónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.conversiónToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.conversiónToolStripMenuItem.Text = "Nueva conversión";
            this.conversiónToolStripMenuItem.Click += new System.EventHandler(this.conversiónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeLaTeXcelToolStripMenuItem,
            this.acercaDeMSExcelToolStripMenuItem,
            this.acercaDeLaTeXToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeLaTeXcelToolStripMenuItem
            // 
            this.acercaDeLaTeXcelToolStripMenuItem.Name = "acercaDeLaTeXcelToolStripMenuItem";
            this.acercaDeLaTeXcelToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.acercaDeLaTeXcelToolStripMenuItem.Text = "Acerca de LaTeXcel";
            // 
            // acercaDeMSExcelToolStripMenuItem
            // 
            this.acercaDeMSExcelToolStripMenuItem.Name = "acercaDeMSExcelToolStripMenuItem";
            this.acercaDeMSExcelToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.acercaDeMSExcelToolStripMenuItem.Text = "Acerca de MS Excel";
            // 
            // acercaDeLaTeXToolStripMenuItem
            // 
            this.acercaDeLaTeXToolStripMenuItem.Name = "acercaDeLaTeXToolStripMenuItem";
            this.acercaDeLaTeXToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.acercaDeLaTeXToolStripMenuItem.Text = "Acerca de LaTeX";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // LaTeXcelFileOpener
            // 
            this.LaTeXcelFileOpener.FileName = "File Opener";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // LaTeXcelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 364);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LaTeXcelMain";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeLaTeXcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMSExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeLaTeXToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog LaTeXcelFileOpener;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
    }
}

