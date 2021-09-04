
namespace Practica_02
{
    partial class VerAutos
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
            this.DataGridViewAutos = new System.Windows.Forms.DataGridView();
            this.ComboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewAutos
            // 
            this.DataGridViewAutos.AllowUserToAddRows = false;
            this.DataGridViewAutos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DataGridViewAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAutos.Location = new System.Drawing.Point(12, 67);
            this.DataGridViewAutos.Name = "DataGridViewAutos";
            this.DataGridViewAutos.Size = new System.Drawing.Size(643, 150);
            this.DataGridViewAutos.TabIndex = 0;
            // 
            // ComboBoxBuscar
            // 
            this.ComboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBuscar.FormattingEnabled = true;
            this.ComboBoxBuscar.Items.AddRange(new object[] {
            "Todos",
            "Honda",
            "Hyundai",
            "Kia",
            "Nissan",
            "Toyota"});
            this.ComboBoxBuscar.Location = new System.Drawing.Point(12, 40);
            this.ComboBoxBuscar.Name = "ComboBoxBuscar";
            this.ComboBoxBuscar.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxBuscar.TabIndex = 1;
            this.ComboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar autos por marca";
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.BackColor = System.Drawing.Color.Indigo;
            this.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEliminar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonEliminar.Location = new System.Drawing.Point(547, 39);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(108, 21);
            this.ButtonEliminar.TabIndex = 3;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = false;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // VerAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 229);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxBuscar);
            this.Controls.Add(this.DataGridViewAutos);
            this.Name = "VerAutos";
            this.Text = "Ver autos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewAutos;
        private System.Windows.Forms.ComboBox ComboBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEliminar;
    }
}