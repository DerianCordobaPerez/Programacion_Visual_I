using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_03
{
    public partial class Form1 : Form
    {
        private VisorBuilder visorBuilder;
        public List<string> imagenes;

        public Form1()
        {
            InitializeComponent();
            visorBuilder = new VisorBuilder(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visorBuilder.SetImagenes();
            visorBuilder.SetImagenesComboBox();
            visorBuilder.SetImagen();
        }

        private void comboBoxSelectorImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            visorBuilder.SetImagen(checkBoxVisionEscalaGrises.Checked);
            visorBuilder.SetToolStripLabel();
        }

        private void checkBoxVisionNormal_CheckedChanged(object sender, EventArgs e)
        {
            visorBuilder.SetOpcionesVisionNormal(true);
            visorBuilder.SetImagen();
        }

        private void toolStripButtonNormal_Click(object sender, EventArgs e)
        {
            visorBuilder.SetOpcionesVisionNormal();
            visorBuilder.SetImagen();
        }

        private void ToolStripMenuItemNormal_Click(object sender, EventArgs e)
        {
            visorBuilder.SetOpcionesVisionNormal();
            visorBuilder.SetImagen();
        }

        private void checkBoxVisionEscalaGrises_CheckedChanged(object sender, EventArgs e)
        {
            visorBuilder.SetOpcionesVisionGris(true);
            visorBuilder.SetImagen(true);
        }

        private void toolStripButtonGris_Click(object sender, EventArgs e)
        {
            visorBuilder.SetOpcionesVisionGris();
            visorBuilder.SetImagen(true);
        }

        private void ToolStripMenuItemGris_Click(object sender, EventArgs e)
        {
            visorBuilder.SetOpcionesVisionGris();
            visorBuilder.SetImagen(true);
        }

        private void MenuItemRotarDerecha_Click(object sender, EventArgs e)
        {
            visorBuilder.RotarImagen(true);
        }

        private void MenuItemRotarIzquierda_Click(object sender, EventArgs e)
        {
            visorBuilder.RotarImagen();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visorBuilder.SetClipboardImagen();
        }

        private void MenuItemGuardar_Click(object sender, EventArgs e)
        {
            visorBuilder.GuardarImagen();
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            visorBuilder.SetPosicionImagen();
        }

        private void buttonAdelantarFin_Click(object sender, EventArgs e)
        {
            visorBuilder.SetPosicionImagen(imagenes.Count - 1);
        }

        private void buttonVolverUna_Click(object sender, EventArgs e)
        {
            visorBuilder.SetPosicionImagen(
                (comboBoxSelectorImagen.SelectedIndex - 1) < 0 ? imagenes.Count - 1 : comboBoxSelectorImagen.SelectedIndex - 1
            );
        }

        private void buttonAdelantarUna_Click(object sender, EventArgs e)
        {
            visorBuilder.SetPosicionImagen(
                (comboBoxSelectorImagen.SelectedIndex + 1) > (imagenes.Count - 1) ? 0 : comboBoxSelectorImagen.SelectedIndex + 1
            );
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visorBuilder.Cerrar();
        }
    }
}
