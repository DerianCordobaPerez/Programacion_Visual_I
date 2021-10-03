
namespace Practica_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.buttonVolverUna = new System.Windows.Forms.Button();
            this.buttonAdelantarFin = new System.Windows.Forms.Button();
            this.buttonAdelantarUna = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGris = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCentrada = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripNombreArchivo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusNombreArchivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxVision = new System.Windows.Forms.GroupBox();
            this.checkBoxVisionEscalaGrises = new System.Windows.Forms.CheckBox();
            this.checkBoxVisionNormal = new System.Windows.Forms.CheckBox();
            this.groupBoxTamaño = new System.Windows.Forms.GroupBox();
            this.radioButtonTamañoZoom = new System.Windows.Forms.RadioButton();
            this.radioButtonTamañoAjustar = new System.Windows.Forms.RadioButton();
            this.radioButtonTamañoCentrada = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNormal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGris = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCentrada = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAjustar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoom = new System.Windows.Forms.ToolStripButton();
            this.comboBoxSelectorImagen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.contextMenuStripClickDerecho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemRotarDerecha = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRotarIzquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStripNombreArchivo.SuspendLayout();
            this.groupBoxVision.SuspendLayout();
            this.groupBoxTamaño.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.contextMenuStripClickDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.Indigo;
            this.buttonVolverInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVolverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVolverInicio.Location = new System.Drawing.Point(12, 412);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(110, 53);
            this.buttonVolverInicio.TabIndex = 0;
            this.buttonVolverInicio.Text = "<<";
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // buttonVolverUna
            // 
            this.buttonVolverUna.BackColor = System.Drawing.Color.Indigo;
            this.buttonVolverUna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolverUna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVolverUna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverUna.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVolverUna.Location = new System.Drawing.Point(128, 412);
            this.buttonVolverUna.Name = "buttonVolverUna";
            this.buttonVolverUna.Size = new System.Drawing.Size(110, 53);
            this.buttonVolverUna.TabIndex = 1;
            this.buttonVolverUna.Text = "<";
            this.buttonVolverUna.UseVisualStyleBackColor = false;
            this.buttonVolverUna.Click += new System.EventHandler(this.buttonVolverUna_Click);
            // 
            // buttonAdelantarFin
            // 
            this.buttonAdelantarFin.BackColor = System.Drawing.Color.Indigo;
            this.buttonAdelantarFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdelantarFin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdelantarFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdelantarFin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdelantarFin.Location = new System.Drawing.Point(410, 412);
            this.buttonAdelantarFin.Name = "buttonAdelantarFin";
            this.buttonAdelantarFin.Size = new System.Drawing.Size(109, 53);
            this.buttonAdelantarFin.TabIndex = 3;
            this.buttonAdelantarFin.Text = ">>";
            this.buttonAdelantarFin.UseVisualStyleBackColor = false;
            this.buttonAdelantarFin.Click += new System.EventHandler(this.buttonAdelantarFin_Click);
            // 
            // buttonAdelantarUna
            // 
            this.buttonAdelantarUna.BackColor = System.Drawing.Color.Indigo;
            this.buttonAdelantarUna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdelantarUna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdelantarUna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdelantarUna.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdelantarUna.Location = new System.Drawing.Point(294, 412);
            this.buttonAdelantarUna.Name = "buttonAdelantarUna";
            this.buttonAdelantarUna.Size = new System.Drawing.Size(110, 53);
            this.buttonAdelantarUna.TabIndex = 2;
            this.buttonAdelantarUna.Text = ">";
            this.buttonAdelantarUna.UseVisualStyleBackColor = false;
            this.buttonAdelantarUna.Click += new System.EventHandler(this.buttonAdelantarUna_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.visionToolStripMenuItem,
            this.tamañoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGuardar,
            this.toolStripMenuItem2,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // MenuItemGuardar
            // 
            this.MenuItemGuardar.Name = "MenuItemGuardar";
            this.MenuItemGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.MenuItemGuardar.Size = new System.Drawing.Size(204, 22);
            this.MenuItemGuardar.Text = "Guardar";
            this.MenuItemGuardar.Click += new System.EventHandler(this.MenuItemGuardar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNormal,
            this.ToolStripMenuItemGris});
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.visionToolStripMenuItem.Text = "Vision";
            // 
            // ToolStripMenuItemNormal
            // 
            this.ToolStripMenuItemNormal.Checked = true;
            this.ToolStripMenuItemNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItemNormal.Name = "ToolStripMenuItemNormal";
            this.ToolStripMenuItemNormal.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItemNormal.Size = new System.Drawing.Size(241, 22);
            this.ToolStripMenuItemNormal.Text = "Normal";
            this.ToolStripMenuItemNormal.Click += new System.EventHandler(this.ToolStripMenuItemNormal_Click);
            // 
            // ToolStripMenuItemGris
            // 
            this.ToolStripMenuItemGris.Name = "ToolStripMenuItemGris";
            this.ToolStripMenuItemGris.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.ToolStripMenuItemGris.Size = new System.Drawing.Size(241, 22);
            this.ToolStripMenuItemGris.Text = "Escala de grises";
            this.ToolStripMenuItemGris.Click += new System.EventHandler(this.ToolStripMenuItemGris_Click);
            // 
            // tamañoToolStripMenuItem
            // 
            this.tamañoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCentrada,
            this.MenuItemAjustar,
            this.MenuItemZoom});
            this.tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            this.tamañoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tamañoToolStripMenuItem.Text = "Tamaño";
            // 
            // MenuItemCentrada
            // 
            this.MenuItemCentrada.Checked = true;
            this.MenuItemCentrada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemCentrada.Name = "MenuItemCentrada";
            this.MenuItemCentrada.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.MenuItemCentrada.Size = new System.Drawing.Size(210, 22);
            this.MenuItemCentrada.Text = "Centrada";
            this.MenuItemCentrada.Click += new System.EventHandler(this.MenuItemCentrada_Click);
            // 
            // MenuItemAjustar
            // 
            this.MenuItemAjustar.Name = "MenuItemAjustar";
            this.MenuItemAjustar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.MenuItemAjustar.Size = new System.Drawing.Size(210, 22);
            this.MenuItemAjustar.Text = "Ajustar";
            this.MenuItemAjustar.Click += new System.EventHandler(this.MenuItemAjustar_Click);
            // 
            // MenuItemZoom
            // 
            this.MenuItemZoom.Name = "MenuItemZoom";
            this.MenuItemZoom.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.MenuItemZoom.Size = new System.Drawing.Size(210, 22);
            this.MenuItemZoom.Text = "Zoom";
            this.MenuItemZoom.Click += new System.EventHandler(this.MenuItemZoom_Click);
            // 
            // statusStripNombreArchivo
            // 
            this.statusStripNombreArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusNombreArchivo});
            this.statusStripNombreArchivo.Location = new System.Drawing.Point(0, 473);
            this.statusStripNombreArchivo.Name = "statusStripNombreArchivo";
            this.statusStripNombreArchivo.Size = new System.Drawing.Size(531, 22);
            this.statusStripNombreArchivo.TabIndex = 5;
            this.statusStripNombreArchivo.Text = "statusStrip1";
            // 
            // toolStripStatusNombreArchivo
            // 
            this.toolStripStatusNombreArchivo.Name = "toolStripStatusNombreArchivo";
            this.toolStripStatusNombreArchivo.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusNombreArchivo.Text = "toolStripStatusLabel1";
            // 
            // groupBoxVision
            // 
            this.groupBoxVision.Controls.Add(this.checkBoxVisionEscalaGrises);
            this.groupBoxVision.Controls.Add(this.checkBoxVisionNormal);
            this.groupBoxVision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVision.Location = new System.Drawing.Point(12, 50);
            this.groupBoxVision.Name = "groupBoxVision";
            this.groupBoxVision.Size = new System.Drawing.Size(500, 62);
            this.groupBoxVision.TabIndex = 6;
            this.groupBoxVision.TabStop = false;
            this.groupBoxVision.Text = "Vision";
            // 
            // checkBoxVisionEscalaGrises
            // 
            this.checkBoxVisionEscalaGrises.AutoSize = true;
            this.checkBoxVisionEscalaGrises.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVisionEscalaGrises.Location = new System.Drawing.Point(241, 25);
            this.checkBoxVisionEscalaGrises.Name = "checkBoxVisionEscalaGrises";
            this.checkBoxVisionEscalaGrises.Size = new System.Drawing.Size(136, 22);
            this.checkBoxVisionEscalaGrises.TabIndex = 1;
            this.checkBoxVisionEscalaGrises.Text = "Escala de grises";
            this.checkBoxVisionEscalaGrises.UseVisualStyleBackColor = true;
            this.checkBoxVisionEscalaGrises.CheckedChanged += new System.EventHandler(this.checkBoxVisionEscalaGrises_CheckedChanged);
            // 
            // checkBoxVisionNormal
            // 
            this.checkBoxVisionNormal.AutoSize = true;
            this.checkBoxVisionNormal.Checked = true;
            this.checkBoxVisionNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVisionNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVisionNormal.Location = new System.Drawing.Point(108, 25);
            this.checkBoxVisionNormal.Name = "checkBoxVisionNormal";
            this.checkBoxVisionNormal.Size = new System.Drawing.Size(76, 22);
            this.checkBoxVisionNormal.TabIndex = 0;
            this.checkBoxVisionNormal.Text = "Normal";
            this.checkBoxVisionNormal.UseVisualStyleBackColor = true;
            this.checkBoxVisionNormal.CheckedChanged += new System.EventHandler(this.checkBoxVisionNormal_CheckedChanged);
            // 
            // groupBoxTamaño
            // 
            this.groupBoxTamaño.Controls.Add(this.radioButtonTamañoZoom);
            this.groupBoxTamaño.Controls.Add(this.radioButtonTamañoAjustar);
            this.groupBoxTamaño.Controls.Add(this.radioButtonTamañoCentrada);
            this.groupBoxTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTamaño.Location = new System.Drawing.Point(375, 118);
            this.groupBoxTamaño.Name = "groupBoxTamaño";
            this.groupBoxTamaño.Size = new System.Drawing.Size(137, 288);
            this.groupBoxTamaño.TabIndex = 7;
            this.groupBoxTamaño.TabStop = false;
            this.groupBoxTamaño.Text = "Tamaño";
            // 
            // radioButtonTamañoZoom
            // 
            this.radioButtonTamañoZoom.AutoSize = true;
            this.radioButtonTamañoZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTamañoZoom.Location = new System.Drawing.Point(26, 150);
            this.radioButtonTamañoZoom.Name = "radioButtonTamañoZoom";
            this.radioButtonTamañoZoom.Size = new System.Drawing.Size(66, 22);
            this.radioButtonTamañoZoom.TabIndex = 2;
            this.radioButtonTamañoZoom.Text = "Zoom";
            this.radioButtonTamañoZoom.UseVisualStyleBackColor = true;
            this.radioButtonTamañoZoom.CheckedChanged += new System.EventHandler(this.radioButtonTamañoZoom_CheckedChanged);
            // 
            // radioButtonTamañoAjustar
            // 
            this.radioButtonTamañoAjustar.AutoSize = true;
            this.radioButtonTamañoAjustar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTamañoAjustar.Location = new System.Drawing.Point(26, 103);
            this.radioButtonTamañoAjustar.Name = "radioButtonTamañoAjustar";
            this.radioButtonTamañoAjustar.Size = new System.Drawing.Size(71, 22);
            this.radioButtonTamañoAjustar.TabIndex = 1;
            this.radioButtonTamañoAjustar.Text = "Ajustar";
            this.radioButtonTamañoAjustar.UseVisualStyleBackColor = true;
            this.radioButtonTamañoAjustar.CheckedChanged += new System.EventHandler(this.radioButtonTamañoAjustar_CheckedChanged);
            // 
            // radioButtonTamañoCentrada
            // 
            this.radioButtonTamañoCentrada.AutoSize = true;
            this.radioButtonTamañoCentrada.Checked = true;
            this.radioButtonTamañoCentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTamañoCentrada.Location = new System.Drawing.Point(26, 61);
            this.radioButtonTamañoCentrada.Name = "radioButtonTamañoCentrada";
            this.radioButtonTamañoCentrada.Size = new System.Drawing.Size(86, 22);
            this.radioButtonTamañoCentrada.TabIndex = 0;
            this.radioButtonTamañoCentrada.TabStop = true;
            this.radioButtonTamañoCentrada.Text = "Centrada";
            this.radioButtonTamañoCentrada.UseVisualStyleBackColor = true;
            this.radioButtonTamañoCentrada.CheckedChanged += new System.EventHandler(this.radioButtonTamañoCentrada_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNormal,
            this.toolStripButtonGris,
            this.toolStripButtonCentrada,
            this.toolStripButtonAjustar,
            this.toolStripButtonZoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(531, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNormal
            // 
            this.toolStripButtonNormal.Checked = true;
            this.toolStripButtonNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNormal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNormal.Image")));
            this.toolStripButtonNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNormal.Name = "toolStripButtonNormal";
            this.toolStripButtonNormal.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNormal.Text = "Normal";
            this.toolStripButtonNormal.Click += new System.EventHandler(this.toolStripButtonNormal_Click);
            // 
            // toolStripButtonGris
            // 
            this.toolStripButtonGris.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGris.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGris.Image")));
            this.toolStripButtonGris.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGris.Name = "toolStripButtonGris";
            this.toolStripButtonGris.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGris.Text = "Escala de grises";
            this.toolStripButtonGris.Click += new System.EventHandler(this.toolStripButtonGris_Click);
            // 
            // toolStripButtonCentrada
            // 
            this.toolStripButtonCentrada.Checked = true;
            this.toolStripButtonCentrada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonCentrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCentrada.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCentrada.Image")));
            this.toolStripButtonCentrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCentrada.Name = "toolStripButtonCentrada";
            this.toolStripButtonCentrada.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCentrada.Text = "Centrada";
            this.toolStripButtonCentrada.Click += new System.EventHandler(this.toolStripButtonCentrada_Click);
            // 
            // toolStripButtonAjustar
            // 
            this.toolStripButtonAjustar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAjustar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAjustar.Image")));
            this.toolStripButtonAjustar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAjustar.Name = "toolStripButtonAjustar";
            this.toolStripButtonAjustar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAjustar.Text = "Ajustar";
            this.toolStripButtonAjustar.Click += new System.EventHandler(this.toolStripButtonAjustar_Click);
            // 
            // toolStripButtonZoom
            // 
            this.toolStripButtonZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoom.Image")));
            this.toolStripButtonZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoom.Name = "toolStripButtonZoom";
            this.toolStripButtonZoom.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonZoom.Text = "Zoom";
            this.toolStripButtonZoom.Click += new System.EventHandler(this.toolStripButtonZoom_Click);
            // 
            // comboBoxSelectorImagen
            // 
            this.comboBoxSelectorImagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSelectorImagen.FormattingEnabled = true;
            this.comboBoxSelectorImagen.Location = new System.Drawing.Point(128, 118);
            this.comboBoxSelectorImagen.Name = "comboBoxSelectorImagen";
            this.comboBoxSelectorImagen.Size = new System.Drawing.Size(224, 21);
            this.comboBoxSelectorImagen.TabIndex = 9;
            this.comboBoxSelectorImagen.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectorImagen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imagen actual";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(12, 145);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(357, 261);
            this.pictureBoxImagen.TabIndex = 11;
            this.pictureBoxImagen.TabStop = false;
            // 
            // contextMenuStripClickDerecho
            // 
            this.contextMenuStripClickDerecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRotarDerecha,
            this.MenuItemRotarIzquierda,
            this.toolStripMenuItem1,
            this.copiarToolStripMenuItem});
            this.contextMenuStripClickDerecho.Name = "contextMenuStripClickDerecho";
            this.contextMenuStripClickDerecho.Size = new System.Drawing.Size(247, 76);
            // 
            // MenuItemRotarDerecha
            // 
            this.MenuItemRotarDerecha.Name = "MenuItemRotarDerecha";
            this.MenuItemRotarDerecha.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.MenuItemRotarDerecha.Size = new System.Drawing.Size(246, 22);
            this.MenuItemRotarDerecha.Text = "Rotar 90° a la derecha";
            this.MenuItemRotarDerecha.Click += new System.EventHandler(this.MenuItemRotarDerecha_Click);
            // 
            // MenuItemRotarIzquierda
            // 
            this.MenuItemRotarIzquierda.Name = "MenuItemRotarIzquierda";
            this.MenuItemRotarIzquierda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.MenuItemRotarIzquierda.Size = new System.Drawing.Size(246, 22);
            this.MenuItemRotarIzquierda.Text = "Rotar 90° a la izquierda";
            this.MenuItemRotarIzquierda.Click += new System.EventHandler(this.MenuItemRotarIzquierda_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 495);
            this.ContextMenuStrip = this.contextMenuStripClickDerecho;
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectorImagen);
            this.Controls.Add(this.buttonAdelantarUna);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxTamaño);
            this.Controls.Add(this.groupBoxVision);
            this.Controls.Add(this.statusStripNombreArchivo);
            this.Controls.Add(this.buttonAdelantarFin);
            this.Controls.Add(this.buttonVolverUna);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripNombreArchivo.ResumeLayout(false);
            this.statusStripNombreArchivo.PerformLayout();
            this.groupBoxVision.ResumeLayout(false);
            this.groupBoxVision.PerformLayout();
            this.groupBoxTamaño.ResumeLayout(false);
            this.groupBoxTamaño.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.contextMenuStripClickDerecho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonVolverInicio;
        public System.Windows.Forms.Button buttonVolverUna;
        public System.Windows.Forms.Button buttonAdelantarFin;
        public System.Windows.Forms.Button buttonAdelantarUna;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuItemGuardar;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNormal;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGris;
        public System.Windows.Forms.ToolStripMenuItem tamañoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuItemCentrada;
        public System.Windows.Forms.ToolStripMenuItem MenuItemAjustar;
        public System.Windows.Forms.ToolStripMenuItem MenuItemZoom;
        public System.Windows.Forms.StatusStrip statusStripNombreArchivo;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusNombreArchivo;
        public System.Windows.Forms.GroupBox groupBoxVision;
        public System.Windows.Forms.CheckBox checkBoxVisionEscalaGrises;
        public System.Windows.Forms.CheckBox checkBoxVisionNormal;
        public System.Windows.Forms.GroupBox groupBoxTamaño;
        public System.Windows.Forms.RadioButton radioButtonTamañoZoom;
        public System.Windows.Forms.RadioButton radioButtonTamañoAjustar;
        public System.Windows.Forms.RadioButton radioButtonTamañoCentrada;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripButtonNormal;
        public System.Windows.Forms.ToolStripButton toolStripButtonGris;
        public System.Windows.Forms.ToolStripButton toolStripButtonCentrada;
        public System.Windows.Forms.ToolStripButton toolStripButtonAjustar;
        public System.Windows.Forms.ToolStripButton toolStripButtonZoom;
        public System.Windows.Forms.ComboBox comboBoxSelectorImagen;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBoxImagen;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripClickDerecho;
        public System.Windows.Forms.ToolStripMenuItem MenuItemRotarDerecha;
        public System.Windows.Forms.ToolStripMenuItem MenuItemRotarIzquierda;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
    }
}

