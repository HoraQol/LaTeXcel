namespace Vista
{
    partial class LaTeXcelDocumentSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxChar = new System.Windows.Forms.GroupBox();
            this.gbxPar = new System.Windows.Forms.GroupBox();
            this.btnCustomAplicar = new System.Windows.Forms.Button();
            this.btnCustomCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbxChar
            // 
            this.gbxChar.Location = new System.Drawing.Point(12, 38);
            this.gbxChar.Name = "gbxChar";
            this.gbxChar.Size = new System.Drawing.Size(522, 100);
            this.gbxChar.TabIndex = 0;
            this.gbxChar.TabStop = false;
            this.gbxChar.Text = "Personalización de caracter";
            // 
            // gbxPar
            // 
            this.gbxPar.Location = new System.Drawing.Point(12, 166);
            this.gbxPar.Name = "gbxPar";
            this.gbxPar.Size = new System.Drawing.Size(522, 100);
            this.gbxPar.TabIndex = 1;
            this.gbxPar.TabStop = false;
            this.gbxPar.Text = "Personalización de párrafo";
            // 
            // btnCustomAplicar
            // 
            this.btnCustomAplicar.Location = new System.Drawing.Point(365, 366);
            this.btnCustomAplicar.Name = "btnCustomAplicar";
            this.btnCustomAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnCustomAplicar.TabIndex = 2;
            this.btnCustomAplicar.Text = "Aplicar";
            this.btnCustomAplicar.UseVisualStyleBackColor = true;
            // 
            // btnCustomCerrar
            // 
            this.btnCustomCerrar.Location = new System.Drawing.Point(459, 366);
            this.btnCustomCerrar.Name = "btnCustomCerrar";
            this.btnCustomCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCustomCerrar.TabIndex = 3;
            this.btnCustomCerrar.Text = "Cancelar";
            this.btnCustomCerrar.UseVisualStyleBackColor = true;
            this.btnCustomCerrar.Click += new System.EventHandler(this.btnCustomCerrar_Click);
            // 
            // LaTeXcelDocumentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 437);
            this.Controls.Add(this.btnCustomCerrar);
            this.Controls.Add(this.btnCustomAplicar);
            this.Controls.Add(this.gbxPar);
            this.Controls.Add(this.gbxChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaTeXcelDocumentSettings";
            this.Text = "LaTeXcelDocumentSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxChar;
        private System.Windows.Forms.GroupBox gbxPar;
        private System.Windows.Forms.Button btnCustomAplicar;
        private System.Windows.Forms.Button btnCustomCerrar;
    }
}