namespace UIAutomotora
{
    partial class AutomotoraMilenium
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.agregarVehiculo = new System.Windows.Forms.Button();
            this.verVehiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(152, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(298, 315);
            this.panelPrincipal.TabIndex = 0;
            // 
            // agregarVehiculo
            // 
            this.agregarVehiculo.Location = new System.Drawing.Point(34, 82);
            this.agregarVehiculo.Name = "agregarVehiculo";
            this.agregarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.agregarVehiculo.TabIndex = 1;
            this.agregarVehiculo.Text = "Agregar";
            this.agregarVehiculo.UseVisualStyleBackColor = true;
            this.agregarVehiculo.Click += new System.EventHandler(this.agregarVehiculo_Click);
            // 
            // verVehiculo
            // 
            this.verVehiculo.Location = new System.Drawing.Point(34, 130);
            this.verVehiculo.Name = "verVehiculo";
            this.verVehiculo.Size = new System.Drawing.Size(75, 23);
            this.verVehiculo.TabIndex = 2;
            this.verVehiculo.Text = "Ver";
            this.verVehiculo.UseVisualStyleBackColor = true;
            this.verVehiculo.Click += new System.EventHandler(this.verVehiculo_Click);
            // 
            // AutomotoraMilenium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 341);
            this.Controls.Add(this.verVehiculo);
            this.Controls.Add(this.agregarVehiculo);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "AutomotoraMilenium";
            this.Text = "Automotora Milenium";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button agregarVehiculo;
        private System.Windows.Forms.Button verVehiculo;
    }
}

