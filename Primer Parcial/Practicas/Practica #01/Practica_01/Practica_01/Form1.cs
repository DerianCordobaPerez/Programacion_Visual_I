using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Practica_01
{
    public partial class Form1 : Form
    {

        private Auto _auto;
        private List<string> propiedades = new List<string>() { "Rines", "Transmision", "Estado", "Marca", "Precio", "Kilometraje" };

        public Form1()
        {
            InitializeComponent();
        }

        private IEnumerable<Control> ObtenerControles(string llave) 
            => Controls
                .OfType<Control>()
                .Where(control => control.Name.StartsWith(llave))
                .Select(control => control);

        private bool ValidarCampos(IEnumerable<Control> controles) 
            => controles.All(control => !string.IsNullOrWhiteSpace(control.Text));

        private void ReestablecerCampos(IEnumerable<Control> controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                else
                    ((ComboBox)control).SelectedIndex = -1;
                    
            }
        }

        private Auto NuevoAuto(List<string> valores)
        {
            Auto auto = new Auto();

            for (int i = 0; i < valores.Count; ++i)
            {
                if (string.Compare(propiedades.ElementAt(i), "Precio", StringComparison.Ordinal) == 0 || string.Compare(propiedades.ElementAt(i), "Kilometraje", StringComparison.Ordinal) == 0)
                    auto.GetType().GetProperty(propiedades.ElementAt(i))
                        ?.SetValue(auto, Convert.ToDouble(valores[i]));
                else
                    auto.GetType().GetProperty(propiedades.ElementAt(i))
                        ?.SetValue(auto, valores[i]);
            }

            return auto;
        }

        private void GuardarAutos(IEnumerable<Control> controles)
        {
            if (ValidarCampos(controles) && Convert.ToDouble(ControlTextBoxPrice.Text) > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Exito al guardar");
                _auto = NuevoAuto(controles.Select(control => control.Text.Trim()).ToList());
                ReestablecerCampos(controles);
            }
            else
                MessageBox.Show("Error al guardar los datos", "Ocurrio Error");
        }

        private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && (((TextBox) sender).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void ValidatarTextBoxs(TextBox textBox)
        {
            if(textBox.Text.CompareTo(".") == 0)
                textBox.Text = $@"0{textBox.Text}0";

            if (textBox.Text.StartsWith("."))
                textBox.Text = $@"0{textBox.Text}";
        }

        private void buttonShowCars_Click(object sender, EventArgs e)
        {
            if (_auto != null)
            {
                string contentido = "AUTO REGISTRADO\n";
                for (int i = 0; i < propiedades.Count; ++i)
                    contentido += $"{propiedades.ElementAt(i)}: {_auto.GetType().GetProperty(propiedades.ElementAt(i))?.GetValue(_auto, null)}\n";

                MessageBox.Show($@"{contentido}");
            }
            else
                MessageBox.Show(@"No se ha ingresado ningun auto");
        }

        private void buttonSaveCar_Click(object sender, EventArgs e)
        {
            GuardarAutos(ObtenerControles("Control"));
        }

        private void ControlTextBoxMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSoloNumeros(sender, e);
        }

        private void ControlTextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {    
            PermitirSoloNumeros(sender, e);
        }

        private void ControlTextBoxMileage_Leave(object sender, EventArgs e)
        {
            ValidatarTextBoxs(ControlTextBoxMileage);
        }

        private void ControlTextBoxPrice_Leave(object sender, EventArgs e)
        {
            ValidatarTextBoxs(ControlTextBoxPrice);
        }
    }
}
