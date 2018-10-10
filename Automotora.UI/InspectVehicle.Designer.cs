namespace Automotora.UI
{
    partial class InspectVehicle
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
            this.nudKilometers = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAdded = new System.Windows.Forms.DateTimePicker();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.txbBrand = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
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
            this.nudKilometers.DecimalPlaces = 1;
            this.nudKilometers.Location = new System.Drawing.Point(110, 200);
            this.nudKilometers.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKilometers.Name = "nudKilometros";
            this.nudKilometers.Size = new System.Drawing.Size(120, 20);
            this.nudKilometers.TabIndex = 31;
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
            this.dtpAdded.CustomFormat = "dd/MM/yyyy";
            this.dtpAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdded.Location = new System.Drawing.Point(110, 159);
            this.dtpAdded.Name = "dtpIngreso";
            this.dtpAdded.Size = new System.Drawing.Size(120, 20);
            this.dtpAdded.TabIndex = 26;
            // 
            // nudAño
            // 
            this.nudYear.Location = new System.Drawing.Point(110, 119);
            this.nudYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYear.Name = "nudAño";
            this.nudYear.Size = new System.Drawing.Size(120, 20);
            this.nudYear.TabIndex = 25;
            this.nudYear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // txbModelo
            // 
            this.txbModel.Location = new System.Drawing.Point(110, 82);
            this.txbModel.Name = "txbModelo";
            this.txbModel.Size = new System.Drawing.Size(120, 20);
            this.txbModel.TabIndex = 24;
            // 
            // txbMarca
            // 
            this.txbBrand.Location = new System.Drawing.Point(110, 40);
            this.txbBrand.Name = "txbMarca";
            this.txbBrand.Size = new System.Drawing.Size(120, 20);
            this.txbBrand.TabIndex = 23;
            // 
            // MostrarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudKilometers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAdded);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.txbModel);
            this.Controls.Add(this.txbBrand);
            this.Name = "MostrarVehiculo";
            this.Text = "Vehículo";
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudKilometers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAdded;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.TextBox txbBrand;
    }
}