namespace UIAutomotora
{
    partial class MostrarVehiculo
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
            this.label5 = new System.Windows.Forms.Label();
            this.nudKilometros = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Km";
            // 
            // nudKilometros
            // 
            this.nudKilometros.DecimalPlaces = 1;
            this.nudKilometros.Location = new System.Drawing.Point(110, 200);
            this.nudKilometros.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKilometros.Name = "nudKilometros";
            this.nudKilometros.Size = new System.Drawing.Size(120, 20);
            this.nudKilometros.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Marca";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(110, 159);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(120, 20);
            this.dtpIngreso.TabIndex = 26;
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(110, 119);
            this.nudAño.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(120, 20);
            this.nudAño.TabIndex = 25;
            this.nudAño.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(110, 82);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(120, 20);
            this.txbModelo.TabIndex = 24;
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(110, 40);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(120, 20);
            this.txbMarca.TabIndex = 23;
            // 
            // MostrarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudKilometros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.nudAño);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.txbMarca);
            this.Name = "MostrarVehiculo";
            this.Text = "Vehículo";
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudKilometros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbMarca;
    }
}