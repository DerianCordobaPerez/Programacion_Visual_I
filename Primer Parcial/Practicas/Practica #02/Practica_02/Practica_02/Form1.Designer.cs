
namespace Practica_02
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
            this.components = new System.ComponentModel.Container();
            this.ControlTextBoxKilometraje = new System.Windows.Forms.TextBox();
            this.ControlComboBoxKilometraje = new System.Windows.Forms.ComboBox();
            this.ControlComboBoxMarca = new System.Windows.Forms.ComboBox();
            this.ControlTextBoxPrecio = new System.Windows.Forms.TextBox();
            this.ControlComboBoxTransmision = new System.Windows.Forms.ComboBox();
            this.RadioButtonSi = new System.Windows.Forms.RadioButton();
            this.RadioButtonNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ButtonVer = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlTextBoxKilometraje
            // 
            this.ControlTextBoxKilometraje.Location = new System.Drawing.Point(12, 87);
            this.ControlTextBoxKilometraje.Name = "ControlTextBoxKilometraje";
            this.ControlTextBoxKilometraje.Size = new System.Drawing.Size(181, 20);
            this.ControlTextBoxKilometraje.TabIndex = 2;
            this.ControlTextBoxKilometraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTextBoxKilometraje_KeyPress);
            this.ControlTextBoxKilometraje.Leave += new System.EventHandler(this.ControlTextBoxKilometraje_Leave);
            // 
            // ControlComboBoxKilometraje
            // 
            this.ControlComboBoxKilometraje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControlComboBoxKilometraje.FormattingEnabled = true;
            this.ControlComboBoxKilometraje.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.ControlComboBoxKilometraje.Location = new System.Drawing.Point(12, 145);
            this.ControlComboBoxKilometraje.Name = "ControlComboBoxKilometraje";
            this.ControlComboBoxKilometraje.Size = new System.Drawing.Size(181, 21);
            this.ControlComboBoxKilometraje.TabIndex = 3;
            // 
            // ControlComboBoxMarca
            // 
            this.ControlComboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControlComboBoxMarca.FormattingEnabled = true;
            this.ControlComboBoxMarca.Items.AddRange(new object[] {
            "Honda",
            "Hyundai",
            "Kia",
            "Nissan ",
            "Toyota"});
            this.ControlComboBoxMarca.Location = new System.Drawing.Point(12, 29);
            this.ControlComboBoxMarca.Name = "ControlComboBoxMarca";
            this.ControlComboBoxMarca.Size = new System.Drawing.Size(181, 21);
            this.ControlComboBoxMarca.Sorted = true;
            this.ControlComboBoxMarca.TabIndex = 1;
            // 
            // ControlTextBoxPrecio
            // 
            this.ControlTextBoxPrecio.Location = new System.Drawing.Point(225, 30);
            this.ControlTextBoxPrecio.Name = "ControlTextBoxPrecio";
            this.ControlTextBoxPrecio.Size = new System.Drawing.Size(181, 20);
            this.ControlTextBoxPrecio.TabIndex = 4;
            this.ControlTextBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTextBoxPrecio_KeyPress);
            this.ControlTextBoxPrecio.Leave += new System.EventHandler(this.ControlTextBoxPrecio_Leave);
            // 
            // ControlComboBoxTransmision
            // 
            this.ControlComboBoxTransmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControlComboBoxTransmision.FormattingEnabled = true;
            this.ControlComboBoxTransmision.Items.AddRange(new object[] {
            "Manual",
            "Automatica"});
            this.ControlComboBoxTransmision.Location = new System.Drawing.Point(225, 87);
            this.ControlComboBoxTransmision.Name = "ControlComboBoxTransmision";
            this.ControlComboBoxTransmision.Size = new System.Drawing.Size(181, 21);
            this.ControlComboBoxTransmision.TabIndex = 5;
            // 
            // RadioButtonSi
            // 
            this.RadioButtonSi.AutoSize = true;
            this.RadioButtonSi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.RadioButtonSi.Location = new System.Drawing.Point(225, 147);
            this.RadioButtonSi.Name = "RadioButtonSi";
            this.RadioButtonSi.Size = new System.Drawing.Size(38, 21);
            this.RadioButtonSi.TabIndex = 6;
            this.RadioButtonSi.TabStop = true;
            this.RadioButtonSi.Text = "Si";
            this.RadioButtonSi.UseVisualStyleBackColor = true;
            // 
            // RadioButtonNo
            // 
            this.RadioButtonNo.AutoSize = true;
            this.RadioButtonNo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.RadioButtonNo.Location = new System.Drawing.Point(306, 147);
            this.RadioButtonNo.Name = "RadioButtonNo";
            this.RadioButtonNo.Size = new System.Drawing.Size(46, 21);
            this.RadioButtonNo.TabIndex = 7;
            this.RadioButtonNo.TabStop = true;
            this.RadioButtonNo.Text = "No";
            this.RadioButtonNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kilometraje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(222, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(222, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Transmision";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(222, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rines de lujo?";
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.BackColor = System.Drawing.Color.Indigo;
            this.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonGuardar.Location = new System.Drawing.Point(16, 192);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(177, 47);
            this.ButtonGuardar.TabIndex = 8;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.UseVisualStyleBackColor = false;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // ButtonVer
            // 
            this.ButtonVer.BackColor = System.Drawing.Color.Indigo;
            this.ButtonVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonVer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonVer.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonVer.Location = new System.Drawing.Point(225, 192);
            this.ButtonVer.Name = "ButtonVer";
            this.ButtonVer.Size = new System.Drawing.Size(181, 47);
            this.ButtonVer.TabIndex = 9;
            this.ButtonVer.Text = "Ver autos";
            this.ButtonVer.UseVisualStyleBackColor = false;
            this.ButtonVer.Click += new System.EventHandler(this.ButtonVer_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 254);
            this.Controls.Add(this.ButtonVer);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioButtonNo);
            this.Controls.Add(this.RadioButtonSi);
            this.Controls.Add(this.ControlComboBoxTransmision);
            this.Controls.Add(this.ControlTextBoxPrecio);
            this.Controls.Add(this.ControlComboBoxMarca);
            this.Controls.Add(this.ControlComboBoxKilometraje);
            this.Controls.Add(this.ControlTextBoxKilometraje);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ControlTextBoxKilometraje;
        private System.Windows.Forms.ComboBox ControlComboBoxKilometraje;
        private System.Windows.Forms.ComboBox ControlComboBoxMarca;
        private System.Windows.Forms.TextBox ControlTextBoxPrecio;
        private System.Windows.Forms.ComboBox ControlComboBoxTransmision;
        private System.Windows.Forms.RadioButton RadioButtonSi;
        private System.Windows.Forms.RadioButton RadioButtonNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.Button ButtonVer;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}

