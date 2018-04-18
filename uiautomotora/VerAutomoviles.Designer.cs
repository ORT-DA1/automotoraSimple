namespace UIAutomotora
{
    partial class VerAutomoviles
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAutomoviles = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAutomoviles
            // 
            this.lstAutomoviles.FormattingEnabled = true;
            this.lstAutomoviles.Location = new System.Drawing.Point(20, 12);
            this.lstAutomoviles.Name = "lstAutomoviles";
            this.lstAutomoviles.Size = new System.Drawing.Size(230, 251);
            this.lstAutomoviles.TabIndex = 0;
            this.lstAutomoviles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAutomoviles_MouseDoubleClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(91, 278);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // VerAutomoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lstAutomoviles);
            this.Name = "VerAutomoviles";
            this.Size = new System.Drawing.Size(266, 315);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAutomoviles;
        private System.Windows.Forms.Button btnBorrar;
    }
}
