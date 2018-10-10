namespace Automotora.UI
{
    partial class AddVehicle
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
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
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(91, 214);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Km";
            // 
            // nudKilometros
            // 
            this.nudKilometers.DecimalPlaces = 1;
            this.nudKilometers.Location = new System.Drawing.Point(91, 179);
            this.nudKilometers.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKilometers.Name = "nudKilometros";
            this.nudKilometers.Size = new System.Drawing.Size(120, 20);
            this.nudKilometers.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Marca";
            // 
            // dtpIngreso
            // 
            this.dtpAdded.CustomFormat = "dd/MM/yyyy";
            this.dtpAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdded.Location = new System.Drawing.Point(91, 138);
            this.dtpAdded.Name = "dtpIngreso";
            this.dtpAdded.Size = new System.Drawing.Size(120, 20);
            this.dtpAdded.TabIndex = 16;
            // 
            // nudAño
            // 
            this.nudYear.Location = new System.Drawing.Point(91, 100);
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
            this.nudYear.TabIndex = 15;
            this.nudYear.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // txbModelo
            // 
            this.txbModel.Location = new System.Drawing.Point(91, 63);
            this.txbModel.Name = "txbModelo";
            this.txbModel.Size = new System.Drawing.Size(120, 20);
            this.txbModel.TabIndex = 14;
            // 
            // txbMarca
            // 
            this.txbBrand.Location = new System.Drawing.Point(91, 21);
            this.txbBrand.Name = "txbMarca";
            this.txbBrand.Size = new System.Drawing.Size(120, 20);
            this.txbBrand.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(91, 261);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AltaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxTipo);
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
            this.Name = "AltaAutomovil";
            this.Size = new System.Drawing.Size(255, 309);
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTipo;
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
        private System.Windows.Forms.Button btnAgregar;
    }
}
