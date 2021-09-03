using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_02
{
    public partial class Form1 : Form
    {

        private List<Auto> autos = new List<Auto>();
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
                else
                    ((RadioButton)control).Checked = false;
            }
        }

        private Auto NuevoAuto(List<string> valores)
        {
            Auto auto = new Auto();

            foreach(var l in valores)
                MessageBox.Show(l);
            
            for (int i = 0; i < valores.Count; ++i)
            {

                if (string.Compare(propiedades.ElementAt(i), "Rines", StringComparison.Ordinal) == 0)
                    auto.Rines = RadioButtonSi.Checked;
                else
                {
                    if (string.Compare(propiedades.ElementAt(i), "Precio", StringComparison.Ordinal) == 0 || string.Compare(propiedades.ElementAt(i), "Kilometraje", StringComparison.Ordinal) == 0)
                        auto.GetType().GetProperty(propiedades.ElementAt(i))
                            ?.SetValue(auto, Convert.ToDouble(valores[i]));
                    else
                        auto.GetType().GetProperty(propiedades.ElementAt(i))
                            ?.SetValue(auto, valores[i]);
                }
            }

            return auto;
        }

        private void GuardarAutos(IEnumerable<Control> controles)
        {
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
            if (textBox.Text.CompareTo(".") == 0)
                textBox.Text = $@"0{textBox.Text}0";

            if (textBox.Text.StartsWith("."))
                textBox.Text = $@"0{textBox.Text}";
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            GuardarAutos(ObtenerControles("Control"));
        }

        private void ButtonVer_Click(object sender, EventArgs e)
        {
            if (autos.Count > 0)
                new VerAutos().ShowDialog();
            else
                MessageBox.Show("Aun no se han agregado ningun auto", "Error al ver los autos");
        }

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
