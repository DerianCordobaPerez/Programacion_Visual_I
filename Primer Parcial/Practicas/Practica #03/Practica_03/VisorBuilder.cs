using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace Practica_03
{
    internal class VisorBuilder
    {

        private readonly Form1 _formulario;
        private readonly string _carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public VisorBuilder(Form1 formulario)
        {
            _formulario = formulario;
        }

        public void Cerrar()
        {
            _formulario.Close();
        }

        public void SetImagenes()
        {
            _formulario.Imagenes = new DirectoryInfo(_carpeta).GetFiles("*.*")
                .Where(imagen => Regex.IsMatch(imagen.Name, @"\.jpg$|\.png$|\.jpeg$"))
                .OrderBy(imagen => imagen.Name)
                .Select(imagen => imagen.Name)
                .ToList();
        }

        public void SetImagenesComboBox()
        {
            _formulario.Imagenes.ForEach(imagen => _formulario.comboBoxSelectorImagen.Items.Add(imagen));
            _formulario.comboBoxSelectorImagen.SelectedIndex = 0;
        }

        public void SetImagen()
        {
            var imagen = new Bitmap(new Bitmap($@"{_carpeta}\{_formulario.comboBoxSelectorImagen.Text}"));
            _formulario.pictureBoxImagen.Image = !_formulario.checkBoxVisionEscalaGrises.Checked ? imagen : ToolStripRenderer.CreateDisabledImage(imagen); 
        }

        public void SetToolStripLabel()
        {
            _formulario.toolStripStatusNombreArchivo.Text = $@"{_carpeta}\{_formulario.comboBoxSelectorImagen.Text}";
        }

        public void SetOpcionesVisionNormal(bool check = false)
        {
            _formulario.ToolStripMenuItemNormal.Checked = check
                ? _formulario.toolStripButtonNormal.Checked = _formulario.checkBoxVisionNormal.Checked
                : _formulario.toolStripButtonNormal.Checked = _formulario.checkBoxVisionNormal.Checked = !_formulario.checkBoxVisionNormal.Checked;

            _formulario.ToolStripMenuItemGris.Checked = _formulario.toolStripButtonGris.Checked = _formulario.checkBoxVisionEscalaGrises.Checked = !_formulario.checkBoxVisionNormal.Checked;
            SetImagen();
        }

        public void SetOpcionesVisionGris(bool check = false)
        {
           _formulario.ToolStripMenuItemGris.Checked = check
                ? _formulario.toolStripButtonGris.Checked = _formulario.checkBoxVisionEscalaGrises.Checked
                : _formulario.toolStripButtonGris.Checked = _formulario.checkBoxVisionEscalaGrises.Checked = !_formulario.checkBoxVisionEscalaGrises.Checked;

           _formulario.ToolStripMenuItemNormal.Checked = _formulario.toolStripButtonNormal.Checked = _formulario.checkBoxVisionNormal.Checked = !_formulario.checkBoxVisionEscalaGrises.Checked;
            SetImagen();
        }

        public void setOpcionesCentrada(bool check = false)
        {

            if (check)
                _formulario.radioButtonTamañoCentrada.Checked = check;

            _formulario.toolStripButtonCentrada.Checked = _formulario.MenuItemCentrada.Checked = _formulario.radioButtonTamañoCentrada.Checked;
            _formulario.toolStripButtonAjustar.Checked = _formulario.MenuItemAjustar.Checked = false;
            _formulario.MenuItemZoom.Checked = _formulario.toolStripButtonZoom.Checked = false;
        }

        public void SetOpcionesAjustar(bool check = false)
        {
            if (check)
                _formulario.radioButtonTamañoAjustar.Checked = check;

            _formulario.toolStripButtonAjustar.Checked = _formulario.MenuItemAjustar.Checked = _formulario.radioButtonTamañoAjustar.Checked;
            _formulario.toolStripButtonCentrada.Checked = _formulario.MenuItemCentrada.Checked = false;
            _formulario.MenuItemZoom.Checked = _formulario.toolStripButtonZoom.Checked = false;

        }

        public void SetOpcionesZoom(bool check = false)
        {
            if(check)
                _formulario.radioButtonTamañoZoom.Checked = check;

            _formulario.MenuItemZoom.Checked = _formulario.toolStripButtonZoom.Checked = _formulario.radioButtonTamañoZoom.Checked;
            _formulario.toolStripButtonAjustar.Checked = _formulario.MenuItemAjustar.Checked = false;
            _formulario.toolStripButtonCentrada.Checked = _formulario.MenuItemCentrada.Checked = false;
        }

        public void SetTamanoImagen(string opcion = "", bool check = false)
        {
            if (opcion.ToLower().CompareTo("centrada") == 0)
            {
                _formulario.pictureBoxImagen.SizeMode = PictureBoxSizeMode.CenterImage;
                setOpcionesCentrada(check);
            }
            else if (opcion.ToLower().CompareTo("ajustar") == 0)
            {
                _formulario.pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                SetOpcionesAjustar(check);
            }
            else
            {
                _formulario.pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
                SetOpcionesZoom(check);
            }
        }

        public void RotarImagen(bool derecha = false)
        {
            var imagen = _formulario.pictureBoxImagen.Image;
            imagen.RotateFlip(!derecha ? RotateFlipType.Rotate270FlipNone : RotateFlipType.Rotate90FlipNone);
            _formulario.pictureBoxImagen.Image = imagen;
        }

        public void GuardarImagen()
        {
            var guardarImagen = new SaveFileDialog();
            guardarImagen.CheckPathExists = true;
            guardarImagen.Filter = @"Formato JPG (*.jpg)|.jpg|Formato PNG (*.png)|.png";
            guardarImagen.FilterIndex = 1;
            var formato = ImageFormat.Jpeg;

            if (guardarImagen.ShowDialog() != DialogResult.OK) return;

            switch(guardarImagen.Filter)
            {
                case ".jpg":
                    formato = ImageFormat.Jpeg;
                    break;
                case ".png":
                    formato = ImageFormat.Png;
                    break;
            }

            _formulario.pictureBoxImagen.Image.Save(guardarImagen.FileName, formato);
            MessageBox.Show(@"Imagen guardada con éxito");
        }

        public void SetPosicionImagen(int indice = 0)
        {
            _formulario.comboBoxSelectorImagen.SelectedIndex = indice;
        }

        public void SetClipboardImagen()
        {
            Clipboard.SetImage(_formulario.pictureBoxImagen.Image);
        }

    }
}
