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

        public void SetImagen(bool gris = false)
        {
            var imagen = new Bitmap(new Bitmap($@"{_carpeta}\{_formulario.comboBoxSelectorImagen.Text}", true));
            _formulario.pictureBoxImagen.Image = !gris ? imagen : ToolStripRenderer.CreateDisabledImage(imagen);
        }

        public void SetToolStripLabel()
        {
            _formulario.toolStripStatusNombreArchivo.Text = $@"{_carpeta}\{_formulario.comboBoxSelectorImagen.Text}";
        }

        public void SetOpcionesVisionNormal(bool check = false)
        {
            _formulario.ToolStripMenuItemNormal.Checked = check
                ? _formulario.toolStripButtonNormal.Checked = _formulario.checkBoxVisionNormal.Checked
                : _formulario.toolStripButtonNormal.Checked = _formulario.checkBoxVisionNormal.Checked =
                    !_formulario.checkBoxVisionNormal.Checked;


            if(_formulario.checkBoxVisionNormal.Checked)
                _formulario.ToolStripMenuItemGris.Checked = _formulario.toolStripButtonGris.Checked = _formulario.checkBoxVisionEscalaGrises.Checked = false;
        }

        public void SetOpcionesVisionGris(bool check = false)
        {
            _formulario.ToolStripMenuItemGris.Checked = check
                ? _formulario.toolStripButtonGris.Checked = _formulario.checkBoxVisionEscalaGrises.Checked
                : _formulario.toolStripButtonGris.Checked = _formulario.checkBoxVisionEscalaGrises.Checked = 
                    !_formulario.checkBoxVisionEscalaGrises.Checked;

            if (_formulario.checkBoxVisionEscalaGrises.Checked)
                _formulario.ToolStripMenuItemNormal.Checked = _formulario.toolStripButtonNormal.Checked = _formulario.checkBoxVisionNormal.Checked = false;
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

        /*private byte[] ObtenerBytesImagen(Bitmap image, ImageLockMode lockMode, out BitmapData bmpData)
        {
            bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                     lockMode, image.PixelFormat);

            byte[] imageBytes = new byte[bmpData.Stride * image.Height];
            Marshal.Copy(bmpData.Scan0, imageBytes, 0, imageBytes.Length);

            return imageBytes;
        }

        private Bitmap ConvertirGris(Bitmap source)
        {
            Bitmap target = new Bitmap(source.Width, source.Height, source.PixelFormat);
            BitmapData targetData, sourceData;

            byte[] sourceBytes = ObtenerBytesImagen(source, ImageLockMode.ReadOnly, out sourceData);
            byte[] targetBytes = ObtenerBytesImagen(target, ImageLockMode.ReadWrite, out targetData);

            //recorrer los pixeles
            for (int i = 0; i < sourceBytes.Length; i += 3)
            {
                //ignorar el padding, es decir solo procesar los bytes necesarios
                if ((i + 3) % (source.Width * 3) > 0)
                {
                    //Hallar tono gris
                    byte y = (byte)(sourceBytes[i + 2] * 0.3f
                                 + sourceBytes[i + 1] * 0.59f
                                 + sourceBytes[i] * 0.11f);

                    //Asignar tono gris a cada byte del pixel
                    targetBytes[i + 2] = targetBytes[i + 1] = targetBytes[i] = y;
                }
            }

            Marshal.Copy(targetBytes, 0, targetData.Scan0, targetBytes.Length);

            source.UnlockBits(sourceData);
            target.UnlockBits(targetData);

            return target;
        }*/

    }
}
