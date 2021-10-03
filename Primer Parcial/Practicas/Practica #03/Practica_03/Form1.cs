using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica_03
{
    public partial class Form1 : Form
    {
        private readonly VisorBuilder _visorBuilder;
        public List<string> Imagenes { get; set; }

        public Form1()
        {
            InitializeComponent();
            _visorBuilder = new VisorBuilder(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _visorBuilder.SetImagenes();
            _visorBuilder.SetImagenesComboBox();
            _visorBuilder.SetImagen();
            _visorBuilder.SetTamanoImagen("centrada");
        }

        private void comboBoxSelectorImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            _visorBuilder.SetImagen();
            _visorBuilder.SetToolStripLabel();
        }

        private void checkBoxVisionNormal_CheckedChanged(object sender, EventArgs e)
        {
            _visorBuilder.SetOpcionesVisionNormal(true);
        }

        private void toolStripButtonNormal_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetOpcionesVisionNormal();
        }

        private void ToolStripMenuItemNormal_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetOpcionesVisionNormal();
        }

        private void checkBoxVisionEscalaGrises_CheckedChanged(object sender, EventArgs e)
        {
            _visorBuilder.SetOpcionesVisionGris(true);
        }

        private void toolStripButtonGris_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetOpcionesVisionGris();
        }

        private void ToolStripMenuItemGris_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetOpcionesVisionGris();
        }

        private void MenuItemRotarDerecha_Click(object sender, EventArgs e)
        {
            _visorBuilder.RotarImagen(true);
        }

        private void MenuItemRotarIzquierda_Click(object sender, EventArgs e)
        {
            _visorBuilder.RotarImagen();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetClipboardImagen();
        }

        private void MenuItemGuardar_Click(object sender, EventArgs e)
        {
            _visorBuilder.GuardarImagen();
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetPosicionImagen();
        }

        private void buttonAdelantarFin_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetPosicionImagen(Imagenes.Count - 1);
        }

        private void buttonVolverUna_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetPosicionImagen(
                (comboBoxSelectorImagen.SelectedIndex - 1) < 0 ? Imagenes.Count - 1 : comboBoxSelectorImagen.SelectedIndex - 1
            );
        }

        private void buttonAdelantarUna_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetPosicionImagen(
                (comboBoxSelectorImagen.SelectedIndex + 1) > (Imagenes.Count - 1) ? 0 : comboBoxSelectorImagen.SelectedIndex + 1
            );
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _visorBuilder.Cerrar();
        }

        private void radioButtonTamañoCentrada_CheckedChanged(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen("centrada");
        }

        private void radioButtonTamañoAjustar_CheckedChanged(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen("ajustar");
        }

        private void radioButtonTamañoZoom_CheckedChanged(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen();
        }

        private void toolStripButtonCentrada_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen("centrada", true);
        }

        private void toolStripButtonAjustar_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen("ajustar", true);
        }

        private void toolStripButtonZoom_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen("", true);
        }

        private void MenuItemCentrada_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen("centrada", true);
        }

        private void MenuItemAjustar_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen("ajustar", true);
        }

        private void MenuItemZoom_Click(object sender, EventArgs e)
        {
            _visorBuilder.SetTamanoImagen("", true);
        }
    }
}
