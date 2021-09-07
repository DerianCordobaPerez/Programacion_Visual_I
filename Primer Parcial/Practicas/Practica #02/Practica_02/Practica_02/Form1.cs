using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Practica_02
{
    public partial class Form1 : Form
    {

        public List<Auto> autos = new List<Auto>();
        private List<string> propiedades = new List<string>() { "Transmision", "Precio", "Marca", "Estado", "Kilometraje" };

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
        {

            if(!RadioButtonSi.Checked && !RadioButtonNo.Checked)
                ErrorProvider.SetError(RadioButtonNo, $@"Estos campo ({RadioButtonSi.Name} o {RadioButtonNo.Name}) es requerido");

            foreach (var control in controles)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                    ErrorProvider.SetError(control, $@"Este campo ({control.Name}) es requerido");
            }
            
            return controles.All(control => !string.IsNullOrWhiteSpace(control.Text)) && (RadioButtonSi.Checked || RadioButtonNo.Checked);
        }

        private void ReestablecerCampos(IEnumerable<Control> controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;

                RadioButtonSi.Checked = RadioButtonNo.Checked = false;
                ErrorProvider.Clear();
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

            auto.Rines = RadioButtonSi.Checked;

            return auto;
        }

        private void GuardarAutos(IEnumerable<Control> controles)
        {
            if (Convert.ToDouble(ControlTextBoxPrecio.Text) <= 0)
                ErrorProvider.SetError(ControlTextBoxPrecio, "El precio tiene que ser mayor a 0");
                
            if (ValidarCampos(controles) && Convert.ToDouble(ControlTextBoxPrecio.Text) > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Exito al guardar");
                autos.Add(NuevoAuto(controles.Select(control => control.Text.Trim()).ToList()));
                ReestablecerCampos(controles);
            }
        }

        private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void ValidatarTextBoxs(TextBox textBox)
        {
            if (String.Compare(textBox.Text, ".", StringComparison.Ordinal) == 0)
                textBox.Text = $@"0{textBox.Text}0";

            if (textBox.Text.StartsWith("."))
                textBox.Text = $@"0{textBox.Text}";
            
            if(textBox.Text.EndsWith("."))
                textBox.Text = $@"{textBox.Text}0";
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            GuardarAutos(ObtenerControles("Control"));
        }

        private void ButtonVer_Click(object sender, EventArgs e)
            => new VerAutos(autos).ShowDialog();

        private void ControlTextBoxKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSoloNumeros(sender, e);
        }

        private void ControlTextBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSoloNumeros(sender, e);
        }

        private void ControlTextBoxKilometraje_Leave(object sender, EventArgs e)
        {
            ValidatarTextBoxs(ControlTextBoxKilometraje);
        }

        private void ControlTextBoxPrecio_Leave(object sender, EventArgs e)
        {
            ValidatarTextBoxs(ControlTextBoxPrecio);
        }
    }
}
