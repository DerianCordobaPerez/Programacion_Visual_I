using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Practica_03
{
    class VisorBuilder
    {

        private Form1 formulario;

        private static readonly string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        
        public VisorBuilder(Form1 formulario)
        {
            this.formulario = formulario;
        }

        public void Cerrar()
        {
            formulario.Close();
        }

        public void SetImagenes()
        {
            formulario.imagenes = new DirectoryInfo(carpeta).GetFiles("*.*")
                .Where(imagen => Regex.IsMatch(imagen.Name, @"\.jpg$|\.png$|\.jpeg$"))
                .OrderBy(imagen => imagen.Name)
                .Select(imagen => imagen.Name)
                .ToList();
        }

        public void SetImagenesComboBox()
        {
            formulario.imagenes.ForEach(imagen => formulario.comboBoxSelectorImagen.Items.Add(imagen));
            formulario.comboBoxSelectorImagen.SelectedIndex = 0;
        }

        public void SetImagen(bool gris = false)
        {
            Bitmap imagen = new Bitmap(new Bitmap($@"{carpeta}\{formulario.comboBoxSelectorImagen.Text}", true));
            if (!gris)
                formulario.pictureBoxImagen.Image = imagen;
            else
                formulario.pictureBoxImagen.Image = ConvertirGris(imagen);
        }

        public void SetToolStripLabel()
        {
            formulario.toolStripStatusNombreArchivo.Text = $@"{carpeta}\{formulario.comboBoxSelectorImagen.Text}";
        }

        public void SetOpcionesVisionNormal(bool check = false)
        {
            
            if(check)
                formulario.ToolStripMenuItemNormal.Checked = formulario.toolStripButtonNormal.Checked = formulario.checkBoxVisionNormal.Checked;
            else
                formulario.ToolStripMenuItemNormal.Checked = formulario.toolStripButtonNormal.Checked = formulario.checkBoxVisionNormal.Checked = !formulario.checkBoxVisionNormal.Checked;


            if(formulario.checkBoxVisionNormal.Checked)
                formulario.ToolStripMenuItemGris.Checked = formulario.toolStripButtonGris.Checked = formulario.checkBoxVisionEscalaGrises.Checked = false;
        }

        public void SetOpcionesVisionGris(bool check = false)
        {
            if(check)
                formulario.ToolStripMenuItemGris.Checked = formulario.toolStripButtonGris.Checked = formulario.checkBoxVisionEscalaGrises.Checked;
            else
                formulario.ToolStripMenuItemGris.Checked = formulario.toolStripButtonGris.Checked = formulario.checkBoxVisionEscalaGrises.Checked = !formulario.checkBoxVisionEscalaGrises.Checked;

            if (formulario.checkBoxVisionEscalaGrises.Checked)
                formulario.ToolStripMenuItemNormal.Checked = formulario.toolStripButtonNormal.Checked = formulario.checkBoxVisionNormal.Checked = false;

        }

        public void SetOpcionesTamaño()
        {
            
        }

        public void SetImagenCentrada()
        {
            formulario.pictureBoxImagen.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        public void RotarImagen(bool derecha = false)
        {
            Image imagen = formulario.pictureBoxImagen.Image;
            imagen.RotateFlip(!derecha ? RotateFlipType.Rotate270FlipNone : RotateFlipType.Rotate90FlipNone);
            formulario.pictureBoxImagen.Image = imagen;
        }

        public void GuardarImagen()
        {
            SaveFileDialog guardarImagen = new SaveFileDialog();
            guardarImagen.CheckPathExists = true;
            guardarImagen.Filter = "Formato JPG (*.jpg)|.jpg|Formato PNG (*.png)|.png";
            guardarImagen.FilterIndex = 1;
            ImageFormat formato = ImageFormat.Jpeg;

            if(guardarImagen.ShowDialog() == DialogResult.OK)
            {
                switch(guardarImagen.Filter)
                {
                    case ".jpg":
                        formato = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        formato = ImageFormat.Png;
                        break;
                }

                formulario.pictureBoxImagen.Image.Save(guardarImagen.FileName, formato);
                MessageBox.Show("Imagen guardada con éxito");
            }
        }

        public void SetPosicionImagen(int indice = 0)
        {
            formulario.comboBoxSelectorImagen.SelectedIndex = indice;
        }

        public void SetClipboardImagen()
        {
            Clipboard.SetImage(formulario.pictureBoxImagen.Image);
        }

        private byte[] ObtenerBytesImagen(Bitmap image, ImageLockMode lockMode, out BitmapData bmpData)
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
        }

    }
}
