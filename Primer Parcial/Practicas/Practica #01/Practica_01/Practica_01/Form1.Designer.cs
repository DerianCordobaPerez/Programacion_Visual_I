
namespace Practica_01
{
    partial class Form1
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
            this.labelCarRegister = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlTextBoxMileage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ControlTextBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSaveCar = new System.Windows.Forms.Button();
            this.buttonShowCars = new System.Windows.Forms.Button();
            this.ControlComboBoxBrand = new System.Windows.Forms.ComboBox();
            this.ControlComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.ControlComboBoxTransmission = new System.Windows.Forms.ComboBox();
            this.ControlComboBoxRine = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelCarRegister
            // 
            this.labelCarRegister.AutoSize = true;
            this.labelCarRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.labelCarRegister.Location = new System.Drawing.Point(95, 30);
            this.labelCarRegister.Name = "labelCarRegister";
            this.labelCarRegister.Size = new System.Drawing.Size(563, 76);
            this.labelCarRegister.TabIndex = 0;
            this.labelCarRegister.Text = "Registro de Autos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(59, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(59, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kilometraje";
            // 
            // ControlTextBoxMileage
            // 
            this.ControlTextBoxMileage.Location = new System.Drawing.Point(185, 202);
            this.ControlTextBoxMileage.Name = "ControlTextBoxMileage";
            this.ControlTextBoxMileage.Size = new System.Drawing.Size(156, 20);
            this.ControlTextBoxMileage.TabIndex = 4;
            this.ControlTextBoxMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTextBoxMileage_KeyPress);
            this.ControlTextBoxMileage.Leave += new System.EventHandler(this.ControlTextBoxMileage_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(59, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(368, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio";
            // 
            // ControlTextBoxPrice
            // 
            this.ControlTextBoxPrice.Location = new System.Drawing.Point(517, 150);
            this.ControlTextBoxPrice.Name = "ControlTextBoxPrice";
            this.ControlTextBoxPrice.Size = new System.Drawing.Size(156, 20);
            this.ControlTextBoxPrice.TabIndex = 8;
            this.ControlTextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTextBoxPrice_KeyPress);
            this.ControlTextBoxPrice.Leave += new System.EventHandler(this.ControlTextBoxPrice_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(368, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Transmision";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(368, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rines de lujo";
            // 
            // buttonSaveCar
            // 
            this.buttonSaveCar.BackColor = System.Drawing.Color.Indigo;
            this.buttonSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSaveCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSaveCar.Location = new System.Drawing.Point(64, 316);
            this.buttonSaveCar.Name = "buttonSaveCar";
            this.buttonSaveCar.Size = new System.Drawing.Size(277, 51);
            this.buttonSaveCar.TabIndex = 13;
            this.buttonSaveCar.Text = "Guardar";
            this.buttonSaveCar.UseVisualStyleBackColor = false;
            this.buttonSaveCar.Click += new System.EventHandler(this.buttonSaveCar_Click);
            // 
            // buttonShowCars
            // 
            this.buttonShowCars.BackColor = System.Drawing.Color.Indigo;
            this.buttonShowCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonShowCars.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonShowCars.Location = new System.Drawing.Point(396, 316);
            this.buttonShowCars.Name = "buttonShowCars";
            this.buttonShowCars.Size = new System.Drawing.Size(277, 51);
            this.buttonShowCars.TabIndex = 14;
            this.buttonShowCars.Text = "Ver Registros";
            this.buttonShowCars.UseVisualStyleBackColor = false;
            this.buttonShowCars.Click += new System.EventHandler(this.buttonShowCars_Click);
            // 
            // ControlComboBoxBrand
            // 
            this.ControlComboBoxBrand.Items.AddRange(new object[] {
            "Nissan",
            "Toyota",
            "Hyundai",
            "Kia",
            "Honda"});
            this.ControlComboBoxBrand.Location = new System.Drawing.Point(185, 150);
            this.ControlComboBoxBrand.Name = "ControlComboBoxBrand";
            this.ControlComboBoxBrand.Size = new System.Drawing.Size(156, 21);
            this.ControlComboBoxBrand.TabIndex = 15;
            // 
            // ControlComboBoxStatus
            // 
            this.ControlComboBoxStatus.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.ControlComboBoxStatus.Location = new System.Drawing.Point(185, 250);
            this.ControlComboBoxStatus.Name = "ControlComboBoxStatus";
            this.ControlComboBoxStatus.Size = new System.Drawing.Size(156, 21);
            this.ControlComboBoxStatus.TabIndex = 16;
            // 
            // ControlComboBoxTransmission
            // 
            this.ControlComboBoxTransmission.Items.AddRange(new object[] {
            "Manual",
            "Automatico"});
            this.ControlComboBoxTransmission.Location = new System.Drawing.Point(517, 202);
            this.ControlComboBoxTransmission.Name = "ControlComboBoxTransmission";
            this.ControlComboBoxTransmission.Size = new System.Drawing.Size(156, 21);
            this.ControlComboBoxTransmission.TabIndex = 17;
            // 
            // ControlComboBoxRine
            // 
            this.ControlComboBoxRine.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.ControlComboBoxRine.Location = new System.Drawing.Point(517, 250);
            this.ControlComboBoxRine.Name = "ControlComboBoxRine";
            this.ControlComboBoxRine.Size = new System.Drawing.Size(156, 21);
            this.ControlComboBoxRine.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 428);
            this.Controls.Add(this.ControlComboBoxRine);
            this.Controls.Add(this.ControlComboBoxTransmission);
            this.Controls.Add(this.ControlComboBoxStatus);
            this.Controls.Add(this.ControlComboBoxBrand);
            this.Controls.Add(this.buttonShowCars);
            this.Controls.Add(this.buttonSaveCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ControlTextBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ControlTextBoxMileage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCarRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Practica #01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCarRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ControlTextBoxMileage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ControlTextBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSaveCar;
        private System.Windows.Forms.Button buttonShowCars;
        private System.Windows.Forms.ComboBox ControlComboBoxBrand;
        private System.Windows.Forms.ComboBox ControlComboBoxStatus;
        private System.Windows.Forms.ComboBox ControlComboBoxTransmission;
        private System.Windows.Forms.ComboBox ControlComboBoxRine;
    }
}

